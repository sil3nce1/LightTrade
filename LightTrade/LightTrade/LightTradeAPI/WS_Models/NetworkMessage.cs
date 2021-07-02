using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessage
    {
        public int id { get; set; }
        public bool success { get; set; }
        public string clientId { get; set; }

        public string message { get; set; }

        public NetworkMessage(int id)
        {
            this.clientId = API.clientId;
            this.id = id;
        }

        public NetworkMessage() { }
    }
}
