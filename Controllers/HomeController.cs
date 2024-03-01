using Azure.Core;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendEmail()
        {
            try
            {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(Request.Form["From"]);
            mailMessage.To.Add(Request.Form["To"]);
            mailMessage.Subject = Request.Form["Subject"];
            mailMessage.Body = "<h1>This is body</h1>";
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(Request.Form["From"], "Charan#7090"),
                EnableSsl = true,
            };
            smtpClient.Send(mailMessage);
                mailMessage.Dispose();
                smtpClient.Dispose();

            } catch (Exception ex)
            {
                //Handle EXCEPTOPN
            }
            
            return View("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
