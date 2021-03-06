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
    public partial class StaffForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point();
        private static Func func;
        private int locating;

        Home f1;
        Statistic f2;

        public StaffForm(Func tmp)
        {
            InitializeComponent();
            func = tmp;
            f1 = new Home(func);
            f2 = new Statistic(func);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void StaffForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void StaffForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void StaffForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if( locating != 1 )
            {
                f2.Hide();
                f1.Show();
                locating = 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if ( locating != 2 )
            {
                f1.Hide();
                f2.Show();
                locating = 2;
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            lbStaffName.Text = func.displayName;
            f1.TopLevel = false;
            f1.AutoScroll = true;
            StaffPanel.Controls.Add(f1);
            f2.TopLevel = false;
            f2.AutoScroll = true;
            StaffPanel.Controls.Add(f2);
            f1.Show();
            locating = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangePwd f = new ChangePwd(func);
            f.ShowDialog();
        }
    }
}
