using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class NetworkMessageRooms : NetworkMessage
    {
        public List<TradeRoom> rooms { get; set; }
    }
}
