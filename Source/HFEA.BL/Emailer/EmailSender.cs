using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using HFEA.BL.Contracts;
using HFEA.Core;
using HFEA.Core.Constants;

namespace HFEA.BL.Emailer
{
    public class EmailSender : IEmailSender
    {
        private const string MIME_HTML = "text/html";
        private const string MIME_TEXT = "text/plain";

        public MailMessage GetMailMessage(Email email)
        {
            if (email != null)
            {
                // pre validation and fixes to email
                if (string.IsNullOrWhiteSpace(email.ToAddress))
                {
                    //TODO: get default emailTo address from somewhere
                }

                if (string.IsNullOrWhiteSpace(email.FromAddress))
                {
                    //TODO: get default emailFrom address from somewhere
                }

                MailMessage mailMessage = new MailMessage();

                if (!string.IsNullOrWhiteSpace(email.FromAddress))
                {
                    mailMessage.From = new MailAddress(email.FromAddress.Trim());
                }

                //Add email To addresses
                if (!string.IsNullOrWhiteSpace(email.ToAddress))
                {
                    string[] toAddresses = email.ToAddress.Split(new char[] { EmailerConstants.Multiple_EmailAddresses_Seperator }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string address in toAddresses)
                    {
                        mailMessage.To.Add(address);
                    }
                }

                //Add email Cc addresses
                if (!string.IsNullOrWhiteSpace(email.CcAddress))
                {
                    string[] ccAddresses = email.CcAddress.Split(new char[] { EmailerConstants.Multiple_EmailAddresses_Seperator }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string address in ccAddresses)
                    {
                        mailMessage.CC.Add(address);
                    }
                }


                //Add Bcc addresses
                if (!string.IsNullOrWhiteSpace(email.BccAddress))
                {
                    string[] bccAddresses = email.BccAddress.Split(new char[] { EmailerConstants.Multiple_EmailAddresses_Seperator }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string address in bccAddresses)
                    {
                        mailMessage.Bcc.Add(address);
                    }
                }

                mailMessage.Subject = email.Subject;

                if (!string.IsNullOrWhiteSpace(email.BodyHTML) && !string.IsNullOrWhiteSpace(email.BodyText))
                {
                    mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(email.BodyHTML, null, MIME_HTML));
                    mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(email.BodyText, null, MIME_TEXT));
                }
                else
                {
                    bool isHtml = !string.IsNullOrWhiteSpace(email.BodyHTML) ? true : false;

                    mailMessage.Body = isHtml ? email.BodyHTML : email.BodyText;

                    mailMessage.IsBodyHtml = isHtml;
                }

                return mailMessage;
            }

            return null;
        }

        public bool Send(Email email)
        {
            bool sent = false;

            MailMessage message = this.GetMailMessage(email);

            try
            {
                using (SmtpClient client = new SmtpClient())
                {
                    client.Send(message);
                    sent = true;
                }
            }
            catch
            { }
            finally
            {
                if (message != null)
                    message.Dispose();
            }

            return sent;

        }
    }
}
