using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }
        public bool Login(string staffID, string password)
        {
            string query = string.Format("call USP_Login( '{0}' , '{1}' )", staffID, CreateMD5(password));

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count > 0;
        }
        public bool CheckPassword(string input, string password)
        {
            return CreateMD5(input).Equals(password);
        }
        public Account GetAccountByStaffID(string staffID)
        {
            string query = string.Format(@"select * from loginaccount where staffID = '{0}'", staffID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }
        public bool ChangePassWord(string staffID, string newPassword)
        {
            string query = string.Format("call USP_ChangePassword( '{0}'  , '{1}' )",staffID, CreateMD5(newPassword));

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool InsertAccount(Account account)
        {
            string query = string.Format("insert into loginaccount (`staffID`, `roleID`, `passWord`) values ('{0}', {1}, '{2}')", account.StaffID, account.RoleID, CreateMD5(account.Password));

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(Account account)
        {
            if (account == null) { return false; }

            string query = string.Format("update loginaccount set status = 0 where staffID = '{0}'", account.StaffID);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public static string CreateMD5(string input)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();
                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(input)))
                    builder.Append(b.ToString("x2").ToLower());
                return builder.ToString();
            }
        }
    }
}
