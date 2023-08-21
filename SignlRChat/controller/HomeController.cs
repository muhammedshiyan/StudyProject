using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SignlRChat.controller
{
    public class HomeController : Controller
    {
      //  private object _notificationHubContext;

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
     
    }
}





