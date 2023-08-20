using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class FoodListDAO
    {
        private static FoodListDAO instance;
        public static FoodListDAO Instance
        {
            get { if (instance == null) instance = new FoodListDAO(); return instance; }
            private set { instance = value; }
        }
        private FoodListDAO() { }
        public List<FoodList> GetMenuListByTable(int tableID)
        {
            List<FoodList> list = new List<FoodList>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select food.foodName , food.foodPrice , billinfo.amount, food.foodPrice*billinfo.amount as 'foodTotalPrice' from food, billinfo, bill where food.foodID = billinfo.foodID and billinfo.billID = bill.billID and bill.billStatus = 0 and bill.tableID = " + tableID);

            foreach (DataRow row in data.Rows)
            {
                FoodList menu = new FoodList(row);
                list.Add(menu);
            }

            return list;
        }
        public List<FoodList> GetMenuListByBillID(int billID)
        {
            List<FoodList> list = new List<FoodList>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select food.foodName , food.foodPrice , billinfo.amount, food.foodPrice*billinfo.amount as 'foodTotalPrice' from food, billinfo, bill where food.foodID = billinfo.foodID and billinfo.billID = bill.billID and bill.billStatus = 1 and bill.billID = " + billID);

            foreach (DataRow row in data.Rows)
            {
                FoodList menu = new FoodList(row);
                list.Add(menu);
            }

            return list;
        }
    }
}
