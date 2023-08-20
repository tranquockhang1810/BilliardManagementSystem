using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Role
    {
        private int iD;
        private string name;
        private int status;

        public Role(string name)
        {
            Name = name;
        }

        public Role (DataRow row)
        {
            ID = (int)row["roleID"];
            Name = (string)row["roleName"];
            Status = (int)row["status"];
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
    }
}
