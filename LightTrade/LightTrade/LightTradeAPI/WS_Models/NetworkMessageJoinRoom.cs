using LightTrade.LightTradeAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageJoinRoom : NetworkMessage
    {
        public string roomId { get; set; }
        public TradeRoom tradeRoom { get; set; }

        public NetworkMessageJoinRoom(string roomId): base((int)NetworkMessageEnum.JOIN_ROOM)
        {
            this.roomId = roomId;
        }
    }
}
