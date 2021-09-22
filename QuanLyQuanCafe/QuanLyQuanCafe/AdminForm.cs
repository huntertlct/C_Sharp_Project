using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyQuanCafe
{
    public partial class AdminForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private static Func func;
        
        Home f1;
        Employees f2;
        Drinks f3;
        Statistic f4;

        private void HideAllForm()
        {
            f1.Hide();
            f2.Hide();
            f3.Hide();
            f4.Hide();
        }

        public AdminForm(Func tmp)
        {
            InitializeComponent();
            func = tmp;
            f1 = new Home(func);
            f2 = new Employees(func);
            f3 = new Drinks(func);
            f4 = new Statistic(func);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.startPoint.X, p.Y-this.startPoint.Y);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangePwd f = new ChangePwd(func);
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HideAllForm();
            f1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            HideAllForm();
            f2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            HideAllForm();
            f3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HideAllForm();
            f4.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbAdminName.Text = func.displayName;
            f1.TopLevel = false;
            f1.AutoScroll = true;
            AdminPanel.Controls.Add(f1);
            f2.TopLevel = false;
            f2.AutoScroll = true;
            AdminPanel.Controls.Add(f2);
            f3.TopLevel = false;
            f3.AutoScroll = true;
            AdminPanel.Controls.Add(f3);
            f4.TopLevel = false;
            f4.AutoScroll = true;
            AdminPanel.Controls.Add(f4);
            f1.Show();
        }
    }
}
