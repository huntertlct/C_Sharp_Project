using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private SqlConnection conn;
        private Func func = new Func();
        private AdminForm fAdmin;
        private StaffForm fStaff;

        private void Auth()
        {
            if (func.AccountAuth(txtUser.Text, txtPwd.Text) == 1)
            {
                if(fAdmin == null)
                {
                    fAdmin = new AdminForm(func);
                }    
                this.Hide();
                fAdmin.ShowDialog();
                if (fAdmin.IsDisposed)
                {
                    func.DisconnectDB();
                    Application.Exit();
                }
                this.Show();
                //txtUser.Clear();
                //txtPwd.Clear();
            }
            else if (func.AccountAuth(txtUser.Text, txtPwd.Text) == 0)
            {
                if(fStaff == null)
                {
                    fStaff = new StaffForm(func);
                }    
                this.Hide();
                fStaff.ShowDialog();
                if (fStaff.IsDisposed)
                {
                    func.DisconnectDB();
                    Application.Exit();
                }
                this.Show();
                //txtUser.Clear();
                //txtPwd.Clear();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Auth();
            }    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                conn = func.ConnectDB();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối DB!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            func.DisconnectDB();
        }
    }
}
