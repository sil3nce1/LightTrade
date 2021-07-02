using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class Plan
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int days { get; set; }

    }
}
