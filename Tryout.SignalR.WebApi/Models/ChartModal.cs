using System.Collections.Generic;

namespace Tryout.SignalR.WebApi.Models
{
    public class ChartModal
    {
        public List<int> Data { get; set; } = new();
        public string Label { get; set; }
    }
}
