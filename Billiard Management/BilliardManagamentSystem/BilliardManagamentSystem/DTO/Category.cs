using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private int status;
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
        public Category(DataRow row)
        {
            CategoryID = (int)row["categoryID"];
            CategoryName = (string)row["categoryName"];
            Status = (int)row["status"];
        }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int Status { get => status; set => status = value; }
    }
}
