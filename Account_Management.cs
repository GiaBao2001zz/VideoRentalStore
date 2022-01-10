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

namespace VideoRentalStore
{
    public partial class Account_Management : Form
    {
        public Account_Management()
        {
            InitializeComponent();
            Load_DataGrid();
        }
        //string connectionSTR = @"Data Source = ADMJIN; Initial Catalog = VideoRentalStore; Integrated Security = True";
        string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
        
        private void Load_DataGrid()
        {
            SqlConnection Sqlcon = new SqlConnection(connectionSTR);
            Sqlcon.Open();
            string str = "select * from Account";
            SqlDataAdapter sqlDa = new SqlDataAdapter(str, Sqlcon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid_AccountManagement.DataSource = dtbl;
        }

         void DataGrid_ManageStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex.Equals(-1))
            {
                MessageBox.Show("Không được click vào header!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(DataGrid_AccountManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //Hiện mật khẩu dưới dạng không che
                SqlConnection Sqlcon = new SqlConnection(connectionSTR);
                Sqlcon.Open();
                string user = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtUsername"].FormattedValue.ToString();
                string a = "Select Password from Account where Username = '" + user + "'";
                SqlCommand cmd = new SqlCommand(a, Sqlcon);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    TextBox_Password.Text = da.GetValue(0).ToString();
                }
                
                //CheckBox
                if (CheckBox_HidePass.Checked)
                {
                    TextBox_Password.isPassword = true;

                }
                else
                {
                    TextBox_Password.isPassword = false;

                }
                
                //Hiện thông tin khi click vào Cell
                DataGrid_AccountManagement.CurrentRow.Selected = true;
                //DataGrid_AccountManagement.Rows[0].ReadOnly = true;
                Textbox_Username.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtUsername"].FormattedValue.ToString();
                TextBox_DisplayName.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtDisplayName"].FormattedValue.ToString();
                //TextBox_Password.Text = ;
                TextBox_PhoneNum.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtPhoneNumber"].FormattedValue.ToString();
                TextBox_Email.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtEmail"].FormattedValue.ToString();
                Label_DateCreate.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtDateCreate"].FormattedValue.ToString();
                TextBox_CMND.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtCMND"].FormattedValue.ToString();
                TextBox_Address.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtAddress"].FormattedValue.ToString();
                Textbox_Type.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["txtType"].FormattedValue.ToString();

            }
            else
            {
                Load_DataGrid();
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            string username = Textbox_Username.Text;
            string displayname = TextBox_DisplayName.Text;
            string email = TextBox_Email.Text;
            string phonenumber = TextBox_PhoneNum.Text;
            string cmnd = TextBox_CMND.Text;
            string address = TextBox_Address.Text;
            string password = TextBox_Password.Text;
            string t = Textbox_Type.Text;
            DateTime now = DateTime.Now;

            SqlConnection Sqlcon = new SqlConnection(connectionSTR);
            Sqlcon.Open();

            //Check Username
            string check = "SELECT Username FROM Account WHERE Username = '" + username + " ' ";
            SqlCommand command = new SqlCommand(check, Sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable i = new DataTable();
            adapter.Fill(i);

            //Check Type
            if(username.Length<1|| displayname.Length < 1 || email.Length < 1 || phonenumber.Length < 1 || cmnd.Length < 1 || address.Length < 1 || t.Length < 1)
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (t != "0" && t != "1")
            {
                MessageBox.Show("Type sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (username.Length < 4 || password.Length < 4 || username.Length > 20 || password.Length > 20)
            {
                MessageBox.Show("Vui lòng dùng tài khoản và mật khẩu từ 4-20 ký tự! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (i.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int type = Convert.ToInt32(t);
                string sql = "insert into Account values('" + username + "',N'" + displayname + "','" + password + "','" + phonenumber
                    + "','" + email + "','" + now + "','" + cmnd + "',N'" + address + "'," + type + ")";

                SqlCommand commandd = new SqlCommand(sql, Sqlcon);
                commandd.ExecuteNonQuery();
                Sqlcon.Close();

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DataGrid();
                Textbox_Username.Text = "";
                TextBox_DisplayName.Text = "";
                TextBox_Password.Text = "";
                TextBox_PhoneNum.Text = "";
                TextBox_Email.Text = "";
                Label_DateCreate.Text = "";
                TextBox_CMND.Text = "";
                TextBox_Address.Text = "";
                Textbox_Type.Text = "";
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                int index = DataGrid_AccountManagement.SelectedRows[0].Index;
                string username = DataGrid_AccountManagement.Rows[DataGrid_AccountManagement.SelectedRows[0].Index].
                    Cells["txtUsername"].Value.ToString();
              

                SqlConnection Sqlcon = new SqlConnection(connectionSTR);
                Sqlcon.Open();
                string str = "delete Account where Username ='" + username + "'";
                SqlCommand cmd = new SqlCommand(str, Sqlcon);
                cmd.ExecuteNonQuery();
                Sqlcon.Close();

                DataGrid_AccountManagement.Rows.RemoveAt(index);

                Textbox_Username.Text = "";
                TextBox_DisplayName.Text = "";
                TextBox_Password.Text = "";
                TextBox_PhoneNum.Text = "";
                TextBox_Email.Text = "";
                Label_DateCreate.Text = "";
                TextBox_CMND.Text = "";
                TextBox_Address.Text = "";
                Textbox_Type.Text = "";
            }

        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            string dbusername = DataGrid_AccountManagement.Rows[DataGrid_AccountManagement.SelectedRows[0].Index].
                    Cells["txtUsername"].Value.ToString();
            string username = Textbox_Username.Text ;
            string displayname = TextBox_DisplayName.Text ;
            string password = TextBox_Password.Text ;
            string phonenumber = TextBox_PhoneNum.Text ;
            string email = TextBox_Email.Text ;
            string datecreate = Label_DateCreate.Text ;
            string cmnd = TextBox_CMND.Text ;
            string address = TextBox_Address.Text ;
            string typ = Textbox_Type.Text ;
            

            SqlConnection Sqlcon = new SqlConnection(connectionSTR);
            Sqlcon.Open();

            if (username.Length < 1 || displayname.Length < 1 || email.Length < 1 || phonenumber.Length < 1 || cmnd.Length < 1 || address.Length < 1 || typ.Length < 1)
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (typ != "0" && typ != "1")
            {
                MessageBox.Show("Type sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (username.Length < 4 || password.Length < 4 || username.Length > 20 || password.Length > 20)
            {
                MessageBox.Show("Vui lòng dùng tài khoản và mật khẩu từ 4-20 ký tự! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {

                int type = Convert.ToInt32(typ);
                string sql = "update Account " + "set Username ='"+username+
                    "', DisplayName = N'" + displayname + "', " + " Password = '" + password + "', " + " Email = '" + email + "', "
                    + " PhoneNumber = '" + phonenumber + "', " + " CMND = '" + cmnd + "', " + " Address = N'" + address  + "', Type = " + type+ "  where Username='" + dbusername + "'";
                SqlCommand commandd = new SqlCommand(sql, Sqlcon);
                commandd.ExecuteNonQuery();
                
                Sqlcon.Close();

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DataGrid();

                Textbox_Username.Text = "";
                TextBox_DisplayName.Text = "";
                TextBox_Password.Text = "";
                TextBox_PhoneNum.Text = "";
                TextBox_Email.Text = "";
                Label_DateCreate.Text = "";
                TextBox_CMND.Text = "";
                TextBox_Address.Text = "";
                Textbox_Type.Text = "";
            }
        }

        private void DataGrid_AccountManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', 4);
            }
        }
    }
}
