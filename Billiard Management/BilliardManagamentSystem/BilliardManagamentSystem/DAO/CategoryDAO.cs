using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BilliardManagamentSystem.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAO() { }
        public Category GetCategoryByCategoryName(string categoryName)
        {
            
            string query = "select * from foodcategory where categoryName = '" + categoryName + "' and status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Category category = new(row);
                return category;
            }

            return null;

        }
        public DataTable GetCategoryList()
        {
            string query = "select categoryID as `ID danh mục`, categoryName as `Tên danh mục` from foodcategory where status = 1";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from foodcategory where status = 1 order by categoryName");

            foreach (DataRow row in data.Rows)
            {
                Category category = new Category(row);
                list.Add(category);
            }

            return list;
        }
        public Category GetCategoryByID(int categoryID) 
        {
            string query = "select * from foodcategory where categoryID = " + categoryID + " and status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in data.Rows)
            {
                Category category = new(row);
                return category;
            }

            return null;
        }
        public bool InsertCategory(Category category)
        {
            string query = string.Format("insert into foodcategory(`categoryName`) values ('{0}')", category.CategoryName);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCategory(Category category)
        {
            string query = string.Format("update foodcategory set categoryName = '{0}' where categoryID = {1}", category.CategoryName, category.CategoryID);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(Category category)
        {
            string query = string.Format("update foodcategory set status = 0 where categoryID = {0}", category.CategoryID);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable SearchCategory(string categoryName)
        {
            string query = string.Format("select categoryID as `ID danh mục`, categoryName as `Tên danh mục` from foodcategory where ClosestSearch(categoryName) like concat('%', ClosestSearch('{0}'), '%') and status = 1 ", categoryName);

            return DataProvider.Instance.ExecuteQuery(@query);
        }
    }
}
