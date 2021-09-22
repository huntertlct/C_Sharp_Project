using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe
{
    public class Table
    {
        private int no;
        private string name;
        private string stt;

        public Table(DataRow row)
        {
            this.No = (int)row["table_no"];
            this.Name = row["table_name"].ToString();
            this.Stt = row["table_stt"].ToString();
        }

        public string Name { get => name; set => name = value; }
        public string Stt { get => stt; set => stt = value; }
        public int No { get => no; set => no = value; }
    }
}
