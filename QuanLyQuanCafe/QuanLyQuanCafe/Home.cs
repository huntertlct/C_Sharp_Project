using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Home : Form
    {
        private Func func;
        private int billTotal;
        private List<Drink> drinkList;

        //hiển thị các bàn có trong CSDL
        private void LoadTable()
        {
            flpHome.Controls.Clear();
            List<Table> tableList = func.getTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() {Width = Func.TableWitdh, Height = Func.TableHeight };
                btn.Text = item.Name + Environment.NewLine + Environment.NewLine + item.Stt;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.Stt)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpHome.Controls.Add(btn);
            }
        }

        //hiển thị danh sách nước uống trong combobox
        private void loadDisplayDrink(string name)
        {
            cbDrink.Items.Clear();
            cbDrink.ResetText();
            if ( name.Length == 0 )
            {
                foreach (Drink item in drinkList)
                    cbDrink.Items.Add(item.DrinkName);
            }
            else
            {
                foreach (Drink item in drinkList)
                    if(item.DrinkName.Contains(name))
                        cbDrink.Items.Add(item.DrinkName);
            }
            if(cbDrink.Items.Count > 0) cbDrink.SelectedIndex = 0;
        }

        //hiển thị thông tin hóa đơn
        private void showBill(int id)
        {
            lvBill.Items.Clear();
            billTotal = 0;
            List<BillDetail> billDetailList = func.getBillDetailList(func.getUncheckBillNoByTableNo(id));

            foreach(BillDetail item in billDetailList)
            {
                ListViewItem lvItem = new ListViewItem(item.DrinkName.ToString());
                lvItem.SubItems.Add(item.DrinkAmount.ToString());
                lvItem.SubItems.Add(item.DrinkPrice.ToString("N0"));
                lvItem.SubItems.Add(item.DrinkTotal.ToString("N0") + "đ");
                billTotal += item.DrinkTotal;

                lvBill.Items.Add(lvItem);
            }
            txtBillTotal.Text = billTotal.ToString("N0") + "đ";
        }

        private void btn_Click(Object sender, EventArgs e)
        {
            int tableNo = ((sender as Button).Tag as Table).No;
            lvBill.Tag = (sender as Button).Tag;
            showBill(tableNo);
        }
        public Home(Func tmp)
        {
            InitializeComponent();
            func = tmp;
            drinkList = func.getDrinkList();
            LoadComboboxTable();
        }

        private void txtDrinkSearch_TextChanged(object sender, EventArgs e)
        {
            loadDisplayDrink(txtDrinkSearch.Text);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadDisplayDrink("");
            LoadTable();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvBill.Tag as Table;
                if (table == null) throw new Exception("Vui lòng chọn bàn!");
                int billNo = func.getUncheckBillNoByTableNo(table.No);
                int drinkNo = func.getDrinkNoByName(cbDrink.SelectedItem.ToString());
                int drinkAmount = (int)nudDrinkAmount.Value;
                if (billNo == -1)
                {
                    func.createBill(table.No);
                    func.addBillDetail(func.getMaxBillNo(), drinkNo, drinkAmount);
                    LoadTable();
                    LoadComboboxTable();
                }
                else
                {
                    func.addBillDetail(billNo, drinkNo, drinkAmount);
                }
                showBill(table.No);
                nudDrinkAmount.Value = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tạo bàn mới!");
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            if (table != null)
            {
                int billNo = func.getUncheckBillNoByTableNo(table.No);

                if (billNo != -1)
                {
                    if (MessageBox.Show("Thanh toán hóa đơn " + table.Name + "?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        func.checkOut(billNo, txtBillTotal.Text.Replace(",", "").Replace("đ", ""));
                        showBill(table.No);
                        LoadTable();
                        LoadComboboxTable();
                    }
                }
            }
            else MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadComboboxTable ()
        {
            cbTableSwitch.DataSource = func.getEmptyTableList();
            cbTableSwitch.DisplayMember = "Name";
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            int table1No = (lvBill.Tag as Table).No;
            int table2No = (cbTableSwitch.SelectedItem as Table).No;
            if( func.getUncheckBillNoByTableNo(table1No) != -1 )
            if( MessageBox.Show("Chuyển bàn " + table1No + " sang bàn " + table2No + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                func.switchTable(table1No, table2No);
                LoadTable();
                LoadComboboxTable();
            }
        }
    }
}
