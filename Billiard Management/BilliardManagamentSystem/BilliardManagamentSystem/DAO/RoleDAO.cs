using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;
        public static RoleDAO Instance 
        {
            get { if (instance == null) { instance = new RoleDAO(); } return instance; }
            private set { instance = value; }
        }
        private RoleDAO() { }
        public List<Role> GetRoleList()
        {
            List<Role> list = new List<Role>();

            string query = "select * from staffrole where status = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                Role role = new Role(row);
                list.Add(role);
            }

            return list;
        }
        public DataTable GetRoleTable()
        {
            string query = "select roleID as `ID vị trí`, roleName as `Tên vị trí` from staffrole where status = 1";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public Role GetRoleByID(int roleID)
        {
            string query = string.Format("select * from staffrole where status = 1 and roleID = {0}", roleID);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Role role = new Role(row);
                return role;
            }

            return null;
        }
        public Role GetRoleByName(string roleName)
        {
            string query = string.Format("select * from staffrole where status = 1 and roleName = '{0}'", roleName);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Role role = new Role(row);
                return role;
            }

            return null;
        }
        public bool CanBeChangeOrDeleteRole(Role role)
        {
            Role admin = GetRoleByID(1);
            Role casher = GetRoleByID(2);
            if (role.ID == admin.ID || role.ID == casher.ID)
            {
                return false;
            }
            return true;
        }
    }
}
