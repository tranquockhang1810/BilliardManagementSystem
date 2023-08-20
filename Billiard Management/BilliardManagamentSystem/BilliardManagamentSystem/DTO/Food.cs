using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Food
    {
        private int foodID;
        private string foodName;
        private int categoryID;
        private double foodPrice;
        private string foodImage;
        private int status;
        public Food(string foodName, int categoryID, double foodPrice, string foodImage)
        {
            FoodName = foodName;
            CategoryID = categoryID;
            FoodPrice = foodPrice;
            FoodImage = foodImage;
        }
        public Food(DataRow row) 
        {
            FoodID = (int)row["foodID"];
            FoodName = (string)row["foodName"];
            CategoryID = (int)row["categoryID"];
            FoodPrice = (double)row["foodPrice"];
            FoodImage = (string)row["foodImage"];
            Status = (int)row["status"];
        }

        public int FoodID { get => foodID; set => foodID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }
        public string FoodImage { get => foodImage; set => foodImage = value; }
        public int Status { get => status; set => status = value; }
    }
}
