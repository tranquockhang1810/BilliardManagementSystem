using BilliardManagamentSystem.DTO;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        private TableDAO() { }
        public List<BilliardTable> LoadTableList()
        {
            List<BilliardTable> list = new List<BilliardTable>();

            string query = string.Format("select * from billiardtable where deleteStatus = 1");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                BilliardTable table = new BilliardTable(row);
                list.Add(table);
            }

            return list;
        }
        public void SetTableStatusToNotEmpty(int tableID)
        {
            string query = "update billiardtable set tableStatus = 'Có người' where tableID = " + tableID;

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void SetTableStatusToEmpty(int tableID)
        {
            string query = "update billiardtable set tableStatus = 'Trống' where tableID = " + tableID;

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void ChangeTable(int tableID1, int tableID2)
        {
            string query = string.Format("call USP_ChangeTable( {0} , {1} )", tableID1, tableID2);

            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GetTableIDByBillID(int billID)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select tableID from bill where billStatus = 0 and billID = " + billID);
            }
            catch 
            { 
                return -1;
            }

        }
        public DataTable GetTableListForAdmin()
        {
            string query = "select tableID as `ID bàn`, tableName as `Tên bàn`, tableType as `Loại bàn` from billiardtable where deleteStatus = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertTable(BilliardTable table)
        {
            string query = string.Format("insert into billiardtable(`tableName`, `tableType`) values ('{0}', '{1}')", table.Name, table.Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(BilliardTable table)
        {
            string query = string.Format("update billiardtable set tableName = '{0}', tableType = '{1}' where tableID = {2}", table.Name, table.Type, table.Id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(BilliardTable table)
        {
            string query = string.Format("update billiardtable set deleteStatus = 0 where tableID = {0}", table.Id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable SearchTable(string name)
        {
            string query = string.Format("select tableID as `ID bàn`, tableName as `Tên bàn`, tableType as `Loại bàn` from billiardtable where deleteStatus = 1 and ClosestSearch(tableName) like concat('%', ClosestSearch('{0}'), '%') and deleteStatus = 1", name);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public BilliardTable GetTableByID(int tableID)
        {
            string query = "select * from billiardtable where deleteStatus = 1 and tableID = " + tableID;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                BilliardTable table = new BilliardTable(row);
                return table;
            }
            return null;
        }
    }
}
