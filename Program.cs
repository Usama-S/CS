using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MailsEntities();
            var emails = db.myMails.Find(1);

            var toaddress = "example.receiver@gmail.com";
            var fromaddress = "example.sender@gmail.com";
            var subject = "Testing Email";
            var body = "This is a testing email sent through C# using gmail.";

            var host = "smtp.gmail.com";                    //should be kept in a .config file
            var port = 587;                                 //should be kept in a .config file
            var username = "example.sender@gmail.com";      //should be kept in a .config file
            var password = "gmail.password";                //should be kept in a .config file

            var client = new System.Net.Mail.SmtpClient(host, port);
            client.Credentials = new NetworkCredential(username, password);
            client.EnableSsl = true;

            MailMessage msg = new MailMessage(fromaddress, toaddress);
            msg.Subject = subject;
            msg.Body = body;
            client.Send(msg);
        }
    }
}
