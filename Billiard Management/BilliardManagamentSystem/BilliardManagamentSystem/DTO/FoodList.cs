using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class FoodList
    {
        private string foodName;
        private double foodPrice;
        private int amount;
        private double foodTotalPrice;
        public FoodList(string foodName, double foodPrice, int amount, double foodTotalPrice = 0)
        {
            FoodName = foodName;
            FoodPrice = foodPrice;
            Amount = amount;
            FoodTotalPrice = foodTotalPrice;
        }
        public FoodList (DataRow row)
        {
            FoodName = (string)row["foodName"];
            FoodPrice = (double)row["foodPrice"];
            Amount = (int)row["amount"];
            FoodTotalPrice = (double)row["foodTotalPrice"];
        }
        public string FoodName { get => foodName; set => foodName = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }
        public int Amount { get => amount; set => amount = value; }
        public double FoodTotalPrice { get => foodTotalPrice; set => foodTotalPrice = value; }
    }
}
