using LightTrade.LightTradeAPI;
using LightTrade.LightTradeAPI.HTTP_Models;
using MaterialSkin;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightTrade.Forms
{
    public partial class RegisterAccountForm : MaterialSkin.Controls.MaterialForm
    {
        public RegisterAccountForm()
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

        private void RegisterAccountForm_Load(object sender, EventArgs e)
        {

        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.username = txtUsername.Text;
            account.email = txtEmail.Text;
            account.password = txtPassword.Text;
            ServerResponse serverResponse = await API.Services.Account.Create(account);
            
            if (serverResponse.success)
            {
                MessageBox.Show(serverResponse.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm.instance.SetUsernameAndPassword(txtUsername.Text, txtPassword.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show(serverResponse.message, Defines.WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
