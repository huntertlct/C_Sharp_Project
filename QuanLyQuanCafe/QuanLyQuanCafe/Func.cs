using System;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace QuanLyQuanCafe
{
    public class Func
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sqlstr = "";
        private string user;

        public static int TableWitdh = 95;
        public static int TableHeight = 95;
        public string displayName
        {
            set;
            get;
        }

        //hàm băm mật khẩu
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        //xác thực tài khoản
        public int AccountAuth(string user, string pwd)
        {
            string authpwd = "";
            try
            {
                cmd = new SqlCommand("getPwd", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@acc_user", SqlDbType.VarChar).Value = user;
                authpwd = cmd.ExecuteScalar().ToString();
                string hPwd = ComputeHash(pwd, new SHA256CryptoServiceProvider());
                hPwd = hPwd.Replace("-", "").ToLower();
                if (hPwd.Equals(authpwd))
                {
                    cmd = new SqlCommand("getEmpName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@acc_user", SqlDbType.VarChar).Value = user;
                    this.user = user;
                    this.displayName = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand("EXEC dbo.getAccType @acc_user = '" + user + "'", conn);
                    return Convert.ToInt32( cmd.ExecuteScalar());
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        //kết nối cơ sở dữ liệu
        public SqlConnection ConnectDB()
        {
            conn = new SqlConnection("Server=MATRIX_PHAN\\SQLEXPRESS; UID=sa; pwd=vip@123; Database=QuanLyQuanCafe");
            conn.Open();
            return conn;
        }

        //ngắn kết nối cơ sở dữ liệu
        public void DisconnectDB()
        {
            conn.Close();
        }

        //load dữ liệu nhân viên cho form admin
        public void loadEmployee(DataGridView dgv)
        {
            try
            {
                sqlstr = "EXEC getEmployee";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                dgv.AutoResizeColumns();
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi load dữ liệu nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //load dữ liệu nước uống cho form admin
        public void loadDrinkAdmin(DataGridView dgv)
        {
            try
            {
                sqlstr = "SELECT drink_no AS 'Mã đồ uống'," +
                                " drink_name AS 'Tên đồ uống'," +
                                " drink_price AS 'Giá'" +
                        " FROM cf_drink";
                SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                //dgv.AutoResizeColumns();
                //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi load dữ liệu nước uống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //thay đổi mật khẩu
        public int changePWD(string oldPwd, string newPwd, string cfmPwd)
        {
            try
            {
                if (newPwd.Equals(cfmPwd))
                {
                    oldPwd = ComputeHash(oldPwd, new SHA256CryptoServiceProvider());
                    oldPwd = oldPwd.Replace("-", "").ToLower();
                    cmd = new SqlCommand("getPwd", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@acc_user", SqlDbType.VarChar).Value = this.user;
                    string authPwd = cmd.ExecuteScalar().ToString();
                    if (authPwd.Equals(oldPwd))
                    {
                        newPwd = ComputeHash(newPwd, new SHA256CryptoServiceProvider());
                        newPwd = newPwd.Replace("-", "").ToLower();
                        cmd = new SqlCommand("changePwd", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@newPwd", SqlDbType.Char).Value = newPwd;
                        cmd.Parameters.Add("@acc_user", SqlDbType.VarChar).Value = this.user;
                        int reusult = cmd.ExecuteNonQuery();
                        if (reusult == 1)
                        {
                            MessageBox.Show("Đã thay đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return 0;
                        }
                        else MessageBox.Show("Lỗi thay đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận chưa chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 1;
        }

        //lấy ra danh sách bàn
        public List<Table> getTableList()
        {
            List<Table> tableList = new List<Table>();
            sqlstr = "EXEC getTableList";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public List<Table> getEmptyTableList()
        {
            List<Table> tableList = new List<Table>();
            sqlstr = "SELECT * FROM dbo.Cf_Table WHERE table_stt = N'Trống'";
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        //lấy mã hóa đơn chưa thanh toán của bàn có số = tableNo
        /// <summary>
        /// Thành công: billNo
        /// Thất bại: -1
        /// </summary>
        /// <param name="tableNo"></param>
        /// <returns></returns>
        public int getUncheckBillNoByTableNo(int tableNo)
        {
            sqlstr = "EXEC getUncheckBillByTableNo @tableNo = " + tableNo;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                Bill bill = new Bill(dt.Rows[0]);
                return bill.BillNo;
            }
            return -1;
        }

        //lấy danh sách chi tiết hóa đơn
        public List<BillDetail> getBillDetailList(int billNo)
        {
            List<BillDetail> billDetailList = new List<BillDetail>();

            sqlstr = "EXEC getBillDetailListByBillNo @billNo = " + billNo;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach(DataRow item in dt.Rows)
            {
                BillDetail detail = new BillDetail(item);
                billDetailList.Add(detail);
            }

            return billDetailList;
        }

        //lấy danh sách nước uống
        public List<Drink> getDrinkList()
        {
            List<Drink> drinkList = new List<Drink>();
            SqlDataAdapter ds = new SqlDataAdapter("EXEC getDrinkList", conn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                Drink item = new Drink(row);
                drinkList.Add(item);
            }

            return drinkList;
        }

        //lấy mã nước uống theo tên
        public int getDrinkNoByName(string name)
        {
            sqlstr = "SELECT drink_no FROM cf_drink WHERE drink_name = N'" + name + "'";
            cmd = new SqlCommand(sqlstr, conn);
            return (int)cmd.ExecuteScalar();
        }

        //lấy giá trị lớn nhất của bill_no
        public int getMaxBillNo()
        {
            try
            {
                sqlstr = "SELECT MAX(bill_no) FROM cf_bill";
                cmd = new SqlCommand(sqlstr, conn);
                return Convert.ToInt32( cmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                return -1;
            }
        }

        //thêm hóa đơn theo số bàn
        public void createBill(int No)
        {
            sqlstr = "EXEC dbo.createBillByTableNo @tableNo = " + No;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }

        //thêm chi tiết hóa đơn
        public void addBillDetail(int billNo, int drinkNo, int drinkAmount)
        {
            sqlstr = "EXEC dbo.addBillDetail @billNo = " + billNo + ", @drinkNo = " + drinkNo + ", @drinkAmount = " + drinkAmount;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }

        //thanh toán hóa đơn
        public void checkOut(int No)
        {
            sqlstr = "EXEC payBill @billNo = " + No;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }

        //chuyển bàn
        public void switchTable(int table1, int table2)
        {
            sqlstr = "EXEC dbo.switchTable @table1 = " + table1 + ", @table2 = " + table2;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }

        //tạo nhân viên mới
        public void createEmployee(string name, string dobTmp, string id, string address, string account, int accType)
        {
            Array arr = dobTmp.Split('/');
            string dob = "";
            foreach(string s in arr)
                dob = s + dob;
            if (name.Length != 0 && id.Length != 0 && account.Length != 0 && (accType == 1 || accType == 0))
            {
                string hPwd = ComputeHash(id, new SHA256CryptoServiceProvider());
                hPwd = hPwd.Replace("-", "").ToLower();
                sqlstr = "EXEC dbo.createEmployee @name = N'" + name + "', @dob = '" + dob + "', @id = '" + id + "', @address = N'" + address 
                                            + "', @account = '" + account + "', @pwd = '" + hPwd + "', @accType = " + accType;
                cmd = new SqlCommand(sqlstr, conn);
                cmd.ExecuteNonQuery();
            }
            else MessageBox.Show("Vui lòng nhập đủ các trường thông tin!", "Thông báo");
        }

        //hiển thị thông tin nhân viên lên form
        public Employee getEmployeeInfo (string empNo)
        {
            sqlstr = "EXEC dbo.getEmployeeInfoByNo @empNo = " + empNo;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            Employee emp = new Employee(dt.Rows[0]);

            return emp;
        }

        //đặt lại mật khẩu cho tài khoản
        public void resetPassword(string empNo)
        {
            sqlstr = "EXEC dbo.getEmployeeInfoByNo @empNo = " + empNo;
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, conn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            Employee emp = new Employee(dt.Rows[0]);

            string hPwd = ComputeHash(emp.Emp_id.Trim(), new SHA256CryptoServiceProvider());
            hPwd = hPwd.Replace("-", "").ToLower();
            sqlstr = "EXEC dbo.resetPwdByEmpNo @empNo = " + empNo + ", @newPwd = '" + hPwd + "'";
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }

        //xóa nhân viên
        public void deleteEmployee(string empNo)
        {
            sqlstr = "EXEC dbo.deleteEmployeeByNo @empNo = " + empNo;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }
        
        //sửa thông tin nhân viên
        public void updateEmpInfo(string empNo, string name, string dobTmp, string id, string address, string accType)
        {
            Array arr = dobTmp.Split('/');
            string dob = "";
            foreach (string s in arr)
                dob = s + dob;
            sqlstr = "EXEC dbo.UpdateEmpInfoByNo @empNo = " + empNo 
                                            + ", @empName = N'" + name 
                                            + "', @empDob = '" + dob 
                                            + "', @empID = '" + id 
                                            + "', @empAddress = N'" + address 
                                            + "', @accType = " + accType;
            cmd = new SqlCommand(sqlstr, conn);
            cmd.ExecuteNonQuery();
        }
    }
}