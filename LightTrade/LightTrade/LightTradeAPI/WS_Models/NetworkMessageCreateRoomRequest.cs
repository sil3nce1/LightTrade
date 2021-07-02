using LightTrade.LightTradeAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageCreateRoomRequest : NetworkMessage
    {
        public int brokerId { get; set; }
        public bool isPrivate { get; set; }

        public NetworkMessageCreateRoomRequest(int brokerId, bool isPrivate): base((int)NetworkMessageEnum.CREATE_ROOM)
        {
            this.brokerId = brokerId;
            this.isPrivate = isPrivate;
        }
    }
}
