using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace SignlRChat.Hubs
{
    public class ChatHub:Hub
    {


        public async Task SendMessage(string user, string message)
        {      
            
            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }

        public async Task SendVideo(string user, string videoUrl)
        {
            await Clients.All.SendAsync("ReceiveVideo", user, videoUrl);
        }






    }
}
  