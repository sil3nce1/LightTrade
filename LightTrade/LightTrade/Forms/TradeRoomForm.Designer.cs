
namespace LightTrade.Forms
{
    partial class TradeRoomForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeRoomForm));
            this.tabSideMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblConnectedUsers = new MaterialSkin.Controls.MaterialLabel();
            this.lblTraderUsername = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRoomId = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGridOrders = new System.Windows.Forms.DataGridView();
            this.InstrumentKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivePair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbBalance = new MaterialSkin.Controls.MaterialComboBox();
            this.sideMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabSideMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSideMenu
            // 
            this.tabSideMenu.Controls.Add(this.tabPage1);
            this.tabSideMenu.Controls.Add(this.tabPage2);
            this.tabSideMenu.Controls.Add(this.tabPage3);
            this.tabSideMenu.Depth = 0;
            this.tabSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSideMenu.ImageList = this.sideMenuImageList;
            this.tabSideMenu.Location = new System.Drawing.Point(3, 64);
            this.tabSideMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSideMenu.Multiline = true;
            this.tabSideMenu.Name = "tabSideMenu";
            this.tabSideMenu.SelectedIndex = 0;
            this.tabSideMenu.Size = new System.Drawing.Size(794, 383);
            this.tabSideMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "open-door.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblConnectedUsers);
            this.materialCard1.Controls.Add(this.lblTraderUsername);
            this.materialCard1.Controls.Add(this.btnConnect);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lblRoomId);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(762, 148);
            this.materialCard1.TabIndex = 0;
            // 
            // lblConnectedUsers
            // 
            this.lblConnectedUsers.AutoSize = true;
            this.lblConnectedUsers.Depth = 0;
            this.lblConnectedUsers.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConnectedUsers.Location = new System.Drawing.Point(17, 106);
            this.lblConnectedUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConnectedUsers.Name = "lblConnectedUsers";
            this.lblConnectedUsers.Size = new System.Drawing.Size(123, 19);
            this.lblConnectedUsers.TabIndex = 4;
            this.lblConnectedUsers.Text = "Connected Users:";
            // 
            // lblTraderUsername
            // 
            this.lblTraderUsername.AutoSize = true;
            this.lblTraderUsername.Depth = 0;
            this.lblTraderUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTraderUsername.Location = new System.Drawing.Point(17, 76);
            this.lblTraderUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTraderUsername.Name = "lblTraderUsername";
            this.lblTraderUsername.Size = new System.Drawing.Size(126, 19);
            this.lblTraderUsername.TabIndex = 3;
            this.lblTraderUsername.Text = "Trader Username:";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.Enabled = false;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(543, 96);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 36);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Waiting for";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Status:";
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Depth = 0;
            this.lblRoomId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomId.Location = new System.Drawing.Point(17, 14);
            this.lblRoomId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(66, 19);
            this.lblRoomId.TabIndex = 1;
            this.lblRoomId.Text = "Room ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dtGridOrders);
            this.tabPage2.ImageKey = "credit-card.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            // 
            // dtGridOrders
            // 
            this.dtGridOrders.AllowUserToAddRows = false;
            this.dtGridOrders.AllowUserToDeleteRows = false;
            this.dtGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstrumentKey,
            this.ActivePair,
            this.Amount,
            this.Balance,
            this.TimeFrame,
            this.Type});
            this.dtGridOrders.Location = new System.Drawing.Point(6, 6);
            this.dtGridOrders.Name = "dtGridOrders";
            this.dtGridOrders.ReadOnly = true;
            this.dtGridOrders.Size = new System.Drawing.Size(774, 344);
            this.dtGridOrders.TabIndex = 0;
            // 
            // InstrumentKey
            // 
            this.InstrumentKey.HeaderText = "InstrumentKey";
            this.InstrumentKey.Name = "InstrumentKey";
            this.InstrumentKey.ReadOnly = true;
            this.InstrumentKey.Visible = false;
            // 
            // ActivePair
            // 
            this.ActivePair.HeaderText = "ActivePair";
            this.ActivePair.Name = "ActivePair";
            this.ActivePair.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // TimeFrame
            // 
            this.TimeFrame.HeaderText = "TimeFrame";
            this.TimeFrame.Name = "TimeFrame";
            this.TimeFrame.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialCard2);
            this.tabPage3.ImageKey = "setting.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txtAmount);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.cbBalance);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(758, 156);
            this.materialCard2.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(215, 66);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(336, 50);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "1";
            this.txtAmount.TrailingIcon = null;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(147, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Amount:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(147, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Balance:";
            // 
            // cbBalance
            // 
            this.cbBalance.AutoResize = false;
            this.cbBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbBalance.Depth = 0;
            this.cbBalance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBalance.DropDownHeight = 174;
            this.cbBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBalance.DropDownWidth = 121;
            this.cbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBalance.FormattingEnabled = true;
            this.cbBalance.IntegralHeight = false;
            this.cbBalance.ItemHeight = 43;
            this.cbBalance.Items.AddRange(new object[] {
            "Real",
            "Training"});
            this.cbBalance.Location = new System.Drawing.Point(215, 11);
            this.cbBalance.MaxDropDownItems = 4;
            this.cbBalance.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBalance.Name = "cbBalance";
            this.cbBalance.Size = new System.Drawing.Size(336, 49);
            this.cbBalance.StartIndex = 0;
            this.cbBalance.TabIndex = 0;
            // 
            // sideMenuImageList
            // 
            this.sideMenuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sideMenuImageList.ImageStream")));
            this.sideMenuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sideMenuImageList.Images.SetKeyName(0, "credit-card.png");
            this.sideMenuImageList.Images.SetKeyName(1, "open-door.png");
            this.sideMenuImageList.Images.SetKeyName(2, "setting.png");
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(192, 206);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TradeRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSideMenu);
            this.DrawerTabControl = this.tabSideMenu;
            this.Name = "TradeRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade Room";
            this.Load += new System.EventHandler(this.TradeRoomForm_Load);
            this.tabSideMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabSideMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList sideMenuImageList;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblRoomId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private MaterialSkin.Controls.MaterialLabel lblTraderUsername;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbBalance;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dtGridOrders;
        private MaterialSkin.Controls.MaterialLabel lblConnectedUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstrumentKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivePair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}