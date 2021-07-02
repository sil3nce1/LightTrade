using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.IQOptionAPI.WS_Models
{

    public class NetworkMessageAuthenticateRequest
    {
        
        public string client_session_id { get; set; }
        public int protocol { get; set; }
        public string session_id { get; set; }
        public string ssid { get; set; }

        public NetworkMessageAuthenticateRequest(string clientSessionId, int protocol, string sessionId, string ssid)
        {

            this.client_session_id = clientSessionId;
            this.protocol = protocol;
            this.session_id = session_id;
            this.ssid = ssid;
        }

       
    }
}
