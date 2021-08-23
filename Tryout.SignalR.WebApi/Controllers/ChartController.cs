using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Tryout.SignalR.WebApi.DataStorage;
using Tryout.SignalR.WebApi.Hubs;
using Tryout.SignalR.WebApi.TimerFeatures;

namespace Tryout.SignalR.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChartController : ControllerBase
    {
        private readonly ILogger<ChartController> _logger;
        private readonly IHubContext<ChartHub> _hub;

        public ChartController(ILogger<ChartController> logger,
                               IHubContext<ChartHub> hub)
        {
            _logger = logger;
            _hub = hub;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var timerManager = new TimerManager(() =>
                _hub.Clients.All.SendAsync("TransferChartData", DataManager.GetData()));

            return Ok(new { Message = "Request Completed" });
        }
    }
}
