using LightTrade.IQOptionAPI;
using LightTrade.IQOptionAPI.HTTP_Models;
using LightTrade.LightTradeAPI;
using LightTrade.LightTradeAPI.Enums;
using LightTrade.LightTradeAPI.HTTP_Models;
using LightTrade.LightTradeAPI.WS_Models;
using LightTrade.WsServer;
using LightTrade.WsServer.Models;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace LightTrade.Forms
{
    public partial class TradeRoomForm : MaterialSkin.Controls.MaterialForm
    {
        #region BrokerSettings 
        private string brokerUsername;
        private string brokerPassword;
        private int brokerId;
        #endregion

        #region API
        private IQAPI iqApi;
        #endregion

        private TradeRoom tradeRoom = null;
        private bool isTrader = true;
        private WebSocketServer wsServer = null;
        public TradeRoomForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void TradeRoomForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ConnectBrokerAPI();
            API.OnBinaryOperationReceived += new API.OnBinaryOperationReceivedHandler(OnBinaryOperationReceived);
            API.OnDigitalOperationReceived += new API.OnDigitalOperationReceivedHandler(OnDigitalOperationReceived);
            wsServer = new WebSocketServer(LightTrade.LightTradeAPI.URL.WS_EXTENSION_URL);
            wsServer.AddWebSocketService<TradeRoomWsServer>("/tradeRoomWs");
            TradeRoomWsServer.OnWsConnected += new TradeRoomWsServer.OnWsConnectedHandler(OnWsConnected);
            wsServer.Start();

            if (!isTrader)
            {
                lblConnectedUsers.Visible = false;
                btnConnect.Visible = false;
            }
                

            TradeRoom test = new TradeRoom();
            test.roomId = "hahaaha";
            test.ownerUsername = "macaco";
            test.brokerName = "IQOption";
            tradeRoom = test;
            lblRoomId.Text = "Room ID: " + tradeRoom.roomId;
            lblTraderUsername.Text = "Trader Username: " + tradeRoom.ownerUsername;
            btnConnect.Text = $"Waiting for {tradeRoom.brokerName}...";
        }

        private async void ConnectBrokerAPI()
        {
            if (brokerId == (int)BrokerEnum.IQOPTION)
            {
                iqApi = new IQAPI(brokerUsername, brokerPassword);
                await iqApi.Connect();
            }
        }

        public void OnWsConnected(object sender)
        {
            if (isTrader)
            {
                btnConnect.Text = "Connect";
                btnConnect.Enabled = true;
                TradeRoomWsServer.SendMessage(new NetworkMessageAuthRoom(tradeRoom.roomId, API.clientId));
            }
                
        }

        void AddOrderToGrid(string instrumentKey, string activePair, string amount, string balance, string timeFrame, string type)
        {
            DataGridViewRow row = (DataGridViewRow)dtGridOrders.Rows[0].Clone();
            row.Cells[0].Value = instrumentKey;
            row.Cells[1].Value = activePair;
            row.Cells[2].Value = amount;
            row.Cells[3].Value = balance;
            row.Cells[4].Value = timeFrame;
            row.Cells[5].Value = type;
            dtGridOrders.Rows.Add(row);
        }

        public void SetTradeRoom(TradeRoom room)
        {
            tradeRoom = room;
        }

        public void SetIsTrader(bool isTrader)
        {
            this.isTrader = isTrader;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OnBinaryOperationReceived(NetworkMessageBinaryOperation operation)
        {
            if (operation.brokerId == (int)BrokerEnum.IQOPTION)
            {

            }
        }

        private void OnDigitalOperationReceived(NetworkMessageDigitalOperation operation)
        {
            if (operation.brokerId == (int)BrokerEnum.IQOPTION)
            {

            }
        }

        public void SetBrokerSettings(string username, string password, int brokerId)
        {
            brokerUsername = username;
            brokerPassword = password;
            this.brokerId = brokerId;
 
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtAmount.Text);
                if (number >= 200)
                {
                    DialogResult result = MessageBox.Show("It's a higher amount, do you want to continue?", Defines.WINDOW_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        txtAmount.Text = "1";
                }
            }
            catch
            {
                txtAmount.Text = "1";
                MessageBox.Show("Invalid amount", Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            IQAPI iqApi = new IQAPI("joao-vitordeoliveira1@hotmail.com", "mk232323");
            await iqApi.Connect();
            
        }
    }
}
