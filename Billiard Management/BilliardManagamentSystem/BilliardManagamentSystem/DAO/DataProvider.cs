using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = "Server = localhost; Database = billiardmanagement; Port = 3306; User = root; Password = tranquockhang1";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance =  value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionSTR))
            {
                connection.Open();

                MySqlCommand cmd;
                
                cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionSTR))
            {
                connection.Open();
                MySqlCommand cmd;
                
                cmd = new MySqlCommand(query, connection);

                data = cmd.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public object ExecuteScalar(string query)
        {
            object data = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionSTR))
            {
                connection.Open();

                MySqlCommand cmd;
                
                cmd = new MySqlCommand(query, connection);

                data = cmd.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
