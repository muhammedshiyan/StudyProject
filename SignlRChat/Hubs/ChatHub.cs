using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.SignalR;




namespace SignlRChat.Hubs
{
    public class ChatHub:Hub
    {


        public async Task SendMessage(string user, string message)
        {      
            
            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }


    }
}
