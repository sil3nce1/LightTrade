using LightTrade.LightTradeAPI.HTTP_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.LightTradeAPI.Services
{
    public class Services
    {
        public APIService<Account> Account;
        public APIService<BrokerAccount> BrokerAccount;
        public APIService<Plan> Plan;
        public APIService<Coupon> Coupon;
        public APIService<MercadoPago> MercadoPago;

        public Services(string authToken = null)
        {
            Account = new APIService<Account>(URL.API_URL, Path.ACCOUNT, authToken);
            BrokerAccount = new APIService<BrokerAccount>(URL.API_URL, Path.BROKER_ACCOUNT, authToken);
            Plan = new APIService<Plan>(URL.API_URL, Path.PLAN, authToken);
            Coupon = new APIService<Coupon>(URL.API_URL, Path.COUPON, authToken);
            MercadoPago = new APIService<MercadoPago>(URL.API_URL, Path.MERCADOPAGO, authToken);
        }
    }
}
