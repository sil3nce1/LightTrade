using LightTrade.Cypher;
using LightTrade.LightTradeAPI;
using LightTrade.LightTradeAPI.HTTP_Models;
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

namespace LightTrade.Forms
{
    public partial class AddNewBrokerForm : MaterialSkin.Controls.MaterialForm
    {
        public AddNewBrokerForm()
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

        private void AddNewBrokerForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddBrokerAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string brokerName = cbBroker.SelectedItem.ToString();
            string secretKey = txtSecretKey.Text;

            int brokerId = BrokerAccount.GetBrokerId(brokerName);
            if (brokerId == -1)
            {
                MessageBox.Show("Invalid broker selected", Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BrokerAccount brokerAccount = new BrokerAccount();
            brokerAccount.crypted = XOR.EncryptDecrypt(username + "*" + password, secretKey);
            brokerAccount.brokerId = brokerId;
            ServerResponse serverResponse = await API.Services.BrokerAccount.Create(brokerAccount);

            if (serverResponse.success)
            {
                MessageBox.Show(serverResponse.message);
            }

        }
    }
}
