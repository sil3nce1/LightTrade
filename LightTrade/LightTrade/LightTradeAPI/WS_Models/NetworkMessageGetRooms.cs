using LightTrade.LightTradeAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageGetRooms : NetworkMessage
    {
        public int brokerId { get; set; }
        public NetworkMessageGetRooms(int brokerId): base((int)NetworkMessageEnum.ROOMS)
        {
            this.brokerId = brokerId;
        }
    }
}
