using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Account
    {
        private string staffID;
        private string password;
        private int roleID;
        private int status;
        private int loginTime;
        public Account(string staffID,int roleID)
        {
            StaffID = staffID;
            RoleID = roleID;
        }
        public Account(DataRow row)
        {
            StaffID = row["staffID"].ToString();
            Password = row["passWord"].ToString();
            RoleID = (int)row["roleID"];
            Status = (int)row["status"];
            LoginTime = (int)row["loginTime"];
        }
        public string StaffID { get => staffID; set => staffID = value; }
        public string Password { get => password; set => password = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public int Status { get => status; set => status = value; }
        public int LoginTime { get => loginTime; set => loginTime = value; }
    }
}
