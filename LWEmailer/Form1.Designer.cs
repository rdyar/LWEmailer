namespace LWEmailer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.OrderNumber = new System.Windows.Forms.TextBox();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelAdditionalMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AdditionalMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.btnLWLookup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPnl = new System.Windows.Forms.Panel();
            this.DBpasswordTxt = new System.Windows.Forms.TextBox();
            this.LblDBPassword = new System.Windows.Forms.Label();
            this.DBuserTxt = new System.Windows.Forms.TextBox();
            this.LblDBUsername = new System.Windows.Forms.Label();
            this.DBnameTxt = new System.Windows.Forms.TextBox();
            this.LblDBName = new System.Windows.Forms.Label();
            this.DBconnectionTxt = new System.Windows.Forms.TextBox();
            this.LblLWServerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.smtpcheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.awsregionTxt = new System.Windows.Forms.TextBox();
            this.awsregionLbl = new System.Windows.Forms.Label();
            this.awssecretkeyTxt = new System.Windows.Forms.TextBox();
            this.awssecretLbl = new System.Windows.Forms.Label();
            this.awsaccesskeyTxt = new System.Windows.Forms.TextBox();
            this.awsaccesskeyLbl = new System.Windows.Forms.Label();
            this.companyphoneTxt = new System.Windows.Forms.TextBox();
            this.companyphoneLbl = new System.Windows.Forms.Label();
            this.companywebsiteTxt = new System.Windows.Forms.TextBox();
            this.companywebsiteLbl = new System.Windows.Forms.Label();
            this.companyemailTxt = new System.Windows.Forms.TextBox();
            this.companyemailLbl = new System.Windows.Forms.Label();
            this.savesettingsBtn = new System.Windows.Forms.Button();
            this.companynameTxt = new System.Windows.Forms.TextBox();
            this.companynameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.settingsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(149, 375);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(195, 62);
            this.btnSendEmail.TabIndex = 7;
            this.btnSendEmail.Text = "Send Reminder Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(73, 191);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(82, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Customer Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(76, 207);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(223, 20);
            this.Email.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(73, 145);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Customer First Name:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(73, 236);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount:";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(76, 252);
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 5;
            this.Amount.TabStop = false;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(76, 117);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(100, 20);
            this.OrderNumber.TabIndex = 1;
            this.OrderNumber.TextChanged += new System.EventHandler(this.OrderNumber_TextChanged);
            this.OrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderNumber_KeyDown);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(73, 101);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(76, 13);
            this.labelOrderNumber.TabIndex = 7;
            this.labelOrderNumber.Text = "Order Number:";
            // 
            // labelAdditionalMessage
            // 
            this.labelAdditionalMessage.AutoSize = true;
            this.labelAdditionalMessage.Location = new System.Drawing.Point(73, 280);
            this.labelAdditionalMessage.Name = "labelAdditionalMessage";
            this.labelAdditionalMessage.Size = new System.Drawing.Size(136, 13);
            this.labelAdditionalMessage.TabIndex = 9;
            this.labelAdditionalMessage.Text = "Custom Message - Optional";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdditionalMessage
            // 
            this.AdditionalMessage.Location = new System.Drawing.Point(76, 297);
            this.AdditionalMessage.Name = "AdditionalMessage";
            this.AdditionalMessage.Size = new System.Drawing.Size(352, 20);
            this.AdditionalMessage.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainFormToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mainFormToolStripMenuItem.Text = "Main Form";
            this.mainFormToolStripMenuItem.Click += new System.EventHandler(this.mainFormToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.SystemColors.Control;
            this.mainPnl.Controls.Add(this.btnLWLookup);
            this.mainPnl.Controls.Add(this.label2);
            this.mainPnl.Controls.Add(this.AdditionalMessage);
            this.mainPnl.Controls.Add(this.txtName);
            this.mainPnl.Controls.Add(this.labelAdditionalMessage);
            this.mainPnl.Controls.Add(this.labelName);
            this.mainPnl.Controls.Add(this.OrderNumber);
            this.mainPnl.Controls.Add(this.labelEmail);
            this.mainPnl.Controls.Add(this.labelOrderNumber);
            this.mainPnl.Controls.Add(this.Email);
            this.mainPnl.Controls.Add(this.Amount);
            this.mainPnl.Controls.Add(this.btnSendEmail);
            this.mainPnl.Controls.Add(this.labelAmount);
            this.mainPnl.Location = new System.Drawing.Point(20, 28);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(500, 519);
            this.mainPnl.TabIndex = 11;
            // 
            // btnLWLookup
            // 
            this.btnLWLookup.Location = new System.Drawing.Point(207, 115);
            this.btnLWLookup.Name = "btnLWLookup";
            this.btnLWLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLWLookup.TabIndex = 2;
            this.btnLWLookup.Text = "LW Lookup";
            this.btnLWLookup.UseVisualStyleBackColor = true;
            this.btnLWLookup.Click += new System.EventHandler(this.btnLWLookup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Use the form below to email a reminder to pickup an order";
            // 
            // settingsPnl
            // 
            this.settingsPnl.Controls.Add(this.DBpasswordTxt);
            this.settingsPnl.Controls.Add(this.LblDBPassword);
            this.settingsPnl.Controls.Add(this.DBuserTxt);
            this.settingsPnl.Controls.Add(this.LblDBUsername);
            this.settingsPnl.Controls.Add(this.DBnameTxt);
            this.settingsPnl.Controls.Add(this.LblDBName);
            this.settingsPnl.Controls.Add(this.DBconnectionTxt);
            this.settingsPnl.Controls.Add(this.LblLWServerName);
            this.settingsPnl.Controls.Add(this.label3);
            this.settingsPnl.Controls.Add(this.returnBtn);
            this.settingsPnl.Controls.Add(this.smtpcheckBox);
            this.settingsPnl.Controls.Add(this.label5);
            this.settingsPnl.Controls.Add(this.settingsLbl);
            this.settingsPnl.Controls.Add(this.awsregionTxt);
            this.settingsPnl.Controls.Add(this.awsregionLbl);
            this.settingsPnl.Controls.Add(this.awssecretkeyTxt);
            this.settingsPnl.Controls.Add(this.awssecretLbl);
            this.settingsPnl.Controls.Add(this.awsaccesskeyTxt);
            this.settingsPnl.Controls.Add(this.awsaccesskeyLbl);
            this.settingsPnl.Controls.Add(this.companyphoneTxt);
            this.settingsPnl.Controls.Add(this.companyphoneLbl);
            this.settingsPnl.Controls.Add(this.companywebsiteTxt);
            this.settingsPnl.Controls.Add(this.companywebsiteLbl);
            this.settingsPnl.Controls.Add(this.companyemailTxt);
            this.settingsPnl.Controls.Add(this.companyemailLbl);
            this.settingsPnl.Controls.Add(this.savesettingsBtn);
            this.settingsPnl.Controls.Add(this.companynameTxt);
            this.settingsPnl.Controls.Add(this.companynameLbl);
            this.settingsPnl.Location = new System.Drawing.Point(20, 28);
            this.settingsPnl.Name = "settingsPnl";
            this.settingsPnl.Size = new System.Drawing.Size(500, 519);
            this.settingsPnl.TabIndex = 10;
            // 
            // DBpasswordTxt
            // 
            this.DBpasswordTxt.Location = new System.Drawing.Point(291, 401);
            this.DBpasswordTxt.Name = "DBpasswordTxt";
            this.DBpasswordTxt.PasswordChar = '*';
            this.DBpasswordTxt.Size = new System.Drawing.Size(136, 20);
            this.DBpasswordTxt.TabIndex = 30;
            // 
            // LblDBPassword
            // 
            this.LblDBPassword.AutoSize = true;
            this.LblDBPassword.Location = new System.Drawing.Point(288, 385);
            this.LblDBPassword.Name = "LblDBPassword";
            this.LblDBPassword.Size = new System.Drawing.Size(53, 13);
            this.LblDBPassword.TabIndex = 29;
            this.LblDBPassword.Text = "Password";
            // 
            // DBuserTxt
            // 
            this.DBuserTxt.Location = new System.Drawing.Point(237, 401);
            this.DBuserTxt.Name = "DBuserTxt";
            this.DBuserTxt.Size = new System.Drawing.Size(42, 20);
            this.DBuserTxt.TabIndex = 28;
            // 
            // LblDBUsername
            // 
            this.LblDBUsername.AutoSize = true;
            this.LblDBUsername.Location = new System.Drawing.Point(234, 385);
            this.LblDBUsername.Name = "LblDBUsername";
            this.LblDBUsername.Size = new System.Drawing.Size(49, 13);
            this.LblDBUsername.TabIndex = 27;
            this.LblDBUsername.Text = "User (sa)";
            // 
            // DBnameTxt
            // 
            this.DBnameTxt.Location = new System.Drawing.Point(61, 402);
            this.DBnameTxt.Name = "DBnameTxt";
            this.DBnameTxt.Size = new System.Drawing.Size(164, 20);
            this.DBnameTxt.TabIndex = 26;
            // 
            // LblDBName
            // 
            this.LblDBName.AutoSize = true;
            this.LblDBName.Location = new System.Drawing.Point(59, 385);
            this.LblDBName.Name = "LblDBName";
            this.LblDBName.Size = new System.Drawing.Size(53, 13);
            this.LblDBName.TabIndex = 25;
            this.LblDBName.Text = "DB Name";
            // 
            // DBconnectionTxt
            // 
            this.DBconnectionTxt.Location = new System.Drawing.Point(59, 358);
            this.DBconnectionTxt.Name = "DBconnectionTxt";
            this.DBconnectionTxt.Size = new System.Drawing.Size(375, 20);
            this.DBconnectionTxt.TabIndex = 24;
            // 
            // LblLWServerName
            // 
            this.LblLWServerName.AutoSize = true;
            this.LblLWServerName.Location = new System.Drawing.Point(56, 341);
            this.LblLWServerName.Name = "LblLWServerName";
            this.LblLWServerName.Size = new System.Drawing.Size(261, 13);
            this.LblLWServerName.TabIndex = 23;
            this.LblLWServerName.Text = "Server\\DB connection (COMPNAME\\SQLEXPRESS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "LabWorks Database";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(231, 444);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(130, 23);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Return to Main Form";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // smtpcheckBox
            // 
            this.smtpcheckBox.AutoSize = true;
            this.smtpcheckBox.Location = new System.Drawing.Point(57, 286);
            this.smtpcheckBox.Name = "smtpcheckBox";
            this.smtpcheckBox.Size = new System.Drawing.Size(209, 17);
            this.smtpcheckBox.TabIndex = 20;
            this.smtpcheckBox.TabStop = false;
            this.smtpcheckBox.Text = "Use SMTP instead of AWS credentials";
            this.smtpcheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "AWS / Email Server Setup";
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Location = new System.Drawing.Point(157, 12);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(162, 13);
            this.settingsLbl.TabIndex = 17;
            this.settingsLbl.Text = "Settings - All Fields are Required!";
            // 
            // awsregionTxt
            // 
            this.awsregionTxt.Location = new System.Drawing.Point(57, 257);
            this.awsregionTxt.Name = "awsregionTxt";
            this.awsregionTxt.Size = new System.Drawing.Size(184, 20);
            this.awsregionTxt.TabIndex = 13;
            // 
            // awsregionLbl
            // 
            this.awsregionLbl.AutoSize = true;
            this.awsregionLbl.Location = new System.Drawing.Point(54, 241);
            this.awsregionLbl.Name = "awsregionLbl";
            this.awsregionLbl.Size = new System.Drawing.Size(144, 13);
            this.awsregionLbl.TabIndex = 15;
            this.awsregionLbl.Text = "AWS Region / SMTP Server";
            // 
            // awssecretkeyTxt
            // 
            this.awssecretkeyTxt.Location = new System.Drawing.Point(57, 218);
            this.awssecretkeyTxt.Name = "awssecretkeyTxt";
            this.awssecretkeyTxt.PasswordChar = '*';
            this.awssecretkeyTxt.Size = new System.Drawing.Size(294, 20);
            this.awssecretkeyTxt.TabIndex = 12;
            // 
            // awssecretLbl
            // 
            this.awssecretLbl.AutoSize = true;
            this.awssecretLbl.Location = new System.Drawing.Point(54, 202);
            this.awssecretLbl.Name = "awssecretLbl";
            this.awssecretLbl.Size = new System.Drawing.Size(176, 13);
            this.awssecretLbl.TabIndex = 13;
            this.awssecretLbl.Text = "AWS Secret key / SMTP Password";
            // 
            // awsaccesskeyTxt
            // 
            this.awsaccesskeyTxt.Location = new System.Drawing.Point(57, 178);
            this.awsaccesskeyTxt.Name = "awsaccesskeyTxt";
            this.awsaccesskeyTxt.Size = new System.Drawing.Size(294, 20);
            this.awsaccesskeyTxt.TabIndex = 11;
            // 
            // awsaccesskeyLbl
            // 
            this.awsaccesskeyLbl.AutoSize = true;
            this.awsaccesskeyLbl.Location = new System.Drawing.Point(54, 162);
            this.awsaccesskeyLbl.Name = "awsaccesskeyLbl";
            this.awsaccesskeyLbl.Size = new System.Drawing.Size(188, 13);
            this.awsaccesskeyLbl.TabIndex = 11;
            this.awsaccesskeyLbl.Text = "AWS Access Key / SMTP User Name";
            // 
            // companyphoneTxt
            // 
            this.companyphoneTxt.Location = new System.Drawing.Point(54, 94);
            this.companyphoneTxt.Name = "companyphoneTxt";
            this.companyphoneTxt.Size = new System.Drawing.Size(155, 20);
            this.companyphoneTxt.TabIndex = 8;
            // 
            // companyphoneLbl
            // 
            this.companyphoneLbl.AutoSize = true;
            this.companyphoneLbl.Location = new System.Drawing.Point(51, 78);
            this.companyphoneLbl.Name = "companyphoneLbl";
            this.companyphoneLbl.Size = new System.Drawing.Size(78, 13);
            this.companyphoneLbl.TabIndex = 7;
            this.companyphoneLbl.Text = "Phone Number";
            // 
            // companywebsiteTxt
            // 
            this.companywebsiteTxt.Location = new System.Drawing.Point(291, 94);
            this.companywebsiteTxt.Name = "companywebsiteTxt";
            this.companywebsiteTxt.Size = new System.Drawing.Size(172, 20);
            this.companywebsiteTxt.TabIndex = 9;
            // 
            // companywebsiteLbl
            // 
            this.companywebsiteLbl.AutoSize = true;
            this.companywebsiteLbl.Location = new System.Drawing.Point(288, 78);
            this.companywebsiteLbl.Name = "companywebsiteLbl";
            this.companywebsiteLbl.Size = new System.Drawing.Size(46, 13);
            this.companywebsiteLbl.TabIndex = 5;
            this.companywebsiteLbl.Text = "Website";
            // 
            // companyemailTxt
            // 
            this.companyemailTxt.Location = new System.Drawing.Point(291, 55);
            this.companyemailTxt.Name = "companyemailTxt";
            this.companyemailTxt.Size = new System.Drawing.Size(172, 20);
            this.companyemailTxt.TabIndex = 7;
            // 
            // companyemailLbl
            // 
            this.companyemailLbl.AutoSize = true;
            this.companyemailLbl.Location = new System.Drawing.Point(288, 39);
            this.companyemailLbl.Name = "companyemailLbl";
            this.companyemailLbl.Size = new System.Drawing.Size(73, 13);
            this.companyemailLbl.TabIndex = 3;
            this.companyemailLbl.Text = "Email Address";
            // 
            // savesettingsBtn
            // 
            this.savesettingsBtn.Location = new System.Drawing.Point(150, 444);
            this.savesettingsBtn.Name = "savesettingsBtn";
            this.savesettingsBtn.Size = new System.Drawing.Size(75, 23);
            this.savesettingsBtn.TabIndex = 14;
            this.savesettingsBtn.Text = "Save";
            this.savesettingsBtn.UseVisualStyleBackColor = true;
            this.savesettingsBtn.Click += new System.EventHandler(this.savesettingsBtn_Click);
            // 
            // companynameTxt
            // 
            this.companynameTxt.Location = new System.Drawing.Point(54, 55);
            this.companynameTxt.Name = "companynameTxt";
            this.companynameTxt.Size = new System.Drawing.Size(212, 20);
            this.companynameTxt.TabIndex = 6;
            // 
            // companynameLbl
            // 
            this.companynameLbl.AutoSize = true;
            this.companynameLbl.Location = new System.Drawing.Point(51, 39);
            this.companynameLbl.Name = "companynameLbl";
            this.companynameLbl.Size = new System.Drawing.Size(82, 13);
            this.companynameLbl.TabIndex = 0;
            this.companynameLbl.Text = "Company Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 559);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.settingsPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.settingsPnl.ResumeLayout(false);
            this.settingsPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox OrderNumber;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelAdditionalMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox AdditionalMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
        private System.Windows.Forms.Panel settingsPnl;
        private System.Windows.Forms.Label companynameLbl;
        private System.Windows.Forms.Button savesettingsBtn;
        private System.Windows.Forms.TextBox companynameTxt;
        private System.Windows.Forms.Label settingsLbl;
        private System.Windows.Forms.TextBox awsregionTxt;
        private System.Windows.Forms.Label awsregionLbl;
        private System.Windows.Forms.TextBox awssecretkeyTxt;
        private System.Windows.Forms.Label awssecretLbl;
        private System.Windows.Forms.TextBox awsaccesskeyTxt;
        private System.Windows.Forms.Label awsaccesskeyLbl;
        private System.Windows.Forms.TextBox companyphoneTxt;
        private System.Windows.Forms.Label companyphoneLbl;
        private System.Windows.Forms.TextBox companywebsiteTxt;
        private System.Windows.Forms.Label companywebsiteLbl;
        private System.Windows.Forms.TextBox companyemailTxt;
        private System.Windows.Forms.Label companyemailLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox smtpcheckBox;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLWLookup;
        private System.Windows.Forms.TextBox DBconnectionTxt;
        private System.Windows.Forms.Label LblLWServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBpasswordTxt;
        private System.Windows.Forms.Label LblDBPassword;
        private System.Windows.Forms.TextBox DBuserTxt;
        private System.Windows.Forms.Label LblDBUsername;
        private System.Windows.Forms.TextBox DBnameTxt;
        private System.Windows.Forms.Label LblDBName;
    }
}

