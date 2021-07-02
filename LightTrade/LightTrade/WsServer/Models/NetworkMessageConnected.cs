using LightTrade.WsServer;
using LightTrade.WsServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.WsServer.Models
{
   public class NetworkMessageConnected : NetworkMessage
    {

        public NetworkMessageConnected(): base((int)NetworkMessageEnum.CONNECT) { }
    }
}
