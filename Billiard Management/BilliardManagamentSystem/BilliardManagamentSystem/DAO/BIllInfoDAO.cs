using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class BIllInfoDAO
    {
        private static BIllInfoDAO instance;
        public static BIllInfoDAO Instance
        {
            get { if (instance == null) instance = new BIllInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BIllInfoDAO() { }
        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            string query = string.Format("call USP_InsertBillInfo( {0} , {1} , {2} )", billID, foodID, amount);

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool CheckDeleteBillInfo(int foodID)
        {
            string query = string.Format("select * from billinfo, bill where bill.billID = billinfo.billID and bill.billStatus = 0 and foodID = {0}", foodID);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count > 0;
        }
    }
}
