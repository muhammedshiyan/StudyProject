using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace SignlRChat.Hubs
{
  
    public class ChatHub:Hub
    {
        //public async Task NewTabOpened()
        //{
        //    await Clients.Others.SendAsync("TabOpened");
        //}
      


        //public override Task OnConnectedAsync()
        //{
        //    _ = Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
        //    return base.OnConnectedAsync();
        //}
      

        public async Task SendMessage(string user, string message)
        {      
            
            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }



        public async Task Sendurltoall(string user, string message)
        {

            await Clients.All.SendAsync("Receiveurl", user, message);

        }



        //public async Task SendVideo(string user, string videoUrl)
        //{
        //    await Clients.All.SendAsync("ReceiveVideo", user, videoUrl);
        //}

        public Task SendMessageToGroup(string user, string receiver, string message)
        {
          
            return Clients.Group(receiver).SendAsync("ReceiveMessage", user, message);

        }




    }
}
  