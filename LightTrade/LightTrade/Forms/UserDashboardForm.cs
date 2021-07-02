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
using LightTrade.LightTradeAPI;
using MaterialSkin.Controls;
using LightTrade.LightTradeAPI.HTTP_Models;
using LightTrade.Cypher;
using LightTrade.LightTradeAPI.WS_Models;
using LightTrade.Helpers;

namespace LightTrade.Forms
{

    public partial class UserDashboardForm : MaterialSkin.Controls.MaterialForm
    {
        #region PlanTab
        private int planPageIndex = 0;
        #endregion


        private class BtnPlanBuyInfo
        {
            public string planId;
            public MaterialTextBox txtCoupon;

            public BtnPlanBuyInfo(string planId, MaterialTextBox txtCoupon)
            {
                this.planId = planId;
                this.txtCoupon = txtCoupon;
            }
        }

        public UserDashboardForm()
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

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            API.OnMessageReceived += new API.OnMessageReceivedHandler(OnWsServerMessageReceived);
            API.WsConnect();
            dtGridTradeRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblAccountUsername.Text = "Username: " + API.ConnectedAccount.username;
            lblAccountEmail.Text = "Email: " + API.ConnectedAccount.email;

            if (!API.ConnectedAccount.hasPlan)
            {
                btnGoToPlans.Visible = true;
            }
            else
            {
                lblAccountPlanName.Visible = true;
                lblAccountPlanRemainingTime.Visible = true;
                lblAccountPlanName.Text = "Name: " + API.ConnectedAccount.planAccount.plan.name;
                lblAccountPlanRemainingTime.Text = "Remaining Time: " + API.ConnectedAccount.planAccount.planRemainingTime + " Days";
            }
        }

