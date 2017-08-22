using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}


//**** Add the following code inside the body of public class clsBusinessLayer ****
public static bool SendEmail(string Sender, string Recipient, string bcc, string cc, string Subject, string Body) {
    try {
        // Instantiates new MailMessage
        MailMessage MyMailMessage = new MailMessage();
        // Sets the from for the email
        MyMailMessage.From = new MailAddress(Sender);
        // Sets the recipient of the email
        MyMailMessage.To.Add(new MailAddress(Recipient));
        // Checks for bcc

            if (bcc != null && bcc != string.Empty) {
               // Adds bcc recipient
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
       }

        // Checks for cc

            if (cc != null && cc != string.Empty) {
               // Adds cc recipient
               MyMailMessage.CC.Add(new MailAddress(cc));
       }

        // Sets the subject of the email
        MyMailMessage.Subject = Subject;
        // Sets the body of the email
        MyMailMessage.Body = Body;
        // Indicates that the body of the message is in html
        MyMailMessage.IsBodyHtml = true;
        // Sets the message priority level
        MyMailMessage.Priority = MailPriority.Normal;
        // AInstantiates new SmtpClient
        SmtpClient MySmtpClient = new SmtpClient("localhost");
        //SMTP Port = 25;
        //Generic IP host = "127.0.0.1";
        // Sends the message to smtp client for delivery
        MySmtpClient.Send(MyMailMessage);
        // If true, in the try,worked
        return true;
    } 

    catch (Exception ex) {
        // If false, in the try, failed
        return false;
    }

}      


}