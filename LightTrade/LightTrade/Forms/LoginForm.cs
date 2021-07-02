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
using LightTrade.LightTradeAPI.HTTP_Models;
using LightTrade.Forms;

namespace LightTrade
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public static LoginForm instance;
        public LoginForm()
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

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            ServerResponse serverResponse = await API.AuthAsync(txtUsername.Text, txtPassword.Text);
            
            if (!serverResponse.success)
            {
                MessageBox.Show(serverResponse.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serverResponse.account.isTrader)
            {
                TraderDashboardForm frm = new TraderDashboardForm();
                frm.Show();
                this.Hide();
                return;
            }

            if (serverResponse.account.isAdmin)
            {
                AdminDashboardForm frm = new AdminDashboardForm();
                frm.Show();
                this.Hide();
                return;
            }

            if ((!serverResponse.account.isAdmin) && (!serverResponse.account.isTrader))
            {
                UserDashboardForm frm = new UserDashboardForm();
                frm.Show();
                this.Hide();
            }
            
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegisterAccountForm form = new RegisterAccountForm();
            form.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            instance = this;
            TradeRoomForm frm = new TradeRoomForm();
            frm.Show();
        }

        public void SetUsernameAndPassword(string username, string password)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
        }
    }
}
