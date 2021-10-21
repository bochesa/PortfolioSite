using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioSite.Models;
using System.Net.Mail;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ViewModel vm;
        [TempData]
        public string Feedback { get; set; }

        public HomeController(ILogger<HomeController> logger, ViewModel vm)
        {
            _logger = logger;
            this.vm = vm;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Data data = new Data();
            vm.MyInfo = data.GetMyInfo();
            vm.Portfolios = data.GetPortfolios();
            vm.ContactMe = data.GetContactMe();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage mailMsg = new MailMessage();
                    mailMsg.From = new MailAddress(contactMe.Email);
                    mailMsg.To.Add("bochesa@gmail.com");
                    mailMsg.Subject = contactMe.Subject;
                    mailMsg.Body = contactMe.Message;
                    mailMsg.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential
                    ("bochesa@gmail.com", "ixzcuftfrxwgjoxk");
                    smtp.Send(mailMsg);

                    ModelState.Clear();
                    TempData["Feedback"] = "Thank you for Contacting us";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    TempData["Feedback"] = $"Sorry we are facing Problem here {ex.Message}";
                }
            }

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
