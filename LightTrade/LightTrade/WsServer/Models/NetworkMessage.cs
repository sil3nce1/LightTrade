using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.WsServer
{
    public class NetworkMessage
    {
        public int id { get; set; }

        public NetworkMessage(int id)
        {
            this.id = id;
        }

        public NetworkMessage() { }
    }
}
