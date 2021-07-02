using LightTrade.LightTradeAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.HTTP_Models
{
    public class BrokerAccount
    {
        public string id { get; set; }
        public string crypted { get; set; }
        public int brokerId { get; set; }


        public string GetBrokerName()
        {
            if (brokerId == (int)BrokerEnum.IQOPTION)
                return "IQOption";
            else if (brokerId == (int)BrokerEnum.EBINEX)
                return "Ebinex";
            else if (brokerId == (int)BrokerEnum.XTB)
                return "XTB";

            return string.Empty;
        }

        public static int GetBrokerId(string brokerName)
        {
            string brokerNameFormatted = brokerName.ToLower();
            if (brokerNameFormatted == "iqoption")
                return (int)BrokerEnum.IQOPTION;
            else if (brokerNameFormatted == "ebinex")
                return (int)BrokerEnum.EBINEX;
            else if (brokerNameFormatted == "xtb")
                return (int)BrokerEnum.XTB;

            return -1;
        }

    }
}
