using BilliardManagamentSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardManagamentSystem
{
    public partial class fForgotPassword : Form
    {
        public fForgotPassword()
        {
            InitializeComponent();
        }
        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi trang này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
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
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string staffID = tbStaffID.Text.Trim();
            string staffEmail = tbStaffEmail.Text.Trim();

            if(IsValidEmail(staffEmail))
            {
                if (StaffDAO.Instance.CheckEmail(staffID, staffEmail))
                {
                    MessageBox.Show("Mã OTP đã được gửi vào Email của bạn!", "Thông báo");
                    string otp = OTP();
                    SendOTP(staffEmail, otp);
                    lbOtpTitle.Tag = otp;
                    pnlInserting.Enabled = false;
                    pnlOTP.Enabled = true;
                    return;
                }
            }

            else
            {
                MessageBox.Show("Email không đúng!\nVui lòng thử lại!", "Thông báo");
                return;
            }
        }
        int tried = 0;
        private void btnSubmitOTP_Click(object sender, EventArgs e)
        {
            string insertOTP = numericUpDown1.Value.ToString() + numericUpDown2.Value.ToString() + numericUpDown3.Value.ToString() + numericUpDown4.Value.ToString() + numericUpDown5.Value.ToString() + numericUpDown6.Value.ToString();
            if (insertOTP.Equals(lbOtpTitle.Tag.ToString()))
            {
                MessageBox.Show("Xác nhận thành công!", "Thông báo");
                pnlOTP.Enabled = false;
                pnlChangePassword.Enabled = true;
                CreateCaptcha();
                return;
            }
            else
            {
                tried++;
                if (tried == 3)
                {
                    MessageBox.Show("Hệ thống đã gửi lại mã OTP mới vào Email!\n", "Thông báo");
                    string otp = OTP();
                    SendOTP(tbStaffEmail.Text.Trim(), otp);
                    lbOtpTitle.Tag = otp;
                    tried = 0;
                    return;
                }
                MessageBox.Show("Mã OTP không chính xác!\nVui lòng thử lại!" + string.Format("\nCòn {0} lần thử!", 3 - tried), "Thông báo");
            }
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
        public string OTP()
        {
            Random random = new Random();
            int otpLength = 6;
            string otp = "";

            for (int i = 0; i < otpLength; i++)
            {
                otp += random.Next(0, 9).ToString();
            }
            return otp;
        }
        void SendOTP(string staffEmail, string OTP)
        {
            string senderEmail = StoreDAO.Instance.StoreInfo().Email;
            string senderPassword = StoreDAO.Instance.StoreInfo().Password;


            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(senderEmail);
            mailMessage.To.Add(staffEmail);
            mailMessage.Subject = "MÃ XÁC THỰC HỆ THÔNG QUẢN LÍ BILLIARD";
            mailMessage.Body = $"Mã OTP của bạn: {OTP}\nKhông chia sẻ mã này cho bất cứ ai!";


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.Send(mailMessage);
        }

        bool IsValidEmail(string email)
        {
            if (email.Contains("@gmailcom"))
            {
                return true;
            }
            return false;
        }

        void ChangePassword()
        {
            if (tbCaptcha.Text == lbCaptcha.Text)
            {

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
                if (AccountDAO.Instance.ChangePassWord(tbStaffID.Text.Trim(), tbNewPassWord.Text))
                {
                    MessageBox.Show("Cập nhật mật khẩu mới thành công!\nVui lòng đăng nhập lại!", "Thông báo");
                    Close();
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

        #endregion
    }
}
