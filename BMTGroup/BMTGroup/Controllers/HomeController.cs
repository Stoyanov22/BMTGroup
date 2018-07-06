using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BMTGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public async Task<ActionResult> email(FormCollection form)
        {
            var name = form["sname"];
            var email = form["semail"];
            var messages = form["smessage"];
            var phone = form["sphone"];
            var x = await SendEmail(name, email, messages, phone);
            if (x == "sent")
                ViewData["esent"] = "Your Message Has Been Sent";
            return RedirectToAction("Index");
        }
        private async Task<string> SendEmail(string name, string email, string messages, string phone)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("iliyan.stoyanov.22@gmail.com"));  // replace with receiver's email id  
            message.From = new MailAddress("iliyan.stoyanov.22@gmail.com");  // replace with sender's email id 
            message.Subject = "Message From" + email;
            message.Body = "Name: " + name + "\nFrom: " + email + "\nPhone: " + phone + "\n" + messages;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "iliyan.stoyanov.22@gmail.com",  // replace with sender's email id 
                    Password = "101suriv22"  // replace with password 
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
                return "sent";
            }
        }
    }
}