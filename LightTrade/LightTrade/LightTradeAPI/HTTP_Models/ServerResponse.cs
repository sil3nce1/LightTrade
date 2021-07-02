using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class ServerResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string token { get; set; }
        public Account account { get; set; }
        public bool freePlan { get; set; }

    }
}
