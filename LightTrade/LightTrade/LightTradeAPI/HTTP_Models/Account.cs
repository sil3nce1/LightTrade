using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class Account
    {
        public string id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isBanned { get; set; }
        public string banReason { get; set; }
        public bool isTrader { get; set; }
        public bool isAdmin { get; set; }
        public bool hasPlan { get; set; }
        public PlanAccount planAccount { get; set; }
        

    }
}
