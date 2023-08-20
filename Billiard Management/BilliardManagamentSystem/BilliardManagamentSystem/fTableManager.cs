using BilliardManagamentSystem.DAO;
using BilliardManagamentSystem.DTO;
using FontAwesome.Sharp;
using ImageMagick;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Printing;
using System.Reflection.Metadata;
using System.Resources.Tools;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BilliardManagamentSystem
{
    public partial class fTableManager : Form
    {
        private Staff loginStaff;
        private Account loginAcc;
        private Button currentButton;
        private IconButton currentIButton;

        public Staff LoginStaff
        {
            get
            {
                return loginStaff;
            }
            set
            {
                loginStaff = value;
            }
        }

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        public fTableManager(Account loginAcc)
        {
            InitializeComponent();
            LoginAcc = loginAcc;
            if (loginAcc.LoginTime == 1)
            {
                fChangePassword f = new fChangePassword(loginAcc);
                Hide();
                f.ShowDialog();
                Show();
            }
            LoginStaff = StaffDAO.Instance.GetStaffByStaffID(LoginAcc.StaffID);
            LoadTable();
            LoadCategory();
        }

        #region Events
        private void btnStarting_Click(object sender, EventArgs e)
        {
            timerGetPlayTime.Start();

            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id);


            if (billID == -1)
            {
                BillDAO.Instance.InsertBill(table.Id, LoginStaff.StaffID);
                TableDAO.Instance.SetTableStatusToNotEmpty(table.Id);
                LoadTable();
                ShowBill(BillDAO.Instance.GetMaxBillID());
            }
            else
            {
                MessageBox.Show(string.Format(table.Name + " đã có bill!"), "Thông báo");
                LoadTable();
                ShowBill(billID);
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateIButton(sender);
            int categoryID = ((sender as Button).Tag as Category).CategoryID;
            flpnlTableList.Controls.Clear();
            LoadFood(categoryID);
        }
        void btnTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            lstVwFoodBill.Size = lstVwFoodBill.MaximumSize;

            pnlAddFood.Visible = false;

            pnlAddFood.Enabled = false;

            int tableId = ((sender as Button).Tag as BilliardTable).Id;

            lbTableNameOnBill.Text = ((sender as Button).Tag as BilliardTable).Name + " - " + ((sender as Button).Tag as BilliardTable).Type;

            lstVwFoodBill.Tag = (sender as Button).Tag;

            nmDiscount.Value = 0;

            ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(tableId));
        }
        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            BilliardTable table1 = lstVwFoodBill.Tag as BilliardTable;
            if (table1 == null)
            {
                MessageBox.Show("Chưa chọn bàn để thực hiện chuyển bàn!", "Thông báo");
                return;
            }
            BilliardTable table2 = cbTableChangeList.SelectedItem as BilliardTable;

            if (MessageBox.Show(string.Format("Bạn có muốn chuyển {0} qua bàn {1} không?", table1.Name, table2.Name), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (table1.Status != table2.Status)
                {
                    TableDAO.Instance.ChangeTable(table1.Id, table2.Id);
                    TableDAO.Instance.SetTableStatusToEmpty(table1.Id);
                    TableDAO.Instance.SetTableStatusToNotEmpty(table2.Id);
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Chỉ có thể chuyển giữa 1 bàn trống và 1 bàn có người!", "Thông báo");
                }
            }
        }
        private void timerGetPlayTime_Tick(object sender, EventArgs e)
        {
            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id));
        }
        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;
            ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id));
        }
        private void btnSetting_MouseMove(object sender, MouseEventArgs e)
        {
            btnSetting.Size = new Size(62, 62);
        }
        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.Size = new Size(60, 60);
        }
        private void btnShowTableList_Click(object sender, EventArgs e)
        {
            ActivateIButton(sender);
            pnlAddFood.Visible = false;
            pnlAddFood.Enabled = false;
            flpnlTableList.Controls.Clear();
            LoadTable();
        }
        private void btnAddFood_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddFood.Font = new Font("Cambria", 16, FontStyle.Bold);
        }
        private void btnAddFood_MouseLeave(object sender, EventArgs e)
        {
            btnAddFood.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        private void btnUpdateFood_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdateFood.Font = new Font("Cambria", 16, FontStyle.Bold);
        }
        private void btnUpdateFood_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateFood.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        private void btnDeleteFood_MouseMove(object sender, MouseEventArgs e)
        {
            btnDeleteFood.Font = new Font("Cambria", 16, FontStyle.Bold);
        }
        private void btnDeleteFood_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteFood.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        bool foodMenuIsOpen = false;
        private void timerFoodMenu_Tick(object sender, EventArgs e)
        {
            if (foodMenuIsOpen)
            {
                pnlTableAndMenu.Height -= 50;
                if (pnlTableAndMenu.Height == pnlTableAndMenu.MinimumSize.Height)
                {
                    foodMenuIsOpen = false;
                    timerFoodMenu.Stop();
                }
            }
            else
            {
                pnlTableAndMenu.Height += 50;
                if (pnlTableAndMenu.Height == pnlTableAndMenu.MaximumSize.Height)
                {
                    foodMenuIsOpen = true;
                    timerFoodMenu.Stop();
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerFoodMenu.Start();
            LoadCategory();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            timerGetPlayTime.Stop();

            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            CultureInfo culture = new CultureInfo("vi-VN");

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id);

            int discount = (int)nmDiscount.Value;

            double tablePrice = (double)lbTablePrice.Tag;

            double totalPrice = (double)lbTotalPrice.Tag;

            if (billID != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán cho " + table.Name + " không?\nTổng hóa đơn: " + totalPrice.ToString("c", culture)), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BillDAO.Instance.CheckOut(billID, discount, tablePrice, totalPrice);
                    lstVwFoodBill.Items.Clear();
                    lbTimeCheckIn.Text = "00:00";
                    lbTimePlay.Text = "00:00";
                    lbTablePrice.Text = "0";
                    lbTotalPrice.Text = "0";
                    LoadTable();
                    if (MessageBox.Show("Bạn có muốn in hóa đơn vừa thanh toán không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnCheckOut.Tag = billID;
                        PrintBill(billID);
                    }
                }
            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            if (table == null)
            {
                MessageBox.Show("Chưa chọn bàn để thêm món!", "Thông báo");
                return;
            }

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id);

            Food selectedFood = btnAddFood.Tag as Food;

            if (selectedFood != null)
            {
                int foodID = selectedFood.FoodID;

                int amount = (int)nmFoodAmount.Value;

                if (billID == -1)
                {
                    BillDAO.Instance.InsertBill(table.Id, LoginStaff.StaffID);
                    BIllInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBillID(), foodID, amount);
                    ShowBill(BillDAO.Instance.GetMaxBillID());
                }
                else
                {
                    BIllInfoDAO.Instance.InsertBillInfo(billID, foodID, amount);
                    ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id));
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món để thêm vào bill!", "Thông báo!");
                return;
            }
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id);

            Food selectedFood = FoodDAO.Instance.GetFoodByFoodName(lbSelectedFood.Text);

            int amount = (int)nmFoodAmount.Value;

            BIllInfoDAO.Instance.InsertBillInfo(billID, selectedFood.FoodID, amount);

            ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id));
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            BilliardTable table = lstVwFoodBill.Tag as BilliardTable;

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id);

            Food selectedFood = FoodDAO.Instance.GetFoodByFoodName(lbSelectedFood.Text);

            BIllInfoDAO.Instance.InsertBillInfo(billID, selectedFood.FoodID, 0);

            ShowBill(BillDAO.Instance.GetUncheckedBillIDByTableID(table.Id));
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            timerSetting.Start();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.FromArgb(74, 74, 74);
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateIButton(sender);
            if (LoginStaff.RoleID == 1)
            {
                fAdmin f = new fAdmin();
                f.loginAcc = LoginAcc;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ tài khoản Admin mới có thể truy cập vào mục này!", "Thông báo");
            }
        }
        bool settingMemuIsOpen = false;
        private void timerSetting_Tick(object sender, EventArgs e)
        {
            if (settingMemuIsOpen)
            {
                pnlSettingMenu.Height -= 50;
                if (pnlSettingMenu.Height == pnlSettingMenu.MinimumSize.Height)
                {
                    settingMemuIsOpen = false;
                    timerSetting.Stop();
                }
            }
            else
            {
                pnlSettingMenu.Height += 50;
                if (pnlSettingMenu.Height == pnlSettingMenu.MaximumSize.Height)
                {
                    settingMemuIsOpen = true;
                    timerSetting.Stop();
                }
            }
        }
        private void btnSettingMenu_Click(object sender, EventArgs e)
        {
            timerSetting.Start();
        }
        private void btnAccInfoMenu_MouseMove(object sender, MouseEventArgs e)
        {
            btnSettingMenu.Font = new Font("Cambria", 28, FontStyle.Bold);
        }
        private void btnAccInfoMenu_MouseLeave(object sender, EventArgs e)
        {
            btnSettingMenu.Font = new Font("Cambria", 24, FontStyle.Bold);
        }
        private void btnAccInfoMenu_MouseDown(object sender, MouseEventArgs e)
        {
            btnSettingMenu.Font = new Font("Cambria", 20, FontStyle.Bold);
        }
        private void btnAccInfo_Click(object sender, EventArgs e)
        {
            ActivateIButton(sender);
            fStaffProfile f = new fStaffProfile(LoginAcc);
            f.ShowDialog();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ActivateIButton(sender);
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        private void btnStarting_MouseMove(object sender, MouseEventArgs e)
        {
            btnStarting.Font = new Font("Cambria", 18, FontStyle.Bold);
        }
        private void btnStarting_MouseLeave(object sender, EventArgs e)
        {
            btnStarting.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        private void btnChangeTable_MouseMove(object sender, MouseEventArgs e)
        {
            btnChangeTable.Font = new Font("Cambria", 11, FontStyle.Bold);
        }
        private void btnChangeTable_MouseLeave(object sender, EventArgs e)
        {
            btnChangeTable.Font = new Font("Cambria", 10, FontStyle.Bold);
        }
        private void btnCheckOut_MouseMove(object sender, MouseEventArgs e)
        {
            btnCheckOut.Font = new Font("Cambria", 16, FontStyle.Bold);
        }
        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            btnCheckOut.Font = new Font("Cambria", 14, FontStyle.Bold);
        }
        void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            lstVwFoodBill.Size = lstVwFoodBill.MinimumSize;

            btnStarting.Enabled = false;

            btnStarting.Visible = false;

            pnlAddFood.Visible = true;

            pnlAddFood.Enabled = true;

            btnAddFood.Enabled = true;

            EnableUpdateAndDeleteFoodButton();

            btnAddFood.Tag = (sender as Button).Tag;

            lbSelectedFood.Text = (btnAddFood.Tag as Food).FoodName;

            lbSelectedPrice.Text = (btnAddFood.Tag as Food).FoodPrice.ToString("c", new CultureInfo("vi-VN"));

            nmFoodAmount.Value = 1;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbDay.Text = DateTime.Now.ToString("dddd", culture);
            lbDateMonthYear.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbStaffName.Text = LoginStaff.StaffName;
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Store store = StoreDAO.Instance.StoreInfo();
            PrintBill bill = BillDAO.Instance.GetPrintBill((int)btnCheckOut.Tag);

            int width = printDocument.DefaultPageSettings.PaperSize.Width; //827
            int height = printDocument.DefaultPageSettings.PaperSize.Height; //1169

            //header
            e.Graphics.DrawString(store.Name.ToUpper(), new Font("Courier New", 28, FontStyle.Bold), Brushes.Black, new Point(40, 80));
            e.Graphics.DrawString(store.Address.ToUpper(), new Font("Courier New", 16), Brushes.Black, new Point(40, 130));
            e.Graphics.DrawString("SĐT: " + store.Phone.ToUpper(), new Font("Courier New", 16), Brushes.Black, new Point(40, 160));
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Courier New", 28, FontStyle.Bold), Brushes.Black, new Point(200, 230));
            e.Graphics.DrawString("Mã hóa đơn: " + bill.BillID, new Font("Courier New", 16, FontStyle.Bold), Brushes.Black, new Point(300, 280));

            //body (560)
            e.Graphics.DrawString(bill.TableName, new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(40, 350));
            e.Graphics.DrawString("Thu ngân: " + bill.StaffName, new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(40, 390));
            e.Graphics.DrawString("Ngày: " + bill.Date, new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(width / 2, 350));
            e.Graphics.DrawString("Giờ chơi: " + bill.Playtime, new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(40, 430));
            e.Graphics.DrawString("Giảm giá: " + bill.Discount + "%" + string.Format(" - (Giảm {0})", DiscoutPrice(bill.TablePrice, bill.Discount).ToString("c", new CultureInfo("vi-VN"))), new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(width / 2, 390));
            e.Graphics.DrawString("Tiền bàn: " + bill.TablePrice.ToString("c", new CultureInfo("vi-VN")), new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(width / 2, 430));

            List<FoodList> list = FoodListDAO.Instance.GetMenuListByBillID(bill.BillID);
            int x = 50;
            int y = 550;

            if (list.Count > 0)
            {
                //foodheader
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(40, 480), new Point(width - 40, 480));
                e.Graphics.DrawString("Tên món", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(50, 500));
                e.Graphics.DrawString("Đơn giá", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(400, 500));
                e.Graphics.DrawString("SL", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(580, 500));
                e.Graphics.DrawString("Thành tiền", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(650, 500));
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(40, 530), new Point(width - 40, 530));


                //foodtable
                foreach (FoodList item in list)
                {
                    e.Graphics.DrawString(item.FoodName, new Font("Courier New", 14), Brushes.Black, new Point(x, y));
                    e.Graphics.DrawString(item.FoodPrice.ToString("c", new CultureInfo("vi-VN")), new Font("Courier New", 14), Brushes.Black, new Point(x + 350, y));
                    e.Graphics.DrawString(item.Amount.ToString(), new Font("Courier New", 14), Brushes.Black, new Point(x + 530, y));
                    e.Graphics.DrawString(item.FoodTotalPrice.ToString("c", new CultureInfo("vi-VN")), new Font("Courier New", 14), Brushes.Black, new Point(x + 600, y));
                    e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(40, y + 30), new Point(width - 40, y + 30));
                    y += 50;
                }

                //line
                y -= 20;
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(40, 480), new Point(40, y));
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(390, 480), new Point(390, y));
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(540, 480), new Point(540, y));
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(640, 480), new Point(640, y));
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(width - 40, 480), new Point(width - 40, y));
            }
            else
            {
                y = 450;
            }

            //end
            e.Graphics.DrawString("Tiền món ăn: ", new Font("Courier New", 16, FontStyle.Italic), Brushes.Black, new Point(40, y + 30));
            e.Graphics.DrawString((bill.TotalPrice - bill.TablePrice).ToString("c", new CultureInfo("vi-VN")), new Font("Courier New", 16, FontStyle.Italic), Brushes.Black, new Point(650, y + 30));
            e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(40, y + 60), new Point(width - 40, y + 60));
            e.Graphics.DrawString("Tổng hóa đơn: ", new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(40, y + 80));
            e.Graphics.DrawString(bill.TotalPrice.ToString("c", new CultureInfo("vi-VN")), new Font("Courier New", 20, FontStyle.Bold), Brushes.Black, new Point(630, y + 80));
            e.Graphics.DrawString("Trân trọng cảm ơn!", new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(300, y + 130));
        }
        private void DeleteFoodOnListView_MouseClick(object sender, EventArgs e)
        {
            lstVwFoodBill.Size = lstVwFoodBill.MinimumSize;

            pnlAddFood.Visible = true;

            pnlAddFood.Enabled = true;

            btnAddFood.Enabled = false;

            EnableUpdateAndDeleteFoodButton();

            try
            {
                lbSelectedFood.Text = lstVwFoodBill.SelectedItems[0].SubItems[0].Text;

                lbSelectedPrice.Text = lstVwFoodBill.SelectedItems[0].SubItems[1].Text;

                nmFoodAmount.Value = Convert.ToDecimal(lstVwFoodBill.SelectedItems[0].SubItems[2].Text);
            }
            catch { }

        }
        #endregion

        #region Methods
        void EnableUpdateAndDeleteFoodButton()
        {
            btnAddFood.Visible = btnAddFood.Enabled;
            btnUpdateFood.Enabled = !btnAddFood.Enabled;
            btnUpdateFood.Visible = !btnAddFood.Enabled;
            btnDeleteFood.Enabled = !btnAddFood.Enabled;
            btnDeleteFood.Visible = !btnAddFood.Enabled;
        }
        void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(47, 47, 47);
            }
        }
        void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
            }
        }
        void ActivateIButton(object sender)
        {
            if (sender != null)
            {
                DisableIButton();
                currentIButton = (IconButton)sender;
                currentIButton.BackColor = Color.FromArgb(179, 179, 179);
                currentIButton.ForeColor = Color.FromArgb(74, 74, 74);
                currentIButton.IconColor = Color.FromArgb(74, 74, 74);
            }
        }
        void DisableIButton()
        {
            if (currentIButton != null)
            {
                currentIButton.BackColor = Color.Transparent;
                currentIButton.ForeColor = Color.FromArgb(235, 245, 238);
                currentIButton.IconColor = Color.FromArgb(235, 245, 238);
            }
        }
        void DisplayCheckInTimeAndPlayTime(int tableID)
        {
            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(tableID);
            var time = BillDAO.Instance.GetCheckInTimeByUncheckedBillID(billID);
            var playTime = DateTime.MinValue;
            if (time != null && billID != -1)
            {
                playTime = BillDAO.Instance.GetPlayTime(time);
                lbTimeCheckIn.Text = time.ToString("HH:mm");
                lbTimePlay.Text = playTime.ToString("HH:mm");
            }
            else
            {
                lbTimeCheckIn.Text = "00:00";
                lbTimePlay.Text = "00:00";
            }
        }
        TimeSpan GetPlayTime(int tableID)
        {
            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(tableID);

            if (billID == -1)
                return TimeSpan.MinValue;

            var checkInTime = BillDAO.Instance.GetCheckInTimeByUncheckedBillID(billID);

            TimeSpan playTime = DateTime.Now - checkInTime;

            return playTime;
        }
        double TablePrice(int tableID)
        {
            double pricePerHour = StoreDAO.Instance.StoreInfo().PricePerHour;

            int billID = BillDAO.Instance.GetUncheckedBillIDByTableID(tableID);

            if (billID == -1)
                return 0;

            TimeSpan playTime = GetPlayTime(tableID);

            if (playTime.TotalMinutes <= 60)
                return pricePerHour;

            double price = Math.Round(playTime.TotalMinutes * pricePerHour / 60);

            if ((price % 1000) < 500)
                price = price - (price % 1000);
            else
                price = price - (price % 1000) + 1000;

            return price;
        }
        void LoadTable()
        {
            flpnlTableList.Controls.Clear();

            cbTableChangeList.DataSource = TableDAO.Instance.LoadTableList();
            cbTableChangeList.DisplayMember = "Name";

            lstVwFoodBill.Size = lstVwFoodBill.MaximumSize;

            btnStarting.Enabled = true;
            btnStarting.Visible = true;

            List<BilliardTable> list = TableDAO.Instance.LoadTableList();

            foreach (BilliardTable table in list)
            {
                Button btn = new Button()
                {
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Center,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Size = new Size(300, 188),
                    Font = new Font("Cambria", 12, FontStyle.Bold),
                    TabIndex = 0,
                    Text = table.Name + " - " + table.Type,
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = false,
                    AutoSize = false,
                    Cursor = Cursors.Hand,
                };
                btn.Tag = table;
                btn.Click += btnTable_Click;
                switch (table.Status)
                {
                    case "Trống":
                        btn.BackgroundImage = Properties.Resources.empty_table;
                        break;
                    case "Có người":
                        btn.BackgroundImage = Properties.Resources.playing_table;
                        break;
                }
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 47, 47);
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                flpnlTableList.Controls.Add(btn);
            }
        }
        void LoadCategory()
        {
            pnlTableAndMenu.Controls.Clear();

            List<Category> categories = CategoryDAO.Instance.GetCategories();

            foreach (Category category in categories)
            {
                IconButton button = new IconButton()
                {
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent,
                    Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.FromArgb(235, 245, 238),
                    IconChar = FontAwesome.Sharp.IconChar.Play,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    IconColor = Color.FromArgb(235, 245, 238),
                    IconFont = FontAwesome.Sharp.IconFont.Auto,
                    IconSize = 40,
                    Location = new Point(3, 3),
                    Padding = new Padding(20, 0, 0, 0),
                    Size = new Size(280, 77),
                    Text = "    " + category.CategoryName,
                    TextAlign = ContentAlignment.MiddleLeft,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    UseVisualStyleBackColor = true,
                };
                button.Click += btnCategory_Click;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 179, 179);
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.Tag = category;
                pnlTableAndMenu.Controls.Add(button);
            }
        }
        void ShowBill(int billID)
        {
            lstVwFoodBill.Items.Clear();

            int tableId = TableDAO.Instance.GetTableIDByBillID(billID);

            CultureInfo culture = new CultureInfo("vi-VN");

            List<FoodList> list = FoodListDAO.Instance.GetMenuListByTable(tableId);

            double tablePrice = TablePrice(tableId) - (TablePrice(tableId) * (double)nmDiscount.Value / 100);

            double totalPrice = tablePrice;

            foreach (FoodList menu in list)
            {
                ListViewItem lvItem = new ListViewItem(menu.FoodName.ToString());
                lvItem.SubItems.Add(menu.FoodPrice.ToString("c", culture));
                lvItem.SubItems.Add(menu.Amount.ToString());
                lvItem.SubItems.Add(menu.FoodTotalPrice.ToString("c", culture));
                totalPrice += menu.FoodTotalPrice;
                lstVwFoodBill.Items.Add(lvItem);
            }

            lbTablePrice.Tag = tablePrice;

            lbTablePrice.Text = tablePrice.ToString("c", culture);

            lbTotalPrice.Tag = totalPrice;

            lbTotalPrice.Text = totalPrice.ToString("c", culture);

            DisplayCheckInTimeAndPlayTime(tableId);

        }
        void LoadFood(int categoryID)
        {
            List<Food> list = FoodDAO.Instance.GetFoodListByCategoryID(categoryID);

            foreach (Food food in list)
            {
                Button btn = new Button()
                {
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Center,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Size = new Size(300, 300),
                    Font = new Font("Cambria", 14, FontStyle.Bold),
                    TabIndex = 0,
                    Text = food.FoodName,
                    TextAlign = ContentAlignment.BottomCenter,
                    UseVisualStyleBackColor = false,
                    AutoSize = false,
                    Cursor = Cursors.Hand
                };

                btn.Tag = food;
                btn.Click += btnFood_Click;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 47, 47);
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;

                if (food.FoodImage == "Chưa có ảnh")
                {
                    string categoryName = CategoryDAO.Instance.GetCategoryByID(food.CategoryID).CategoryName;

                    if (categoryName.Contains("Kem"))
                        btn.BackgroundImage = Properties.Resources.ice_cream;
                    else if (categoryName.Contains("Bia"))
                        btn.BackgroundImage = Properties.Resources.beer;
                    else if (categoryName.Contains("Trà"))
                        btn.BackgroundImage = Properties.Resources.tea;
                    else if (categoryName.Contains("Cafe") || categoryName.Contains("Cà phê"))
                        btn.BackgroundImage = Properties.Resources.coffee;
                    else if (categoryName.Contains("Cơm"))
                        btn.BackgroundImage = Properties.Resources.rice;
                    else if (categoryName.Contains("Mì"))
                        btn.BackgroundImage = Properties.Resources.noodle;
                    else if (categoryName.Contains("Giải khát") || categoryName.Contains("Nước ngọt"))
                        btn.BackgroundImage = Properties.Resources.soft_drinks;
                    else if (categoryName.Contains("Ăn vặt") || categoryName.Contains("Snacks"))
                        btn.BackgroundImage = Properties.Resources.snacks;
                }
                else
                {
                    using (var image = new MagickImage(food.FoodImage))
                    {
                        image.Resize(220, 220);
                        btn.BackgroundImage = MagickImageToBitmap(image);
                    }
                }

                flpnlTableList.Controls.Add(btn);
            }
        }
        private Bitmap MagickImageToBitmap(MagickImage magickImage)
        {
            using (var memoryStream = new MemoryStream())
            {
                magickImage.Write(memoryStream, MagickFormat.Bmp);
                memoryStream.Position = 0;
                return new Bitmap(memoryStream);
            }
        }
        void ResizePrintPage(int billID)
        {
            List<FoodList> list = FoodListDAO.Instance.GetMenuListByBillID(billID);
            int amount = list.Count;
            int heightDif;
            //50: độ cao của một hàng món ăn
            //750: tổng độ cao của head(550) + tableHead(100) + end của hóa đơn(100)
            if (amount > 0)
                heightDif = (50 * amount) + 750 - printDocument.DefaultPageSettings.PaperSize.Height;
            else
                heightDif = 650 - printDocument.DefaultPageSettings.PaperSize.Height; // trừ phần tableHead(100)
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", printDocument.DefaultPageSettings.PaperSize.Width, printDocument.DefaultPageSettings.PaperSize.Height + heightDif);
        }
        void PrintBill(int billID)
        {
            ResizePrintPage(billID);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        double DiscoutPrice(double price, int discount)
        {
            return (price * 100 / (100 - discount)) - price;
        }
        #endregion


    }
}
