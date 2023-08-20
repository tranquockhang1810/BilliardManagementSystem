using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardManagamentSystem.DTO
{
    public class PrintBill 
    {
        private int billID;
        private string tableName;
        private string staffName;
        private string date;
        private string playtime;
        private int discount;
        private double tablePrice;
        private double totalPrice;

        public PrintBill(DataRow row)
        {
            BillID = (int)row["Mã hóa đơn"];
            TableName = (string)row["Tên bàn"];
            StaffName = (string)row["Tên thu ngân"];
            Date = (string)row["Ngày"];
            Playtime = row["Giờ chơi"].ToString();
            Discount = (int)row["Giảm giá (%)"];
            TablePrice = (double)row["Tiền bàn"];
            TotalPrice = (double)row["Tổng tiền"];
        }

        public int BillID { get => billID; set => billID = value; }
        public string TableName { get => tableName; set => tableName = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string Date { get => date; set => date = value; }
        public string Playtime { get => playtime; set => playtime = value; }
        public int Discount { get => discount; set => discount = value; }
        public double TablePrice { get => tablePrice; set => tablePrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
    }

    public class Bill
    {
        private int billID;
        private int tableID;
        private DateTime? checkIn;
        private DateTime? checkOut;
        private int discount;
        private double billTotalPrice;
        private int billStatus;

        public Bill(int billID, int tableID, DateTime? checkIn, DateTime? checkOut, int discount, double billTotalPrice, int billStatus)
        {
            BillID = billID;
            TableID = tableID;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Discount = discount;
            BillTotalPrice = billTotalPrice;
            BillStatus = billStatus;
        }

        public Bill(DataRow row)
        {
            BillID = (int)row["billID"];
            TableID = (int)row["tableID"];
            CheckIn = (DateTime?)row["checkIn"];

            var checkOutTemp = row["checkOut"];
            if (checkOutTemp.ToString() != "")
            {
                CheckOut = (DateTime?)checkOutTemp;
            }

            Discount = (int)row["discount"];
            BillTotalPrice = (double)row["billTotalPrice"];
            BillStatus = (int)row["billStatus"];
        }

        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public int BillID { get => billID; set => billID = value; }
        public int TableID { get => tableID; set => tableID = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int Discount { get => discount; set => discount = value; }
        public double BillTotalPrice { get => billTotalPrice; set => billTotalPrice = value; }
        public int BillStatus { get => billStatus; set => billStatus = value; }
    }
}
