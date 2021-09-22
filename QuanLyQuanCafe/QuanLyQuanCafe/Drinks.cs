using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Drinks : Form
    {
        private Func func;
        public Drinks(Func tmp)
        {
            InitializeComponent();
            func = tmp;
        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            func.loadDrinkAdmin(dgvDrink);
        }
    }
}