        void OnWsServerMessageReceived(NetworkMessage message)
        {
            if (message.success)
            {
                MessageBox.Show(message.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        MaterialCard GeneratePlanCard(int index, Plan plan)
        {
            MaterialCard card = new MaterialCard();
            int posX = index == 0 ? 31 : index * 195 + 31;
            card.Location = new Point(posX, 31);
            card.Size = new Size(167, 309);
            card.Tag = plan;

            MaterialLabel lblPlanName = new MaterialLabel();
            lblPlanName.Location = new Point(48, 14);
            lblPlanName.Text = plan.name;
            card.Controls.Add(lblPlanName);

            MaterialLabel lblPlanDays = new MaterialLabel();
            lblPlanDays.Location = new Point(17, 55);
            lblPlanDays.Text = "Days: " + plan.days.ToString();
            card.Controls.Add(lblPlanDays);

            MaterialLabel lblPlanPrice = new MaterialLabel();
            lblPlanPrice.Location = new Point(17, 84);
            lblPlanPrice.Text = "Price: R$" + plan.price.ToString();
            card.Controls.Add(lblPlanPrice);

            MaterialLabel lblPlanCoupon = new MaterialLabel();
            lblPlanCoupon.Location = new Point(17, 135);
            lblPlanCoupon.Text = "Coupon:";
            card.Controls.Add(lblPlanCoupon);

            MaterialTextBox txtCoupon = new MaterialTextBox();
            txtCoupon.Location = new Point(17, 157);
            txtCoupon.Size = new Size(133, 50);
            txtCoupon.Text = "";
            txtCoupon.TextChanged += new EventHandler(OnPlanTxtCouponTextChanged);
            txtCoupon.Tag = card;
            card.Controls.Add(txtCoupon);

            MaterialButton btnPermissions = new MaterialButton();
            btnPermissions.Tag = plan.id.ToString();
            btnPermissions.Click += new EventHandler(PlanBtnPermissionsClicked); 
            btnPermissions.Location = new Point(26, 216);
            btnPermissions.Text = "Permissions";
            card.Controls.Add(btnPermissions);

            MaterialButton btnBuy = new MaterialButton();
            btnBuy.Tag = new BtnPlanBuyInfo(plan.id, txtCoupon);
            btnBuy.Click += new EventHandler(PlanBtnBuyClicked);
            btnBuy.Location = new Point(51, 260);
            btnBuy.Text = "Buy";
            card.Controls.Add(btnBuy);
            return card;
        }

        private void PlanBtnPermissionsClicked(object sender, EventArgs e)
        {
            string planId = ((MaterialButton)sender).Tag.ToString();
        }

        private async void OnPlanTxtCouponTextChanged(object sender, EventArgs e)
        {
            MaterialTextBox txtCoupon = (MaterialTextBox)sender;
            MaterialCard card = (MaterialCard)txtCoupon.Tag;
            Plan plan = (Plan)card.Tag;

            try
            {
                if (txtCoupon.Text.Length >= 6)
                {
                    List<string> paramsList = new List<string>();
                    paramsList.Add(txtCoupon.Text);
                    Coupon coupon = await API.Services.Coupon.GetByParams(paramsList);

                    if (coupon != null)
                    {
                        foreach (Control control in card.Controls)
                        {
                            if (control.Text.Contains("Price:"))
                            {
                                control.Text = "Price: " + (plan.price - MathHelper.CalculatePercentage(coupon.percentage, plan.price)).ToString();
                            }
                                
                        }
                    }
                    
                }
            }
            catch
            {
                return;
            }

        }

        private async void PlanBtnBuyClicked(object sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;
            BtnPlanBuyInfo buyInfo = (BtnPlanBuyInfo)btn.Tag;

            List<string> paramsList = new List<string>();
            paramsList.Add(buyInfo.planId);
            paramsList.Add(buyInfo.txtCoupon.Text);

            MercadoPago mp = await API.Services.MercadoPago.GetByParams(paramsList);
            if (mp.success)
            {
                System.Diagnostics.Process.Start(mp.url);
            }
            else
            {
                MessageBox.Show(mp.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        MaterialCard GenerateBrokerCard(int index, BrokerAccount brokerAccount)
        {
            MaterialCard card = new MaterialCard();
            int posX = index == 0 ? 25 : index * 175 + 25;
            card.Location = new Point(posX, 38);
            card.Size = new Size(170, 169);

            MaterialLabel lblHeaderText = new MaterialLabel();
            lblHeaderText.Location = new Point(53, 14);
            lblHeaderText.Text = brokerAccount.GetBrokerName();
            card.Controls.Add(lblHeaderText);

            MaterialLabel lblIndexText = new MaterialLabel();
            lblIndexText.Location = new Point(76, 43);
            lblIndexText.Text = index.ToString();
            card.Controls.Add(lblIndexText);

            MaterialButton btn = new MaterialButton();
            btn.Text = "View";
            btn.Tag = brokerAccount.id;
            btn.Location = new Point(49, 72);
            btn.Click += new EventHandler(ViewBrokerAccount);
            card.Controls.Add(btn);

            btn = new MaterialButton();
            btn.Text = "Delete";
            btn.Tag = brokerAccount.id;
            btn.Location = new Point(44, 120);
            btn.Click += new EventHandler(DeleteBrokerAccount);
            card.Controls.Add(btn);

            return card;
        }

        public async void DeleteBrokerAccount(object sender, EventArgs e)
        {
            string brokerAccountId = ((MaterialButton)sender).Tag.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete?", Defines.WINDOW_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ServerResponse serverResponse = await API.Services.BrokerAccount.Delete(brokerAccountId);
                if (serverResponse.success)
                {
                    MessageBox.Show(serverResponse.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public async void ViewBrokerAccount(object sender, EventArgs e)
        {
            string brokerAccountId = ((MaterialButton)sender).Tag.ToString();
            string secretKey = Microsoft.VisualBasic.Interaction.InputBox("Type the secret key", "LightTrade", "");
            List<string> paramList = new List<string>();
            paramList.Add(brokerAccountId);

            BrokerAccount brokerAccount = await API.Services.BrokerAccount.GetByParams(paramList);
            try
            {
                string decrypted = XOR.EncryptDecrypt(brokerAccount.crypted, secretKey);
                string username = decrypted.Split(new[] { "*" }, StringSplitOptions.RemoveEmptyEntries)[0];
                string password = decrypted.Split(new[] { "*" }, StringSplitOptions.RemoveEmptyEntries)[1];
                MessageBox.Show($"Username: {username}{Environment.NewLine}Password: {password}", Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to decrypt data", Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        async void FetchPlans()
        {
            foreach (Control control in panelPlans.Controls)
            {
                if (control.GetType() == typeof(MaterialCard))
                    panelPlans.Controls.Remove(control);
            }
            foreach (Control control in panelPlans.Controls)
            {
                if (control.GetType() == typeof(MaterialCard))
                    panelPlans.Controls.Remove(control);
            }
            List<string> paramsList = new List<string>();
            paramsList.Add(planPageIndex.ToString());
            List<Plan> plans = await API.Services.Plan.GetAllByParams(paramsList);
            for (int i = 0; i < plans.Count; i++)
            {
                panelPlans.Controls.Add(GeneratePlanCard(i, plans[i]));
            }
        }

        private void tabSideMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabSideMenu.SelectedIndex == 1)
            {
                FetchPlans();
            }

            if ((tabSideMenu.SelectedIndex >= 2) && (!API.ConnectedAccount.hasPlan))
            {
                MessageBox.Show("You don't have a plan yet", Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSideMenu.SelectTab(0);
            }
        }

        private async void btnSelectBroker_Click(object sender, EventArgs e)
        {
            List<string> paramsList = new List<string>();
            paramsList.Add(BrokerAccount.GetBrokerId(cbBrokerName.SelectedItem.ToString()).ToString());
            List<BrokerAccount> brokerAccounts = await API.Services.BrokerAccount.GetAllByParams(paramsList);

            if (brokerAccounts.Count == 0)
            {
                lblBrokerAccount.Text = "You don't have any broker account, go to add new to add one";
            }
            else
            {
                lblBrokerAccount.Text = "Your Broker Accounts";
            }

            foreach (Control control in panelBrokers.Controls)
            {
                if (control.GetType() == typeof(MaterialCard))
                    panelBrokers.Controls.Remove(control);
            }

            for (int i = 0; i < brokerAccounts.Count; i++)
            {
                BrokerAccount currentBrokerAccount = brokerAccounts[i];
                panelBrokers.Controls.Add(GenerateBrokerCard(i, currentBrokerAccount));
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddNewBrokerForm frm = new AddNewBrokerForm();
            frm.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnJoinPrivateRoom_Click(object sender, EventArgs e)
        {
            string roomId = Microsoft.VisualBasic.Interaction.InputBox("Type the room id", "LightTrade", "");
        }

        private void btnSelectTradeRoom_Click(object sender, EventArgs e)
        {
            API.GetPublicRooms(BrokerAccount.GetBrokerId(cbTradeRoomBrokerName.SelectedItem.ToString()), OnPublicRoomsReceived);
        }

        private int OnPublicRoomsReceived(object obj)
        {
            List<TradeRoom> rooms = (List<TradeRoom>)obj;
            dtGridTradeRooms.Rows.Clear();
            foreach (TradeRoom room in rooms)
            {
                DataGridViewRow row = (DataGridViewRow)dtGridTradeRooms.Rows[0].Clone();
                row.Cells[0].Value = room.roomId;
                row.Cells[1].Value = room.ownerUsername;
                row.Cells[2].Value = room.brokerName;
                dtGridTradeRooms.Rows.Add(row);
            }

            return 0;
        }

        private void btnPlanPageBack_Click(object sender, EventArgs e)
        {
            if (planPageIndex <= 0)
                return;

            planPageIndex -= 1;
            lblPlanPage.Text = (planPageIndex + 1).ToString();
            FetchPlans();
        }

        private void btnPlanPageFoward_Click(object sender, EventArgs e)
        {
            planPageIndex += 1;
            lblPlanPage.Text = (planPageIndex + 1).ToString();
            FetchPlans();
        }

        private void btnGoToPlans_Click(object sender, EventArgs e)
        {
            tabSideMenu.SelectTab(1);
        }

        private void dtGridTradeRooms_DoubleClick(object sender, EventArgs e)
        {
            string roomId = dtGridTradeRooms.SelectedRows[0].Cells[0].Value.ToString();
            API.JoinTradeRoom(roomId, OnTradeRoomJoined);
        }

        int OnTradeRoomJoined(object msg)
        {
            NetworkMessageJoinRoom joinRoomResponse = (NetworkMessageJoinRoom)msg;

            if (joinRoomResponse.success)
            {
                TradeRoomForm frm = new TradeRoomForm();
                frm.SetTradeRoom(joinRoomResponse.tradeRoom);
                frm.SetIsTrader(false);
                frm.Show();
            }
            else
            {
                MessageBox.Show(joinRoomResponse.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        private void dtGridTradeRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGridTradeRooms.SelectedRows.Count > 1)
            {
                dtGridTradeRooms.ClearSelection();
            }     
        }
    }
}
