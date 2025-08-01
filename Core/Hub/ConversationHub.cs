using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Core.Hub
{
    public class ConversationHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"Client connected: {Context.ConnectionId}");
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine($"Client disconnected: {Context.ConnectionId}");
            return base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
