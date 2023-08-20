namespace BilliardManagamentSystem
{
    partial class fChangePassword
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
            panel1 = new Panel();
            lbChangeInfo = new Label();
            btnEye2 = new Button();
            btnEye = new Button();
            btnUpdatePassword = new Button();
            tbNewPassWordAgain = new TextBox();
            lbNewPassWordAgain = new Label();
            tbNewPassWord = new TextBox();
            lbNewPassWord = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            panel1.Controls.Add(lbChangeInfo);
            panel1.Controls.Add(btnEye2);
            panel1.Controls.Add(btnEye);
            panel1.Controls.Add(btnUpdatePassword);
            panel1.Controls.Add(tbNewPassWordAgain);
            panel1.Controls.Add(lbNewPassWordAgain);
            panel1.Controls.Add(tbNewPassWord);
            panel1.Controls.Add(lbNewPassWord);
            panel1.Location = new Point(30, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 559);
            panel1.TabIndex = 0;
            // 
            // lbChangeInfo
            // 
            lbChangeInfo.AutoSize = true;
            lbChangeInfo.BackColor = Color.Transparent;
            lbChangeInfo.FlatStyle = FlatStyle.Flat;
            lbChangeInfo.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbChangeInfo.ForeColor = Color.FromArgb(74, 74, 74);
            lbChangeInfo.Location = new Point(148, 75);
            lbChangeInfo.Name = "lbChangeInfo";
            lbChangeInfo.Size = new Size(254, 31);
            lbChangeInfo.TabIndex = 27;
            lbChangeInfo.Text = "Thay đổi mật khẩu";
            lbChangeInfo.TextAlign = ContentAlignment.MiddleCenter;
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
            btnEye2.Location = new Point(474, 355);
            btnEye2.Name = "btnEye2";
            btnEye2.Size = new Size(35, 26);
            btnEye2.TabIndex = 26;
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
            btnEye.Location = new Point(474, 211);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(35, 26);
            btnEye.TabIndex = 25;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.Click += btnEye_Click;
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
            btnUpdatePassword.Location = new Point(38, 462);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(471, 43);
            btnUpdatePassword.TabIndex = 24;
            btnUpdatePassword.Text = "Cập nhật";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // tbNewPassWordAgain
            // 
            tbNewPassWordAgain.BackColor = Color.White;
            tbNewPassWordAgain.Cursor = Cursors.IBeam;
            tbNewPassWordAgain.Font = new Font("Colonna MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            tbNewPassWordAgain.Location = new Point(38, 355);
            tbNewPassWordAgain.Name = "tbNewPassWordAgain";
            tbNewPassWordAgain.Size = new Size(471, 27);
            tbNewPassWordAgain.TabIndex = 22;
            tbNewPassWordAgain.UseSystemPasswordChar = true;
            // 
            // lbNewPassWordAgain
            // 
            lbNewPassWordAgain.AutoSize = true;
            lbNewPassWordAgain.FlatStyle = FlatStyle.Flat;
            lbNewPassWordAgain.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWordAgain.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWordAgain.Location = new Point(38, 321);
            lbNewPassWordAgain.Name = "lbNewPassWordAgain";
            lbNewPassWordAgain.Size = new Size(316, 31);
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
            tbNewPassWord.Location = new Point(38, 211);
            tbNewPassWord.Name = "tbNewPassWord";
            tbNewPassWord.Size = new Size(471, 27);
            tbNewPassWord.TabIndex = 20;
            tbNewPassWord.UseSystemPasswordChar = true;
            // 
            // lbNewPassWord
            // 
            lbNewPassWord.AutoSize = true;
            lbNewPassWord.FlatStyle = FlatStyle.Flat;
            lbNewPassWord.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassWord.ForeColor = Color.FromArgb(74, 74, 74);
            lbNewPassWord.Location = new Point(38, 177);
            lbNewPassWord.Name = "lbNewPassWord";
            lbNewPassWord.Size = new Size(277, 31);
            lbNewPassWord.TabIndex = 21;
            lbNewPassWord.Text = "Nhập mật khẩu mới:";
            lbNewPassWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(602, 674);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fChangePassword";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEye2;
        private Button btnEye;
        private Button btnUpdatePassword;
        private TextBox tbNewPassWordAgain;
        private Label lbNewPassWordAgain;
        private TextBox tbNewPassWord;
        private Label lbNewPassWord;
        private Label lbChangeInfo;
    }
}