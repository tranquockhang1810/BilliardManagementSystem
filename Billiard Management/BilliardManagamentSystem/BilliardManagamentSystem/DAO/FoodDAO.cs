using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if(instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetFoodListByCategoryID(int categoryID)
        {
            List<Food> list = new List<Food>();

            string query = "select * from food where categoryID = " + categoryID + " and status = 1 order by foodName";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }

            return list;
        }
        public DataTable GetFoodByCategory(int categoryID)
        {
            
            string query = string.Format("call USP_GetFoodByCategory( {0} )", categoryID);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable GetFoodList()
        {
            string query = "select foodID as `ID món`, foodName as `Tên món`, categoryName as `Tên danh mục`, foodPrice as `Đơn giá`, foodImage as `Hình ảnh` from food, foodcategory where food.categoryID = foodcategory.categoryID and food.status = 1;";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Food GetFoodByFoodID(int foodID)
        {
            string query = "select * from food where foodID = " + foodID;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                return food;
            }
            return null;
        }
        public Food GetFoodByFoodName(string foodName)
        {
            string query = "select * from food where foodName = '" + foodName + "' order by foodID desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                return food;
            }
            return null;
        }
        public bool InsertFood(Food food)
        {
            string newImage = "";
            if (food.FoodImage != null)
            {
                string[] newFoodImage = food.FoodImage.Split(@"\");
                for (int i = 0; i < newFoodImage.Length; i++)
                {
                    if (i != newFoodImage.Length - 1)
                    {
                        newImage += newFoodImage[i] + @"\\";
                    }
                    else
                    {
                        newImage += newFoodImage[i];
                        break;
                    }
                }
            }
            else
            {
                newImage = "Chưa có ảnh";
            }
            food.FoodImage = newImage;

            string query = string.Format(@"insert into food (`foodName`,`categoryID`,`foodPrice`,`foodImage`) values('{0}', {1}, {2}, '{3}')",food.FoodName, food.CategoryID, food.FoodPrice, food.FoodImage);

            int result = DataProvider.Instance.ExecuteNonQuery(@query);

            return result > 0;
        }
        public bool UpdateFood(Food food)
        {
            string newImage = "";
            if (food.FoodImage != null)
            {
                string[] newFoodImage = food.FoodImage.Split(@"\");
                for (int i = 0; i < newFoodImage.Length; i++)
                {
                    if (i != newFoodImage.Length - 1)
                    {
                        newImage += newFoodImage[i] + @"\\";
                    }
                    else
                    {
                        newImage += newFoodImage[i];
                        break;
                    }
                }
            }
            else
            {
                newImage = "Chưa có ảnh";
            }

            food.FoodImage = newImage;

            string query = string.Format(@"update food set foodName = '{0}', categoryID = {1}, foodPrice = {2}, foodImage = '{3}' where foodID = {4}", food.FoodName, food.CategoryID, food.FoodPrice, food.FoodImage, food.FoodID);
            int result = DataProvider.Instance.ExecuteNonQuery(@query);
            return result > 0;
        }
        public bool DeleteFood(Food food)
        {
            string query = string.Format(@"update food set status = 0 where foodID = {0}", food.FoodID);
            int result = DataProvider.Instance.ExecuteNonQuery(@query);
            return result > 0;
        }
        public DataTable SearchFood(string name) 
        {
            string query = string.Format("select foodID as `ID món`, foodName as `Tên món`, categoryName as `Tên danh mục`, foodPrice as `Đơn giá`, foodImage as `Hình ảnh` from food, foodcategory where ClosestSearch(foodName) like concat('%', ClosestSearch('{0}'), '%') and food.categoryID = foodcategory.categoryID and food.status = 1", name);
            
            return DataProvider.Instance.ExecuteQuery(@query);

        }
        public bool IsNotAvailableFoodName(string name)
        {
            string query = string.Format("select * from food where foodName = '{0}' and status = 1", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public bool ResetOriginalPicture(Food food)
        {
            string query = string.Format(@"update food set foodImage = 'Chưa có ảnh' where foodID = {0}", food.FoodID);
            int result = DataProvider.Instance.ExecuteNonQuery(@query);
            return result > 0;
        }
    }
}

