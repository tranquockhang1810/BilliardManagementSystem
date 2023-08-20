using System.Globalization;

namespace BilliardManagamentSystem
{
    partial class fAdmin
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
            btnExit = new Button();
            tabControl1 = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            tbPage = new TextBox();
            btnNextPage = new Button();
            btnPrePage = new Button();
            btnLastPage = new Button();
            btnFirstPage = new Button();
            dtgvBillByDate = new DataGridView();
            panel1 = new Panel();
            btnShowReport = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            tpTable = new TabPage();
            panel20 = new Panel();
            label10 = new Label();
            tbFindTable = new TextBox();
            panel6 = new Panel();
            tbTableType = new TextBox();
            tbTableName = new TextBox();
            label2 = new Label();
            lbDisplayName = new Label();
            tbTableID = new TextBox();
            lbUserName = new Label();
            panel4 = new Panel();
            dtgvTableList = new DataGridView();
            panel3 = new Panel();
            btnShowTable = new Button();
            btnUpdateTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tbCategory = new TabPage();
            panel21 = new Panel();
            label18 = new Label();
            tbFindCategory = new TextBox();
            panel10 = new Panel();
            tbCategoryName = new TextBox();
            label5 = new Label();
            tbCategoryID = new TextBox();
            label6 = new Label();
            panel9 = new Panel();
            dtgvCategoryList = new DataGridView();
            panel7 = new Panel();
            btnShowCategory = new Button();
            btnUpdateCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tbFood = new TabPage();
            panel14 = new Panel();
            btnChoseImage = new Button();
            pbFoodImage = new PictureBox();
            label17 = new Label();
            tbFoodName = new TextBox();
            cbFoodCategory = new ComboBox();
            nmFoodPrice = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            tbFoodID = new TextBox();
            label4 = new Label();
            panel13 = new Panel();
            label1 = new Label();
            tbFindFoodName = new TextBox();
            panel12 = new Panel();
            dtgvFoodList = new DataGridView();
            panel11 = new Panel();
            btnResetFoodList = new Button();
            btnShowFood = new Button();
            btnUpdateFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            tbStaff = new TabPage();
            panel16 = new Panel();
            label19 = new Label();
            tbFindStaffName = new TextBox();
            panel15 = new Panel();
            cbStaffRole = new ComboBox();
            label9 = new Label();
            tbStaffEmail = new TextBox();
            label14 = new Label();
            tbStaffPhone = new TextBox();
            label13 = new Label();
            tbStaffName = new TextBox();
            label11 = new Label();
            tbStaffID = new TextBox();
            label12 = new Label();
            panel8 = new Panel();
            dtgvStaffList = new DataGridView();
            panel5 = new Panel();
            btnShowStaffByRole = new Button();
            btnShowAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tpStoreInfo = new TabPage();
            btnSubmit = new Button();
            btnUpdateStoreInfo = new Button();
            label25 = new Label();
            nmTablePricePerHour = new NumericUpDown();
            label24 = new Label();
            tbStorePhone = new TextBox();
            label23 = new Label();
            tbStoreAddress = new TextBox();
            label22 = new Label();
            tbStoreName = new TextBox();
            label21 = new Label();
            btnResetPicture = new Button();
            tabControl1.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBillByDate).BeginInit();
            panel1.SuspendLayout();
            tpTable.SuspendLayout();
            panel20.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTableList).BeginInit();
            panel3.SuspendLayout();
            tbCategory.SuspendLayout();
            panel21.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategoryList).BeginInit();
            panel7.SuspendLayout();
            tbFood.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFoodList).BeginInit();
            panel11.SuspendLayout();
            tbStaff.SuspendLayout();
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStaffList).BeginInit();
            panel5.SuspendLayout();
            tpStoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmTablePricePerHour).BeginInit();
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
            btnExit.Location = new Point(1247, 6);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(58, 44);
            btnExit.TabIndex = 6;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_MouseLeave;
            btnExit.MouseMove += btnExit_MouseMove;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpBill);
            tabControl1.Controls.Add(tpTable);
            tabControl1.Controls.Add(tbCategory);
            tabControl1.Controls.Add(tbFood);
            tabControl1.Controls.Add(tbStaff);
            tabControl1.Controls.Add(tpStoreInfo);
            tabControl1.Location = new Point(2, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1305, 613);
            tabControl1.TabIndex = 7;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 26);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(1297, 583);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(179, 179, 179);
            panel2.Controls.Add(tbPage);
            panel2.Controls.Add(btnNextPage);
            panel2.Controls.Add(btnPrePage);
            panel2.Controls.Add(btnLastPage);
            panel2.Controls.Add(btnFirstPage);
            panel2.Controls.Add(dtgvBillByDate);
            panel2.ForeColor = Color.FromArgb(74, 74, 74);
            panel2.Location = new Point(7, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1287, 512);
            panel2.TabIndex = 1;
            // 
            // tbPage
            // 
            tbPage.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbPage.ForeColor = Color.FromArgb(74, 74, 74);
            tbPage.Location = new Point(566, 475);
            tbPage.Name = "tbPage";
            tbPage.Size = new Size(159, 34);
            tbPage.TabIndex = 7;
            tbPage.Text = "1";
            tbPage.TextAlign = HorizontalAlignment.Center;
            tbPage.TextChanged += tbPage_TextChanged;
            // 
            // btnNextPage
            // 
            btnNextPage.Cursor = Cursors.Hand;
            btnNextPage.ForeColor = Color.FromArgb(74, 74, 74);
            btnNextPage.Location = new Point(731, 475);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(108, 34);
            btnNextPage.TabIndex = 6;
            btnNextPage.Text = "Trang sau";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Cursor = Cursors.Hand;
            btnPrePage.ForeColor = Color.FromArgb(74, 74, 74);
            btnPrePage.Location = new Point(452, 475);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(108, 34);
            btnPrePage.TabIndex = 5;
            btnPrePage.Text = "Trang trước";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnPrePage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.Cursor = Cursors.Hand;
            btnLastPage.ForeColor = Color.FromArgb(74, 74, 74);
            btnLastPage.Location = new Point(1176, 475);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(108, 34);
            btnLastPage.TabIndex = 4;
            btnLastPage.Text = "Trang cuối";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Cursor = Cursors.Hand;
            btnFirstPage.ForeColor = Color.FromArgb(74, 74, 74);
            btnFirstPage.Location = new Point(3, 475);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(108, 34);
            btnFirstPage.TabIndex = 3;
            btnFirstPage.Text = "Trang đầu";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // dtgvBillByDate
            // 
            dtgvBillByDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBillByDate.BackgroundColor = Color.FromArgb(179, 179, 179);
            dtgvBillByDate.BorderStyle = BorderStyle.None;
            dtgvBillByDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBillByDate.GridColor = Color.FromArgb(74, 74, 74);
            dtgvBillByDate.Location = new Point(3, 3);
            dtgvBillByDate.Name = "dtgvBillByDate";
            dtgvBillByDate.ReadOnly = true;
            dtgvBillByDate.RowHeadersWidth = 51;
            dtgvBillByDate.RowTemplate.Height = 29;
            dtgvBillByDate.Size = new Size(1284, 466);
            dtgvBillByDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            panel1.Controls.Add(btnShowReport);
            panel1.Controls.Add(dtpToDate);
            panel1.Controls.Add(dtpFromDate);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 55);
            panel1.TabIndex = 0;
            // 
            // btnShowReport
            // 
            btnShowReport.Cursor = Cursors.Hand;
            btnShowReport.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowReport.Location = new Point(566, 18);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(159, 26);
            btnShowReport.TabIndex = 2;
            btnShowReport.Text = "Báo cáo";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Location = new Point(961, 17);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(301, 25);
            dtpToDate.TabIndex = 1;
            dtpToDate.ValueChanged += dtp_ValueChanged;
            // 
            // dtpFromDate
            // 
            dtpFromDate.CalendarForeColor = Color.FromArgb(74, 74, 74);
            dtpFromDate.Location = new Point(22, 17);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(301, 25);
            dtpFromDate.TabIndex = 0;
            dtpFromDate.ValueChanged += dtp_ValueChanged;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel20);
            tpTable.Controls.Add(panel6);
            tpTable.Controls.Add(panel4);
            tpTable.Controls.Add(panel3);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(1297, 580);
            tpTable.TabIndex = 1;
            tpTable.Text = "Bàn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(179, 179, 179);
            panel20.Controls.Add(label10);
            panel20.Controls.Add(tbFindTable);
            panel20.Location = new Point(869, 5);
            panel20.Name = "panel20";
            panel20.Size = new Size(430, 90);
            panel20.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(74, 74, 74);
            label10.Location = new Point(16, 12);
            label10.Name = "label10";
            label10.Size = new Size(181, 31);
            label10.TabIndex = 14;
            label10.Text = "Tìm tên bàn:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFindTable
            // 
            tbFindTable.BackColor = Color.White;
            tbFindTable.Cursor = Cursors.IBeam;
            tbFindTable.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbFindTable.ForeColor = Color.FromArgb(74, 74, 74);
            tbFindTable.Location = new Point(16, 46);
            tbFindTable.Name = "tbFindTable";
            tbFindTable.Size = new Size(397, 29);
            tbFindTable.TabIndex = 13;
            tbFindTable.TextChanged += tbFindTable_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(179, 179, 179);
            panel6.Controls.Add(tbTableType);
            panel6.Controls.Add(tbTableName);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(lbDisplayName);
            panel6.Controls.Add(tbTableID);
            panel6.Controls.Add(lbUserName);
            panel6.ForeColor = Color.FromArgb(74, 74, 74);
            panel6.Location = new Point(869, 98);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 482);
            panel6.TabIndex = 3;
            // 
            // tbTableType
            // 
            tbTableType.BackColor = Color.White;
            tbTableType.Cursor = Cursors.IBeam;
            tbTableType.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbTableType.ForeColor = Color.FromArgb(74, 74, 74);
            tbTableType.Location = new Point(22, 328);
            tbTableType.Name = "tbTableType";
            tbTableType.Size = new Size(391, 29);
            tbTableType.TabIndex = 23;
            // 
            // tbTableName
            // 
            tbTableName.BackColor = Color.White;
            tbTableName.Cursor = Cursors.IBeam;
            tbTableName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbTableName.ForeColor = Color.FromArgb(74, 74, 74);
            tbTableName.Location = new Point(22, 224);
            tbTableName.Name = "tbTableName";
            tbTableName.Size = new Size(391, 29);
            tbTableName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(22, 299);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 17;
            label2.Text = "Loại bàn:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDisplayName
            // 
            lbDisplayName.AutoSize = true;
            lbDisplayName.FlatStyle = FlatStyle.Flat;
            lbDisplayName.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbDisplayName.ForeColor = Color.FromArgb(74, 74, 74);
            lbDisplayName.Location = new Point(22, 195);
            lbDisplayName.Name = "lbDisplayName";
            lbDisplayName.Size = new Size(127, 31);
            lbDisplayName.TabIndex = 15;
            lbDisplayName.Text = "Tên bàn:";
            lbDisplayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbTableID
            // 
            tbTableID.BackColor = Color.FromArgb(179, 179, 179);
            tbTableID.BorderStyle = BorderStyle.None;
            tbTableID.Cursor = Cursors.IBeam;
            tbTableID.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbTableID.ForeColor = Color.FromArgb(74, 74, 74);
            tbTableID.Location = new Point(170, 105);
            tbTableID.Name = "tbTableID";
            tbTableID.ReadOnly = true;
            tbTableID.Size = new Size(243, 39);
            tbTableID.TabIndex = 12;
            tbTableID.Text = "7";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.FlatStyle = FlatStyle.Flat;
            lbUserName.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.FromArgb(74, 74, 74);
            lbUserName.Location = new Point(22, 113);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(108, 31);
            lbUserName.TabIndex = 13;
            lbUserName.Text = "ID bàn:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(dtgvTableList);
            panel4.Location = new Point(7, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(856, 482);
            panel4.TabIndex = 1;
            // 
            // dtgvTableList
            // 
            dtgvTableList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTableList.BackgroundColor = Color.FromArgb(179, 179, 179);
            dtgvTableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTableList.GridColor = Color.FromArgb(74, 74, 74);
            dtgvTableList.Location = new Point(4, 3);
            dtgvTableList.Name = "dtgvTableList";
            dtgvTableList.RowHeadersWidth = 51;
            dtgvTableList.RowTemplate.Height = 29;
            dtgvTableList.Size = new Size(849, 476);
            dtgvTableList.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 179, 179);
            panel3.Controls.Add(btnShowTable);
            panel3.Controls.Add(btnUpdateTable);
            panel3.Controls.Add(btnDeleteTable);
            panel3.Controls.Add(btnAddTable);
            panel3.ForeColor = Color.FromArgb(74, 74, 74);
            panel3.Location = new Point(7, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(856, 90);
            panel3.TabIndex = 0;
            // 
            // btnShowTable
            // 
            btnShowTable.Cursor = Cursors.Hand;
            btnShowTable.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowTable.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowTable.Location = new Point(669, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(130, 85);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Làm mới";
            btnShowTable.UseVisualStyleBackColor = true;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Cursor = Cursors.Hand;
            btnUpdateTable.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateTable.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateTable.Location = new Point(465, 2);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(130, 85);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Chỉnh sửa";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Cursor = Cursors.Hand;
            btnDeleteTable.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteTable.ForeColor = Color.FromArgb(74, 74, 74);
            btnDeleteTable.Location = new Point(253, 2);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(130, 85);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Cursor = Cursors.Hand;
            btnAddTable.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTable.ForeColor = Color.FromArgb(74, 74, 74);
            btnAddTable.Location = new Point(46, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(130, 85);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tbCategory
            // 
            tbCategory.Controls.Add(panel21);
            tbCategory.Controls.Add(panel10);
            tbCategory.Controls.Add(panel9);
            tbCategory.Controls.Add(panel7);
            tbCategory.Location = new Point(4, 26);
            tbCategory.Name = "tbCategory";
            tbCategory.Padding = new Padding(3);
            tbCategory.Size = new Size(1297, 583);
            tbCategory.TabIndex = 2;
            tbCategory.Text = "Danh mục thức ăn";
            tbCategory.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(179, 179, 179);
            panel21.Controls.Add(label18);
            panel21.Controls.Add(tbFindCategory);
            panel21.Location = new Point(869, 5);
            panel21.Name = "panel21";
            panel21.Size = new Size(430, 90);
            panel21.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(74, 74, 74);
            label18.Location = new Point(16, 8);
            label18.Name = "label18";
            label18.Size = new Size(259, 31);
            label18.TabIndex = 14;
            label18.Text = "Tìm tên danh mục:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFindCategory
            // 
            tbFindCategory.BackColor = Color.White;
            tbFindCategory.Cursor = Cursors.IBeam;
            tbFindCategory.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbFindCategory.ForeColor = Color.FromArgb(74, 74, 74);
            tbFindCategory.Location = new Point(16, 42);
            tbFindCategory.Name = "tbFindCategory";
            tbFindCategory.Size = new Size(392, 29);
            tbFindCategory.TabIndex = 13;
            tbFindCategory.TextChanged += tbFindCategotyName_TextChanged;
            tbFindCategory.KeyPress += tbString_KeyPress;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(179, 179, 179);
            panel10.Controls.Add(tbCategoryName);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(tbCategoryID);
            panel10.Controls.Add(label6);
            panel10.ForeColor = Color.FromArgb(74, 74, 74);
            panel10.Location = new Point(869, 98);
            panel10.Name = "panel10";
            panel10.Size = new Size(425, 482);
            panel10.TabIndex = 5;
            // 
            // tbCategoryName
            // 
            tbCategoryName.BackColor = Color.White;
            tbCategoryName.Cursor = Cursors.IBeam;
            tbCategoryName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCategoryName.ForeColor = Color.FromArgb(74, 74, 74);
            tbCategoryName.Location = new Point(21, 266);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(387, 29);
            tbCategoryName.TabIndex = 14;
            tbCategoryName.KeyPress += tbString_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(74, 74, 74);
            label5.Location = new Point(21, 237);
            label5.Name = "label5";
            label5.Size = new Size(205, 31);
            label5.TabIndex = 15;
            label5.Text = "Tên danh mục:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCategoryID
            // 
            tbCategoryID.BackColor = Color.FromArgb(179, 179, 179);
            tbCategoryID.BorderStyle = BorderStyle.None;
            tbCategoryID.Cursor = Cursors.IBeam;
            tbCategoryID.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbCategoryID.ForeColor = Color.FromArgb(74, 74, 74);
            tbCategoryID.Location = new Point(242, 132);
            tbCategoryID.Name = "tbCategoryID";
            tbCategoryID.ReadOnly = true;
            tbCategoryID.Size = new Size(166, 39);
            tbCategoryID.TabIndex = 12;
            tbCategoryID.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(74, 74, 74);
            label6.Location = new Point(21, 140);
            label6.Name = "label6";
            label6.Size = new Size(190, 31);
            label6.TabIndex = 13;
            label6.Text = "ID Danh mục:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Silver;
            panel9.Controls.Add(dtgvCategoryList);
            panel9.Location = new Point(7, 98);
            panel9.Name = "panel9";
            panel9.Size = new Size(856, 482);
            panel9.TabIndex = 4;
            // 
            // dtgvCategoryList
            // 
            dtgvCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategoryList.BackgroundColor = Color.FromArgb(179, 179, 179);
            dtgvCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategoryList.GridColor = Color.FromArgb(74, 74, 74);
            dtgvCategoryList.Location = new Point(4, 3);
            dtgvCategoryList.Name = "dtgvCategoryList";
            dtgvCategoryList.RowHeadersWidth = 51;
            dtgvCategoryList.RowTemplate.Height = 29;
            dtgvCategoryList.Size = new Size(849, 476);
            dtgvCategoryList.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(179, 179, 179);
            panel7.Controls.Add(btnShowCategory);
            panel7.Controls.Add(btnUpdateCategory);
            panel7.Controls.Add(btnDeleteCategory);
            panel7.Controls.Add(btnAddCategory);
            panel7.ForeColor = Color.FromArgb(74, 74, 74);
            panel7.Location = new Point(7, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(856, 90);
            panel7.TabIndex = 1;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Cursor = Cursors.Hand;
            btnShowCategory.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowCategory.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowCategory.Location = new Point(669, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(130, 85);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Làm mới";
            btnShowCategory.UseVisualStyleBackColor = true;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Cursor = Cursors.Hand;
            btnUpdateCategory.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCategory.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateCategory.Location = new Point(465, 2);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(130, 85);
            btnUpdateCategory.TabIndex = 2;
            btnUpdateCategory.Text = "Chỉnh sửa";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCategory.ForeColor = Color.FromArgb(74, 74, 74);
            btnDeleteCategory.Location = new Point(253, 2);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(130, 85);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Cursor = Cursors.Hand;
            btnAddCategory.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.FromArgb(74, 74, 74);
            btnAddCategory.Location = new Point(46, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(130, 85);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // tbFood
            // 
            tbFood.Controls.Add(panel14);
            tbFood.Controls.Add(panel13);
            tbFood.Controls.Add(panel12);
            tbFood.Controls.Add(panel11);
            tbFood.Location = new Point(4, 26);
            tbFood.Name = "tbFood";
            tbFood.Padding = new Padding(3);
            tbFood.Size = new Size(1297, 583);
            tbFood.TabIndex = 3;
            tbFood.Text = "Menu đồ ăn";
            tbFood.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(179, 179, 179);
            panel14.Controls.Add(btnResetPicture);
            panel14.Controls.Add(btnChoseImage);
            panel14.Controls.Add(pbFoodImage);
            panel14.Controls.Add(label17);
            panel14.Controls.Add(tbFoodName);
            panel14.Controls.Add(cbFoodCategory);
            panel14.Controls.Add(nmFoodPrice);
            panel14.Controls.Add(label8);
            panel14.Controls.Add(label7);
            panel14.Controls.Add(label3);
            panel14.Controls.Add(tbFoodID);
            panel14.Controls.Add(label4);
            panel14.ForeColor = Color.FromArgb(74, 74, 74);
            panel14.Location = new Point(869, 101);
            panel14.Name = "panel14";
            panel14.Size = new Size(428, 479);
            panel14.TabIndex = 7;
            // 
            // btnChoseImage
            // 
            btnChoseImage.Cursor = Cursors.Hand;
            btnChoseImage.ForeColor = Color.FromArgb(74, 74, 74);
            btnChoseImage.Location = new Point(16, 362);
            btnChoseImage.Name = "btnChoseImage";
            btnChoseImage.Size = new Size(252, 47);
            btnChoseImage.TabIndex = 24;
            btnChoseImage.Text = "Chọn ảnh";
            btnChoseImage.UseVisualStyleBackColor = true;
            btnChoseImage.Click += btnChoseImage_Click;
            // 
            // pbFoodImage
            // 
            pbFoodImage.Location = new Point(280, 328);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(137, 137);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 23;
            pbFoodImage.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(74, 74, 74);
            label17.Location = new Point(16, 328);
            label17.Name = "label17";
            label17.Size = new Size(71, 31);
            label17.TabIndex = 22;
            label17.Text = "Ảnh:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFoodName
            // 
            tbFoodName.BackColor = Color.White;
            tbFoodName.Cursor = Cursors.IBeam;
            tbFoodName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbFoodName.ForeColor = Color.FromArgb(74, 74, 74);
            tbFoodName.Location = new Point(16, 126);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new Size(406, 29);
            tbFoodName.TabIndex = 21;
            tbFoodName.KeyPress += tbString_KeyPress;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbFoodCategory.ForeColor = Color.FromArgb(74, 74, 74);
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(16, 199);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(406, 29);
            cbFoodCategory.TabIndex = 20;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            nmFoodPrice.ForeColor = Color.FromArgb(74, 74, 74);
            nmFoodPrice.Location = new Point(16, 274);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(406, 29);
            nmFoodPrice.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(74, 74, 74);
            label8.Location = new Point(16, 240);
            label8.Name = "label8";
            label8.Size = new Size(63, 31);
            label8.TabIndex = 18;
            label8.Text = "Giá:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(74, 74, 74);
            label7.Location = new Point(16, 170);
            label7.Name = "label7";
            label7.Size = new Size(158, 31);
            label7.TabIndex = 17;
            label7.Text = "Danh mục: ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(16, 97);
            label3.Name = "label3";
            label3.Size = new Size(176, 31);
            label3.TabIndex = 15;
            label3.Text = "Tên món ăn:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFoodID
            // 
            tbFoodID.BackColor = Color.FromArgb(179, 179, 179);
            tbFoodID.BorderStyle = BorderStyle.None;
            tbFoodID.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbFoodID.ForeColor = Color.FromArgb(74, 74, 74);
            tbFoodID.Location = new Point(213, 36);
            tbFoodID.Name = "tbFoodID";
            tbFoodID.ReadOnly = true;
            tbFoodID.Size = new Size(209, 39);
            tbFoodID.TabIndex = 12;
            tbFoodID.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(16, 44);
            label4.Name = "label4";
            label4.Size = new Size(157, 31);
            label4.TabIndex = 13;
            label4.Text = "ID món ăn:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(179, 179, 179);
            panel13.Controls.Add(label1);
            panel13.Controls.Add(tbFindFoodName);
            panel13.Location = new Point(869, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(430, 90);
            panel13.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 14;
            label1.Text = "Tìm tên món:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFindFoodName
            // 
            tbFindFoodName.BackColor = Color.White;
            tbFindFoodName.Cursor = Cursors.IBeam;
            tbFindFoodName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbFindFoodName.ForeColor = Color.FromArgb(74, 74, 74);
            tbFindFoodName.Location = new Point(16, 45);
            tbFindFoodName.Name = "tbFindFoodName";
            tbFindFoodName.Size = new Size(401, 29);
            tbFindFoodName.TabIndex = 13;
            tbFindFoodName.TextChanged += btnFindFood_Click;
            tbFindFoodName.KeyPress += tbString_KeyPress;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Silver;
            panel12.Controls.Add(dtgvFoodList);
            panel12.Location = new Point(7, 98);
            panel12.Name = "panel12";
            panel12.Size = new Size(856, 482);
            panel12.TabIndex = 5;
            // 
            // dtgvFoodList
            // 
            dtgvFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFoodList.BackgroundColor = Color.FromArgb(179, 179, 179);
            dtgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFoodList.GridColor = Color.FromArgb(74, 74, 74);
            dtgvFoodList.Location = new Point(4, 3);
            dtgvFoodList.Name = "dtgvFoodList";
            dtgvFoodList.RowHeadersWidth = 51;
            dtgvFoodList.RowTemplate.Height = 29;
            dtgvFoodList.Size = new Size(849, 476);
            dtgvFoodList.TabIndex = 0;
            dtgvFoodList.SelectionChanged += dtgvFoodList_SelectedChanged;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(179, 179, 179);
            panel11.Controls.Add(btnResetFoodList);
            panel11.Controls.Add(btnShowFood);
            panel11.Controls.Add(btnUpdateFood);
            panel11.Controls.Add(btnDeleteFood);
            panel11.Controls.Add(btnAddFood);
            panel11.ForeColor = Color.FromArgb(74, 74, 74);
            panel11.Location = new Point(7, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(856, 90);
            panel11.TabIndex = 2;
            // 
            // btnResetFoodList
            // 
            btnResetFoodList.Cursor = Cursors.Hand;
            btnResetFoodList.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetFoodList.ForeColor = Color.FromArgb(74, 74, 74);
            btnResetFoodList.Location = new Point(676, 3);
            btnResetFoodList.Name = "btnResetFoodList";
            btnResetFoodList.Size = new Size(130, 85);
            btnResetFoodList.TabIndex = 4;
            btnResetFoodList.Text = "Làm mới";
            btnResetFoodList.UseVisualStyleBackColor = true;
            btnResetFoodList.Click += btnResetFoodList_Click;
            // 
            // btnShowFood
            // 
            btnShowFood.Cursor = Cursors.Hand;
            btnShowFood.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowFood.Location = new Point(519, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(130, 85);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem theo danh mục";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Cursor = Cursors.Hand;
            btnUpdateFood.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateFood.Location = new Point(362, 3);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(130, 85);
            btnUpdateFood.TabIndex = 2;
            btnUpdateFood.Text = "Chỉnh sửa";
            btnUpdateFood.UseVisualStyleBackColor = true;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Cursor = Cursors.Hand;
            btnDeleteFood.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnDeleteFood.Location = new Point(205, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(130, 85);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.FromArgb(74, 74, 74);
            btnAddFood.Location = new Point(48, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(130, 85);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // tbStaff
            // 
            tbStaff.Controls.Add(panel16);
            tbStaff.Controls.Add(panel15);
            tbStaff.Controls.Add(panel8);
            tbStaff.Controls.Add(panel5);
            tbStaff.Location = new Point(4, 29);
            tbStaff.Name = "tbStaff";
            tbStaff.Padding = new Padding(3);
            tbStaff.Size = new Size(1297, 580);
            tbStaff.TabIndex = 4;
            tbStaff.Text = "Nhân viên";
            tbStaff.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(179, 179, 179);
            panel16.Controls.Add(label19);
            panel16.Controls.Add(tbFindStaffName);
            panel16.Location = new Point(869, 5);
            panel16.Name = "panel16";
            panel16.Size = new Size(430, 90);
            panel16.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(74, 74, 74);
            label19.Location = new Point(16, 13);
            label19.Name = "label19";
            label19.Size = new Size(265, 31);
            label19.TabIndex = 14;
            label19.Text = "Tìm tên nhân viên:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFindStaffName
            // 
            tbFindStaffName.BackColor = Color.White;
            tbFindStaffName.Cursor = Cursors.IBeam;
            tbFindStaffName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbFindStaffName.ForeColor = Color.FromArgb(74, 74, 74);
            tbFindStaffName.Location = new Point(16, 47);
            tbFindStaffName.Name = "tbFindStaffName";
            tbFindStaffName.Size = new Size(390, 29);
            tbFindStaffName.TabIndex = 13;
            tbFindStaffName.TextChanged += tbFindStaffName_TextChanged;
            tbFindStaffName.KeyPress += tbString_KeyPress;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(179, 179, 179);
            panel15.Controls.Add(cbStaffRole);
            panel15.Controls.Add(label9);
            panel15.Controls.Add(tbStaffEmail);
            panel15.Controls.Add(label14);
            panel15.Controls.Add(tbStaffPhone);
            panel15.Controls.Add(label13);
            panel15.Controls.Add(tbStaffName);
            panel15.Controls.Add(label11);
            panel15.Controls.Add(tbStaffID);
            panel15.Controls.Add(label12);
            panel15.Location = new Point(869, 99);
            panel15.Name = "panel15";
            panel15.Size = new Size(432, 481);
            panel15.TabIndex = 7;
            // 
            // cbStaffRole
            // 
            cbStaffRole.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbStaffRole.ForeColor = Color.FromArgb(74, 74, 74);
            cbStaffRole.FormattingEnabled = true;
            cbStaffRole.Location = new Point(16, 151);
            cbStaffRole.Name = "cbStaffRole";
            cbStaffRole.Size = new Size(390, 29);
            cbStaffRole.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(74, 74, 74);
            label9.Location = new Point(16, 117);
            label9.Name = "label9";
            label9.Size = new Size(89, 31);
            label9.TabIndex = 30;
            label9.Text = "Vị trí:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffEmail
            // 
            tbStaffEmail.BackColor = Color.White;
            tbStaffEmail.Cursor = Cursors.IBeam;
            tbStaffEmail.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffEmail.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffEmail.Location = new Point(16, 318);
            tbStaffEmail.Name = "tbStaffEmail";
            tbStaffEmail.Size = new Size(390, 29);
            tbStaffEmail.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(74, 74, 74);
            label14.Location = new Point(16, 289);
            label14.Name = "label14";
            label14.Size = new Size(95, 31);
            label14.TabIndex = 28;
            label14.Text = "Email:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffPhone
            // 
            tbStaffPhone.BackColor = Color.White;
            tbStaffPhone.Cursor = Cursors.IBeam;
            tbStaffPhone.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffPhone.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffPhone.Location = new Point(16, 411);
            tbStaffPhone.Name = "tbStaffPhone";
            tbStaffPhone.Size = new Size(390, 29);
            tbStaffPhone.TabIndex = 25;
            tbStaffPhone.MaxLength = 10;
            tbStaffPhone.KeyPress += tbStaffPhone_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(74, 74, 74);
            label13.Location = new Point(16, 377);
            label13.Name = "label13";
            label13.Size = new Size(183, 31);
            label13.TabIndex = 26;
            label13.Text = "Số điện thoại:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffName
            // 
            tbStaffName.BackColor = Color.White;
            tbStaffName.Cursor = Cursors.IBeam;
            tbStaffName.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffName.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffName.Location = new Point(16, 239);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.Size = new Size(390, 29);
            tbStaffName.TabIndex = 14;
            tbStaffName.KeyPress += tbString_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(74, 74, 74);
            label11.Location = new Point(16, 210);
            label11.Name = "label11";
            label11.Size = new Size(211, 31);
            label11.TabIndex = 15;
            label11.Text = "Tên nhân viên:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffID
            // 
            tbStaffID.BackColor = Color.White;
            tbStaffID.Cursor = Cursors.IBeam;
            tbStaffID.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffID.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffID.Location = new Point(16, 70);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(390, 29);
            tbStaffID.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(74, 74, 74);
            label12.Location = new Point(16, 41);
            label12.Name = "label12";
            label12.Size = new Size(192, 31);
            label12.TabIndex = 13;
            label12.Text = "ID nhân viên:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Controls.Add(dtgvStaffList);
            panel8.Location = new Point(7, 98);
            panel8.Name = "panel8";
            panel8.Size = new Size(856, 482);
            panel8.TabIndex = 6;
            // 
            // dtgvStaffList
            // 
            dtgvStaffList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStaffList.BackgroundColor = Color.FromArgb(179, 179, 179);
            dtgvStaffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStaffList.GridColor = Color.FromArgb(74, 74, 74);
            dtgvStaffList.Location = new Point(4, 3);
            dtgvStaffList.Name = "dtgvStaffList";
            dtgvStaffList.RowHeadersWidth = 51;
            dtgvStaffList.RowTemplate.Height = 29;
            dtgvStaffList.Size = new Size(849, 476);
            dtgvStaffList.TabIndex = 0;
            dtgvStaffList.SelectionChanged += dtgvStaffList_SelectionChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(179, 179, 179);
            panel5.Controls.Add(btnShowStaffByRole);
            panel5.Controls.Add(btnShowAccount);
            panel5.Controls.Add(btnDeleteAccount);
            panel5.Controls.Add(btnAddAccount);
            panel5.Location = new Point(7, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(856, 90);
            panel5.TabIndex = 3;
            // 
            // btnShowStaffByRole
            // 
            btnShowStaffByRole.Cursor = Cursors.Hand;
            btnShowStaffByRole.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowStaffByRole.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowStaffByRole.Location = new Point(465, 2);
            btnShowStaffByRole.Name = "btnShowStaffByRole";
            btnShowStaffByRole.Size = new Size(130, 85);
            btnShowStaffByRole.TabIndex = 4;
            btnShowStaffByRole.Text = "    Xem theo          vị trí     ";
            btnShowStaffByRole.UseVisualStyleBackColor = true;
            btnShowStaffByRole.Click += btnShowStaffByRole_Click;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Cursor = Cursors.Hand;
            btnShowAccount.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowAccount.ForeColor = Color.FromArgb(74, 74, 74);
            btnShowAccount.Location = new Point(669, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(130, 85);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Làm mới";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Cursor = Cursors.Hand;
            btnDeleteAccount.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAccount.ForeColor = Color.FromArgb(74, 74, 74);
            btnDeleteAccount.Location = new Point(253, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(130, 85);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Cursor = Cursors.Hand;
            btnAddAccount.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAccount.ForeColor = Color.FromArgb(74, 74, 74);
            btnAddAccount.Location = new Point(48, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(130, 85);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // tpStoreInfo
            // 
            tpStoreInfo.BackColor = Color.FromArgb(179, 179, 179);
            tpStoreInfo.Controls.Add(btnSubmit);
            tpStoreInfo.Controls.Add(btnUpdateStoreInfo);
            tpStoreInfo.Controls.Add(label25);
            tpStoreInfo.Controls.Add(nmTablePricePerHour);
            tpStoreInfo.Controls.Add(label24);
            tpStoreInfo.Controls.Add(tbStorePhone);
            tpStoreInfo.Controls.Add(label23);
            tpStoreInfo.Controls.Add(tbStoreAddress);
            tpStoreInfo.Controls.Add(label22);
            tpStoreInfo.Controls.Add(tbStoreName);
            tpStoreInfo.Controls.Add(label21);
            tpStoreInfo.Location = new Point(4, 29);
            tpStoreInfo.Name = "tpStoreInfo";
            tpStoreInfo.Padding = new Padding(3);
            tpStoreInfo.Size = new Size(1297, 580);
            tpStoreInfo.TabIndex = 6;
            tpStoreInfo.Text = "Thông tin cửa hàng";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.FromArgb(74, 74, 74);
            btnSubmit.Location = new Point(121, 487);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(1054, 53);
            btnSubmit.TabIndex = 27;
            btnSubmit.Text = "Cập nhật";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdateStoreInfo
            // 
            btnUpdateStoreInfo.BackColor = Color.Transparent;
            btnUpdateStoreInfo.Cursor = Cursors.Hand;
            btnUpdateStoreInfo.FlatAppearance.BorderSize = 0;
            btnUpdateStoreInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdateStoreInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnUpdateStoreInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateStoreInfo.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStoreInfo.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateStoreInfo.Location = new Point(121, 487);
            btnUpdateStoreInfo.Name = "btnUpdateStoreInfo";
            btnUpdateStoreInfo.Size = new Size(1054, 53);
            btnUpdateStoreInfo.TabIndex = 26;
            btnUpdateStoreInfo.Text = "Chỉnh sửa";
            btnUpdateStoreInfo.UseVisualStyleBackColor = false;
            btnUpdateStoreInfo.Click += btnUpdateStoreInfo_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.FlatStyle = FlatStyle.Flat;
            label25.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(74, 74, 74);
            label25.Location = new Point(465, 47);
            label25.Name = "label25";
            label25.Size = new Size(375, 47);
            label25.TabIndex = 25;
            label25.Text = "Thông tin cửa hàng";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nmTablePricePerHour
            // 
            nmTablePricePerHour.BackColor = Color.FromArgb(179, 179, 179);
            nmTablePricePerHour.BorderStyle = BorderStyle.FixedSingle;
            nmTablePricePerHour.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nmTablePricePerHour.ForeColor = Color.FromArgb(74, 74, 74);
            nmTablePricePerHour.Location = new Point(781, 378);
            nmTablePricePerHour.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nmTablePricePerHour.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmTablePricePerHour.Name = "nmTablePricePerHour";
            nmTablePricePerHour.ReadOnly = true;
            nmTablePricePerHour.Size = new Size(394, 39);
            nmTablePricePerHour.TabIndex = 24;
            nmTablePricePerHour.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.FlatStyle = FlatStyle.Flat;
            label24.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.FromArgb(74, 74, 74);
            label24.Location = new Point(781, 328);
            label24.Name = "label24";
            label24.Size = new Size(322, 47);
            label24.TabIndex = 23;
            label24.Text = "Giá bàn một giờ:";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStorePhone
            // 
            tbStorePhone.BackColor = Color.FromArgb(179, 179, 179);
            tbStorePhone.BorderStyle = BorderStyle.None;
            tbStorePhone.Cursor = Cursors.IBeam;
            tbStorePhone.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbStorePhone.ForeColor = Color.FromArgb(74, 74, 74);
            tbStorePhone.Location = new Point(781, 197);
            tbStorePhone.Name = "tbStorePhone";
            tbStorePhone.ReadOnly = true;
            tbStorePhone.Size = new Size(394, 36);
            tbStorePhone.TabIndex = 20;
            tbStorePhone.MaxLength = 10;
            tbStorePhone.KeyPress += tbStaffPhone_KeyPress;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.FlatStyle = FlatStyle.Flat;
            label23.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(74, 74, 74);
            label23.Location = new Point(781, 147);
            label23.Name = "label23";
            label23.Size = new Size(271, 47);
            label23.TabIndex = 21;
            label23.Text = "Số điện thoại:";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStoreAddress
            // 
            tbStoreAddress.BackColor = Color.FromArgb(179, 179, 179);
            tbStoreAddress.BorderStyle = BorderStyle.None;
            tbStoreAddress.Cursor = Cursors.IBeam;
            tbStoreAddress.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbStoreAddress.ForeColor = Color.FromArgb(74, 74, 74);
            tbStoreAddress.Location = new Point(121, 378);
            tbStoreAddress.Name = "tbStoreAddress";
            tbStoreAddress.ReadOnly = true;
            tbStoreAddress.Size = new Size(540, 36);
            tbStoreAddress.TabIndex = 18;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(74, 74, 74);
            label22.Location = new Point(121, 328);
            label22.Name = "label22";
            label22.Size = new Size(158, 47);
            label22.TabIndex = 19;
            label22.Text = "Địa chỉ:";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStoreName
            // 
            tbStoreName.BackColor = Color.FromArgb(179, 179, 179);
            tbStoreName.BorderStyle = BorderStyle.None;
            tbStoreName.Cursor = Cursors.IBeam;
            tbStoreName.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbStoreName.ForeColor = Color.FromArgb(74, 74, 74);
            tbStoreName.Location = new Point(121, 197);
            tbStoreName.Name = "tbStoreName";
            tbStoreName.ReadOnly = true;
            tbStoreName.Size = new Size(540, 36);
            tbStoreName.TabIndex = 16;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.FlatStyle = FlatStyle.Flat;
            label21.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(74, 74, 74);
            label21.Location = new Point(121, 147);
            label21.Name = "label21";
            label21.Size = new Size(276, 47);
            label21.TabIndex = 17;
            label21.Text = "Tên cửa hàng:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetPicture
            // 
            btnResetPicture.Cursor = Cursors.Hand;
            btnResetPicture.ForeColor = Color.FromArgb(74, 74, 74);
            btnResetPicture.Location = new Point(16, 415);
            btnResetPicture.Name = "btnResetPicture";
            btnResetPicture.Size = new Size(252, 47);
            btnResetPicture.TabIndex = 25;
            btnResetPicture.Text = "Quay về ảnh mặc định";
            btnResetPicture.UseVisualStyleBackColor = true;
            btnResetPicture.Click += btnResetPicture_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1312, 648);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAdmin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdmin";
            tabControl1.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBillByDate).EndInit();
            panel1.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTableList).EndInit();
            panel3.ResumeLayout(false);
            tbCategory.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategoryList).EndInit();
            panel7.ResumeLayout(false);
            tbFood.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFoodList).EndInit();
            panel11.ResumeLayout(false);
            tbStaff.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStaffList).EndInit();
            panel5.ResumeLayout(false);
            tpStoreInfo.ResumeLayout(false);
            tpStoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmTablePricePerHour).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private TabControl tabControl1;
        private TabPage tpBill;
        private Panel panel2;
        private DataGridView dtgvBillByDate;
        private Panel panel1;
        private Button btnShowReport;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private TabPage tpTable;
        private Panel panel4;
        private Panel panel3;
        private TabPage tbCategory;
        private TabPage tbFood;
        private TabPage tbStaff;
        private Panel panel6;
        private Panel panel5;
        private Button btnFindTable;
        private DataGridView dtgvTableList;
        private Button btnShowTable;
        private Button btnUpdateTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private TextBox textBox1;
        private TextBox tbStaffName;
        private Label label2;
        private TextBox tbDisplayName;
        private Label lbDisplayName;
        private TextBox tbTableID;
        private Label lbUserName;
        private TextBox tbFindTableName;
        private Panel panel10;
        private TextBox tbCategoryName;
        private Label label5;
        private TextBox tbCategoryID;
        private Label label6;
        private Panel panel9;
        private DataGridView dtgvCategoryList;
        private Panel panel8;
        private TextBox tbFindCategoryName;
        private Button btnFindCategory;
        private Panel panel7;
        private Button btnShowCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel13;
        private TextBox tbFindFoodName;
        private Panel panel12;
        private DataGridView dtgvFoodList;
        private Panel panel11;
        private Button btnShowFood;
        private Button btnUpdateFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel14;
        private TextBox textBox4;
        private Label label3;
        private TextBox tbFoodID;
        private Label label4;
        private ComboBox cbFoodCategory;
        private NumericUpDown nmFoodPrice;
        private Label label8;
        private Label label7;
        private Panel panel15;
        private Label label11;
        private TextBox tbStaffID;
        private Label label12;
        private DataGridView dtgvStaffList;
        private Button btnShowAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private TextBox tbTableType;
        private TextBox tbTableName;
        private TextBox tbFoodName;
        private TextBox tbStaffPhone;
        private Label label13;
        private Panel panel16;
        private TextBox tbFindStaffName;
        private TextBox tbPage;
        private Button btnNextPage;
        private Button btnPrePage;
        private Button btnLastPage;
        private Button btnFirstPage;
        private Label label9;
        private TextBox tbStaffEmail;
        private Label label14;
        private PictureBox pbFoodImage;
        private Label label17;
        private Button btnChoseImage;
        private Button btnResetFoodList;
        private Panel panel20;
        private TextBox tbFindTable;
        private Panel panel21;
        private TextBox tbFindCategory;
        private Label label1;
        private Label label10;
        private Label label18;
        private Label label19;
        private ComboBox cbStaffRole;
        private Button btnShowStaffByRole;
        private TabPage tpStoreInfo;
        private Label label24;
        private TextBox tbStorePhone;
        private Label label23;
        private TextBox tbStoreAddress;
        private Label label22;
        private TextBox tbStoreName;
        private Label label21;
        private Label label25;
        private NumericUpDown nmTablePricePerHour;
        private Button btnUpdateStoreInfo;
        private Button btnSubmit;
        private Button btnResetPicture;
    }
}