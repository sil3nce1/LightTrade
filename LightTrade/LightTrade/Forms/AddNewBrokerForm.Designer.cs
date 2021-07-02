
namespace LightTrade.Forms
{
    partial class AddNewBrokerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbBroker = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddBrokerAccount = new MaterialSkin.Controls.MaterialButton();
            this.txtSecretKey = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 117);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(103, 105);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(340, 50);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(22, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(103, 161);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 50);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(47, 233);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Broker:";
            // 
            // cbBroker
            // 
            this.cbBroker.AutoResize = false;
            this.cbBroker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbBroker.Depth = 0;
            this.cbBroker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBroker.DropDownHeight = 174;
            this.cbBroker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBroker.DropDownWidth = 121;
            this.cbBroker.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBroker.FormattingEnabled = true;
            this.cbBroker.IntegralHeight = false;
            this.cbBroker.ItemHeight = 43;
            this.cbBroker.Items.AddRange(new object[] {
            "IQOption",
            "Ebinex",
            "XTB"});
            this.cbBroker.Location = new System.Drawing.Point(103, 217);
            this.cbBroker.MaxDropDownItems = 4;
            this.cbBroker.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBroker.Name = "cbBroker";
            this.cbBroker.Size = new System.Drawing.Size(340, 49);
            this.cbBroker.StartIndex = 0;
            this.cbBroker.TabIndex = 12;
            // 
            // btnAddBrokerAccount
            // 
            this.btnAddBrokerAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBrokerAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddBrokerAccount.Depth = 0;
            this.btnAddBrokerAccount.HighEmphasis = true;
            this.btnAddBrokerAccount.Icon = null;
            this.btnAddBrokerAccount.Location = new System.Drawing.Point(228, 335);
            this.btnAddBrokerAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBrokerAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBrokerAccount.Name = "btnAddBrokerAccount";
            this.btnAddBrokerAccount.Size = new System.Drawing.Size(64, 36);
            this.btnAddBrokerAccount.TabIndex = 13;
            this.btnAddBrokerAccount.Text = "ADD";
            this.btnAddBrokerAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddBrokerAccount.UseAccentColor = false;
            this.btnAddBrokerAccount.UseVisualStyleBackColor = true;
            this.btnAddBrokerAccount.Click += new System.EventHandler(this.btnAddBrokerAccount_Click);
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretKey.Depth = 0;
            this.txtSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecretKey.LeadingIcon = null;
            this.txtSecretKey.Location = new System.Drawing.Point(103, 272);
            this.txtSecretKey.MaxLength = 50;
            this.txtSecretKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSecretKey.Multiline = false;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(340, 50);
            this.txtSecretKey.TabIndex = 14;
            this.txtSecretKey.Text = "";
            this.txtSecretKey.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 286);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Secret Key:";
            // 
            // AddNewBrokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 380);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.btnAddBrokerAccount);
            this.Controls.Add(this.cbBroker);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtUsername);
            this.Name = "AddNewBrokerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightTrade - Add Broker Account";
            this.Load += new System.EventHandler(this.AddNewBrokerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbBroker;
        private MaterialSkin.Controls.MaterialButton btnAddBrokerAccount;
        private MaterialSkin.Controls.MaterialTextBox txtSecretKey;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}