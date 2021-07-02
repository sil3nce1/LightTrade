using LightTrade.LightTradeAPI.Enums;
using LightTrade.LightTradeAPI.HTTP_Models;
using LightTrade.LightTradeAPI.WS_Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace LightTrade.LightTradeAPI
{
    public static class API
    {
        public static Services.Services Services = new Services.Services();
        public static Account ConnectedAccount { get; set; }
        private static string authToken;
        private static WebSocket ws;
        public static string clientId = string.Empty;

        private static Func<object, int> currentCb = null;
 

        #region Room
        public static TradeRoom ConnectedTradeRoom { get; set; }
        #endregion

        #region Operations
        public delegate void OnDigitalOperationReceivedHandler(NetworkMessageDigitalOperation operation);
        public static event OnDigitalOperationReceivedHandler OnDigitalOperationReceived;

        public delegate void OnBinaryOperationReceivedHandler(NetworkMessageBinaryOperation operation);
        public static event OnBinaryOperationReceivedHandler OnBinaryOperationReceived;
        #endregion

        #region Message
        public delegate void OnMessageReceivedHandler(NetworkMessage message);
        public static event OnMessageReceivedHandler OnMessageReceived;
        #endregion

        public static async Task<ServerResponse> AuthAsync(string username, string password)
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestClient client = new RestClient(URL.API_URL);
            IRestRequest request = new RestRequest(Path.AUTH_SIGN_IN, DataFormat.Json);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("username", username);
            dict.Add("password", password);
            request.AddJsonBody(dict);
            ServerResponse serverResponse = await client.PostAsync<ServerResponse>(request, cancellationToken);
            if (serverResponse.success)
            {
                Services = new Services.Services(serverResponse.token);
                ConnectedAccount = serverResponse.account;
                authToken = serverResponse.token;
            }

            return serverResponse;
        }

        public static void WsConnect()
        {
            ws = new WebSocket(URL.WS_URL);
            ws.OnMessage += (sender, e) => ReadWsMessage(e.Data);
            ws.Connect();
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("id", (int)NetworkMessageEnum.CONNECT);
            pairs.Add("authToken", authToken);
            ws.Send(JsonSerializer.Serialize(pairs));
        }

        private static void ReadWsMessage(string message)
        {
            NetworkMessage networkMessage = JsonSerializer.Deserialize<NetworkMessage>(message);
            MessageBox.Show(message);
            switch (networkMessage.id)
            {
                case (int)NetworkMessageEnum.CONNECT:
                    NetworkConnectMessage connectMessage = JsonSerializer.Deserialize<NetworkConnectMessage>(message);
                    clientId = connectMessage.clientId;
                    break;
                case (int)NetworkMessageEnum.ROOMS:
                    NetworkMessageRooms roomMessage = JsonSerializer.Deserialize<NetworkMessageRooms>(message);
                    currentCb(roomMessage.rooms);
                    break;
                case (int)NetworkMessageEnum.CREATE_ROOM:
                    NetworkMessageCreateRoomResponse createRoomResponse = JsonSerializer.Deserialize<NetworkMessageCreateRoomResponse>(message);
                    currentCb(createRoomResponse);
                    break;
                case (int)NetworkMessageEnum.DIGITAL_OPERATION:
                    NetworkMessageDigitalOperation digitalOperation = JsonSerializer.Deserialize<NetworkMessageDigitalOperation>(message);
                    OnDigitalOperationReceived(digitalOperation);
                    break;
                case (int)NetworkMessageEnum.BINARY_OPERATION:
                    NetworkMessageBinaryOperation binaryOperation = JsonSerializer.Deserialize<NetworkMessageBinaryOperation>(message);
                    OnBinaryOperationReceived(binaryOperation);
                    break;
                case (int)NetworkMessageEnum.JOIN_ROOM:
                    NetworkMessageJoinRoom joinRoomResponse = JsonSerializer.Deserialize<NetworkMessageJoinRoom>(message);
                    currentCb(joinRoomResponse);
                    break;
                case (int)NetworkMessageEnum.MESSAGE:
                    NetworkMessage msgReceived = JsonSerializer.Deserialize<NetworkMessage>(message);
                    OnMessageReceived(msgReceived);
                    break;
            }
        }

        public static void SendWsMessage(object message)
        {
            ws.Send(JsonSerializer.Serialize(message));
        }

        public static void GetPublicRooms(int brokerId, Func<object, int> func)
        {
            SendWsMessage(new NetworkMessageGetRooms(brokerId));
            currentCb = func;
        }

        public static void JoinTradeRoom(string roomId, Func<object, int> func)
        {
            SendWsMessage(new NetworkMessageJoinRoom(roomId));
            currentCb = func;
        }

        public static void CreateTradeRoom(int brokerId, bool isPrivate, Func<object, int> func)
        {
            SendWsMessage(new NetworkMessageCreateRoomRequest(brokerId, isPrivate));
            currentCb = func;
        }

    }

}
