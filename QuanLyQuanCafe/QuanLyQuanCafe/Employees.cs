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
        private string toDo = "";

        private bool checkEmpty()
        {
            if ( txtName.Text.Length > 0 && txtID.Text.Length > 0 && txtxAddress.Text.Length > 0 && txtAccount.Text.Length > 0  && cbAccType.Text.Length > 0)
            {
                if (cbAccType.Text.Equals("0") || cbAccType.Text.Equals("1"))
                    return true;
                else MessageBox.Show("Loại tài khoản không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            return false;
        }

        public Employees(Func tmp)
        {
            InitializeComponent();
            func = tmp;
            func.loadEmployee(dgvEmployee, "");
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee emp = func.getEmployeeInfo(dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[0].Value.ToString());
            txtEmpNo.Text = emp.Emp_no.ToString();
            txtName.Text = emp.Emp_name;
            dpDOB.Value = emp.Emp_dob;
            txtID.Text = emp.Emp_id;
            txtxAddress.Text = emp.Emp_address;
            txtAccount.Text = emp.Account;
            txtAccount.ReadOnly = true;
            cbAccType.Text = emp.AccType.ToString();
            toDo = "update";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (toDo.Equals("update"))
                MessageBox.Show("Bạn đang ở chế độ cập nhật thông tin nhân viên!", "Thông báo");
            else if ( checkEmpty() == true )
            {
                func.createEmployee(txtName.Text, dpDOB.Text, txtID.Text, txtxAddress.Text, txtAccount.Text, Convert.ToInt32(cbAccType.SelectedItem));
                func.loadEmployee(dgvEmployee, "");
                bunifuButton4_Click(null, null);
            }
            else
            {
                MessageBox.Show("Tất cả các trường không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            txtEmpNo.Clear();
            txtName.Clear();
            dpDOB.Value = DateTime.Today;
            txtID.Clear();
            txtxAddress.Clear();
            txtAccount.Clear();
            txtAccount.ReadOnly = false;
            cbAccType.SelectedIndex = -1;
            toDo = "";
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Length > 0)
            {
                if ( MessageBox.Show("Đặt lại mật khẩu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    func.resetPassword(txtEmpNo.Text);
                    bunifuButton4_Click(null, null);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản cần đặt lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text.Length > 0)
            {
                func.deleteEmployee(txtEmpNo.Text, txtAccount.Text);
                func.loadEmployee(dgvEmployee, "");
                bunifuButton4_Click(null, null);
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if( txtEmpNo.Text.Length > 0 )
            {
                if (txtName.Text.Length > 0 && txtID.Text.Length > 0 && txtxAddress.Text.Length > 0)
                {
                    func.updateEmpInfo(txtEmpNo.Text, txtName.Text, dpDOB.Text, txtID.Text, txtxAddress.Text, cbAccType.Text);
                    func.loadEmployee(dgvEmployee, "");
                    bunifuButton4_Click(null, null);
                }
                else MessageBox.Show("Các trường không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn tài khoản cần chỉnh sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            func.loadEmployee(dgvEmployee, txtFilter.Text);
        }
    }
}
