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
    public partial class fChangePassword : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        public fChangePassword(Account loginAcc)
        {
            InitializeComponent();
            LoginAcc = loginAcc;
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
        void ChangePassword()
        {
            if (tbNewPassWord.Text.Trim().Length < 8)
            {
                MessageBox.Show("Mật khẩu mới phải dài hơi hoặc bằng 8 kí tự và không có khoảng trắng ở đầu và cuối mật khẩu!", "Thông báo");
                return;
            }
            if (tbNewPassWord.Text != tbNewPassWordAgain.Text)
            {
                MessageBox.Show("Mật khẩu được nhập lại không khớp với mật khẩu mới!", "Thông báo");
                return;
            }
            if (AccountDAO.Instance.ChangePassWord(LoginAcc.StaffID, tbNewPassWord.Text))
            {
                MessageBox.Show("Cập nhật mật khẩu mới thành công!", "Thông báo");
                Close();
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
    }
}
