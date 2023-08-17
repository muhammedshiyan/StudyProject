using Microsoft.AspNetCore.SignalR;

namespace weblivecoremvc.wwwroot.Hubs
{
    public class UserHub:Hub
    {
        public static int TottalViews { get; set; } = 0;


        public async Task newwindowloaded()
        {
            TottalViews++;
            await Clients.All.SendAsync("UpdateTotalViews", TottalViews);

        }

    }
}
