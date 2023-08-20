using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class BillInfo
    {
        private int billInfoID;
        private int billID;
        private int foodID;
        private int amount;

        public BillInfo(DataRow row) 
        {
            BillInfoID = (int)row["billInfoID"];
            BillID = (int)row["billID"];
            FoodID = (int)row["foodID"];
            Amount = (int)row["amount"];
        }
        public BillInfo(int billInfoID, int billID, int foodID, int amount)
        {
            BillInfoID = billInfoID;
            BillID = billID;
            FoodID = foodID;
            Amount = amount;
        }
        public int BillInfoID { get => billInfoID; set => billInfoID = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
