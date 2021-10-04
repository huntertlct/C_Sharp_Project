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
    public partial class Statistic : Form
    {
        private Func func;
        public Statistic(Func tmp)
        {
            InitializeComponent();
            func = tmp;
        }

        private void cbStatisticType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatisticType.SelectedItem.Equals("Khoảng thời gian") )
            {
                dpFrom.Enabled = true;
                dpTo.Enabled = true;
            }
            else
            {
                dpFrom.Enabled = false;
                dpTo.Enabled = false;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (cbStatisticType.SelectedIndex != -1)
            {
                Array fromDateArr = dpFrom.Text.Split('/');
                Array toDateArr = dpTo.Text.Split('/');
                string fromDate = "";
                string toDate = "";
                foreach (string s in fromDateArr)
                    fromDate = s + fromDate;
                foreach (string s in toDateArr)
                    toDate = s + toDate;

                if (cbStatisticType.SelectedItem.Equals("Tất cả"))
                {
                    func.loadStatistic(dgvStatistic, "all", fromDate, toDate);
                }
                else
                {
                    func.loadStatistic(dgvStatistic, "time", fromDate, toDate);
                }
            }
        }
    }
}
