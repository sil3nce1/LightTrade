using LightTrade.IQOptionAPI.HTTP_Models;
using LightTrade.IQOptionAPI.WS_Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websocket.Client;

namespace LightTrade.IQOptionAPI
{
    public class IQAPI
    {
        private string username;
        private string password;

        private WebsocketClient ws;

        public IQAPI(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public async Task<bool> Connect()
        {
            IRestClient client = new RestClient(URL.API_AUTH);
            IRestRequest request = new RestRequest(Path.AUTH_SIGNIN, DataFormat.Json);
            Dictionary<string, string> dictParams = new Dictionary<string, string>();
            dictParams.Add("identifier", username);
            dictParams.Add("password", password);
            request.AddJsonBody(dictParams);
            Authentication auth = await client.PostAsync<Authentication>(request);
            if (auth.ssid == null)
                return false;

            MessageBox.Show("haha");
            ws = new WebsocketClient(new Uri(URL.WS_URL));
            ws.ReconnectTimeout = TimeSpan.FromSeconds(30);
            ws.MessageReceived.Subscribe(msg => ReadWsMessage(msg.Text));
            await ws.Start();
            SendMessage(new NetworkMessage("authenticate", new NetworkMessageAuthenticateRequest("", 3, "", auth.ssid +"d")));
            return true;
        }

        private void ReadWsMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void SendMessage(string message)
        {
            ws.Send(message);
        }

        public void SendMessage(object message)
        {
            MessageBox.Show(JsonSerializer.Serialize(message));
            ws.Send(JsonSerializer.Serialize(message));
        }
    }
}
