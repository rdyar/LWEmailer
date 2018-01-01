# LWEmailer
Simple app to send a reminder email to LW POS customers that have ready orders.

This is built using the community version of Visual Studio.

You can download a zip file of the installer and required file above under `Releases`.

Go to File >> Settings to configure your info.

Type in a LW Order Number and press return and it should populate the boxes below and then highlite the Custom Message text box. Click the send button and it will send the email (email is also cc'd to the lab email address).

The Customer First Name field can be problematic, there is no first name field in LW, just the account name. The code is checking to see if there is a comma in the account name (like `smith, dave`) and if there is then it splits it and uses the second part as the First Name. If there is no comma in the account name then it uses the whole account name.

Email is best done via AWS SES and a properly secured IAM user that only has send mail permissions. You can use Gmail or another email provider though, just know that the password is not properly secured (it is stored in plain text in some hidden file somewhere).

*Disclaimer: I have no idea what I am doing, use at your own risk.*

![Main Screen](images/main-screen.png)  

![Settings Screen](images/settings-screen.png)  

![email](images/email.png)  
