using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyQuanCafe
{
    public partial class Employees : Form
    {
        private Func func;
        private string sqlstr = "";
        private SqlCommand cmd;
        private static SqlConnection conn;

        public Employees(Func tmp)
        {
            InitializeComponent();
            func = tmp;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            func.loadEmployee(dgvEmployee);
        }
    }
}
