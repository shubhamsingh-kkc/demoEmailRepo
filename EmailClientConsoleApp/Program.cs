// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Mail;
// System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;  

Console.WriteLine("Hello, World!");

// Client setup
SmtpClient smtp = new SmtpClient();
smtp.Host = "smtp.gmail.com";
smtp.EnableSsl = true;
smtp.UseDefaultCredentials = false;
smtp.Credentials = new NetworkCredential("s.shubham999.ss@gmail.com","zhmdjykaeisgaekb");
smtp.Port = 587;

// Email setup
MailMessage message = new MailMessage();
message.From = new MailAddress("s.shubham999.ss@gmail.com");
message.To.Add("s.shubham999.ss@gmail.com");
message.Subject = "SMTP Client testing";
message.Body = "This is an sample email sent via .Net Console application to test if SMTP client code is correct or not";

smtp.Send(message);