using System.IO;
using System.Net;
using System.Net.Mail;
using UnityEngine;

public class EmailController
{
    public static void SendEmail(byte[] attachmentArray, string filename)
    {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("pruebacartasiowa@gmail.com");
        mail.To.Add("recursoslapsucc@ucatolica.edu.co");
        mail.Subject = $"{PlayerPrefs.GetString("lastName")} {PlayerPrefs.GetInt("identification")} Analiticas.csv";
        mail.Body = $"La persona con apellido {PlayerPrefs.GetString("lastName")} con identificacion {PlayerPrefs.GetInt("identification")} " +
        $"presentó la prueba de las cartas de Iowa a las {System.DateTime.Now.ToLongTimeString()}"; ;

        Attachment attachment = new Attachment(new MemoryStream(attachmentArray), filename);
        mail.Attachments.Add(attachment);

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new NetworkCredential("pruebacartasiowa@gmail.com", "catolica123");
        SmtpServer.EnableSsl = true;
        SmtpServer.Send(mail);
    }
}
