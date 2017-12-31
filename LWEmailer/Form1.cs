using System;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Windows.Forms;
using Amazon;
using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail;
using LWEmailer.Properties;
using System.Data.SqlClient;
using System.Security;

namespace LWEmailer
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            this.Text = "LW Emailer";
            OrderNumber.Select();
            //load settings if any
            companynameTxt.Text = Settings.Default["companyname"].ToString();
            companyphoneTxt.Text = Settings.Default["companyphone"].ToString();
            companywebsiteTxt.Text = Settings.Default["companywebsite"].ToString();
            companyemailTxt.Text = Settings.Default["companyemail"].ToString();
            awsaccesskeyTxt.Text = Settings.Default["awsaccesskey"].ToString();
            awssecretkeyTxt.Text = Settings.Default["awssecretkey"].ToString();
            awsregionTxt.Text = Settings.Default["awsregion"].ToString();
            smtpcheckBox.Checked = Properties.Settings.Default.smtp;
            DBconnectionTxt.Text = Settings.Default["dbconnection"].ToString();
            DBnameTxt.Text = Settings.Default["dbname"].ToString();
            DBuserTxt.Text = Settings.Default["dbuser"].ToString();
            DBpasswordTxt.Text = Settings.Default["dbpassword"].ToString();

            setconnectionstring();
        }

        private void setconnectionstring()
        {
            connectionString = "Data Source=" + DBconnectionTxt.Text + ";Initial Catalog=" + DBnameTxt.Text + ";Integrated Security=False;UID=" + DBuserTxt.Text + ";PWD=" + DBpasswordTxt.Text;
        }

        private void clearboxes()
        {
            foreach (TextBox tb in mainPnl.Controls.OfType<TextBox>().ToArray())
            {
                tb.Clear();
            }
            OrderNumber.Select();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //MessageBox.Show("some ting wong");
            }
            else
            {
                errorProvider1.SetError(Email, "");
                errorProvider1.SetError(txtName, "");
                errorProvider1.SetError(Amount, "");
               //build email body
                string myemailbody = "<p>Hi " + txtName.Text +",</p>"
                          + "<p>This is just a reminder that you have an order waiting to be picked up.</p>"
                          + "<p>" +  AdditionalMessage.Text + "</p>"
                          + "<p>Order Number: " + OrderNumber.Text + "<br>"
                          + "Amount: $" + Amount.Text + "</p>"
                          +"<p>Thanks!<br>"
                          + Settings.Default["companyname"].ToString() + "<br>"
                          + Settings.Default["companywebsite"].ToString() + "<br>"
                          + Settings.Default["companyphone"].ToString() + "</p>"
                          ;
                string myemailsubject = "Reminder - your order is ready - "  + Settings.Default["companyname"].ToString();
                string myemailsendto = Email.Text;

                mysendEmail(myemailsendto, myemailsubject, myemailbody);
             }    
        }

        public void mysendEmail(string sendto, string mysubject, string body)
        {
            if (Properties.Settings.Default.smtp == false)
            {
                try //using aws credentials
                {
                    string access = Settings.Default["awsaccesskey"].ToString();
                    string secret = Settings.Default["awssecretkey"].ToString();
                    var region = RegionEndpoint.GetBySystemName(Settings.Default["awsregion"].ToString());
                    var client = new AmazonSimpleEmailServiceClient(access,secret,region);
                    SendEmailRequest myemail = new SendEmailRequest();
                    myemail.Destination = new Destination();
                    myemail.Destination.ToAddresses.Add(sendto);
                    myemail.Destination.CcAddresses.Add(Settings.Default["companyemail"].ToString());
                    myemail.Message = new Amazon.SimpleEmail.Model.Message();
                    myemail.Message.Body = new Body();
                    myemail.Message.Body.Html = new Content();
                    myemail.Message.Body.Html.Data = body;
                    myemail.Message.Subject = new Content();
                    myemail.Message.Subject.Data = mysubject;
                    myemail.Source = Settings.Default["companyemail"].ToString();
                    myemail.ReturnPath = Settings.Default["companyemail"].ToString();
                    myemail.ReplyToAddresses.Add(Settings.Default["companyemail"].ToString());
                    var response = client.SendEmail(myemail);

                    MessageBox.Show("Email Sent");
                    //clear textboxes
                    clearboxes();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong - error:" + ex.Message);
                }

            }

            else //must be using smtp now
            {
                try
                {
                    string sender = Settings.Default["companyemail"].ToString();

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = Settings.Default["awsregion"].ToString();
                    smtp.UseDefaultCredentials = false;
                    NetworkCredential netcred = new NetworkCredential(Settings.Default["awsaccesskey"].ToString(), Settings.Default["awssecretkey"].ToString());
                    smtp.Credentials = netcred;
                    smtp.EnableSsl = true;

                    MailMessage msg = new MailMessage(sender,sendto);

                    msg.Subject = mysubject;
                    msg.Body = body;
                    msg.Bcc.Add(sender);
                    msg.IsBodyHtml = true;

                    smtp.Send(msg);
                    MessageBox.Show("Email Sent");
                    //clear text boxes
                    clearboxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong - error:" + ex.Message);
                }
            }
        }

        private bool ValidateForm()
        {
            if (txtName.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtName, "Please enter the customer name");
                return true;
            }// Returns true if no input or only space is found
            if (Email.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(Email, "Please enter the customer email"); 
                return true;
            }
            if (Amount.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(Amount, "Please enter the amount");
                return true;
            }
            else
                try
                {
                    decimal temp = decimal.Parse(Amount.Text);
                    errorProvider1.SetError(Amount, "");
                }
            catch
                {
                    errorProvider1.SetError(Amount, "numbers only");
                    return true;
                }
            return false;              
        }
               
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLWLookup_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsPnl.BringToFront();
            mainPnl.SendToBack();
            companynameTxt.Select();
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPnl.BringToFront();
            settingsPnl.SendToBack();
            clearboxes();
            OrderNumber.Select();
        }

        private void savesettingsBtn_Click(object sender, EventArgs e)
        {
            Settings.Default["companyname"] = companynameTxt.Text;
            Settings.Default["companyemail"] = companyemailTxt.Text;
            Settings.Default["companyphone"] = companyphoneTxt.Text;
            Settings.Default["companywebsite"] = companywebsiteTxt.Text;
            Settings.Default["awsaccesskey"] = awsaccesskeyTxt.Text;
            Settings.Default["awssecretkey"] = awssecretkeyTxt.Text;
            Settings.Default["awsregion"] = awsregionTxt.Text;
            Settings.Default["smtp"] = smtpcheckBox.Checked;
            Settings.Default["dbconnection"] = DBconnectionTxt.Text;
            Settings.Default["dbname"] = DBnameTxt.Text;
            Settings.Default["dbuser"] = DBuserTxt.Text;
            Settings.Default["dbpassword"] = DBpasswordTxt.Text;
            Settings.Default.Save();
            setconnectionstring();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainPnl.BringToFront();
            settingsPnl.SendToBack();
            clearboxes();
            OrderNumber.Select();
        }

        private void btnLWLookup_Click(object sender, EventArgs e)
        {
            try
            {
                decimal temp = decimal.Parse(OrderNumber.Text);
                errorProvider1.SetError(OrderNumber, "");
            }
            catch
            {
                errorProvider1.SetError(OrderNumber, "numbers only");
                //clear text boxes
                clearboxes();
                OrderNumber.Select();
                return;
            }
            {
                if (DBconnectionTxt.TextLength == 0 || DBnameTxt.TextLength == 0)
                {
                    MessageBox.Show("Error, Check LW DB Connection Settings");
                    return;
                }
                string id2check = OrderNumber.Text;
                string sql = "SELECT OrderInfo.Total, CustomerInfo.CustomerName, ContactInfo.EmailAddress FROM OrderInfo join CustomerInfo on " +
                    "OrderInfo.CustomerID = CustomerInfo.CustomerID join ContactInfo on OrderInfo.CustomerID = ContactInfo.CustomerID where OrderId =" + id2check;
                try
                {

					using (connection = new SqlConnection(connectionString))
					
					{
					
					connection.Open();
						using (SqlCommand command = new SqlCommand(sql, connection))

						{
							SqlDataReader reader = command.ExecuteReader();


							if (reader.HasRows)
							{
								while (reader.Read())
									if (reader["EmailAddress"].ToString() != string.Empty)

									{
										string fullname = reader["CustomerName"].ToString();
										string FName;

										if (fullname.Contains(','))
										{
											var names = fullname.Split(',');
											FName = names[1].Trim();
											FName = FName.First().ToString().ToUpper() + FName.Substring(1);

										}
										else
										{
											FName = fullname;
										}
										Email.Text = reader["EmailAddress"].ToString();
										txtName.Text = FName;
										Amount.Text = reader["Total"].ToString();
										AdditionalMessage.Select();
									}
									else
									{
										MessageBox.Show("No Email address for that Order Number");
										//clear text boxes
										clearboxes();
										OrderNumber.Select();
									}
							}
							else
							{
								MessageBox.Show("That does not seem to be a valid order number");
								//clear text boxes
								clearboxes();
								OrderNumber.Select();
							}

						}
						connection.Close();

					}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong - error: " + ex.Message);
                }
            }
        }

        private void OrderNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
