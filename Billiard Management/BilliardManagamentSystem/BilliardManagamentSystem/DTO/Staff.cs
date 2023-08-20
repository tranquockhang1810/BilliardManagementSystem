using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Staff
    {
        private string staffID;
        private string staffName;
        private string staffPhone;
        private string staffEmail;
        private int roleID;
        private int status;
        public Staff(string staffID, int roleID, string staffName, string staffEmail, string staffPhone)
        {
            StaffID = staffID;
            RoleID = roleID;
            StaffName = staffName;
            StaffEmail = staffEmail;
            StaffPhone = staffPhone;
        }
        public Staff(DataRow row)
        {
            StaffID = (string)row["staffID"];

            StaffName = (string)row["staffName"];

            StaffPhone = row["staffPhone"].ToString();

            StaffEmail = row["staffEmail"].ToString();

            RoleID = (int)row["roleID"];

            Status = (int)row["status"];
        }
        public string StaffPhone { get => staffPhone; set => staffPhone = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string StaffEmail { get => staffEmail; set => staffEmail = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public int Status { get => status; set => status = value; }
    }
}
