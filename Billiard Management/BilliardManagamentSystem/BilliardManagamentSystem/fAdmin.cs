using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardManagamentSystem.DAO;
using BilliardManagamentSystem.DTO;
using ImageMagick;
using MySql.Data.MySqlClient;

namespace BilliardManagamentSystem
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource roleList = new BindingSource();
        BindingSource staffList = new BindingSource();
        public Account loginAcc;
        public fAdmin()
        {
            InitializeComponent();
            Loading();
        }

        #region Events
        //
        // Nút thoát
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }
        //
        // Tab Doanh thu
        //
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            tbPage.Text = "1";
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int billAmount = BillDAO.Instance.GetBillAmountByDate(dtpFromDate.Value, dtpToDate.Value);

            int lastPage = billAmount / 14;

            if (billAmount % 10 != 0)
            {
                lastPage++;
            }

            tbPage.Text = lastPage.ToString();
        }
        private void tbPage_TextChanged(object sender, EventArgs e)
        {
            LoadBillListByDate(dtpFromDate.Value, dtpToDate.Value);
        }
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbPage.Text);

            if (page > 1)
            {
                page--;
            }
            tbPage.Text = page.ToString();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(tbPage.Text);

            int billAmount = BillDAO.Instance.GetBillAmountByDate(dtpFromDate.Value, dtpToDate.Value);

            int lastPage = billAmount / 14;

            if (page <= lastPage)
            {
                page++;
            }
            tbPage.Text = page.ToString();
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            f.ShowDialog();
        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadBillListByDate(dtpFromDate.Value, dtpToDate.Value);
        }
        //
        //Tab Menu món ăn
        //
        private void dtgvFoodList_SelectedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFoodList.SelectedCells.Count > 0)
                {
                    string categoryName = Convert.ToString(dtgvFoodList.SelectedCells[0].OwningRow.Cells["Tên danh mục"].Value);

                    Category category = CategoryDAO.Instance.GetCategoryByCategoryName(categoryName);

                    List<Category> list = CategoryDAO.Instance.GetCategories();

                    for (int i = 0; i < cbFoodCategory.Items.Count; i++)
                    {
                        if (category.CategoryID == list[i].CategoryID)
                        {
                            cbFoodCategory.SelectedIndex = i;
                        }
                    }

                    string foodImagePath = Convert.ToString(dtgvFoodList.SelectedCells[0].OwningRow.Cells["Hình ảnh"].Value);

                    if (foodImagePath == "Chưa có ảnh")
                    {
                        if (categoryName.Contains("Kem"))
                            pbFoodImage.Image = Properties.Resources.ice_cream;
                        else if (categoryName.Contains("Bia"))
                            pbFoodImage.Image = Properties.Resources.beer;
                        else if (categoryName.Contains("Trà"))
                            pbFoodImage.Image = Properties.Resources.tea;
                        else if (categoryName.Contains("Cafe"))
                            pbFoodImage.Image = Properties.Resources.coffee;
                        else if (categoryName.Contains("Cơm"))
                            pbFoodImage.Image = Properties.Resources.rice;
                        else if (categoryName.Contains("Mì"))
                            pbFoodImage.Image = Properties.Resources.noodle;
                        else if (categoryName.Contains("Giải khát") || categoryName.Contains("Nước ngọt"))
                            pbFoodImage.Image = Properties.Resources.soft_drinks;
                        else if (categoryName.Contains("Ăn vặt") || categoryName.Contains("Snacks"))
                            pbFoodImage.Image = Properties.Resources.snacks;
                    }
                    else
                    {
                        pbFoodImage.Image = Image.FromFile(@foodImagePath);
                    }
                }
            }
            catch { }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {

            if (tbFoodName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên món!", "Thông báo");
                return;
            }
            if (FoodDAO.Instance.IsNotAvailableFoodName(tbFoodName.Text.Trim()))
            {
                MessageBox.Show("Tên món bị trùng!", "Thông báo");
                return;
            }
            Category category = cbFoodCategory.SelectedItem as Category;

            Food food = new Food(tbFoodName.Text, category.CategoryID, (double)nmFoodPrice.Value, (string)@pbFoodImage.Tag);

            if (FoodDAO.Instance.InsertFood(food))
            {
                MessageBox.Show("Thêm món thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món!", "Thông báo");
            }
            LoadFoodList();
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            if (tbFoodName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên món!", "Thông báo");
                return;
            }

            Food food = FoodDAO.Instance.GetFoodByFoodID(Convert.ToInt32(tbFoodID.Text));
            food.FoodName = tbFoodName.Text;
            food.CategoryID = (cbFoodCategory.SelectedItem as Category).CategoryID;
            food.FoodPrice = (double)nmFoodPrice.Value;
            food.FoodImage = (string)@pbFoodImage.Tag;

            if (FoodDAO.Instance.UpdateFood(food))
            {
                MessageBox.Show("Cập nhật món thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật món!", "Thông báo");
            }
            LoadFoodList();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            Food food = FoodDAO.Instance.GetFoodByFoodID(Convert.ToInt32(tbFoodID.Text));

            if (BIllInfoDAO.Instance.CheckDeleteBillInfo(food.FoodID))
            {
                MessageBox.Show("Không thể xóa món khi món này đang có trong hóa đơn của bàn đang hoạt động!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện thao tác xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (FoodDAO.Instance.DeleteFood(food))
                {
                    MessageBox.Show("Xóa món thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa món!", "Thông báo");
                }
                LoadFoodList();
            }
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadFoodByCategory();
        }
        private void btnResetFoodList_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }
        private void btnFindFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = FoodDAO.Instance.SearchFood(tbFindFoodName.Text);
        }
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                using (var image = new MagickImage(imagePath))
                {
                    image.Resize(200, 200);
                    pbFoodImage.Image = MagickImageToBitmap(image);
                    pbFoodImage.Tag = imagePath;
                }
            }
        }
        private void btnResetPicture_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn quay về hình mặc định của món ăn không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Food food = FoodDAO.Instance.GetFoodByFoodID(Convert.ToInt32(tbFoodID.Text));
                if (FoodDAO.Instance.ResetOriginalPicture(food))
                {
                    MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo");
                    LoadFoodList();
                    return;
                }
            }
        }
        //
        //Tab Nhân viên
        //
        private void dtgvStaffList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvStaffList.SelectedCells.Count > 0)
                {
                    string roleName = Convert.ToString(dtgvStaffList.SelectedCells[0].OwningRow.Cells["Vị trí"].Value);

                    Role role = RoleDAO.Instance.GetRoleByName(roleName);

                    List<Role> list = RoleDAO.Instance.GetRoleList();

                    for (int i = 0; i < cbStaffRole.Items.Count; i++)
                    {
                        if (role.ID == list[i].ID)
                        {
                            cbStaffRole.SelectedIndex = i;
                        }
                    }
                }
            }
            catch { }
        }
        private void tbStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (tbStaffID.Text.Trim() == "" || tbStaffName.Text.Trim() == "" || tbStaffEmail.Text.Trim() == "" || tbStaffPhone.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống thông tin!", "Thông báo");
                return;
            }

            if (!IsValidEmail(tbStaffEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo");
                return;
            }

            if (StaffDAO.Instance.IsAvailableStaffID(tbStaffID.Text.Trim(), tbStaffEmail.Text.Trim(), tbStaffPhone.Text.Trim()))
            {
                MessageBox.Show("Thông tin nhân viên đã bị trùng!", "Thông báo");
                return;
            }
            Staff staff = new(tbStaffID.Text, (cbStaffRole.SelectedItem as Role).ID, tbStaffName.Text, tbStaffEmail.Text, tbStaffPhone.Text);
            if (StaffDAO.Instance.InsertStaff(staff))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                Account account = new(staff.StaffID, staff.RoleID);
                account.Password = RandomPassword();
                if (AccountDAO.Instance.InsertAccount(account))
                {
                    MessageBox.Show(string.Format("Hệ thống đã tạo tài khoản đăng nhập thành công!\nTài khoản đăng nhập đã được gửi qua Email của nhân viên!", staff.StaffID), "Thông báo");
                    SendAccount(staff.StaffEmail, staff.StaffID, account.Password);
                }
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            }
            LoadStaffList();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string staffID = Convert.ToString(dtgvStaffList.SelectedCells[0].OwningRow.Cells["ID nhân viên"].Value);

            Staff staff = StaffDAO.Instance.GetStaffByStaffID(staffID);

            if (loginAcc.StaffID.Equals(staffID))
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện thao tác xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (StaffDAO.Instance.DeleteStaff(staff))
                {
                    Account account = AccountDAO.Instance.GetAccountByStaffID(staffID);
                    if (AccountDAO.Instance.DeleteAccount(account))
                    {
                        MessageBox.Show(string.Format("Hệ thống đã xóa tài khoản đăng nhập của ID: {0} thành công!", staff.StaffID), "Thông báo");
                    }
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo");
                }
                LoadStaffList();
            }
        }
        private void btnShowStaffByRole_Click(object sender, EventArgs e)
        {
            int roleID = (cbStaffRole.SelectedItem as Role).ID;
            staffList.DataSource = StaffDAO.Instance.GetStaffListByRole(roleID);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void tbFindStaffName_TextChanged(object sender, EventArgs e)
        {
            staffList.DataSource = StaffDAO.Instance.SearchStaff(tbFindStaffName.Text);
        }
        //
        //Tab Bàn
        //
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (tbTableName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên bàn!", "Thông báo");
                return;
            }
            BilliardTable table = new(tbTableName.Text, tbTableType.Text);
            if (TableDAO.Instance.InsertTable(table))
            {
                MessageBox.Show("Thêm bàn thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Thêm bàn mới thất bại!", "Thông báo");
            }
            LoadTableList();
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            BilliardTable table = TableDAO.Instance.GetTableByID(Convert.ToInt32(tbTableID.Text));
            if (table.Status == "Có người")
            {
                MessageBox.Show("Không thể xóa bàn đang có người!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện thao tác xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TableDAO.Instance.DeleteTable(table))
                {
                    MessageBox.Show("Xóa bàn thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Xóa bàn thất bại!", "Thông báo");
                }
                LoadTableList();
            }
        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (tbTableName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên bàn!", "Thông báo");
                return;
            }
            BilliardTable table = TableDAO.Instance.GetTableByID(Convert.ToInt32(tbTableID.Text));
            table.Name = tbTableName.Text;
            table.Type = tbTableType.Text;
            if (TableDAO.Instance.UpdateTable(table))
            {
                MessageBox.Show("Cập nhật bàn thành công!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại!", "Thông báo");
            }
            LoadTableList();
        }
        private void tbFindTable_TextChanged(object sender, EventArgs e)
        {
            tableList.DataSource = TableDAO.Instance.SearchTable(tbFindTable.Text);
        }
        //
        //Tab Danh mục món
        //
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (tbCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên danh mục!", "Thông báo");
                return;
            }
            Category category = new(tbCategoryName.Text);
            if (CategoryDAO.Instance.InsertCategory(category))
            {
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại!", "Thông báo");
            }
            LoadCategoryList();
            LoadCategoryComboBox();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category category = CategoryDAO.Instance.GetCategoryByID(Convert.ToInt32(tbCategoryID.Text));
            if (FoodDAO.Instance.GetFoodByCategory(category.CategoryID).Rows.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì còn món ăn thuộc danh mục này!", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện thao tác xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CategoryDAO.Instance.DeleteCategory(category))
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa danh mục thất bại!", "Thông báo");
                }
                LoadCategoryList();
                LoadCategoryComboBox();
            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (tbCategoryName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tên danh mục!", "Thông báo");
                return;
            }
            Category category = CategoryDAO.Instance.GetCategoryByID(Convert.ToInt32(tbCategoryID.Text));
            category.CategoryName = tbCategoryName.Text;
            if (CategoryDAO.Instance.UpdateCategory(category))
            {
                MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục thất bại!", "Thông báo");
            }
            LoadCategoryList();
            LoadCategoryComboBox();
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void tbFindCategotyName_TextChanged(object sender, EventArgs e)
        {
            categoryList.DataSource = CategoryDAO.Instance.SearchCategory(tbFindCategory.Text);
        }
        //
        //Tab Thông tin cửa hàng
        //
        private void btnUpdateStoreInfo_Click(object sender, EventArgs e)
        {
            btnUpdateStoreInfo.Enabled = false;
            btnUpdateStoreInfo.Visible = false;

            btnSubmit.Enabled = true;
            btnSubmit.Visible = true;

            tbStoreName.ReadOnly = !tbStoreName.ReadOnly;
            tbStoreName.BackColor = Color.White;

            tbStoreAddress.ReadOnly = !tbStoreAddress.ReadOnly;
            tbStoreAddress.BackColor = Color.White;

            tbStorePhone.ReadOnly = !tbStorePhone.ReadOnly;
            tbStorePhone.BackColor = Color.White;

            nmTablePricePerHour.ReadOnly = !nmTablePricePerHour.ReadOnly;
            nmTablePricePerHour.BackColor = Color.White;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbStoreName.Text.Trim() == "" || tbStoreAddress.Text.Trim() == "" || tbStorePhone.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống thông tin!", "Thông báo!");
                return;
            }

            Store store = StoreDAO.Instance.StoreInfo();
            store.Name = tbStoreName.Text;
            store.Address = tbStoreAddress.Text;
            store.Phone = tbStorePhone.Text;
            store.PricePerHour = (double)nmTablePricePerHour.Value;

            if (StoreDAO.Instance.UpdateInfo(store))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
            LoadStoreInfo();
        }
        #endregion

        #region Methods
        void Loading()
        {
            GetBindingList();
            LoadDateTimePicker();
            LoadBillListByDate(dtpFromDate.Value, dtpToDate.Value);
            LoadFoodList();
            LoadTableList();
            LoadCategoryList();
            LoadRoleList();
            LoadStaffList();
            AddFoodBinding();
            AddTableBinding();
            AddCategoryBinding();
            AddStaffBinding();
            LoadCategoryComboBox();
            LoadRoleComboBox();
            LoadStoreInfo();
        }
        bool IsValidEmail(string email)
        {

            if (email.Contains("@gmail.com"))
            {
                return true;
            }
            else return false;
        }
        void GetBindingList()
        {
            dtgvFoodList.DataSource = foodList;
            dtgvTableList.DataSource = tableList;
            dtgvCategoryList.DataSource = categoryList;
            dtgvStaffList.DataSource = staffList;
        }
        void LoadStoreInfo()
        {
            Store store = StoreDAO.Instance.StoreInfo();

            btnUpdateStoreInfo.Enabled = true;
            btnUpdateStoreInfo.Visible = true;

            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;

            tbStoreName.Text = store.Name;
            tbStoreName.BackColor = Color.FromArgb(179, 179, 179);
            tbStoreName.ReadOnly = true;

            tbStoreAddress.Text = store.Address;
            tbStoreAddress.BackColor = Color.FromArgb(179, 179, 179);
            tbStoreAddress.ReadOnly = true;

            tbStorePhone.Text = store.Phone;
            tbStorePhone.BackColor = Color.FromArgb(179, 179, 179);
            tbStorePhone.ReadOnly = true;

            nmTablePricePerHour.Value = (decimal)store.PricePerHour;
            nmTablePricePerHour.BackColor = Color.FromArgb(179, 179, 179);
            nmTablePricePerHour.ReadOnly = true;
        }
        void LoadBillListByDate(DateTime fromDate, DateTime toDate)
        {
            dtgvBillByDate.DataSource = BillDAO.Instance.GetBillList(fromDate, toDate, Convert.ToInt32(tbPage.Text), 14);
            dtgvBillByDate.Columns["billID"].HeaderText = "ID hóa đơn";
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;

            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);

            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.Instance.GetStaffList();
        }
        void AddStaffBinding()
        {
            tbStaffID.DataBindings.Add(new Binding("Text", dtgvStaffList.DataSource, "ID nhân viên", true, DataSourceUpdateMode.Never));
            tbStaffName.DataBindings.Add(new Binding("Text", dtgvStaffList.DataSource, "Tên nhân viên", true, DataSourceUpdateMode.Never));
            tbStaffEmail.DataBindings.Add(new Binding("Text", dtgvStaffList.DataSource, "Email", true, DataSourceUpdateMode.Never));
            tbStaffPhone.DataBindings.Add(new Binding("Text", dtgvStaffList.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
        }
        void LoadRoleList()
        {
            roleList.DataSource = RoleDAO.Instance.GetRoleTable();
        }
        void LoadCategoryList()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetCategoryList();
        }
        void AddCategoryBinding()
        {
            tbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategoryList.DataSource, "ID danh mục", true, DataSourceUpdateMode.Never));
            tbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategoryList.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }
        void LoadTableList()
        {
            tableList.DataSource = TableDAO.Instance.GetTableListForAdmin();
        }
        void AddTableBinding()
        {
            tbTableID.DataBindings.Add(new Binding("Text", dtgvTableList.DataSource, "ID bàn", true, DataSourceUpdateMode.Never));
            tbTableName.DataBindings.Add(new Binding("Text", dtgvTableList.DataSource, "Tên bàn", true, DataSourceUpdateMode.Never));
            tbTableType.DataBindings.Add(new Binding("Text", dtgvTableList.DataSource, "Loại bàn", true, DataSourceUpdateMode.Never));
        }
        void LoadFoodList()
        {
            foodList.DataSource = FoodDAO.Instance.GetFoodList();
        }
        void LoadFoodByCategory()
        {
            int categoryID = (cbFoodCategory.SelectedItem as Category).CategoryID;
            foodList.DataSource = FoodDAO.Instance.GetFoodByCategory(categoryID);
        }
        void AddFoodBinding()
        {
            tbFoodID.DataBindings.Add(new Binding("Text", dtgvFoodList.DataSource, "ID món", true, DataSourceUpdateMode.Never));
            tbFoodName.DataBindings.Add(new Binding("Text", dtgvFoodList.DataSource, "Tên món", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFoodList.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryComboBox()
        {
            cbFoodCategory.DataSource = CategoryDAO.Instance.GetCategories();
            cbFoodCategory.DisplayMember = "categoryName";
        }
        void LoadRoleComboBox()
        {
            cbStaffRole.DataSource = RoleDAO.Instance.GetRoleList();
            cbStaffRole.DisplayMember = "Name";
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
        public string RandomPassword()
        {
            Random rand = new Random();
            int num = 8;
            string pass = "";
            do
            {
                int chr = rand.Next(33, 126);
                pass += (char)chr;
                if (pass.Length == num)
                {
                    break;
                }
            } while (true);
            return pass;
        }
        void SendAccount(string staffEmail, string staffID, string password)
        {
            string senderEmail = StoreDAO.Instance.StoreInfo().Email;
            string senderPassword = StoreDAO.Instance.StoreInfo().Password;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(staffEmail);
            mailMessage.Subject = "TÀI KHOẢN ĐĂNG NHẬP PHẦN MỀM QUẢN LÝ CỬA HÀNG BILLIARD";
            mailMessage.Body = string.Format("Đây là tài khoản đăng nhập vào phần mềm!\nTuyệt đối không chia sẻ cho bất kì ai!\n\nMã nhân viên: {0}\nMật khẩu: {1}\n\nVui lòng đổi mật khẩu ngay sau lần đăng nhập đầu tiên!", staffID, password);

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.Send(mailMessage);
        }
        #endregion

    }
}
