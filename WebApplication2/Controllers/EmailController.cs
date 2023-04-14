using Microsoft.Extensions.Configuration;
using Google.Apis.Auth.OAuth2;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Configuration;
using System.Net;
using MailChimp.Net.Models;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace WebApplication2.Controllers
{
    public class EmailController : Controller
    {


        public IActionResult SendEmail()
        {
            return View();
        }





        //[HttpPost]
        //public async Task<IActionResult> SendEmail(string body, IFormFile attachment)
        //{
        //    var email = new MimeMessage();
        //    email.From.Add(MailboxAddress.Parse("skye.metz@ethereal.email"));
        //    email.To.Add(MailboxAddress.Parse("skye.metz@ethereal.email"));
        //    email.Subject = "test email";

        //    var builder = new BodyBuilder();
        //    builder.HtmlBody = body;

        //    if (attachment != null)
        //    {
        //        byte[] fileBytes;
        //        using (var ms = new MemoryStream())
        //        {
        //            await attachment.CopyToAsync(ms);
        //            fileBytes = ms.ToArray();
        //        }
        //        builder.Attachments.Add(attachment.FileName, fileBytes, ContentType.Parse(attachment.ContentType));
        //    }

        //    email.Body = builder.ToMessageBody();

        //    using var smtp = new SmtpClient();
        //    smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
        //    smtp.Authenticate("skye.metz@ethereal.email", "4WRevuDGzuMt6QFMS1");
        //    smtp.Send(email);
        //    smtp.Disconnect(true);

        //    return RedirectToAction("AdminPage", "Account");
        //}














        private static async Task SendGridEmailAsync(string toEmail, string username,
             string subject, string message)
        {
            string apiKey = "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";
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress("ahmad.o.agha1986@gmail.com", "WebApplication2.com");
            var to = new EmailAddress(toEmail, username);
            var plainTextContent = message;
            var htmlContent = "<p>" + message + "</p>";

            var msg = MailHelper.CreateSingleEmail(
                from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(string toEmail, string username, string subject, string message)
        {
            await SendGridEmailAsync(toEmail, username, subject, message);

            return RedirectToAction("AdminPage", "Account");
        }


    }
}

