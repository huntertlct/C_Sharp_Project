using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public class BillDetail
    {
        private int billNo;
        private int drinkAmount;
        private string drinkName;
        private int drinkPrice;
        private int drinkTotal;

        public BillDetail(DataRow row)
        {
            this.BillNo = (int)row["bill_no"];
            this.DrinkAmount = (int)row["drink_amount"];
            this.DrinkName = row["drink_name"].ToString();
            this.DrinkPrice = (int)row["drink_price"];
            this.DrinkTotal = (int)row["drink_total"];
        }

        public int BillNo { get => billNo; set => billNo = value; }
        public int DrinkAmount { get => drinkAmount; set => drinkAmount = value; }
        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int DrinkPrice { get => drinkPrice; set => drinkPrice = value; }
        public int DrinkTotal { get => drinkTotal; set => drinkTotal = value; }
    }
}
