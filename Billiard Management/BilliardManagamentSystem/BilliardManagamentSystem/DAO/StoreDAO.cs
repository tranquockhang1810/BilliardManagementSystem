using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class StoreDAO
    {
        private static StoreDAO instance;

        public static StoreDAO Instance
        {
            get { if (instance == null) { instance = new StoreDAO(); } return instance; }
            private set { instance = value; }
        }
        private StoreDAO() { }

        public Store StoreInfo()
        {
            string query = "select * from storeinfo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Store store = new(row);
                return store;
            }

            return null;
        }
        public bool UpdateInfo(Store store)
        {
            string query = string.Format("update storeinfo set storeName = '{0}', address = '{1}', phone = '{2}', pricePerHour = {3}", store.Name, store.Address, store.Phone, store.PricePerHour);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
