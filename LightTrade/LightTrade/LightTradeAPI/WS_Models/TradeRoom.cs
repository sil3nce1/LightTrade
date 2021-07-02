using LightTrade.LightTradeAPI.HTTP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.WS_Models
{
    public class TradeRoom
    {
        public string roomId { get; set; }
        public string ownerUsername { get; set; }
        public string ownerEmail { get; set; }
        public List<Account> users { get; set; }
        public bool isRoomPrivate { get; set; }
        public string brokerName { get; set; }
        public bool isOnline { get; set; }
    }
}
