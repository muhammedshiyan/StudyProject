using projectemail;
using System.Net;
using System.Net.Mail;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {

        //smtp.office365.com
        //var client = new SmtpClient("smtp.office365.com", 587)
        //{
        //    EnableSsl = true,
        //    UseDefaultCredentials = false,
        //    Credentials = new NetworkCredential("muhammed.shiyan@empressinfotech.com", "Shiyan@99")
        //};

        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("muhammedshiyanv@gmail.com","cpyxkrloyshzamoo")
           

        };



        //    var client = new SmtpClient("smtp.ethereal.email", 587)
        //    {
        //        EnableSsl = true,
        //        UseDefaultCredentials = false,

        //        Credentials = new NetworkCredential("payton.wilderman@ethereal.email", "e4jcB9F6csfAF2w6pv")
        //    };



        //return client.SendMailAsync(
        //    new MailMessage(from: "payton.wilderman@ethereal.email",
        //                    to: email,
        //                    subject,
        //                    message
        //                    ));

        return client.SendMailAsync(
          new MailMessage(from: "muhammedshiyanv@gmail.com",
                          to: email,
                          subject,
                          message
                          ));



    }

}