using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class Coupon
    {
        public string id { get; set; }
        public string code { get; set; }
        public int percentage { get; set; }
    }
}
