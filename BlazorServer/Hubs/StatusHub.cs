using Microsoft.AspNetCore.SignalR;
using BlazorServer.Models;

namespace BlazorServer.Hubs
{
    public class StatusHub : Hub
    {
        public async Task SendStatusUpdate(Status status)
        {
            await Clients.All.SendAsync("ReceiveStatusUpdate", status);
        }
    }
}
