using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class Report
    {
        private double tablePrice;
        private double foodPrice;
        private double totalPrice;

        public Report(DataRow row)
        {
            var tempTablePrice = row["Tổng tiền bàn"].ToString();
            if(tempTablePrice != "")
                TablePrice = Convert.ToDouble(tempTablePrice);
            else TablePrice = 0;

            var tempFoodPrice = row["Tổng tiền đồ ăn"].ToString();
            if(tempFoodPrice != "")
                FoodPrice = Convert.ToDouble(tempFoodPrice);
            else FoodPrice = 0;

            var tempTotalPrice = row["Tổng doanh thu"].ToString();
            if (tempTotalPrice != "")
                TotalPrice = Convert.ToDouble(tempTotalPrice);
            else TotalPrice = 0;
        }

        public double TablePrice { get => tablePrice; set => tablePrice = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
    public class ReportDAO
    {
        private static ReportDAO instance;
        public static ReportDAO Instance 
        {
            get { if (instance == null) { instance = new ReportDAO(); } return instance; }
            private set { instance = value; }
        }
        private ReportDAO() { }

        public Report ReportByDate(DateTime date)
        {
            string query = string.Format("call USP_ReportByDate('{0}')", date.ToString("yyyy-MM-dd"));

            DataTable data =  DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                Report report = new(row);
                return report;
            }
            return null;
        }
        public Report ReportByMonth(DateTime date) 
        {
            DateTime fromDate = new DateTime(date.Year, date.Month, 1);

            DateTime toDate = fromDate.AddMonths(1).AddDays(-1);

            string query = string.Format("call USP_ReportByMonth('{0}', '{1}')", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"));

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Report report = new(row);
                return report;
            }
            return null;
        }
    }
}
