using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class Store
    {
        private string name;
        private string address;
        private string email;
        private string password;
        private string phone;
        private double pricePerHour;

        public Store(string name, string address,string phone, double pricePerHour)
        {
            Name = name;
            Address = address;
            Phone = phone;
            PricePerHour = pricePerHour;
        }

        public Store(DataRow row)
        {
            Name = (string)row["storeName"];
            Address = (string)row["address"];
            Phone = (string)row["phone"];
            PricePerHour = (double)row["pricePerHour"];
            Email = (string)row["email"];
            Password = (string)row["mailPassword"];
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public double PricePerHour { get => pricePerHour; set => pricePerHour = value; }
    }
}
