using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SignlRChat.controller
{
    public class HomeController : Controller
    {
        //  private object _notificationHubContext;
       // private readonly  _dbContext; // Inject your DbContext here
        private readonly IWebHostEnvironment _webHostEnvironment;

        public IActionResult Index()
        {
            return View();
        }

  









    }
}





