using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Tryout.SignalR.WebApi.Hubs
{
    public class ChartHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("TransferChartData", message);
        }
    }
}
