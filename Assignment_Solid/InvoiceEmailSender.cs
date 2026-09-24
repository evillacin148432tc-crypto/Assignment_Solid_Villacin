using System.Net.Mail;

namespace Assignment_Solid
{
    public class InvoiceEmailSender
    {
        public void Send(string toEmail, decimal total)
        {
            var smtp = new SmtpClient("smtp.gmail.com");
            var mail = new MailMessage("store@shop.com", toEmail)
            {
                Body = $"Your total is {total:C}"
            };
            smtp.Send(mail);
        }
    }
}