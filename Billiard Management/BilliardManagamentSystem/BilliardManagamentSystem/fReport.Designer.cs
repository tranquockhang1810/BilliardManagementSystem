namespace BilliardManagamentSystem
{
    partial class fReport
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
            panel1 = new Panel();
            tbMonthTotalPrice = new Label();
            tbMonthFoodPrice = new Label();
            tbMonthTablePrice = new Label();
            tbDateTotalPrice = new Label();
            tbDateFoodPrice = new Label();
            tbDateTablePrice = new Label();
            dtpkReport = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbSelectedMonth = new Label();
            tbSelectedDate = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
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
            btnExit.Location = new Point(813, 0);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(58, 44);
            btnExit.TabIndex = 7;
            btnExit.Text = "X ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            panel1.Controls.Add(tbMonthTotalPrice);
            panel1.Controls.Add(tbMonthFoodPrice);
            panel1.Controls.Add(tbMonthTablePrice);
            panel1.Controls.Add(tbDateTotalPrice);
            panel1.Controls.Add(tbDateFoodPrice);
            panel1.Controls.Add(tbDateTablePrice);
            panel1.Controls.Add(dtpkReport);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbSelectedMonth);
            panel1.Controls.Add(tbSelectedDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 515);
            panel1.TabIndex = 8;
            // 
            // tbMonthTotalPrice
            // 
            tbMonthTotalPrice.FlatStyle = FlatStyle.Flat;
            tbMonthTotalPrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthTotalPrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbMonthTotalPrice.Location = new Point(628, 406);
            tbMonthTotalPrice.Name = "tbMonthTotalPrice";
            tbMonthTotalPrice.Size = new Size(203, 55);
            tbMonthTotalPrice.TabIndex = 35;
            tbMonthTotalPrice.Text = "ngày";
            tbMonthTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbMonthFoodPrice
            // 
            tbMonthFoodPrice.FlatStyle = FlatStyle.Flat;
            tbMonthFoodPrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthFoodPrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbMonthFoodPrice.Location = new Point(628, 318);
            tbMonthFoodPrice.Name = "tbMonthFoodPrice";
            tbMonthFoodPrice.Size = new Size(203, 55);
            tbMonthFoodPrice.TabIndex = 34;
            tbMonthFoodPrice.Text = "ngày";
            tbMonthFoodPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbMonthTablePrice
            // 
            tbMonthTablePrice.FlatStyle = FlatStyle.Flat;
            tbMonthTablePrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbMonthTablePrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbMonthTablePrice.Location = new Point(628, 229);
            tbMonthTablePrice.Name = "tbMonthTablePrice";
            tbMonthTablePrice.Size = new Size(203, 55);
            tbMonthTablePrice.TabIndex = 33;
            tbMonthTablePrice.Text = "ngày";
            tbMonthTablePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDateTotalPrice
            // 
            tbDateTotalPrice.FlatStyle = FlatStyle.Flat;
            tbDateTotalPrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbDateTotalPrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbDateTotalPrice.Location = new Point(350, 406);
            tbDateTotalPrice.Name = "tbDateTotalPrice";
            tbDateTotalPrice.Size = new Size(235, 55);
            tbDateTotalPrice.TabIndex = 32;
            tbDateTotalPrice.Text = "ngày";
            tbDateTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDateFoodPrice
            // 
            tbDateFoodPrice.FlatStyle = FlatStyle.Flat;
            tbDateFoodPrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbDateFoodPrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbDateFoodPrice.Location = new Point(350, 318);
            tbDateFoodPrice.Name = "tbDateFoodPrice";
            tbDateFoodPrice.Size = new Size(235, 55);
            tbDateFoodPrice.TabIndex = 31;
            tbDateFoodPrice.Text = "ngày";
            tbDateFoodPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDateTablePrice
            // 
            tbDateTablePrice.FlatStyle = FlatStyle.Flat;
            tbDateTablePrice.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbDateTablePrice.ForeColor = Color.FromArgb(74, 74, 74);
            tbDateTablePrice.Location = new Point(350, 229);
            tbDateTablePrice.Name = "tbDateTablePrice";
            tbDateTablePrice.Size = new Size(235, 55);
            tbDateTablePrice.TabIndex = 30;
            tbDateTablePrice.Text = "ngày";
            tbDateTablePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpkReport
            // 
            dtpkReport.CalendarMonthBackground = Color.FromArgb(189, 198, 184);
            dtpkReport.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkReport.Location = new Point(21, 140);
            dtpkReport.Name = "dtpkReport";
            dtpkReport.Size = new Size(271, 25);
            dtpkReport.TabIndex = 29;
            dtpkReport.ValueChanged += dtpkReport_ValueChange;
            // 
            // label9
            // 
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(74, 74, 74);
            label9.Location = new Point(3, 461);
            label9.Name = "label9";
            label9.Size = new Size(841, 42);
            label9.TabIndex = 26;
            label9.Text = "-----------------------------------------------------------------------------------------------------";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(74, 74, 74);
            label8.Location = new Point(3, 373);
            label8.Name = "label8";
            label8.Size = new Size(841, 42);
            label8.TabIndex = 25;
            label8.Text = "-----------------------------------------------------------------------------------------------------";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(74, 74, 74);
            label7.Location = new Point(3, 284);
            label7.Name = "label7";
            label7.Size = new Size(841, 42);
            label7.TabIndex = 24;
            label7.Text = "-----------------------------------------------------------------------------------------------------";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(74, 74, 74);
            label6.Location = new Point(3, 195);
            label6.Name = "label6";
            label6.Size = new Size(841, 42);
            label6.TabIndex = 23;
            label6.Text = "-----------------------------------------------------------------------------------------------------";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(74, 74, 74);
            label5.Location = new Point(3, 406);
            label5.Name = "label5";
            label5.Size = new Size(244, 55);
            label5.TabIndex = 22;
            label5.Text = "Tổng doanh thu";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(74, 74, 74);
            label4.Location = new Point(3, 318);
            label4.Name = "label4";
            label4.Size = new Size(244, 55);
            label4.TabIndex = 21;
            label4.Text = "Tổng tiền đồ ăn";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(74, 74, 74);
            label3.Location = new Point(3, 229);
            label3.Name = "label3";
            label3.Size = new Size(244, 55);
            label3.TabIndex = 20;
            label3.Text = "Tổng tiền bàn";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSelectedMonth
            // 
            tbSelectedMonth.FlatStyle = FlatStyle.Flat;
            tbSelectedMonth.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbSelectedMonth.ForeColor = Color.FromArgb(74, 74, 74);
            tbSelectedMonth.Location = new Point(628, 140);
            tbSelectedMonth.Name = "tbSelectedMonth";
            tbSelectedMonth.Size = new Size(203, 55);
            tbSelectedMonth.TabIndex = 19;
            tbSelectedMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbSelectedDate
            // 
            tbSelectedDate.FlatStyle = FlatStyle.Flat;
            tbSelectedDate.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbSelectedDate.ForeColor = Color.FromArgb(74, 74, 74);
            tbSelectedDate.Location = new Point(350, 140);
            tbSelectedDate.Name = "tbSelectedDate";
            tbSelectedDate.Size = new Size(235, 55);
            tbSelectedDate.TabIndex = 18;
            tbSelectedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 74, 74);
            label2.Location = new Point(628, 82);
            label2.Name = "label2";
            label2.Size = new Size(203, 58);
            label2.TabIndex = 17;
            label2.Text = "Theo tháng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 74, 74);
            label1.Location = new Point(350, 85);
            label1.Name = "label1";
            label1.Size = new Size(235, 55);
            label1.TabIndex = 16;
            label1.Text = "Theo ngày";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Colonna MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(74, 74, 74);
            label10.Location = new Point(267, 28);
            label10.Name = "label10";
            label10.Size = new Size(339, 43);
            label10.TabIndex = 15;
            label10.Text = "Báo cáo doanh thu";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(74, 74, 74);
            label11.Location = new Point(309, 98);
            label11.Name = "label11";
            label11.Size = new Size(17, 379);
            label11.TabIndex = 27;
            label11.Text = "|||||||||||||";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(74, 74, 74);
            label12.Location = new Point(605, 98);
            label12.Name = "label12";
            label12.Size = new Size(17, 379);
            label12.TabIndex = 28;
            label12.Text = "|||||||||||||";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 47, 47);
            ClientSize = new Size(871, 577);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fReport";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fReport";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label tbSelectedMonth;
        private Label tbSelectedDate;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label tbMonthTotalPrice;
        private Label tbMonthFoodPrice;
        private Label tbMonthTablePrice;
        private Label tbDateTotalPrice;
        private Label tbDateFoodPrice;
        private Label tbDateTablePrice;
        private DateTimePicker dtpkReport;
        private Label label12;
    }
}