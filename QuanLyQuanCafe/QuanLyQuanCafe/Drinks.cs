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
        private string toDo;

        public Drinks(Func tmp)
        {
            InitializeComponent();
            func = tmp;
            toDo = "";
        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            func.loadDrinkAdmin(dgvDrink, "");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            txtDrinkNo.Clear();
            txtDrinkName.Clear();
            txtDrinkPrice.Clear();
            toDo = "";
        }

        private void dgvDrink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Drink drink = func.getDrinkInfo(dgvDrink.Rows[dgvDrink.CurrentCell.RowIndex].Cells[0].Value.ToString());
            txtDrinkNo.Text = drink.DrinkNo.ToString();
            txtDrinkName.Text = drink.DrinkName;
            txtDrinkPrice.Text = drink.DrinkPrice.ToString();
            toDo = "update";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (toDo.Equals("update"))
                MessageBox.Show("Bạn đang ở chế độ cập nhật thông tin nước uống!", "Thông báo");
            else
            {
                if (txtDrinkName.Text.Length > 0 && txtDrinkPrice.Text.Length > 0)
                {
                    func.createDrink(txtDrinkName.Text, Convert.ToInt32(txtDrinkPrice.Text));
                    func.loadDrinkAdmin(dgvDrink, "");
                    bunifuButton4_Click(null, null);
                }
                else 
                    MessageBox.Show("Tất cả các trường không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (txtDrinkNo.Text.Length > 0)
            {
                func.deleteDrink(txtDrinkNo.Text);
                func.loadDrinkAdmin(dgvDrink, "");
                bunifuButton4_Click(null, null);
            }
            else
                MessageBox.Show("Vui lòng chọn thức uống cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if ( txtDrinkNo.Text.Length > 0 )
            {
                if( txtDrinkName.Text.Length > 0 && txtDrinkPrice.Text.Length > 0 )
                {
                    func.updateDrinkInfo(txtDrinkNo.Text, txtDrinkName.Text, txtDrinkPrice.Text);
                    func.loadDrinkAdmin(dgvDrink, "");
                    bunifuButton4_Click(null, null);
                }   
                else
                    MessageBox.Show("Tất cả các trường không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn thức uống cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            func.loadDrinkAdmin(dgvDrink, txtDrinkFilter.Text);
        }
    }
}
