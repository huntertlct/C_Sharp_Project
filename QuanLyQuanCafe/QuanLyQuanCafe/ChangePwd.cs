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
    public partial class ChangePwd : Form
    {
        private Point startPoint = new Point(0, 0);
        private bool dragging = false;
        private Func func;

        public ChangePwd(Func tmp)
        {
            InitializeComponent();
            this.func = tmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePwd_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void ChangePwd_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ChangePwd_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Length > 0 && txtNewPwd.Text.Length > 0 && txtCfmPwd.Text.Length > 0)
            {
                int result = func.changePWD(txtOldPwd.Text, txtNewPwd.Text, txtCfmPwd.Text);
                if (result == 0) this.Close();
            }
            else MessageBox.Show("Vui lòng nhập tất cả cả các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
