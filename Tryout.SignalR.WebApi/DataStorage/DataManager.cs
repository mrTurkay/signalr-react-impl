using System;
using System.Collections.Generic;
using Tryout.SignalR.WebApi.Models;

namespace Tryout.SignalR.WebApi.DataStorage
{
    public class DataManager
    {
        public static List<ChartModal> GetData()
        {
            var r = new Random();
            return new List<ChartModal>()
            {
                new(){Data = new(){r.Next(1,40)}, Label = "Data1"},
                new(){Data = new(){r.Next(1,40)}, Label = "Data2"},
                new(){Data = new(){r.Next(1,40)}, Label = "Data3"},
                new(){Data = new(){r.Next(1,40)}, Label = "Data4"},
                new(){Data = new(){r.Next(1,40)}, Label = "Data5"},
            };
        }
    }
}
