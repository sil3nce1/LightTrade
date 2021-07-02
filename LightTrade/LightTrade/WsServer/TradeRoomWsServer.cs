using LightTrade.WsServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace LightTrade.WsServer
{
    public class TradeRoomWsServer : WebSocketBehavior
    {
        public static TradeRoomWsServer instance;
        public delegate void OnWsConnectedHandler(object sender);
        public static event OnWsConnectedHandler OnWsConnected;

        public TradeRoomWsServer()
        {
            instance = this;
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            string message = e.Data;
            NetworkMessage networkMessage = JsonSerializer.Deserialize<NetworkMessage>(message);

            switch(networkMessage.id)
            {
                case (int)NetworkMessageEnum.CONNECT:
                    OnWsConnected(this);
                    break;
            }
        }

        public static void SendMessage(object message)
        {
            TradeRoomWsServer.instance.Send(JsonSerializer.Serialize(message));
        }
    }
}
