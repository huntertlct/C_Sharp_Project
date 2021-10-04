using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public class Drink
    {
        private int drinkNo;
        private string drinkName;
        private int drinkPrice;

        public Drink(DataRow row)
        {
            this.DrinkNo = (int)row["drink_no"];
            this.DrinkName = row["drink_name"].ToString();
            this.DrinkPrice = (int)row["drink_price"];
        }

        public int DrinkNo { get => drinkNo; set => drinkNo = value; }
        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int DrinkPrice { get => drinkPrice; set => drinkPrice = value; }
    }
}
