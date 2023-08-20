namespace BilliardManagamentSystem
{
    partial class fForgotPassword
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
            pnlInserting = new Panel();
            btnSendOTP = new Button();
            label4 = new Label();
            tbStaffEmail = new TextBox();
            label2 = new Label();
            tbStaffID = new TextBox();
            label3 = new Label();
            pnlOTP = new Panel();
            btnSubmitOTP = new Button();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            lbOtpTitle = new Label();
            pnlChangePassword = new Panel();
            lbCaptcha = new Label();
            tbCaptcha = new TextBox();
            lbCaptchaTitle = new Label();
            label1 = new Label();
            btnUpdatePassword = new Button();
            btnEye2 = new Button();
            btnEye = new Button();
            tbNewPassWordAgain = new TextBox();
            lbNewPassWordAgain = new Label();
            tbNewPassWord = new TextBox();
            lbNewPassWord = new Label();
            pnlInserting.SuspendLayout();
            pnlOTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            pnlChangePassword.SuspendLayout();
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
            btnExit.Location = new Point(1154, 1);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(49, 52);
            btnExit.TabIndex = 5;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlInserting
            // 
            pnlInserting.BackColor = Color.FromArgb(179, 179, 179);
            pnlInserting.Controls.Add(btnSendOTP);
            pnlInserting.Controls.Add(label4);
            pnlInserting.Controls.Add(tbStaffEmail);
            pnlInserting.Controls.Add(label2);
            pnlInserting.Controls.Add(tbStaffID);
            pnlInserting.Controls.Add(label3);
            pnlInserting.Location = new Point(12, 59);
            pnlInserting.Name = "pnlInserting";
            pnlInserting.Size = new Size(547, 356);
            pnlInserting.TabIndex = 6;
            // 
            // btnSendOTP
            // 
            btnSendOTP.AutoSize = true;
            btnSendOTP.Cursor = Cursors.Hand;
            btnSendOTP.FlatAppearance.BorderSize = 0;
            btnSendOTP.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSendOTP.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnSendOTP.FlatStyle = FlatStyle.Flat;
            btnSendOTP.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendOTP.ForeColor = Color.FromArgb(74, 74, 74);
            btnSendOTP.Location = new Point(22, 279);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(482, 43);
            btnSendOTP.TabIndex = 36;
            btnSendOTP.Text = "Gửi OTP";
            btnSendOTP.UseVisualStyleBackColor = true;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(22, 10);
            label4.Name = "label4";
            label4.Size = new Size(278, 43);
            label4.TabIndex = 29;
            label4.Text = "Quên mật khẩu";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffEmail
            // 
            tbStaffEmail.BackColor = Color.White;
            tbStaffEmail.Cursor = Cursors.IBeam;
            tbStaffEmail.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffEmail.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffEmail.Location = new Point(22, 227);
            tbStaffEmail.Name = "tbStaffEmail";
            tbStaffEmail.Size = new Size(482, 27);
            tbStaffEmail.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(22, 188);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 27;
            label2.Text = "Email:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbStaffID
            // 
            tbStaffID.BackColor = Color.White;
            tbStaffID.Cursor = Cursors.IBeam;
            tbStaffID.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbStaffID.ForeColor = Color.FromArgb(74, 74, 74);
            tbStaffID.Location = new Point(22, 134);
            tbStaffID.Name = "tbStaffID";
            tbStaffID.Size = new Size(482, 27);
            tbStaffID.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(22, 95);
            label3.Name = "label3";
            label3.Size = new Size(176, 32);
            label3.TabIndex = 25;
            label3.Text = "ID nhân viên:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOTP
            // 
            pnlOTP.BackColor = Color.FromArgb(179, 179, 179);
            pnlOTP.Controls.Add(btnSubmitOTP);
            pnlOTP.Controls.Add(numericUpDown6);
            pnlOTP.Controls.Add(numericUpDown5);
            pnlOTP.Controls.Add(numericUpDown4);
            pnlOTP.Controls.Add(numericUpDown3);
            pnlOTP.Controls.Add(numericUpDown2);
            pnlOTP.Controls.Add(numericUpDown1);
            pnlOTP.Controls.Add(lbOtpTitle);
            pnlOTP.Enabled = false;
            pnlOTP.Location = new Point(12, 421);
            pnlOTP.Name = "pnlOTP";
            pnlOTP.Size = new Size(547, 200);
            pnlOTP.TabIndex = 7;
            // 
            // btnSubmitOTP
            // 
            btnSubmitOTP.AutoSize = true;
            btnSubmitOTP.Cursor = Cursors.Hand;
            btnSubmitOTP.FlatAppearance.BorderSize = 0;
            btnSubmitOTP.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSubmitOTP.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 245, 238);
            btnSubmitOTP.FlatStyle = FlatStyle.Flat;
            btnSubmitOTP.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitOTP.ForeColor = Color.FromArgb(74, 74, 74);
            btnSubmitOTP.Location = new Point(22, 140);
            btnSubmitOTP.Name = "btnSubmitOTP";
            btnSubmitOTP.Size = new Size(482, 43);
            btnSubmitOTP.TabIndex = 35;
            btnSubmitOTP.Text = "Xác nhận";
            btnSubmitOTP.UseVisualStyleBackColor = true;
            btnSubmitOTP.Click += btnSubmitOTP_Click;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown6.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown6.Location = new Point(400, 73);
            numericUpDown6.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(58, 54);
            numericUpDown6.TabIndex = 34;
            numericUpDown6.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown5.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown5.Location = new Point(336, 73);
            numericUpDown5.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(58, 54);
            numericUpDown5.TabIndex = 33;
            numericUpDown5.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown4.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown4.Location = new Point(272, 73);
            numericUpDown4.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(58, 54);
            numericUpDown4.TabIndex = 32;
            numericUpDown4.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown3.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown3.Location = new Point(208, 73);
            numericUpDown3.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(58, 54);
            numericUpDown3.TabIndex = 31;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown2.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown2.Location = new Point(144, 73);
            numericUpDown2.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(58, 54);
            numericUpDown2.TabIndex = 30;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.ForeColor = Color.FromArgb(74, 74, 74);
            numericUpDown1.Location = new Point(80, 73);
            numericUpDown1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 54);
            numericUpDown1.TabIndex = 29;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // lbOtpTitle
            // 
            lbOtpTitle.AutoSize = true;
            lbOtpTitle.FlatStyle = FlatStyle.Flat;
            lbOtpTitle.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbOtpTitle.ForeColor = Color.FromArgb(74, 74, 74);
            lbOtpTitle.Location = new Point(22, 16);
            lbOtpTitle.Name = "lbOtpTitle";
            lbOtpTitle.Size = new Size(198, 43);
            lbOtpTitle.TabIndex = 28;
            lbOtpTitle.Text = "Nhập OTP:";
            lbOtpTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.BackColor = Color.FromArgb(179, 179, 179);
            pnlChangePassword.Controls.Add(lbCaptcha);
            pnlChangePassword.Controls.Add(tbCaptcha);
            pnlChangePassword.Controls.Add(lbCaptchaTitle);
            pnlChangePassword.Controls.Add(label1);
            pnlChangePassword.Controls.Add(btnUpdatePassword);
            pnlChangePassword.Controls.Add(btnEye2);
            pnlChangePassword.Controls.Add(btnEye);
            pnlChangePassword.Controls.Add(tbNewPassWordAgain);
            pnlChangePassword.Controls.Add(lbNewPassWordAgain);
            pnlChangePassword.Controls.Add(tbNewPassWord);
            pnlChangePassword.Controls.Add(lbNewPassWord);
            pnlChangePassword.Enabled = false;
            pnlChangePassword.Location = new Point(565, 59);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Size = new Size(627, 562);
            pnlChangePassword.TabIndex = 8;
            // 
            // lbCaptcha
            // 
            lbCaptcha.AutoSize = true;
            lbCaptcha.FlatStyle = FlatStyle.Flat;
            lbCaptcha.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptcha.ForeColor = Color.RosyBrown;
            lbCaptcha.Location = new Point(249, 353);
            lbCaptcha.Name = "lbCaptcha";
            lbCaptcha.Size = new Size(0, 29);
            lbCaptcha.TabIndex = 30;
            lbCaptcha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCaptcha
            // 
            tbCaptcha.BackColor = Color.White;
            tbCaptcha.Cursor = Cursors.IBeam;
            tbCaptcha.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbCaptcha.ForeColor = Color.FromArgb(74, 74, 74);
            tbCaptcha.Location = new Point(38, 385);
            tbCaptcha.Name = "tbCaptcha";
            tbCaptcha.Size = new Size(563, 27);
            tbCaptcha.TabIndex = 28;
            // 
            // lbCaptchaTitle
            // 
            lbCaptchaTitle.AutoSize = true;
            lbCaptchaTitle.FlatStyle = FlatStyle.Flat;
            lbCaptchaTitle.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaptchaTitle.ForeColor = Color.FromArgb(74, 74, 74);
            lbCaptchaTitle.Location = new Point(38, 351);
            lbCaptchaTitle.Name = "lbCaptchaTitle";
            lbCaptchaTitle.Size = new Size(127, 31);
            lbCaptchaTitle.TabIndex = 29;
            lbCaptchaTitle.Text = "Captcha:";
            lbCaptchaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(38, 20);
            label1.Name = "label1";
            label1.Size = new Size(247, 43);
            label1.TabIndex = 27;
            label1.Text = "Đổi mật khẩu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnUpdatePassword.Location = new Point(38, 446);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(563, 43);
            btnUpdatePassword.TabIndex = 26;
            btnUpdatePassword.Text = "Cập nhật";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
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
            btnEye2.Location = new Point(566, 278);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(35, 26);
            btnEye2.TabIndex = 25;
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
            btnEye.Location = new Point(566, 163);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(35, 26);
            btnEye.TabIndex = 24;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
            // 
            // tbNewPassWordAgain
            // 
            tbNewPassWordAgain.BackColor = Color.White;
            tbNewPassWordAgain.Cursor = Cursors.IBeam;
            tbNewPassWordAgain.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            tbNewPassWordAgain.Location = new Point(38, 278);
            tbNewPassWordAgain.Name = "tbNewPassWordAgain";
            tbNewPassWordAgain.Size = new Size(563, 27);
            tbNewPassWordAgain.TabIndex = 22;
            tbNewPassWordAgain.UseSystemPasswordChar = true;
            // 
            // lbNewPassWordAgain
            // 
            lbNewPassWordAgain.AutoSize = true;
            lbNewPassWordAgain.FlatStyle = FlatStyle.Flat;
            lbNewPassWordAgain.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWordAgain.Location = new Point(38, 239);
            lbNewPassWordAgain.Name = "lbNewPassWordAgain";
            lbNewPassWordAgain.Size = new Size(300, 32);
            lbNewPassWordAgain.TabIndex = 23;
            lbNewPassWordAgain.Text = "Nhập lại mật khẩu mới:";
            lbNewPassWordAgain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNewPassWord
            // 
            tbNewPassWord.BackColor = Color.White;
            tbNewPassWord.Cursor = Cursors.IBeam;
            tbNewPassWord.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewPassWord.ForeColor = Color.FromArgb(74, 74, 74);
            tbNewPassWord.Location = new Point(38, 163);
            tbNewPassWord.Name = "tbNewPassWord";
            tbNewPassWord.Size = new Size(563, 27);
            tbNewPassWord.TabIndex = 20;
            tbNewPassWord.UseSystemPasswordChar = true;
            // 
            // lbNewPassWord
            // 
            lbNewPassWord.AutoSize = true;
            lbNewPassWord.FlatStyle = FlatStyle.Flat;
            lbNewPassWord.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWord.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWord.Location = new Point(38, 124);
            lbNewPassWord.Name = "lbNewPassWord";
            lbNewPassWord.Size = new Size(264, 32);
            lbNewPassWord.TabIndex = 21;
            lbNewPassWord.Text = "Nhập mật khẩu mới:";
            lbNewPassWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(1204, 633);
            Controls.Add(pnlChangePassword);
            Controls.Add(pnlOTP);
            Controls.Add(pnlInserting);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fForgotPassword";
            pnlInserting.ResumeLayout(false);
            pnlInserting.PerformLayout();
            pnlOTP.ResumeLayout(false);
            pnlOTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel pnlInserting;
        private Panel pnlOTP;
        private Panel pnlChangePassword;
        private Button btnEye2;
        private Button btnEye;
        private TextBox tbNewPassWordAgain;
        private Label lbNewPassWordAgain;
        private TextBox tbNewPassWord;
        private Label lbNewPassWord;
        private Button btnUpdatePassword;
        private Button btnSendOTP;
        private Label label4;
        private TextBox tbStaffEmail;
        private Label label2;
        private TextBox tbStaffID;
        private Label label3;
        private Button btnSubmitOTP;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label lbOtpTitle;
        private Label label1;
        private Label lbCaptcha;
        private TextBox tbCaptcha;
        private Label lbCaptchaTitle;
    }
}