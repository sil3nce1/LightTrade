using LightTrade.WsServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.WsServer.Models
{
    public class NetworkMessageAuthRoom : NetworkMessage
    {
        public string roomId { get; set; }
        public string clientId { get; set; }

        public NetworkMessageAuthRoom(string roomId, string clientId) : base((int)NetworkMessageEnum.AUTH_ROOM)
        {
            this.roomId = roomId;
            this.clientId = clientId;
        }

    }
}
