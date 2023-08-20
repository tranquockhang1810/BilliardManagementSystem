using BilliardManagamentSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardManagamentSystem
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
            LoadReportByDate(DateTime.Now);
            LoadReportByMonth(DateTime.Now);
        }
        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dtpkReport_ValueChange(object sender, EventArgs e)
        {
            DateTime date = dtpkReport.Value;
            LoadReportByDate(date);
            LoadReportByMonth(date);
        }
        #endregion
        #region Methods
        void LoadReportByDate(DateTime date)
        {
            tbSelectedDate.Text = date.ToString("dd/MM/yyyy");
            CultureInfo culture = new CultureInfo("vi-VN");
            Report report = ReportDAO.Instance.ReportByDate(date);
            tbDateTablePrice.Text = report.TablePrice.ToString("c", culture);
            tbDateFoodPrice.Text = report.FoodPrice.ToString("c", culture);
            tbDateTotalPrice.Text = report.TotalPrice.ToString("c", culture);
        }
        void LoadReportByMonth(DateTime date)
        {
            tbSelectedMonth.Text = date.ToString("MM - yyyy");
            CultureInfo culture = new CultureInfo("vi-VN");
            Report report = ReportDAO.Instance.ReportByMonth(date);
            tbMonthTablePrice.Text = report.TablePrice.ToString("c", culture);
            tbMonthFoodPrice.Text = report.FoodPrice.ToString("c", culture);
            tbMonthTotalPrice.Text = report.TotalPrice.ToString("c", culture);
        }
        #endregion

    }
}

