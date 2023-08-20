using System.Globalization;

namespace BilliardManagamentSystem
{
    partial class fTableManager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            btnExit = new Button();
            pnlMenu = new Panel();
            ibtnMenu = new FontAwesome.Sharp.IconButton();
            ibtnShowTable = new FontAwesome.Sharp.IconButton();
            pnlDateInfo = new Panel();
            pnlDisName = new Panel();
            lbHello = new Label();
            lbStaffName = new Label();
            lbDateMonthYear = new Label();
            lbDay = new Label();
            lbTime = new Label();
            pnlTableAndMenu = new FlowLayoutPanel();
            pnlSettingMenu = new FlowLayoutPanel();
            panel2 = new Panel();
            btnSetting = new PictureBox();
            ibtnAdmin = new FontAwesome.Sharp.IconButton();
            ibtnStaffProfile = new FontAwesome.Sharp.IconButton();
            ibtnLogOut = new FontAwesome.Sharp.IconButton();
            timer = new System.Windows.Forms.Timer(components);
            pnlFoodBill = new Panel();
            lbTableNameOnBill = new Label();
            pnlBackPicBill = new Panel();
            pnlAddFood = new Panel();
            btnDeleteFood = new Button();
            btnUpdateFood = new Button();
            label5 = new Label();
            lbSelectedPrice = new Label();
            label3 = new Label();
            label1 = new Label();
            lbSelectedFood = new Label();
            nmFoodAmount = new NumericUpDown();
            btnAddFood = new Button();
            label4 = new Label();
            lbTimePlay = new Label();
            lbTimeCheckIn = new Label();
            lbTGChoi = new Label();
            lbTGVao = new Label();
            lbLine = new Label();
            lbTienBan = new Label();
            lbTablePrice = new Label();
            lbTongTien1 = new Label();
            lstVwFoodBill = new ListView();
            column1 = new ColumnHeader();
            column2 = new ColumnHeader();
            column3 = new ColumnHeader();
            column4 = new ColumnHeader();
            lbTotalPrice = new Label();
            btnStarting = new Button();
            lbLine3 = new Label();
            lbLine4 = new Label();
            pnlChangeTableAndCheckOut = new Panel();
            pnlBackground3 = new Panel();
            btnCheckOut = new Button();
            nmDiscount = new NumericUpDown();
            btnFoodAmount = new Button();
            cbTableChangeList = new ComboBox();
            btnChangeTable = new Button();
            flpnlTableList = new FlowLayoutPanel();
            timerGetPlayTime = new System.Windows.Forms.Timer(components);
            timerSetting = new System.Windows.Forms.Timer(components);
            timerFoodMenu = new System.Windows.Forms.Timer(components);
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            pnlMenu.SuspendLayout();
            pnlDateInfo.SuspendLayout();
            pnlDisName.SuspendLayout();
            pnlSettingMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSetting).BeginInit();
            pnlFoodBill.SuspendLayout();
            pnlBackPicBill.SuspendLayout();
            pnlAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodAmount).BeginInit();
            pnlChangeTableAndCheckOut.SuspendLayout();
            pnlBackground3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1833, 12);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(62, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_MouseLeave;
            btnExit.MouseMove += btnExit_MouseMove;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(47, 47, 47);
            pnlMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pnlMenu.Controls.Add(ibtnMenu);
            pnlMenu.Controls.Add(ibtnShowTable);
            pnlMenu.Controls.Add(pnlDateInfo);
            pnlMenu.Controls.Add(pnlTableAndMenu);
            pnlMenu.Controls.Add(pnlSettingMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(341, 1102);
            pnlMenu.TabIndex = 6;
            // 
            // ibtnMenu
            // 
            ibtnMenu.Cursor = Cursors.Hand;
            ibtnMenu.FlatAppearance.BorderSize = 0;
            ibtnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 179, 179);
            ibtnMenu.FlatStyle = FlatStyle.Flat;
            ibtnMenu.Font = new Font("Cambria", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnMenu.ForeColor = Color.FromArgb(235, 245, 238);
            ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            ibtnMenu.IconColor = Color.FromArgb(235, 245, 238);
            ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnMenu.IconSize = 70;
            ibtnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnMenu.Location = new Point(6, 508);
            ibtnMenu.Name = "ibtnMenu";
            ibtnMenu.Padding = new Padding(20, 0, 0, 0);
            ibtnMenu.Size = new Size(327, 106);
            ibtnMenu.TabIndex = 1;
            ibtnMenu.Text = "   Menu";
            ibtnMenu.TextAlign = ContentAlignment.MiddleRight;
            ibtnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnMenu.UseVisualStyleBackColor = true;
            ibtnMenu.Click += btnMenu_Click;
            // 
            // ibtnShowTable
            // 
            ibtnShowTable.Cursor = Cursors.Hand;
            ibtnShowTable.FlatAppearance.BorderSize = 0;
            ibtnShowTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 179, 179);
            ibtnShowTable.FlatStyle = FlatStyle.Flat;
            ibtnShowTable.Font = new Font("Cambria", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnShowTable.ForeColor = Color.FromArgb(235, 245, 238);
            ibtnShowTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            ibtnShowTable.IconColor = Color.FromArgb(235, 245, 238);
            ibtnShowTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnShowTable.IconSize = 70;
            ibtnShowTable.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnShowTable.Location = new Point(6, 393);
            ibtnShowTable.Name = "ibtnShowTable";
            ibtnShowTable.Padding = new Padding(20, 0, 0, 0);
            ibtnShowTable.Size = new Size(327, 106);
            ibtnShowTable.TabIndex = 0;
            ibtnShowTable.Text = "   Bàn";
            ibtnShowTable.TextAlign = ContentAlignment.MiddleRight;
            ibtnShowTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnShowTable.UseVisualStyleBackColor = true;
            ibtnShowTable.Click += btnShowTableList_Click;
            // 
            // pnlDateInfo
            // 
            pnlDateInfo.BackColor = Color.Transparent;
            pnlDateInfo.Controls.Add(pnlDisName);
            pnlDateInfo.Controls.Add(lbDateMonthYear);
            pnlDateInfo.Controls.Add(lbDay);
            pnlDateInfo.Controls.Add(lbTime);
            pnlDateInfo.Location = new Point(0, 885);
            pnlDateInfo.Name = "pnlDateInfo";
            pnlDateInfo.Size = new Size(338, 189);
            pnlDateInfo.TabIndex = 9;
            // 
            // pnlDisName
            // 
            pnlDisName.BackColor = Color.Transparent;
            pnlDisName.Controls.Add(lbHello);
            pnlDisName.Controls.Add(lbStaffName);
            pnlDisName.Location = new Point(3, 20);
            pnlDisName.Name = "pnlDisName";
            pnlDisName.Size = new Size(330, 79);
            pnlDisName.TabIndex = 7;
            // 
            // lbHello
            // 
            lbHello.AutoSize = true;
            lbHello.BackColor = Color.Transparent;
            lbHello.Font = new Font("Colonna MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbHello.ForeColor = Color.White;
            lbHello.Location = new Point(19, 13);
            lbHello.Name = "lbHello";
            lbHello.Size = new Size(97, 21);
            lbHello.TabIndex = 7;
            lbHello.Text = "Xin chào!";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.BackColor = Color.Transparent;
            lbStaffName.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbStaffName.ForeColor = Color.White;
            lbStaffName.Location = new Point(19, 38);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(0, 36);
            lbStaffName.TabIndex = 8;
            // 
            // lbDateMonthYear
            // 
            lbDateMonthYear.BackColor = Color.Transparent;
            lbDateMonthYear.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDateMonthYear.ForeColor = Color.White;
            lbDateMonthYear.Location = new Point(22, 134);
            lbDateMonthYear.Name = "lbDateMonthYear";
            lbDateMonthYear.Size = new Size(176, 37);
            lbDateMonthYear.TabIndex = 9;
            lbDateMonthYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.BackColor = Color.Transparent;
            lbDay.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDay.ForeColor = Color.White;
            lbDay.Location = new Point(137, 105);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(0, 23);
            lbDay.TabIndex = 8;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.BackColor = Color.Transparent;
            lbTime.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime.ForeColor = Color.White;
            lbTime.Location = new Point(22, 102);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(0, 27);
            lbTime.TabIndex = 7;
            // 
            // pnlTableAndMenu
            // 
            pnlTableAndMenu.AutoScroll = true;
            pnlTableAndMenu.BackColor = Color.Transparent;
            pnlTableAndMenu.Location = new Point(23, 638);
            pnlTableAndMenu.MaximumSize = new Size(310, 260);
            pnlTableAndMenu.MinimumSize = new Size(310, 0);
            pnlTableAndMenu.Name = "pnlTableAndMenu";
            pnlTableAndMenu.Size = new Size(310, 0);
            pnlTableAndMenu.TabIndex = 14;
            // 
            // pnlSettingMenu
            // 
            pnlSettingMenu.BackColor = Color.Transparent;
            pnlSettingMenu.Controls.Add(panel2);
            pnlSettingMenu.Controls.Add(ibtnAdmin);
            pnlSettingMenu.Controls.Add(ibtnStaffProfile);
            pnlSettingMenu.Controls.Add(ibtnLogOut);
            pnlSettingMenu.Location = new Point(3, 58);
            pnlSettingMenu.MaximumSize = new Size(336, 333);
            pnlSettingMenu.MinimumSize = new Size(336, 76);
            pnlSettingMenu.Name = "pnlSettingMenu";
            pnlSettingMenu.Size = new Size(336, 76);
            pnlSettingMenu.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSetting);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 77);
            panel2.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Image = Properties.Resources.gear;
            btnSetting.Location = new Point(31, 5);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(60, 60);
            btnSetting.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSetting.TabIndex = 2;
            btnSetting.TabStop = false;
            btnSetting.Click += btnSetting_Click;
            btnSetting.MouseLeave += btnSetting_MouseLeave;
            btnSetting.MouseMove += btnSetting_MouseMove;
            // 
            // ibtnAdmin
            // 
            ibtnAdmin.Cursor = Cursors.Hand;
            ibtnAdmin.FlatAppearance.BorderSize = 0;
            ibtnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 111, 111);
            ibtnAdmin.FlatStyle = FlatStyle.Flat;
            ibtnAdmin.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnAdmin.ForeColor = Color.FromArgb(235, 245, 238);
            ibtnAdmin.IconChar = FontAwesome.Sharp.IconChar.Circle;
            ibtnAdmin.IconColor = Color.FromArgb(235, 245, 238);
            ibtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnAdmin.IconSize = 40;
            ibtnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnAdmin.Location = new Point(3, 86);
            ibtnAdmin.Name = "ibtnAdmin";
            ibtnAdmin.Padding = new Padding(40, 0, 0, 0);
            ibtnAdmin.Size = new Size(330, 77);
            ibtnAdmin.TabIndex = 3;
            ibtnAdmin.Text = "    Admin";
            ibtnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            ibtnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnAdmin.UseVisualStyleBackColor = true;
            ibtnAdmin.Click += btnAdmin_Click;
            // 
            // ibtnStaffProfile
            // 
            ibtnStaffProfile.Cursor = Cursors.Hand;
            ibtnStaffProfile.FlatAppearance.BorderSize = 0;
            ibtnStaffProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 111, 111);
            ibtnStaffProfile.FlatStyle = FlatStyle.Flat;
            ibtnStaffProfile.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnStaffProfile.ForeColor = Color.FromArgb(235, 245, 238);
            ibtnStaffProfile.IconChar = FontAwesome.Sharp.IconChar.Circle;
            ibtnStaffProfile.IconColor = Color.FromArgb(235, 245, 238);
            ibtnStaffProfile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnStaffProfile.IconSize = 40;
            ibtnStaffProfile.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnStaffProfile.Location = new Point(3, 169);
            ibtnStaffProfile.Name = "ibtnStaffProfile";
            ibtnStaffProfile.Padding = new Padding(40, 0, 0, 0);
            ibtnStaffProfile.Size = new Size(330, 77);
            ibtnStaffProfile.TabIndex = 4;
            ibtnStaffProfile.Text = "    Thông tin";
            ibtnStaffProfile.TextAlign = ContentAlignment.MiddleLeft;
            ibtnStaffProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnStaffProfile.UseVisualStyleBackColor = true;
            ibtnStaffProfile.Click += btnAccInfo_Click;
            // 
            // ibtnLogOut
            // 
            ibtnLogOut.Cursor = Cursors.Hand;
            ibtnLogOut.FlatAppearance.BorderSize = 0;
            ibtnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 111, 111);
            ibtnLogOut.FlatStyle = FlatStyle.Flat;
            ibtnLogOut.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnLogOut.ForeColor = Color.FromArgb(235, 245, 238);
            ibtnLogOut.IconChar = FontAwesome.Sharp.IconChar.Circle;
            ibtnLogOut.IconColor = Color.FromArgb(235, 245, 238);
            ibtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtnLogOut.IconSize = 40;
            ibtnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnLogOut.Location = new Point(3, 252);
            ibtnLogOut.Name = "ibtnLogOut";
            ibtnLogOut.Padding = new Padding(40, 0, 0, 0);
            ibtnLogOut.Size = new Size(330, 77);
            ibtnLogOut.TabIndex = 5;
            ibtnLogOut.Text = "    Đăng xuất";
            ibtnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            ibtnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnLogOut.UseVisualStyleBackColor = true;
            ibtnLogOut.Click += btnLogOut_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // pnlFoodBill
            // 
            pnlFoodBill.BackColor = Color.FromArgb(47, 47, 47);
            pnlFoodBill.BackgroundImageLayout = ImageLayout.Stretch;
            pnlFoodBill.Controls.Add(lbTableNameOnBill);
            pnlFoodBill.Controls.Add(pnlBackPicBill);
            pnlFoodBill.Location = new Point(1408, 58);
            pnlFoodBill.Name = "pnlFoodBill";
            pnlFoodBill.Size = new Size(500, 884);
            pnlFoodBill.TabIndex = 9;
            // 
            // lbTableNameOnBill
            // 
            lbTableNameOnBill.BackColor = Color.Transparent;
            lbTableNameOnBill.Font = new Font("Colonna MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTableNameOnBill.ForeColor = Color.White;
            lbTableNameOnBill.Location = new Point(18, 9);
            lbTableNameOnBill.Name = "lbTableNameOnBill";
            lbTableNameOnBill.Size = new Size(469, 30);
            lbTableNameOnBill.TabIndex = 29;
            lbTableNameOnBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBackPicBill
            // 
            pnlBackPicBill.BackColor = Color.FromArgb(179, 179, 179);
            pnlBackPicBill.BorderStyle = BorderStyle.FixedSingle;
            pnlBackPicBill.Controls.Add(pnlAddFood);
            pnlBackPicBill.Controls.Add(lbTimePlay);
            pnlBackPicBill.Controls.Add(lbTimeCheckIn);
            pnlBackPicBill.Controls.Add(lbTGChoi);
            pnlBackPicBill.Controls.Add(lbTGVao);
            pnlBackPicBill.Controls.Add(lbLine);
            pnlBackPicBill.Controls.Add(lbTienBan);
            pnlBackPicBill.Controls.Add(lbTablePrice);
            pnlBackPicBill.Controls.Add(lbTongTien1);
            pnlBackPicBill.Controls.Add(lstVwFoodBill);
            pnlBackPicBill.Controls.Add(lbTotalPrice);
            pnlBackPicBill.Controls.Add(btnStarting);
            pnlBackPicBill.Controls.Add(lbLine3);
            pnlBackPicBill.Controls.Add(lbLine4);
            pnlBackPicBill.Location = new Point(18, 49);
            pnlBackPicBill.Name = "pnlBackPicBill";
            pnlBackPicBill.Size = new Size(469, 817);
            pnlBackPicBill.TabIndex = 9;
            // 
            // pnlAddFood
            // 
            pnlAddFood.Controls.Add(btnDeleteFood);
            pnlAddFood.Controls.Add(btnUpdateFood);
            pnlAddFood.Controls.Add(label5);
            pnlAddFood.Controls.Add(lbSelectedPrice);
            pnlAddFood.Controls.Add(label3);
            pnlAddFood.Controls.Add(label1);
            pnlAddFood.Controls.Add(lbSelectedFood);
            pnlAddFood.Controls.Add(nmFoodAmount);
            pnlAddFood.Controls.Add(btnAddFood);
            pnlAddFood.Controls.Add(label4);
            pnlAddFood.Enabled = false;
            pnlAddFood.Location = new Point(0, 275);
            pnlAddFood.Name = "pnlAddFood";
            pnlAddFood.Size = new Size(469, 231);
            pnlAddFood.TabIndex = 29;
            pnlAddFood.Visible = false;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.Transparent;
            btnDeleteFood.Cursor = Cursors.Hand;
            btnDeleteFood.FlatAppearance.BorderSize = 0;
            btnDeleteFood.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeleteFood.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnDeleteFood.FlatStyle = FlatStyle.Flat;
            btnDeleteFood.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnDeleteFood.Location = new Point(6, 181);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(238, 50);
            btnDeleteFood.TabIndex = 34;
            btnDeleteFood.Text = "Xóa món";
            btnDeleteFood.UseVisualStyleBackColor = false;
            btnDeleteFood.Click += btnDeleteFood_Click;
            btnDeleteFood.MouseLeave += btnDeleteFood_MouseLeave;
            btnDeleteFood.MouseMove += btnDeleteFood_MouseMove;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.BackColor = Color.Transparent;
            btnUpdateFood.Cursor = Cursors.Hand;
            btnUpdateFood.FlatAppearance.BorderSize = 0;
            btnUpdateFood.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdateFood.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnUpdateFood.FlatStyle = FlatStyle.Flat;
            btnUpdateFood.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateFood.Location = new Point(243, 181);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(223, 50);
            btnUpdateFood.TabIndex = 33;
            btnUpdateFood.Text = "Cập nhật";
            btnUpdateFood.UseVisualStyleBackColor = false;
            btnUpdateFood.Click += btnUpdateFood_Click;
            btnUpdateFood.MouseLeave += btnUpdateFood_MouseLeave;
            btnUpdateFood.MouseMove += btnUpdateFood_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(74, 74, 74);
            label5.Location = new Point(6, 13);
            label5.Name = "label5";
            label5.Size = new Size(110, 27);
            label5.TabIndex = 31;
            label5.Text = "Tên món:";
            // 
            // lbSelectedPrice
            // 
            lbSelectedPrice.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelectedPrice.ForeColor = Color.FromArgb(74, 74, 74);
            lbSelectedPrice.Location = new Point(179, 83);
            lbSelectedPrice.Name = "lbSelectedPrice";
            lbSelectedPrice.Size = new Size(281, 27);
            lbSelectedPrice.TabIndex = 30;
            lbSelectedPrice.Text = "Giá";
            lbSelectedPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(6, 148);
            label3.Name = "label3";
            label3.Size = new Size(113, 27);
            label3.TabIndex = 29;
            label3.Text = "Số lượng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(6, 83);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 28;
            label1.Text = "Đơn giá:";
            // 
            // lbSelectedFood
            // 
            lbSelectedFood.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSelectedFood.ForeColor = Color.FromArgb(74, 74, 74);
            lbSelectedFood.Location = new Point(179, 13);
            lbSelectedFood.Name = "lbSelectedFood";
            lbSelectedFood.Size = new Size(281, 27);
            lbSelectedFood.TabIndex = 27;
            lbSelectedFood.Text = "Món";
            lbSelectedFood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nmFoodAmount
            // 
            nmFoodAmount.BackColor = Color.FromArgb(179, 179, 179);
            nmFoodAmount.BorderStyle = BorderStyle.None;
            nmFoodAmount.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nmFoodAmount.ForeColor = Color.FromArgb(74, 74, 74);
            nmFoodAmount.Location = new Point(411, 145);
            nmFoodAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmFoodAmount.Name = "nmFoodAmount";
            nmFoodAmount.Size = new Size(49, 30);
            nmFoodAmount.TabIndex = 0;
            nmFoodAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Transparent;
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.Enabled = false;
            btnAddFood.FlatAppearance.BorderSize = 0;
            btnAddFood.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddFood.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnAddFood.Location = new Point(6, 178);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(454, 50);
            btnAddFood.TabIndex = 26;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Visible = false;
            btnAddFood.Click += btnAddFood_Click;
            btnAddFood.MouseLeave += btnAddFood_MouseLeave;
            btnAddFood.MouseMove += btnAddFood_MouseMove;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(0, -18);
            label4.Name = "label4";
            label4.Size = new Size(468, 41);
            label4.TabIndex = 32;
            label4.Text = "--------------------------------------------------";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTimePlay
            // 
            lbTimePlay.BackColor = Color.Transparent;
            lbTimePlay.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimePlay.ForeColor = Color.FromArgb(74, 74, 74);
            lbTimePlay.Location = new Point(320, 595);
            lbTimePlay.Name = "lbTimePlay";
            lbTimePlay.Size = new Size(147, 41);
            lbTimePlay.TabIndex = 23;
            lbTimePlay.Text = "00:00";
            lbTimePlay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTimeCheckIn
            // 
            lbTimeCheckIn.BackColor = Color.Transparent;
            lbTimeCheckIn.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimeCheckIn.ForeColor = Color.FromArgb(74, 74, 74);
            lbTimeCheckIn.Location = new Point(324, 530);
            lbTimeCheckIn.Name = "lbTimeCheckIn";
            lbTimeCheckIn.Size = new Size(147, 41);
            lbTimeCheckIn.TabIndex = 21;
            lbTimeCheckIn.Text = "00:00";
            lbTimeCheckIn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTGChoi
            // 
            lbTGChoi.BackColor = Color.Transparent;
            lbTGChoi.FlatStyle = FlatStyle.Flat;
            lbTGChoi.Font = new Font("Colonna MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTGChoi.ForeColor = Color.FromArgb(74, 74, 74);
            lbTGChoi.Location = new Point(6, 595);
            lbTGChoi.Name = "lbTGChoi";
            lbTGChoi.Size = new Size(219, 41);
            lbTGChoi.TabIndex = 19;
            lbTGChoi.Text = "Thời gian chơi:";
            lbTGChoi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTGVao
            // 
            lbTGVao.BackColor = Color.Transparent;
            lbTGVao.Font = new Font("Colonna MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTGVao.ForeColor = Color.FromArgb(74, 74, 74);
            lbTGVao.Location = new Point(6, 532);
            lbTGVao.Name = "lbTGVao";
            lbTGVao.Size = new Size(217, 41);
            lbTGVao.TabIndex = 17;
            lbTGVao.Text = "Thời gian vào:";
            lbTGVao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLine
            // 
            lbLine.BackColor = Color.Transparent;
            lbLine.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLine.ForeColor = Color.FromArgb(74, 74, 74);
            lbLine.Location = new Point(5, 682);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(464, 41);
            lbLine.TabIndex = 12;
            lbLine.Text = "--------------------------------------------------";
            lbLine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTienBan
            // 
            lbTienBan.BackColor = Color.Transparent;
            lbTienBan.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTienBan.ForeColor = Color.FromArgb(74, 74, 74);
            lbTienBan.Location = new Point(6, 650);
            lbTienBan.Name = "lbTienBan";
            lbTienBan.Size = new Size(219, 41);
            lbTienBan.TabIndex = 11;
            lbTienBan.Text = "Tiền bàn :";
            lbTienBan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTablePrice
            // 
            lbTablePrice.BackColor = Color.Transparent;
            lbTablePrice.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTablePrice.ForeColor = Color.FromArgb(74, 74, 74);
            lbTablePrice.Location = new Point(270, 650);
            lbTablePrice.Name = "lbTablePrice";
            lbTablePrice.Size = new Size(201, 41);
            lbTablePrice.TabIndex = 10;
            lbTablePrice.Text = "0 ₫";
            lbTablePrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTongTien1
            // 
            lbTongTien1.BackColor = Color.Transparent;
            lbTongTien1.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTien1.ForeColor = Color.FromArgb(74, 74, 74);
            lbTongTien1.Location = new Point(18, 742);
            lbTongTien1.Name = "lbTongTien1";
            lbTongTien1.Size = new Size(205, 41);
            lbTongTien1.TabIndex = 9;
            lbTongTien1.Text = "Tổng tiền :";
            lbTongTien1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstVwFoodBill
            // 
            lstVwFoodBill.BackColor = Color.FromArgb(179, 179, 179);
            lstVwFoodBill.BorderStyle = BorderStyle.None;
            lstVwFoodBill.Columns.AddRange(new ColumnHeader[] { column1, column2, column3, column4 });
            lstVwFoodBill.Font = new Font("Colonna MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstVwFoodBill.ForeColor = Color.FromArgb(74, 74, 74);
            lstVwFoodBill.FullRowSelect = true;
            lstVwFoodBill.GridLines = true;
            lstVwFoodBill.Location = new Point(-1, -1);
            lstVwFoodBill.MaximumSize = new Size(468, 420);
            lstVwFoodBill.MinimumSize = new Size(468, 270);
            lstVwFoodBill.Name = "lstVwFoodBill";
            lstVwFoodBill.Size = new Size(468, 420);
            lstVwFoodBill.TabIndex = 0;
            lstVwFoodBill.UseCompatibleStateImageBehavior = false;
            lstVwFoodBill.View = View.Details;
            lstVwFoodBill.SelectedIndexChanged += DeleteFoodOnListView_MouseClick;
            // 
            // column1
            // 
            column1.Text = "Tên món";
            column1.Width = 200;
            // 
            // column2
            // 
            column2.Text = "Đơn giá";
            column2.Width = 100;
            // 
            // column3
            // 
            column3.Text = "SL";
            column3.TextAlign = HorizontalAlignment.Center;
            column3.Width = 40;
            // 
            // column4
            // 
            column4.Text = "T.tiền";
            column4.TextAlign = HorizontalAlignment.Right;
            column4.Width = 100;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.BackColor = Color.Transparent;
            lbTotalPrice.Font = new Font("Colonna MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPrice.ForeColor = Color.FromArgb(74, 74, 74);
            lbTotalPrice.Location = new Point(268, 742);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(201, 41);
            lbTotalPrice.TabIndex = 8;
            lbTotalPrice.Text = "0 ₫";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnStarting
            // 
            btnStarting.BackColor = Color.Transparent;
            btnStarting.Cursor = Cursors.Hand;
            btnStarting.FlatAppearance.BorderSize = 0;
            btnStarting.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStarting.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnStarting.FlatStyle = FlatStyle.Flat;
            btnStarting.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStarting.ForeColor = Color.FromArgb(74, 74, 74);
            btnStarting.Location = new Point(5, 453);
            btnStarting.Name = "btnStarting";
            btnStarting.Size = new Size(457, 53);
            btnStarting.TabIndex = 15;
            btnStarting.Text = "Bắt đầu";
            btnStarting.UseVisualStyleBackColor = false;
            btnStarting.Click += btnStarting_Click;
            btnStarting.MouseLeave += btnStarting_MouseLeave;
            btnStarting.MouseMove += btnStarting_MouseMove;
            // 
            // lbLine3
            // 
            lbLine3.BackColor = Color.Transparent;
            lbLine3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLine3.ForeColor = Color.FromArgb(74, 74, 74);
            lbLine3.Location = new Point(1, 491);
            lbLine3.Name = "lbLine3";
            lbLine3.Size = new Size(468, 41);
            lbLine3.TabIndex = 24;
            lbLine3.Text = "--------------------------------------------------";
            lbLine3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLine4
            // 
            lbLine4.BackColor = Color.Transparent;
            lbLine4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLine4.ForeColor = Color.FromArgb(74, 74, 74);
            lbLine4.Location = new Point(-1, 423);
            lbLine4.Name = "lbLine4";
            lbLine4.Size = new Size(468, 41);
            lbLine4.TabIndex = 30;
            lbLine4.Text = "--------------------------------------------------";
            lbLine4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlChangeTableAndCheckOut
            // 
            pnlChangeTableAndCheckOut.BackColor = Color.FromArgb(47, 47, 47);
            pnlChangeTableAndCheckOut.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChangeTableAndCheckOut.Controls.Add(pnlBackground3);
            pnlChangeTableAndCheckOut.Location = new Point(1408, 948);
            pnlChangeTableAndCheckOut.Name = "pnlChangeTableAndCheckOut";
            pnlChangeTableAndCheckOut.Size = new Size(500, 126);
            pnlChangeTableAndCheckOut.TabIndex = 10;
            // 
            // pnlBackground3
            // 
            pnlBackground3.BackColor = Color.FromArgb(179, 179, 179);
            pnlBackground3.Controls.Add(btnCheckOut);
            pnlBackground3.Controls.Add(nmDiscount);
            pnlBackground3.Controls.Add(btnFoodAmount);
            pnlBackground3.Controls.Add(cbTableChangeList);
            pnlBackground3.Controls.Add(btnChangeTable);
            pnlBackground3.Location = new Point(18, 10);
            pnlBackground3.Name = "pnlBackground3";
            pnlBackground3.Size = new Size(468, 105);
            pnlBackground3.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Transparent;
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCheckOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Goudy Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.FromArgb(74, 74, 74);
            btnCheckOut.Location = new Point(285, 5);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(176, 93);
            btnCheckOut.TabIndex = 27;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            btnCheckOut.MouseLeave += btnCheckOut_MouseLeave;
            btnCheckOut.MouseMove += btnCheckOut_MouseMove;
            // 
            // nmDiscount
            // 
            nmDiscount.BackColor = Color.FromArgb(179, 179, 179);
            nmDiscount.BorderStyle = BorderStyle.FixedSingle;
            nmDiscount.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nmDiscount.ForeColor = Color.FromArgb(74, 74, 74);
            nmDiscount.Location = new Point(167, 60);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(112, 31);
            nmDiscount.TabIndex = 26;
            nmDiscount.TextAlign = HorizontalAlignment.Right;
            nmDiscount.ValueChanged += nmDiscount_ValueChanged;
            // 
            // btnFoodAmount
            // 
            btnFoodAmount.BackColor = Color.Transparent;
            btnFoodAmount.FlatAppearance.BorderSize = 0;
            btnFoodAmount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFoodAmount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFoodAmount.FlatStyle = FlatStyle.Flat;
            btnFoodAmount.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFoodAmount.ForeColor = Color.FromArgb(74, 74, 74);
            btnFoodAmount.Location = new Point(144, 5);
            btnFoodAmount.Name = "btnFoodAmount";
            btnFoodAmount.Size = new Size(139, 50);
            btnFoodAmount.TabIndex = 25;
            btnFoodAmount.Tag = 0;
            btnFoodAmount.Text = "Giảm giá (%)";
            btnFoodAmount.UseVisualStyleBackColor = false;
            // 
            // cbTableChangeList
            // 
            cbTableChangeList.BackColor = Color.FromArgb(179, 179, 179);
            cbTableChangeList.FlatStyle = FlatStyle.Flat;
            cbTableChangeList.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbTableChangeList.ForeColor = Color.FromArgb(74, 74, 74);
            cbTableChangeList.FormattingEnabled = true;
            cbTableChangeList.Location = new Point(7, 61);
            cbTableChangeList.MaxDropDownItems = 4;
            cbTableChangeList.Name = "cbTableChangeList";
            cbTableChangeList.Size = new Size(131, 28);
            cbTableChangeList.TabIndex = 24;
            // 
            // btnChangeTable
            // 
            btnChangeTable.BackColor = Color.Transparent;
            btnChangeTable.Cursor = Cursors.Hand;
            btnChangeTable.FlatAppearance.BorderSize = 0;
            btnChangeTable.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChangeTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnChangeTable.FlatStyle = FlatStyle.Flat;
            btnChangeTable.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeTable.ForeColor = Color.FromArgb(74, 74, 74);
            btnChangeTable.Location = new Point(7, 5);
            btnChangeTable.Name = "btnChangeTable";
            btnChangeTable.Size = new Size(131, 50);
            btnChangeTable.TabIndex = 14;
            btnChangeTable.Text = "Chuyển bàn";
            btnChangeTable.UseVisualStyleBackColor = false;
            btnChangeTable.Click += btnChangeTable_Click;
            btnChangeTable.MouseLeave += btnChangeTable_MouseLeave;
            btnChangeTable.MouseMove += btnChangeTable_MouseMove;
            // 
            // flpnlTableList
            // 
            flpnlTableList.AutoScroll = true;
            flpnlTableList.BackColor = Color.Transparent;
            flpnlTableList.BackgroundImageLayout = ImageLayout.Stretch;
            flpnlTableList.Location = new Point(403, 61);
            flpnlTableList.Name = "flpnlTableList";
            flpnlTableList.Size = new Size(999, 1016);
            flpnlTableList.TabIndex = 11;
            // 
            // timerGetPlayTime
            // 
            timerGetPlayTime.Interval = 30000;
            timerGetPlayTime.Tick += timerGetPlayTime_Tick;
            // 
            // timerSetting
            // 
            timerSetting.Interval = 10;
            timerSetting.Tick += timerSetting_Tick;
            // 
            // timerFoodMenu
            // 
            timerFoodMenu.Interval = 10;
            timerFoodMenu.Tick += timerFoodMenu_Tick;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.ShowIcon = false;
            printPreviewDialog.Visible = false;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 111, 111);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1942, 1102);
            Controls.Add(flpnlTableList);
            Controls.Add(pnlFoodBill);
            Controls.Add(btnExit);
            Controls.Add(pnlChangeTableAndCheckOut);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billiard Management";
            WindowState = FormWindowState.Maximized;
            Load += fTableManager_Load;
            pnlMenu.ResumeLayout(false);
            pnlDateInfo.ResumeLayout(false);
            pnlDateInfo.PerformLayout();
            pnlDisName.ResumeLayout(false);
            pnlDisName.PerformLayout();
            pnlSettingMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSetting).EndInit();
            pnlFoodBill.ResumeLayout(false);
            pnlBackPicBill.ResumeLayout(false);
            pnlAddFood.ResumeLayout(false);
            pnlAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodAmount).EndInit();
            pnlChangeTableAndCheckOut.ResumeLayout(false);
            pnlBackground3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel pnlMenu;
        private Button btnSettingMenu;
        private Panel pnlDisName;
        private Panel pnlDateInfo;
        private Label lbDateMonthYear;
        private Label lbDay;
        private Label lbTime;
        private System.Windows.Forms.Timer timer;
        private Label lbStaffName;
        private Label lbHello;
        private Panel pnlFoodBill;
        private Label label2;
        private Button button4;
        private Panel pnlChangeTableAndCheckOut;
        private Panel pnlBackground3;
        private Button btnChangeTable;
        private ComboBox cbTableChangeList;
        private NumericUpDown nmDiscount;
        private Button btnFoodAmount;
        private Button btnCheckOut;
        private FlowLayoutPanel flpnlTableList;
        private Panel pnlBackPicBill;
        private Label lbTimePlay;
        private Label lbTimeCheckIn;
        private Label lbTGChoi;
        private Label lbTGVao;
        private Button btnStarting;
        private Label lbLine;
        private Label lbTienBan;
        private Label lbTablePrice;
        private Label lbTongTien1;
        private ListView lstVwFoodBill;
        private ColumnHeader column1;
        private ColumnHeader column2;
        private ColumnHeader column3;
        private ColumnHeader column4;
        private Label lbTotalPrice;
        private Label lbLine3;
        private Button btnAddFood;
        private Label lbTableNameOnBill;
        private Panel pnlAddFood;
        private System.Windows.Forms.Timer timerGetPlayTime;
        private FlowLayoutPanel pnlSettingMenu;
        private FlowLayoutPanel pnlTableAndMenu;
        private Panel panel2;
        private System.Windows.Forms.Timer timerSetting;
        private System.Windows.Forms.Timer timerFoodMenu;
        private PictureBox btnSetting;
        private FontAwesome.Sharp.IconButton ibtnShowTable;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private FontAwesome.Sharp.IconButton ibtnAdmin;
        private FontAwesome.Sharp.IconButton ibtnStaffProfile;
        private FontAwesome.Sharp.IconButton ibtnLogOut;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private NumericUpDown nmFoodAmount;
        private Label lbSelectedFood;
        private Label label5;
        private Label lbSelectedPrice;
        private Label label3;
        private Label label1;
        private Label lbLine4;
        private Label label4;
        private Button btnDeleteFood;
        private Button btnUpdateFood;
    }
}