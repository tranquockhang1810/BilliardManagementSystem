namespace BilliardManagamentSystem
{
    partial class fStaffProfile
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
            pnlAccChange = new Panel();
            btnEye1 = new Button();
            btnEye2 = new Button();
            btnEye = new Button();
            lbCaptcha = new Label();
            tbCaptcha = new TextBox();
            lbCaptchaTitle = new Label();
            btnUpdatePassword = new Button();
            tbNewPassWordAgain = new TextBox();
            lbNewPassWordAgain = new Label();
            tbNewPassWord = new TextBox();
            tbOldPassWord = new TextBox();
            lbNewPassWord = new Label();
            lbUserName = new Label();
            lbChangeInfo = new Label();
            tabControl1 = new TabControl();
            tpStaffInfo = new TabPage();
            label1 = new Label();
            panel1 = new Panel();
            lbStaffID = new Label();
            btnUpdateStaffInfo = new Button();
            btnChangeProfile = new Button();
            tbStaffName = new TextBox();
            tbStaffEmail = new TextBox();
            tbStaffPhone = new TextBox();
            lbStaffRole = new Label();
            label13 = new Label();
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tpChangePassword = new TabPage();
            pnlAccChange.SuspendLayout();
            tabControl1.SuspendLayout();
            tpStaffInfo.SuspendLayout();
            panel1.SuspendLayout();
            tpChangePassword.SuspendLayout();
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
            btnExit.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(551, 12);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(39, 41);
            btnExit.TabIndex = 6;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_MouseLeave;
            btnExit.MouseMove += btnExit_MouseMove;
            // 
            // pnlAccChange
            // 
            pnlAccChange.AutoSize = true;
            pnlAccChange.BackColor = Color.Transparent;
            pnlAccChange.Controls.Add(btnEye1);
            pnlAccChange.Controls.Add(btnEye2);
            pnlAccChange.Controls.Add(btnEye);
            pnlAccChange.Controls.Add(lbCaptcha);
            pnlAccChange.Controls.Add(tbCaptcha);
            pnlAccChange.Controls.Add(lbCaptchaTitle);
            pnlAccChange.Controls.Add(btnUpdatePassword);
            pnlAccChange.Controls.Add(tbNewPassWordAgain);
            pnlAccChange.Controls.Add(lbNewPassWordAgain);
            pnlAccChange.Controls.Add(tbNewPassWord);
            pnlAccChange.Controls.Add(tbOldPassWord);
            pnlAccChange.Controls.Add(lbNewPassWord);
            pnlAccChange.Controls.Add(lbUserName);
            pnlAccChange.Location = new Point(3, 80);
            pnlAccChange.Name = "pnlAccChange";
            pnlAccChange.Size = new Size(547, 483);
            pnlAccChange.TabIndex = 8;
            // 
            // btnEye1
            // 
            btnEye1.AutoSize = true;
            btnEye1.BackColor = Color.White;
            btnEye1.BackgroundImage = Properties.Resources.eyeClose;
            btnEye1.BackgroundImageLayout = ImageLayout.Zoom;
            btnEye1.Cursor = Cursors.Hand;
            btnEye1.FlatAppearance.BorderSize = 0;
            btnEye1.FlatStyle = FlatStyle.Flat;
            btnEye1.Location = new Point(458, 48);
            btnEye1.Name = "btnEye1";
            btnEye1.Size = new Size(35, 26);
            btnEye1.TabIndex = 20;
            btnEye1.UseVisualStyleBackColor = false;
            btnEye1.Click += btnEye1_Click;
            // 
            // btnEye2
            // 
            btnEye2.AutoSize = true;
            btnEye2.BackColor = Color.White;
            btnEye2.BackgroundImage = Properties.Resources.eyeClose;
            btnEye2.BackgroundImageLayout = ImageLayout.Zoom;
            btnEye2.Cursor = Cursors.Hand;
            btnEye2.FlatAppearance.BorderSize = 0;
            btnEye2.FlatStyle = FlatStyle.Flat;
            btnEye2.Location = new Point(458, 270);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(35, 26);
            btnEye2.TabIndex = 19;
            btnEye2.UseVisualStyleBackColor = false;
            btnEye2.Click += btnEye2_Click;
            // 
            // btnEye
            // 
            btnEye.AutoSize = true;
            btnEye.BackColor = Color.White;
            btnEye.BackgroundImage = Properties.Resources.eyeClose;
            btnEye.BackgroundImageLayout = ImageLayout.Zoom;
            btnEye.Cursor = Cursors.Hand;
            btnEye.FlatAppearance.BorderSize = 0;
            btnEye.FlatStyle = FlatStyle.Flat;
            btnEye.Location = new Point(458, 160);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(35, 26);
            btnEye.TabIndex = 18;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // lbCaptcha
            // 
            lbCaptcha.AutoSize = true;
            lbCaptcha.FlatStyle = FlatStyle.Flat;
            lbCaptcha.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptcha.ForeColor = Color.RosyBrown;
            lbCaptcha.Location = new Point(233, 333);
            lbCaptcha.Name = "lbCaptcha";
            lbCaptcha.Size = new Size(0, 29);
            lbCaptcha.TabIndex = 17;
            lbCaptcha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCaptcha
            // 
            tbCaptcha.BackColor = Color.White;
            tbCaptcha.Cursor = Cursors.IBeam;
            tbCaptcha.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCaptcha.ForeColor = Color.FromArgb(74, 74, 74);
            tbCaptcha.Location = new Point(22, 365);
            tbCaptcha.Name = "tbCaptcha";
            tbCaptcha.Size = new Size(471, 27);
            tbCaptcha.TabIndex = 15;
            // 
            // lbCaptchaTitle
            // 
            lbCaptchaTitle.AutoSize = true;
            lbCaptchaTitle.FlatStyle = FlatStyle.Flat;
            lbCaptchaTitle.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptchaTitle.ForeColor = Color.FromArgb(74, 74, 74);
            lbCaptchaTitle.Location = new Point(22, 331);
            lbCaptchaTitle.Name = "lbCaptchaTitle";
            lbCaptchaTitle.Size = new Size(127, 31);
            lbCaptchaTitle.TabIndex = 16;
            lbCaptchaTitle.Text = "Captcha:";
            lbCaptchaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.AutoSize = true;
            btnUpdatePassword.Cursor = Cursors.Hand;
            btnUpdatePassword.FlatAppearance.BorderSize = 0;
            btnUpdatePassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdatePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePassword.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdatePassword.Location = new Point(22, 407);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(471, 43);
            btnUpdatePassword.TabIndex = 14;
            btnUpdatePassword.Text = "Cập nhật";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdate_Click;
            btnUpdatePassword.MouseLeave += btnUpdate_MouseLeave;
            btnUpdatePassword.MouseMove += btnUpdate_MouseMove;
            // 
            // tbNewPassWordAgain
            // 
            tbNewPassWordAgain.BackColor = Color.White;
            tbNewPassWordAgain.Cursor = Cursors.IBeam;
            tbNewPassWordAgain.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            tbNewPassWordAgain.Location = new Point(22, 270);
            tbNewPassWordAgain.Name = "tbNewPassWordAgain";
            tbNewPassWordAgain.Size = new Size(471, 27);
            tbNewPassWordAgain.TabIndex = 12;
            tbNewPassWordAgain.UseSystemPasswordChar = true;
            // 
            // lbNewPassWordAgain
            // 
            lbNewPassWordAgain.AutoSize = true;
            lbNewPassWordAgain.FlatStyle = FlatStyle.Flat;
            lbNewPassWordAgain.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWordAgain.Location = new Point(22, 236);
            lbNewPassWordAgain.Name = "lbNewPassWordAgain";
            lbNewPassWordAgain.Size = new Size(316, 31);
            lbNewPassWordAgain.TabIndex = 13;
            lbNewPassWordAgain.Text = "Nhập lại mật khẩu mới:";
            lbNewPassWordAgain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNewPassWord
            // 
            tbNewPassWord.BackColor = Color.White;
            tbNewPassWord.Cursor = Cursors.IBeam;
            tbNewPassWord.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewPassWord.ForeColor = Color.FromArgb(74, 74, 74);
            tbNewPassWord.Location = new Point(22, 160);
            tbNewPassWord.Name = "tbNewPassWord";
            tbNewPassWord.Size = new Size(471, 27);
            tbNewPassWord.TabIndex = 8;
            tbNewPassWord.UseSystemPasswordChar = true;
            // 
            // tbOldPassWord
            // 
            tbOldPassWord.BackColor = Color.White;
            tbOldPassWord.Cursor = Cursors.IBeam;
            tbOldPassWord.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbOldPassWord.ForeColor = Color.Black;
            tbOldPassWord.Location = new Point(22, 48);
            tbOldPassWord.Name = "tbOldPassWord";
            tbOldPassWord.Size = new Size(471, 27);
            tbOldPassWord.TabIndex = 6;
            tbOldPassWord.UseSystemPasswordChar = true;
            // 
            // lbNewPassWord
            // 
            lbNewPassWord.AutoSize = true;
            lbNewPassWord.FlatStyle = FlatStyle.Flat;
            lbNewPassWord.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWord.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWord.Location = new Point(22, 126);
            lbNewPassWord.Name = "lbNewPassWord";
            lbNewPassWord.Size = new Size(277, 31);
            lbNewPassWord.TabIndex = 9;
            lbNewPassWord.Text = "Nhập mật khẩu mới:";
            lbNewPassWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.FlatStyle = FlatStyle.Flat;
            lbUserName.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.ForeColor = Color.FromArgb(74, 74, 74);
            lbUserName.Location = new Point(22, 14);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(257, 31);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "Nhập mật khẩu cũ:";
            lbUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbChangeInfo
            // 
            lbChangeInfo.AutoSize = true;
            lbChangeInfo.BackColor = Color.Transparent;
            lbChangeInfo.FlatStyle = FlatStyle.Flat;
            lbChangeInfo.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbChangeInfo.ForeColor = Color.FromArgb(74, 74, 74);
            lbChangeInfo.Location = new Point(141, 26);
            lbChangeInfo.Name = "lbChangeInfo";
            lbChangeInfo.Size = new Size(254, 31);
            lbChangeInfo.TabIndex = 9;
            lbChangeInfo.Text = "Thay đổi mật khẩu";
            lbChangeInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpStaffInfo);
            tabControl1.Controls.Add(tpChangePassword);
            tabControl1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(25, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 589);
            tabControl1.TabIndex = 10;
            // 
            // tpStaffInfo
            // 
            tpStaffInfo.BackColor = Color.FromArgb(179, 179, 179);
            tpStaffInfo.Controls.Add(label1);
            tpStaffInfo.Controls.Add(panel1);
            tpStaffInfo.Location = new Point(4, 26);
            tpStaffInfo.Name = "tpStaffInfo";
            tpStaffInfo.Padding = new Padding(3);
            tpStaffInfo.Size = new Size(546, 559);
            tpStaffInfo.TabIndex = 0;
            tpStaffInfo.Text = "Thông tin cá nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 36;
            label1.Text = "Thông tin cá nhân";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbStaffID);
            panel1.Controls.Add(btnUpdateStaffInfo);
            panel1.Controls.Add(btnChangeProfile);
            panel1.Controls.Add(tbStaffName);
            panel1.Controls.Add(tbStaffEmail);
            panel1.Controls.Add(tbStaffPhone);
            panel1.Controls.Add(lbStaffRole);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 501);
            panel1.TabIndex = 0;
            // 
            // lbStaffID
            // 
            lbStaffID.FlatStyle = FlatStyle.Flat;
            lbStaffID.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbStaffID.ForeColor = Color.FromArgb(74, 74, 74);
            lbStaffID.Location = new Point(223, 31);
            lbStaffID.Name = "lbStaffID";
            lbStaffID.Size = new Size(317, 36);
            lbStaffID.TabIndex = 45;
            lbStaffID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUpdateStaffInfo
            // 
            btnUpdateStaffInfo.AutoSize = true;
            btnUpdateStaffInfo.Cursor = Cursors.Hand;
            btnUpdateStaffInfo.FlatAppearance.BorderSize = 0;
            btnUpdateStaffInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdateStaffInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnUpdateStaffInfo.FlatStyle = FlatStyle.Flat;
            btnUpdateStaffInfo.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateStaffInfo.ForeColor = Color.FromArgb(74, 74, 74);
            btnUpdateStaffInfo.Location = new Point(32, 436);
            btnUpdateStaffInfo.Name = "btnUpdateStaffInfo";
            btnUpdateStaffInfo.Size = new Size(471, 43);
            btnUpdateStaffInfo.TabIndex = 35;
            btnUpdateStaffInfo.Text = "Chỉnh sửa";
            btnUpdateStaffInfo.UseVisualStyleBackColor = true;
            btnUpdateStaffInfo.Click += btnUpdatePersonalInfo_Click;
            btnUpdateStaffInfo.MouseLeave += btnUpdatePersonalInfo_MouseLeave;
            btnUpdateStaffInfo.MouseMove += btnUpdatePersonalInfo_MouseMove;
            // 
            // btnChangeProfile
            // 
            btnChangeProfile.AutoSize = true;
            btnChangeProfile.Cursor = Cursors.Hand;
            btnChangeProfile.Enabled = false;
            btnChangeProfile.FlatAppearance.BorderSize = 0;
            btnChangeProfile.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChangeProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnChangeProfile.FlatStyle = FlatStyle.Flat;
            btnChangeProfile.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeProfile.ForeColor = Color.FromArgb(74, 74, 74);
            btnChangeProfile.Location = new Point(32, 436);
            btnChangeProfile.Name = "btnChangeProfile";
            btnChangeProfile.Size = new Size(471, 43);
            btnChangeProfile.TabIndex = 43;
            btnChangeProfile.Text = "Cập nhật";
            btnChangeProfile.UseVisualStyleBackColor = true;
            btnChangeProfile.Visible = false;
            btnChangeProfile.Click += btnChangeProfile_Click;
            btnChangeProfile.MouseLeave += btnChangeProfile_MouseLeave;
            btnChangeProfile.MouseMove += btnChangeProfile_MouseMove;
            // 
            // tbStaffName
            // 
            tbStaffName.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffName.BorderStyle = BorderStyle.None;
            tbStaffName.Cursor = Cursors.IBeam;
            tbStaffName.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffName.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffName.Location = new Point(223, 206);
            tbStaffName.Name = "tbStaffName";
            tbStaffName.ReadOnly = true;
            tbStaffName.Size = new Size(317, 27);
            tbStaffName.TabIndex = 0;
            tbStaffName.KeyPress += OnlyString_KeyPress;
            // 
            // tbStaffEmail
            // 
            tbStaffEmail.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffEmail.BorderStyle = BorderStyle.None;
            tbStaffEmail.Cursor = Cursors.IBeam;
            tbStaffEmail.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffEmail.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffEmail.Location = new Point(223, 285);
            tbStaffEmail.Name = "tbStaffEmail";
            tbStaffEmail.ReadOnly = true;
            tbStaffEmail.Size = new Size(317, 27);
            tbStaffEmail.TabIndex = 1;
            // 
            // tbStaffPhone
            // 
            tbStaffPhone.BackColor = Color.FromArgb(179, 179, 179);
            tbStaffPhone.BorderStyle = BorderStyle.None;
            tbStaffPhone.Cursor = Cursors.IBeam;
            tbStaffPhone.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffPhone.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffPhone.Location = new Point(223, 361);
            tbStaffPhone.Name = "tbStaffPhone";
            tbStaffPhone.ReadOnly = true;
            tbStaffPhone.Size = new Size(317, 27);
            tbStaffPhone.TabIndex = 2;
            tbStaffPhone.KeyPress += OnlyNumber_KeyPress;
            // 
            // lbStaffRole
            // 
            lbStaffRole.FlatStyle = FlatStyle.Flat;
            lbStaffRole.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbStaffRole.ForeColor = Color.FromArgb(74, 74, 74);
            lbStaffRole.Location = new Point(223, 119);
            lbStaffRole.Name = "lbStaffRole";
            lbStaffRole.Size = new Size(317, 36);
            lbStaffRole.TabIndex = 45;
            lbStaffRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(74, 74, 74);
            label13.Location = new Point(6, 362);
            label13.Name = "label13";
            label13.Size = new Size(183, 31);
            label13.TabIndex = 34;
            label13.Text = "Số điện thoại:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(74, 74, 74);
            label11.Location = new Point(6, 207);
            label11.Name = "label11";
            label11.Size = new Size(211, 31);
            label11.TabIndex = 30;
            label11.Text = "Tên nhân viên:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 38;
            label2.Text = "ID nhân viên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 40;
            label3.Text = "Vị trí:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(6, 286);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 42;
            label4.Text = "Email:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpChangePassword
            // 
            tpChangePassword.BackColor = Color.FromArgb(179, 179, 179);
            tpChangePassword.Controls.Add(pnlAccChange);
            tpChangePassword.Controls.Add(lbChangeInfo);
            tpChangePassword.Location = new Point(4, 26);
            tpChangePassword.Name = "tpChangePassword";
            tpChangePassword.Padding = new Padding(3);
            tpChangePassword.Size = new Size(546, 559);
            tpChangePassword.TabIndex = 1;
            tpChangePassword.Text = "Đổi mật khẩu";
            // 
            // fStaffProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(602, 674);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fStaffProfile";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += fAccountProfile_Load;
            pnlAccChange.ResumeLayout(false);
            pnlAccChange.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpStaffInfo.ResumeLayout(false);
            tpStaffInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpChangePassword.ResumeLayout(false);
            tpChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel pnlAccChange;
        private TextBox tbNewPassWord;
        private TextBox tbOldPassWord;
        private Label lbNewPassWord;
        private Label lbUserName;
        private TextBox tbNewPassWordAgain;
        private Label lbNewPassWordAgain;
        private Button btnUpdatePassword;
        private Label lbChangeInfo;
        private Label lbCaptcha;
        private TextBox tbCaptcha;
        private Label lbCaptchaTitle;
        private Button btnEye2;
        private Button btnEye;
        private TabControl tabControl1;
        private TabPage tpChangePassword;
        private Button btnEye1;
        private TabPage tpStaffInfo;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private TextBox tbStaffName;
        private Label label13;
        private TextBox tbStaffPhone;
        private Button btnUpdateStaffInfo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbStaffEmail;
        private Button btnChangeProfile;
        private Label lbStaffRole;
        private Label lbStaffID;
    }
}