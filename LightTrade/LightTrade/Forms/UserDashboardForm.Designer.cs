
namespace LightTrade.Forms
{
    partial class UserDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboardForm));
            this.tabSideMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPlans = new System.Windows.Forms.Panel();
            this.btnPlanPageFoward = new MaterialSkin.Controls.MaterialButton();
            this.lblPlanPage = new MaterialSkin.Controls.MaterialLabel();
            this.btnPlanPageBack = new MaterialSkin.Controls.MaterialButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panelBrokers = new System.Windows.Forms.Panel();
            this.lblBrokerAccount = new MaterialSkin.Controls.MaterialLabel();
            this.btnSelectBroker = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbBrokerName = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnJoinPrivateRoom = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGridTradeRooms = new System.Windows.Forms.DataGridView();
            this.tradeRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traderUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSelectTradeRoom = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbTradeRoomBrokerName = new MaterialSkin.Controls.MaterialComboBox();
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAccountUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblAccountEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblAccountPlanRemainingTime = new MaterialSkin.Controls.MaterialLabel();
            this.lblAccountPlanName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGoToPlans = new MaterialSkin.Controls.MaterialButton();
            this.tabSideMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelPlans.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelBrokers.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTradeRooms)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSideMenu
            // 
            this.tabSideMenu.Controls.Add(this.tabPage1);
            this.tabSideMenu.Controls.Add(this.tabPage2);
            this.tabSideMenu.Controls.Add(this.tabPage4);
            this.tabSideMenu.Controls.Add(this.tabPage3);
            this.tabSideMenu.Depth = 0;
            this.tabSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSideMenu.ImageList = this.tabControlImageList;
            this.tabSideMenu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabSideMenu.Location = new System.Drawing.Point(3, 64);
            this.tabSideMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSideMenu.Multiline = true;
            this.tabSideMenu.Name = "tabSideMenu";
            this.tabSideMenu.SelectedIndex = 0;
            this.tabSideMenu.Size = new System.Drawing.Size(794, 407);
            this.tabSideMenu.TabIndex = 0;
            this.tabSideMenu.SelectedIndexChanged += new System.EventHandler(this.tabSideMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panelContainer);
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.materialCard3);
            this.panelContainer.Controls.Add(this.materialCard2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(3, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(780, 374);
            this.panelContainer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panelPlans);
            this.tabPage2.ImageKey = "credit-card.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plans";
            // 
            // panelPlans
            // 
            this.panelPlans.Controls.Add(this.btnPlanPageFoward);
            this.panelPlans.Controls.Add(this.lblPlanPage);
            this.panelPlans.Controls.Add(this.btnPlanPageBack);
            this.panelPlans.Location = new System.Drawing.Point(6, 6);
            this.panelPlans.Name = "panelPlans";
            this.panelPlans.Size = new System.Drawing.Size(774, 368);
            this.panelPlans.TabIndex = 0;
            // 
            // btnPlanPageFoward
            // 
            this.btnPlanPageFoward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlanPageFoward.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlanPageFoward.Depth = 0;
            this.btnPlanPageFoward.HighEmphasis = true;
            this.btnPlanPageFoward.Icon = null;
            this.btnPlanPageFoward.Location = new System.Drawing.Point(685, 324);
            this.btnPlanPageFoward.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlanPageFoward.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlanPageFoward.Name = "btnPlanPageFoward";
            this.btnPlanPageFoward.Size = new System.Drawing.Size(64, 36);
            this.btnPlanPageFoward.TabIndex = 8;
            this.btnPlanPageFoward.Text = ">";
            this.btnPlanPageFoward.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlanPageFoward.UseAccentColor = false;
            this.btnPlanPageFoward.UseVisualStyleBackColor = true;
            this.btnPlanPageFoward.Click += new System.EventHandler(this.btnPlanPageFoward_Click);
            // 
            // lblPlanPage
            // 
            this.lblPlanPage.AutoSize = true;
            this.lblPlanPage.Depth = 0;
            this.lblPlanPage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlanPage.Location = new System.Drawing.Point(668, 332);
            this.lblPlanPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlanPage.Name = "lblPlanPage";
            this.lblPlanPage.Size = new System.Drawing.Size(10, 19);
            this.lblPlanPage.TabIndex = 7;
            this.lblPlanPage.Text = "1";
            // 
            // btnPlanPageBack
            // 
            this.btnPlanPageBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlanPageBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlanPageBack.Depth = 0;
            this.btnPlanPageBack.HighEmphasis = true;
            this.btnPlanPageBack.Icon = null;
            this.btnPlanPageBack.Location = new System.Drawing.Point(597, 324);
            this.btnPlanPageBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlanPageBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlanPageBack.Name = "btnPlanPageBack";
            this.btnPlanPageBack.Size = new System.Drawing.Size(64, 36);
            this.btnPlanPageBack.TabIndex = 6;
            this.btnPlanPageBack.Text = "<";
            this.btnPlanPageBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlanPageBack.UseAccentColor = false;
            this.btnPlanPageBack.UseVisualStyleBackColor = true;
            this.btnPlanPageBack.Click += new System.EventHandler(this.btnPlanPageBack_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialButton1);
            this.tabPage4.Controls.Add(this.panelBrokers);
            this.tabPage4.Controls.Add(this.btnSelectBroker);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.cbBrokerName);
            this.tabPage4.ImageKey = "broker.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "My Brokers";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(672, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(86, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Add new";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panelBrokers
            // 
            this.panelBrokers.Controls.Add(this.lblBrokerAccount);
            this.panelBrokers.Location = new System.Drawing.Point(6, 138);
            this.panelBrokers.Name = "panelBrokers";
            this.panelBrokers.Size = new System.Drawing.Size(774, 237);
            this.panelBrokers.TabIndex = 7;
            // 
            // lblBrokerAccount
            // 
            this.lblBrokerAccount.AutoSize = true;
            this.lblBrokerAccount.Depth = 0;
            this.lblBrokerAccount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBrokerAccount.Location = new System.Drawing.Point(22, 8);
            this.lblBrokerAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBrokerAccount.Name = "lblBrokerAccount";
            this.lblBrokerAccount.Size = new System.Drawing.Size(157, 19);
            this.lblBrokerAccount.TabIndex = 5;
            this.lblBrokerAccount.Text = "Your Broker Accounts:";
            // 
            // btnSelectBroker
            // 
            this.btnSelectBroker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectBroker.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectBroker.Depth = 0;
            this.btnSelectBroker.HighEmphasis = true;
            this.btnSelectBroker.Icon = null;
            this.btnSelectBroker.Location = new System.Drawing.Point(383, 93);
            this.btnSelectBroker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectBroker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectBroker.Name = "btnSelectBroker";
            this.btnSelectBroker.Size = new System.Drawing.Size(74, 36);
            this.btnSelectBroker.TabIndex = 3;
            this.btnSelectBroker.Text = "Select";
            this.btnSelectBroker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectBroker.UseAccentColor = false;
            this.btnSelectBroker.UseVisualStyleBackColor = true;
            this.btnSelectBroker.Click += new System.EventHandler(this.btnSelectBroker_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(251, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(134, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Select Your Broker:";
            // 
            // cbBrokerName
            // 
            this.cbBrokerName.AutoResize = false;
            this.cbBrokerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbBrokerName.Depth = 0;
            this.cbBrokerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBrokerName.DropDownHeight = 174;
            this.cbBrokerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrokerName.DropDownWidth = 121;
            this.cbBrokerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBrokerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBrokerName.FormattingEnabled = true;
            this.cbBrokerName.IntegralHeight = false;
            this.cbBrokerName.ItemHeight = 43;
            this.cbBrokerName.Items.AddRange(new object[] {
            "IQOption",
            "Ebinex",
            "XTB"});
            this.cbBrokerName.Location = new System.Drawing.Point(245, 35);
            this.cbBrokerName.MaxDropDownItems = 4;
            this.cbBrokerName.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBrokerName.Name = "cbBrokerName";
            this.cbBrokerName.Size = new System.Drawing.Size(352, 49);
            this.cbBrokerName.StartIndex = 0;
            this.cbBrokerName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnJoinPrivateRoom);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.btnSelectTradeRoom);
            this.tabPage3.Controls.Add(this.materialLabel5);
            this.tabPage3.Controls.Add(this.cbTradeRoomBrokerName);
            this.tabPage3.ImageKey = "open-door.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trade Rooms";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnJoinPrivateRoom
            // 
            this.btnJoinPrivateRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJoinPrivateRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnJoinPrivateRoom.Depth = 0;
            this.btnJoinPrivateRoom.HighEmphasis = true;
            this.btnJoinPrivateRoom.Icon = null;
            this.btnJoinPrivateRoom.Location = new System.Drawing.Point(645, 93);
            this.btnJoinPrivateRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnJoinPrivateRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJoinPrivateRoom.Name = "btnJoinPrivateRoom";
            this.btnJoinPrivateRoom.Size = new System.Drawing.Size(126, 36);
            this.btnJoinPrivateRoom.TabIndex = 8;
            this.btnJoinPrivateRoom.Text = "Private Room";
            this.btnJoinPrivateRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnJoinPrivateRoom.UseAccentColor = false;
            this.btnJoinPrivateRoom.UseVisualStyleBackColor = true;
            this.btnJoinPrivateRoom.Click += new System.EventHandler(this.btnJoinPrivateRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtGridTradeRooms);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 239);
            this.panel1.TabIndex = 7;
            // 
            // dtGridTradeRooms
            // 
            this.dtGridTradeRooms.AllowUserToAddRows = false;
            this.dtGridTradeRooms.AllowUserToDeleteRows = false;
            this.dtGridTradeRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTradeRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeRoomId,
            this.traderUsername,
            this.brokerName});
            this.dtGridTradeRooms.Location = new System.Drawing.Point(3, 38);
            this.dtGridTradeRooms.Name = "dtGridTradeRooms";
            this.dtGridTradeRooms.ReadOnly = true;
            this.dtGridTradeRooms.Size = new System.Drawing.Size(756, 198);
            this.dtGridTradeRooms.TabIndex = 7;
            this.dtGridTradeRooms.SelectionChanged += new System.EventHandler(this.dtGridTradeRooms_SelectionChanged);
            this.dtGridTradeRooms.DoubleClick += new System.EventHandler(this.dtGridTradeRooms_DoubleClick);
            // 
            // tradeRoomId
            // 
            this.tradeRoomId.HeaderText = "Room ID";
            this.tradeRoomId.Name = "tradeRoomId";
            this.tradeRoomId.ReadOnly = true;
            this.tradeRoomId.Width = 250;
            // 
            // traderUsername
            // 
            this.traderUsername.HeaderText = "Trader Username";
            this.traderUsername.Name = "traderUsername";
            this.traderUsername.ReadOnly = true;
            this.traderUsername.Width = 180;
            // 
            // brokerName
            // 
            this.brokerName.HeaderText = "Broker Name";
            this.brokerName.Name = "brokerName";
            this.brokerName.ReadOnly = true;
            this.brokerName.Width = 200;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(7, 16);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Rooms:";
            // 
            // btnSelectTradeRoom
            // 
            this.btnSelectTradeRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectTradeRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectTradeRoom.Depth = 0;
            this.btnSelectTradeRoom.HighEmphasis = true;
            this.btnSelectTradeRoom.Icon = null;
            this.btnSelectTradeRoom.Location = new System.Drawing.Point(359, 96);
            this.btnSelectTradeRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectTradeRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectTradeRoom.Name = "btnSelectTradeRoom";
            this.btnSelectTradeRoom.Size = new System.Drawing.Size(74, 36);
            this.btnSelectTradeRoom.TabIndex = 6;
            this.btnSelectTradeRoom.Text = "Select";
            this.btnSelectTradeRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectTradeRoom.UseAccentColor = false;
            this.btnSelectTradeRoom.UseVisualStyleBackColor = true;
            this.btnSelectTradeRoom.Click += new System.EventHandler(this.btnSelectTradeRoom_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(222, 19);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(97, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Select Broker:";
            // 
            // cbTradeRoomBrokerName
            // 
            this.cbTradeRoomBrokerName.AutoResize = false;
            this.cbTradeRoomBrokerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTradeRoomBrokerName.Depth = 0;
            this.cbTradeRoomBrokerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTradeRoomBrokerName.DropDownHeight = 174;
            this.cbTradeRoomBrokerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTradeRoomBrokerName.DropDownWidth = 121;
            this.cbTradeRoomBrokerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTradeRoomBrokerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTradeRoomBrokerName.FormattingEnabled = true;
            this.cbTradeRoomBrokerName.IntegralHeight = false;
            this.cbTradeRoomBrokerName.ItemHeight = 43;
            this.cbTradeRoomBrokerName.Items.AddRange(new object[] {
            "IQOption",
            "Ebinex",
            "XTB"});
            this.cbTradeRoomBrokerName.Location = new System.Drawing.Point(221, 41);
            this.cbTradeRoomBrokerName.MaxDropDownItems = 4;
            this.cbTradeRoomBrokerName.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTradeRoomBrokerName.Name = "cbTradeRoomBrokerName";
            this.cbTradeRoomBrokerName.Size = new System.Drawing.Size(352, 49);
            this.cbTradeRoomBrokerName.StartIndex = 0;
            this.cbTradeRoomBrokerName.TabIndex = 4;
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlImageList.ImageStream")));
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlImageList.Images.SetKeyName(0, "home.png");
            this.tabControlImageList.Images.SetKeyName(1, "credit-card.png");
            this.tabControlImageList.Images.SetKeyName(2, "open-door.png");
            this.tabControlImageList.Images.SetKeyName(3, "broker.png");
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblAccountEmail);
            this.materialCard2.Controls.Add(this.lblAccountUsername);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(8, 7);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(765, 165);
            this.materialCard2.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 19);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Account:";
            // 
            // lblAccountUsername
            // 
            this.lblAccountUsername.AutoSize = true;
            this.lblAccountUsername.Depth = 0;
            this.lblAccountUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountUsername.Location = new System.Drawing.Point(17, 48);
            this.lblAccountUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountUsername.Name = "lblAccountUsername";
            this.lblAccountUsername.Size = new System.Drawing.Size(76, 19);
            this.lblAccountUsername.TabIndex = 3;
            this.lblAccountUsername.Text = "Username:";
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Depth = 0;
            this.lblAccountEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountEmail.Location = new System.Drawing.Point(17, 81);
            this.lblAccountEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(45, 19);
            this.lblAccountEmail.TabIndex = 4;
            this.lblAccountEmail.Text = "Email:";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnGoToPlans);
            this.materialCard3.Controls.Add(this.lblAccountPlanRemainingTime);
            this.materialCard3.Controls.Add(this.lblAccountPlanName);
            this.materialCard3.Controls.Add(this.materialLabel10);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(8, 182);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(765, 165);
            this.materialCard3.TabIndex = 2;
            // 
            // lblAccountPlanRemainingTime
            // 
            this.lblAccountPlanRemainingTime.AutoSize = true;
            this.lblAccountPlanRemainingTime.Depth = 0;
            this.lblAccountPlanRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountPlanRemainingTime.Location = new System.Drawing.Point(17, 81);
            this.lblAccountPlanRemainingTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountPlanRemainingTime.Name = "lblAccountPlanRemainingTime";
            this.lblAccountPlanRemainingTime.Size = new System.Drawing.Size(121, 19);
            this.lblAccountPlanRemainingTime.TabIndex = 4;
            this.lblAccountPlanRemainingTime.Text = "Remaining Time:";
            this.lblAccountPlanRemainingTime.Visible = false;
            // 
            // lblAccountPlanName
            // 
            this.lblAccountPlanName.AutoSize = true;
            this.lblAccountPlanName.Depth = 0;
            this.lblAccountPlanName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountPlanName.Location = new System.Drawing.Point(17, 48);
            this.lblAccountPlanName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountPlanName.Name = "lblAccountPlanName";
            this.lblAccountPlanName.Size = new System.Drawing.Size(47, 19);
            this.lblAccountPlanName.TabIndex = 3;
            this.lblAccountPlanName.Text = "Name:";
            this.lblAccountPlanName.Visible = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(37, 19);
            this.materialLabel10.TabIndex = 2;
            this.materialLabel10.Text = "Plan:";
            // 
            // btnGoToPlans
            // 
            this.btnGoToPlans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToPlans.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoToPlans.Depth = 0;
            this.btnGoToPlans.HighEmphasis = true;
            this.btnGoToPlans.Icon = null;
            this.btnGoToPlans.Location = new System.Drawing.Point(311, 64);
            this.btnGoToPlans.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToPlans.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToPlans.Name = "btnGoToPlans";
            this.btnGoToPlans.Size = new System.Drawing.Size(104, 36);
            this.btnGoToPlans.TabIndex = 1;
            this.btnGoToPlans.Text = "Buy a plan";
            this.btnGoToPlans.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoToPlans.UseAccentColor = false;
            this.btnGoToPlans.UseVisualStyleBackColor = true;
            this.btnGoToPlans.Visible = false;
            this.btnGoToPlans.Click += new System.EventHandler(this.btnGoToPlans_Click);
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.tabSideMenu);
            this.DrawerTabControl = this.tabSideMenu;
            this.Name = "UserDashboardForm";
            this.Text = "LightTrade - Dashboard";
            this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            this.tabSideMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelPlans.ResumeLayout(false);
            this.panelPlans.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelBrokers.ResumeLayout(false);
            this.panelBrokers.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTradeRooms)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabSideMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList tabControlImageList;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialComboBox cbBrokerName;
        private MaterialSkin.Controls.MaterialButton btnSelectBroker;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panelBrokers;
        private MaterialSkin.Controls.MaterialLabel lblBrokerAccount;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialButton btnSelectTradeRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cbTradeRoomBrokerName;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnJoinPrivateRoom;
        private System.Windows.Forms.DataGridView dtGridTradeRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn traderUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerName;
        private System.Windows.Forms.Panel panelPlans;
        private MaterialSkin.Controls.MaterialButton btnPlanPageFoward;
        private MaterialSkin.Controls.MaterialLabel lblPlanPage;
        private MaterialSkin.Controls.MaterialButton btnPlanPageBack;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblAccountEmail;
        private MaterialSkin.Controls.MaterialLabel lblAccountUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblAccountPlanRemainingTime;
        private MaterialSkin.Controls.MaterialLabel lblAccountPlanName;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btnGoToPlans;
    }
}