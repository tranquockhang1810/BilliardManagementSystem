using BilliardManagamentSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }

        private StaffDAO() { }

        public Staff GetStaffByStaffID(string staffID)
        {
            string query = string.Format(@"select * from staff where staffID = '{0}'", staffID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                return new Staff(row);
            }
            return null;
        }
        public string GetStaffRoleName(int roleID)
        {
            string query = "select roleName from staffrole where roleID = " + roleID;
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
        public bool UpdateProfile(string staffID, string newName, string newEmail, string newPhone)
        {
            string query = string.Format("update staff set staffEmail = '{0}', staffPhone = '{1}', staffName = '{2}' where staffID = '{3}'", newEmail, newPhone, newName, staffID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CheckEmail(string staffID, string staffEmail)
        {
            string query = string.Format("call USP_CheckEmail( '{0}'  , '{1}' )", staffID, staffEmail);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }
        public DataTable GetStaffList()
        {
            string query = "select staffID as `ID nhân viên`, staffName as `Tên nhân viên`, roleName as `Vị trí`, staffEmail as `Email`, staffPhone as `Số điện thoại` from staff, staffrole where staff.roleID = staffrole.roleID and staff.status = 1";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetStaffListByRole(int roleID)
        {
            string query = string.Format("select staffID as `ID nhân viên`, staffName as `Tên nhân viên`, roleName as `Vị trí`, staffEmail as `Email`, staffPhone as `Số điện thoại` from staff, staffrole where staff.roleID = staffrole.roleID and staff.status = 1 and staff.roleID = {0}", roleID);

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertStaff(Staff staff)
        {
            string query = string.Format("insert into staff (`staffID`, `roleID`, `staffName`, `staffEmail`, `staffPhone`) values ('{0}', {1}, '{2}', '{3}', '{4}')", staff.StaffID, staff.RoleID, staff.StaffName, staff.StaffEmail, staff.StaffPhone);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteStaff(Staff staff)
        {
            string query = string.Format("update staff set status = 0 where staffID = '{0}'", staff.StaffID);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable SearchStaff(string name)
        {
            string query = string.Format("select staffID as `ID nhân viên`, staffName as `Tên nhân viên`, roleName as `Vị trí`, staffEmail as `Email`, staffPhone as `Số điện thoại` from staff, staffrole where staff.roleID = staffrole.roleID and ClosestSearch(staffName) like concat('%', ClosestSearch('{0}'),'%') and status = 1", name);
            
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool IsAvailableStaffID(string staffID, string staffEmail, string staffPhone)
        {
            string query = string.Format("select * from staff where staffID = '{0}' or staffEmail = '{1}' and status = 1  or staffPhone = '{2}' and status = 1", staffID, staffEmail, staffPhone);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count > 0;
        }
    }
}
