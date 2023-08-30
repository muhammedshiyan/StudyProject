using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;
using NuGet.Configuration;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SignlRChat.Hubs
{

    public class ChatHub : Hub
    {
        private static int MessageCount = 0;
        private static int ConnectedDevices = 0;
        private static Dictionary<string, string> UserConnections = new Dictionary<string, string>();
        private static HashSet<string> ConnectedUserIds = new HashSet<string>();
        private CancellationToken newLikeCount;
        private CancellationToken newDislikeCount;

        public async Task SendMessage(string user, string message)
        {
            MessageCount++;
            await Clients.All.SendAsync("ReceiveMessage", user, message, MessageCount);


        }



        public async Task Sendurltoall(string image, string video, string text)
        {

            MessageCount++;
            string userId = Context.User.Identity.Name;

            await Clients.All.SendAsync("Receiveurl", image, video, text, userId);



        }




        public override async Task OnConnectedAsync()
        {
            ConnectedDevices++;

            // Update the count for all clients
            await Clients.All.SendAsync("UpdateConnectedDevicesCount", ConnectedDevices);
            if (Context.User.Identity.IsAuthenticated)
            {
                string userId = Context.User.Identity.Name;
                ConnectedUserIds.Add(userId);
                await Clients.All.SendAsync("UserConnected", $"{userId} connected.");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            ConnectedDevices--;

            // Update the count for all clients
            await Clients.All.SendAsync("UpdateConnectedDevicesCount", ConnectedDevices);

            if (Context.User.Identity.IsAuthenticated)
            {
                string userId = Context.User.Identity.Name;
                ConnectedUserIds.Remove(userId);
                await Clients.All.SendAsync("UserDisconnected", $"{userId} disconnected.");
            }
            await base.OnDisconnectedAsync(exception);
        }
        public List<string> GetConnectedUserIds()
        {
            return ConnectedUserIds.ToList();
        }

        public async Task SendMessageTospecificUser(string userId, string message)
        {
            MessageCount++;
            string sender = Context.User.Identity.Name;
            //  await Clients.Client(userId).SendAsync("ReceiveMessagetospecificuser", userId, sender, message);
            await Clients.User(userId).SendAsync("ReceiveMessagetospecificuser", userId, sender, message);
          
        }

        public async Task LikeMessage(int messageId)
        {
            // Update like count for the message (in memory or database)
            // Broadcast updated like count to all clients
            await Clients.All.SendAsync("UpdateMessageLikes", messageId, newLikeCount);
        }

        public async Task DislikeMessage(int messageId)
        {
            // Update dislike count for the message (in memory or database)
            // Broadcast updated dislike count to all clients
            await Clients.All.SendAsync("UpdateMessageDislikes", messageId, newDislikeCount);
        }




  
    }
}
  