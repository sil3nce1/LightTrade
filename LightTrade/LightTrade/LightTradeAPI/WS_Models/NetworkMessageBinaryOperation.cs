using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageBinaryOperation
    {
        
        public string packet { get; set; }
        public int brokerId { get; set; }
        public NetworkMessageBinaryOperation(string packet, int brokerId)
        {
            this.packet = packet;
            this.brokerId = brokerId;
        }

        public NetworkMessageBinaryOperation() { }

    }
}
