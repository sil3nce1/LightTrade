using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.IQOptionAPI.WS_Models
{
    public class NetworkMessage
    {
        public int local_time { get; set; }
        public object msg { get; set; }
        public string name { get; set; }
        public string request_id { get; set; }

        public NetworkMessage(string name, object msg)
        {
            this.local_time = 8816;
            this.request_id = "1625178247_1251737158";
            this.name = name;
            this.msg = msg;
        }

        public NetworkMessage() { }
    }
}
