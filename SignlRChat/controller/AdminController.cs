using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignlRChat.Hubs;
using SignlRChat.model;

namespace SignlRChat.controller
{
    public class AdminController : Controller
    {
        private readonly IHubContext<NotificationHub> _notificationHubContext;
        public AdminController(IHubContext<NotificationHub> notificationHubContext)
        {
            _notificationHubContext = notificationHubContext;
        }

        
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Article model)
        {
            await _notificationHubContext.Clients.All.SendAsync("sendToUser", model.articleHeading, model.articleContent);
            return View();
        }





    }
}
