using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageCreateRoomResponse : NetworkMessage
    {
        public string roomId { get; set; }
        public string message { get; set; }

    }
}
