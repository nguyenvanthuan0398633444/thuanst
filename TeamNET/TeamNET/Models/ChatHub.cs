
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace TeamNET.Models
{
    public class ChatHub : Hub
    {
        public async Task Send()
        {
            // Call the addNewMessageToPage method to update clients.
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
