using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class PlanAccount
    {
        public string id { get; set; }
        public Account account { get; set; }
        public Plan plan { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int planRemainingTime { get; set; }
    }
}
