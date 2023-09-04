using Microsoft.AspNetCore.Mvc;
using projectemail.Models;
using System.Diagnostics;

namespace projectemail.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender emailSender;

        private readonly ILogger<HomeController> _logger;
        public HomeController(IEmailSender emailSender, ILogger<HomeController> logger)
        {
            this.emailSender = emailSender;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string subject, string message)
        {
            await emailSender.SendEmailAsync(email, subject, message);
            return View();
        }

              
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

    }
}