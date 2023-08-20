using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckedBillIDByTableID(int tableID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from bill where tableID = " + tableID + " and billStatus = 0");
            
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillID;
            }
            return -1;
        }
        public int GetUncheckedBillID()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from bill where billStatus = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillID;
            }
            return -1;
        }
        public void InsertBill(int tableID, string staffID)
        {
            string query = string.Format("call USP_InsertBill( '{0}' , '{1}' )", tableID, staffID);

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GetMaxBillID()
        {
            try
            {
               return (int)DataProvider.Instance.ExecuteScalar("select max(billID) from bill");
            }
            catch
            {
                return -1;
            }
            
        }
        public void CheckOut(int billID, int discount, double tablePrice, double totalPrice)
        {
            string query = "update bill set checkOut = now(), billStatus = 1, discount = " + discount + ", billTotalPrice = " + totalPrice + ", tablePrice =  " + tablePrice + " where billID = " + billID;

            DataProvider.Instance.ExecuteNonQuery(@query);

        }    
        public DateTime GetCheckInTimeByUncheckedBillID(int billID)
        {
            if (billID != -1)
            {
                string query = "select checkIn from bill where billStatus = 0 and billID = " + billID;
                var time = (DateTime)DataProvider.Instance.ExecuteScalar(query);
                return time;
            }
            else
            {
                return DateTime.MinValue;
            }
        }
        public DateTime GetPlayTime(DateTime checkIn)
        {
            string query = string.Format("select timediff( '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ,'" + checkIn.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            TimeSpan span = (TimeSpan)DataProvider.Instance.ExecuteScalar(@query);
            DateTime playtime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            playtime = playtime.Add(span);
            return playtime;
        }
        public int GetBillAmountByDate(DateTime fromDate, DateTime toDate)
        {
            string strFromDate = fromDate.ToString("yyyy-MM-dd");

            toDate = toDate.AddDays(1);

            string strToDate = toDate.ToString("yyyy-MM-dd");

            string query = string.Format("call USP_GetBillAmountByDate( '{0}' , '{1}' )", strFromDate, strToDate);

            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
        }
        public DataTable GetBillList(DateTime fromDate, DateTime toDate, int page , int rowPerPage)
        {
            string strFromDate = fromDate.ToString("yyyy-MM-dd");

            toDate = toDate.AddDays(1);

            string strToDate = toDate.ToString("yyyy-MM-dd");

            string query = string.Format("call USP_GetBillList( '{0}' , '{1}' , {2} , {3} )", strFromDate, strToDate, page, rowPerPage);

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public PrintBill GetPrintBill(int billID)
        {
            string query = string.Format("call USP_GetPrintBill({0})", billID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows) 
            {
                PrintBill bill = new(row);
                return bill;
            }
            return null;
        }
    }
}
