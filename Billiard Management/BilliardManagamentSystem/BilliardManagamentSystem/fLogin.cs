using BilliardManagamentSystem.DAO;
using BilliardManagamentSystem.DTO;

namespace BilliardManagamentSystem
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        #region Events

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            fForgotPassword f = new fForgotPassword();
            Hide();
            f.ShowDialog();
            Show();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string staffID = tbStaffID.Text;
            string passWord = tbPassWord.Text;

            if (Login(staffID, passWord))
            {
                if (tbCaptcha.Text == lbCaptcha.Text)
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByStaffID(staffID);
                    fTableManager f = new fTableManager(loginAccount);
                    Hide();
                    f.ShowDialog();
                    Show();
                    RefreshFormLogin();
                }
                else
                {
                    MessageBox.Show("Sai mã captcha!", "Thông báo");
                    CreateCaptcha();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
                CreateCaptcha();
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

        private void btnEye_Click(object sender, EventArgs e)
        {
            tbPassWord.UseSystemPasswordChar = !tbPassWord.UseSystemPasswordChar;
            if (tbPassWord.UseSystemPasswordChar)
            {
                btnEye.BackgroundImage = Properties.Resources.eyeClose;
            }
            else
            {
                btnEye.BackgroundImage = Properties.Resources.eyeOpen;
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            CreateCaptcha();
        }
        #endregion

        #region Methods
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }
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
        private void RefreshFormLogin()
        {
            tbStaffID.Text = string.Empty;
            tbPassWord.Text = string.Empty;
            tbCaptcha.Text = string.Empty;
            CreateCaptcha();
        }
        #endregion

    }
}