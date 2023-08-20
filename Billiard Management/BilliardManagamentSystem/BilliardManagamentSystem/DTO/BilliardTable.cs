using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class BilliardTable
    {
        private int id;
        private string name;
        private string status;
        private string type;
        private int deleteStatus;
        public BilliardTable(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public BilliardTable(DataRow row)
        {
            Id = (int)row["tableID"];
            Name = (string)row["tableName"];
            Status = (string)row["tableStatus"];
            Type = (string)row["tableType"];
            DeleteStatus = (int)row["deleteStatus"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }
        public int DeleteStatus { get => deleteStatus; set => deleteStatus = value; }
    }
}
