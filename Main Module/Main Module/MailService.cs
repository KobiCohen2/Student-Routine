using System.Net.Mail;
using System.Text;

namespace Main_Module
{
    public static class MailService
    {
        private static string companyMail = "studentroutine@gmail.com";

        //email sender method
        public static void EmailSender(string email, string message, string title)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(companyMail, "KobiTomer!");
            // Specify the e-mail sender.
            // Create a mailing address that includes a UTF8 character
            MailMessage mailMessage = new MailMessage(companyMail, email, title, message);
            mailMessage.BodyEncoding = UTF8Encoding.UTF8;
            mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mailMessage);

            //clear resources
            mailMessage.Dispose();
        }//end method

        //check mail validation method
        public static bool IsValidEmail(string email)
        {
            //trying to create a MailAddress instance, in order to chceck email validation
            try
            {
                MailAddress mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;//if there is equivalence, the mail is valid
            }
            catch// if an exception was thrown, the email is invalid
            {
                return false;
            }
        }//end method

    }//end class
}//end namespace
