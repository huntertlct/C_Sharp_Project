using System;
using System.Data;

namespace QuanLyQuanCafe
{
    public class Employee
    {
        private int emp_no;
        private string emp_name;
        private DateTime emp_dob;
        private string emp_id;
        private string emp_address;
        private string account;
        private int accType;

        public Employee(DataRow row)
        {
            this.Emp_no = (int)row["employee_no"];
            this.Emp_name = row["employee_name"].ToString();
            this.Emp_dob = (DateTime)row["employee_dob"];
            this.Emp_id = row["employee_id"].ToString();
            this.Emp_address = row["employee_address"].ToString();
            this.account = row["account_user"].ToString();
            this.accType = (int)row["account_type"];
        }

        public int Emp_no { get => emp_no; set => emp_no = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public DateTime Emp_dob { get => emp_dob; set => emp_dob = value; }
        public string Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_address { get => emp_address; set => emp_address = value; }
        public string Account { get => account; set => account = value; }
        public int AccType { get => accType; set => accType = value; }
    }
}
