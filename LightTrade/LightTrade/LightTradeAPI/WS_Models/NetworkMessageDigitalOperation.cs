using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageDigitalOperation
    {
        public string packet { get; set; }
        public int brokerId { get; set; }

        public NetworkMessageDigitalOperation(string packet, int brokerId)
        {
            this.packet = packet;
            this.brokerId = brokerId;
        }

        public NetworkMessageDigitalOperation() { }
    }
}
