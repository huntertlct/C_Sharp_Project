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

        public Drink() { }

        public Drink(DataRow row)
        {
            this.DrinkNo = (int)row["drink_no"];
            this.DrinkName = row["drink_name"].ToString();
        }

        public int DrinkNo { get => drinkNo; set => drinkNo = value; }
        public string DrinkName { get => drinkName; set => drinkName = value; }
    }
}
