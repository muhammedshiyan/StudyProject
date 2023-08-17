using Microsoft.AspNetCore.Mvc;

namespace SignlRChat.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
