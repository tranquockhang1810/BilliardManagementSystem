namespace BilliardManagamentSystem
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            btnExit = new Button();
            pnlLogin = new Panel();
            btnForgotPassword = new Button();
            btnEye = new Button();
            lbCaptcha = new Label();
            tbCaptcha = new TextBox();
            lbCaptchaTitle = new Label();
            tbPassWord = new TextBox();
            btLogin = new Button();
            tbStaffID = new TextBox();
            lbPassWord = new Label();
            lbUserName = new Label();
            pnlLogin.SuspendLayout();
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
            btnExit.Font = new Font("Snap ITC", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(736, 1);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(49, 52);
            btnExit.TabIndex = 4;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btExit_Click;
            btnExit.MouseLeave += btnExit_MouseLeave;
            btnExit.MouseMove += btnExit_MouseMove;
            // 
            // pnlLogin
            // 
            pnlLogin.AutoSize = true;
            pnlLogin.BackColor = Color.Transparent;
            pnlLogin.Controls.Add(btnForgotPassword);
            pnlLogin.Controls.Add(btnEye);
            pnlLogin.Controls.Add(lbCaptcha);
            pnlLogin.Controls.Add(tbCaptcha);
            pnlLogin.Controls.Add(lbCaptchaTitle);
            pnlLogin.Controls.Add(tbPassWord);
            pnlLogin.Controls.Add(btLogin);
            pnlLogin.Controls.Add(tbStaffID);
            pnlLogin.Controls.Add(lbPassWord);
            pnlLogin.Controls.Add(lbUserName);
            pnlLogin.Location = new Point(301, 27);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(461, 399);
            pnlLogin.TabIndex = 1;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.Transparent;
            btnForgotPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnForgotPassword.Cursor = Cursors.Hand;
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            btnForgotPassword.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.Font = new Font("Colonna MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnForgotPassword.ForeColor = Color.White;
            btnForgotPassword.Location = new Point(208, 344);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(177, 41);
            btnForgotPassword.TabIndex = 6;
            btnForgotPassword.Text = "Quên mật khẩu";
            btnForgotPassword.TextAlign = ContentAlignment.MiddleRight;
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnEye
            // 
            btnEye.AutoSize = true;
            btnEye.BackColor = Color.White;
            btnEye.BackgroundImage = Properties.Resources.eyeClose;
            btnEye.BackgroundImageLayout = ImageLayout.Zoom;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Location = new Point(350, 136);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(35, 26);
            btnEye.TabIndex = 5;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // lbCaptcha
            // 
            lbCaptcha.AutoSize = true;
            lbCaptcha.FlatStyle = FlatStyle.Flat;
            lbCaptcha.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptcha.ForeColor = Color.RosyBrown;
            lbCaptcha.Location = new Point(208, 182);
            lbCaptcha.Name = "lbCaptcha";
            lbCaptcha.Size = new Size(0, 29);
            lbCaptcha.TabIndex = 4;
            lbCaptcha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCaptcha
            // 
            tbCaptcha.BackColor = Color.White;
            tbCaptcha.Cursor = Cursors.IBeam;
            tbCaptcha.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCaptcha.ForeColor = Color.Black;
            tbCaptcha.Location = new Point(42, 217);
            tbCaptcha.Name = "tbCaptcha";
            tbCaptcha.Size = new Size(343, 27);
            tbCaptcha.TabIndex = 2;
            // 
            // lbCaptchaTitle
            // 
            lbCaptchaTitle.AutoSize = true;
            lbCaptchaTitle.FlatStyle = FlatStyle.Flat;
            lbCaptchaTitle.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptchaTitle.ForeColor = Color.White;
            lbCaptchaTitle.Location = new Point(42, 183);
            lbCaptchaTitle.Name = "lbCaptchaTitle";
            lbCaptchaTitle.Size = new Size(127, 31);
            lbCaptchaTitle.TabIndex = 3;
            lbCaptchaTitle.Text = "Captcha:";
            lbCaptchaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPassWord
            // 
            tbPassWord.BackColor = Color.White;
            tbPassWord.Cursor = Cursors.IBeam;
            tbPassWord.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassWord.ForeColor = Color.Black;
            tbPassWord.Location = new Point(42, 136);
            tbPassWord.Name = "tbPassWord";
            tbPassWord.Size = new Size(343, 27);
            tbPassWord.TabIndex = 1;
            tbPassWord.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.DarkSeaGreen;
            btLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btLogin.Cursor = Cursors.Hand;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            btLogin.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Colonna MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(42, 280);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(343, 46);
            btLogin.TabIndex = 3;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // tbStaffID
            // 
            tbStaffID.BackColor = Color.White;
            tbStaffID.Cursor = Cursors.IBeam;
            tbStaffID.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffID.ForeColor = Color.Black;
            tbStaffID.Location = new Point(42, 55);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(343, 27);
            tbStaffID.TabIndex = 0;
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.FlatStyle = FlatStyle.Flat;
            lbPassWord.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassWord.ForeColor = Color.White;
            lbPassWord.Location = new Point(42, 102);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(142, 31);
            lbPassWord.TabIndex = 2;
            lbPassWord.Text = "Mật khẩu:";
            lbPassWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.FlatStyle = FlatStyle.Flat;
            lbUserName.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.White;
            lbUserName.Location = new Point(42, 21);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(192, 31);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "ID nhân viên:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginScreen1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 438);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Panel pnlLogin;
        private Label lbUserName;
        private Label lbPassWord;
        private TextBox tbStaffID;
        private Button btLogin;
        private TextBox tbPassWord;
        private TextBox tbCaptcha;
        private Label lbCaptchaTitle;
        private Label lbCaptcha;
        private Button btnEye;
        private Button btnForgotPassword;
    }
}