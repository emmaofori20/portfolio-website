using Amoponsah.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Amoponsah
{
    public class MailService
    {
        public MailService()
        {

        }

        public void sendMail( MailViewModel model)
        {

            MailAddress to = new MailAddress("emmanuelofori2638@gmail.com");
            MailAddress from = new MailAddress(model.Email);

            MailMessage message = new MailMessage(from, to);
            message.Subject = model.Subject;
            message.Body = model.Message;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("emmanuelofori2638@gmail.com", "emmaofori20"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
            }
            catch (Exception err)
            {
                var error =err.Message;
                
            }
        }
    }
}
