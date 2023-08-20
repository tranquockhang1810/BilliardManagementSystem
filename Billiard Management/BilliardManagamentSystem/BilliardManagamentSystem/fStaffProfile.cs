using BilliardManagamentSystem.DAO;
using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardManagamentSystem
{
    public partial class fStaffProfile : Form
    {
        private Staff loginStaff;
        private Account loginAcc;

        public Staff LoginStaff { get => loginStaff; set => loginStaff = value; }
        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        public fStaffProfile(Account loginAcc)
        {
            InitializeComponent();
            LoginAcc = loginAcc;
            LoginStaff = StaffDAO.Instance.GetStaffByStaffID(LoginAcc.StaffID);
        }

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void OnlyString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            CreateCaptcha();
            LoadStaffProfile();
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdatePassword.Font = new Font("Cambria", 20, FontStyle.Bold);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdatePassword.Font = new Font("Cambria", 16, FontStyle.Bold);
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            tbNewPassWord.UseSystemPasswordChar = !tbNewPassWord.UseSystemPasswordChar;
            if (tbNewPassWord.UseSystemPasswordChar)
            {
                btnEye.BackgroundImage = Properties.Resources.eyeClose;
            }
            else
            {
                btnEye.BackgroundImage = Properties.Resources.eyeOpen;
            }
        }

        private void btnEye2_Click(object sender, EventArgs e)
        {
            tbNewPassWordAgain.UseSystemPasswordChar = !tbNewPassWordAgain.UseSystemPasswordChar;
            if (tbNewPassWordAgain.UseSystemPasswordChar)
            {
                btnEye2.BackgroundImage = Properties.Resources.eyeClose;
            }
            else
            {
                btnEye2.BackgroundImage = Properties.Resources.eyeOpen;
            }
        }

        private void btnEye1_Click(object sender, EventArgs e)
        {
            tbOldPassWord.UseSystemPasswordChar = !tbOldPassWord.UseSystemPasswordChar;
            if (tbOldPassWord.UseSystemPasswordChar)
            {
                btnEye1.BackgroundImage = Properties.Resources.eyeClose;
            }
            else
            {
                btnEye1.BackgroundImage = Properties.Resources.eyeOpen;
            }
        }

        private void btnUpdatePersonalInfo_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdateStaffInfo.Font = new Font("Cambria", 20, FontStyle.Bold);
        }

        private void btnUpdatePersonalInfo_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateStaffInfo.Font = new Font("Cambria", 16, FontStyle.Bold);
        }

        private void btnUpdatePersonalInfo_Click(object sender, EventArgs e)
        {
            ChangeReadOnlyPropety();
            ChangeTextBoxColorToWhite();
        }
        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            string newName = tbStaffName.Text;
            string newEmail = tbStaffEmail.Text;
            string newPhone = tbStaffPhone.Text;
            string staffID = lbStaffID.Text;


            if (StaffDAO.Instance.UpdateProfile(staffID, newName, newEmail, newPhone))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật!\nVui lòng thử lại!", "Thông báo");
            }
            ChangeReadOnlyPropety();
            ChangeTextBoxColorToTran();
        }
        private void btnChangeProfile_MouseMove(object sender, MouseEventArgs e)
        {
            btnChangeProfile.Font = new Font("Cambria", 20, FontStyle.Bold);
        }

        private void btnChangeProfile_MouseLeave(object sender, EventArgs e)
        {
            btnChangeProfile.Font = new Font("Cambria", 16, FontStyle.Bold);
        }
        #endregion

        #region Methods
        public void CreateCaptcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                    {
                        break;
                    }
                }
            } while (true);
            lbCaptcha.Text = captcha;
        }
        void ChangeReadOnlyPropety()
        {
            tbStaffName.ReadOnly = !tbStaffName.ReadOnly;
            tbStaffEmail.ReadOnly = !tbStaffEmail.ReadOnly;
            tbStaffPhone.ReadOnly = !tbStaffPhone.ReadOnly;

            btnUpdateStaffInfo.Visible = !btnUpdateStaffInfo.Visible;
            btnUpdateStaffInfo.Enabled = !btnUpdateStaffInfo.Enabled;

            btnChangeProfile.Enabled = !btnChangeProfile.Enabled;
            btnChangeProfile.Visible = !btnChangeProfile.Visible;
        }
        void ChangeTextBoxColorToWhite()
        {
            tbStaffName.BackColor = Color.White;
            tbStaffEmail.BackColor = Color.White;
            tbStaffPhone.BackColor = Color.White;
            tbStaffName.Cursor = Cursors.IBeam;
            tbStaffEmail.Cursor = Cursors.IBeam;
            tbStaffPhone.Cursor = Cursors.IBeam;
        }
        void ChangeTextBoxColorToTran()
        {
            tbStaffName.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffEmail.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffPhone.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffName.Cursor = Cursors.Default;
            tbStaffEmail.Cursor = Cursors.Default;
            tbStaffPhone.Cursor = Cursors.Default;
        }
        void LoadStaffProfile()
        {
            lbStaffID.Text = LoginStaff.StaffID;
            lbStaffRole.Text = StaffDAO.Instance.GetStaffRoleName(LoginStaff.RoleID);
            tbStaffName.Text = LoginStaff.StaffName;
            tbStaffEmail.Text = LoginStaff.StaffEmail;
            tbStaffPhone.Text = LoginStaff.StaffPhone;
        }


        void ChangePassword()
        {
            if (tbCaptcha.Text == lbCaptcha.Text)
            {
                if (AccountDAO.Instance.CheckPassword(tbOldPassWord.Text, LoginAcc.Password))
                {
                    if (tbNewPassWord.Text == tbOldPassWord.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông báo");
                        CreateCaptcha();
                        return;
                    }
                    if (tbNewPassWord.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Mật khẩu mới phải dài hơi hoặc bằng 8 kí tự và không có khoảng trắng ở đầu và cuối mật khẩu!", "Thông báo");
                        CreateCaptcha();
                        return;
                    }
                    if (tbNewPassWord.Text != tbNewPassWordAgain.Text)
                    {
                        MessageBox.Show("Mật khẩu được nhập lại không khớp với mật khẩu mới!", "Thông báo");
                        CreateCaptcha();
                        return;
                    }
                    if (AccountDAO.Instance.ChangePassWord(LoginAcc.StaffID, tbNewPassWord.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu mới thành công!", "Thông báo");
                        Clear();
                        CreateCaptcha();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo");
                    CreateCaptcha();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mã Captcha không chính xác!", "Thông báo");
                CreateCaptcha();
                return;
            }
        }
        void Clear()
        {
            tbOldPassWord.Text = string.Empty;
            tbNewPassWord.Text = string.Empty;
            tbNewPassWordAgain.Text = string.Empty;
            tbCaptcha.Text = string.Empty;
        }
        #endregion

        private void tbStaffName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
