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
    public partial class SignIn_Info : Form
    {
        public SignIn_Info()
        {
            InitializeComponent();
        }

        private void Button_CancelLogin_Click(object sender, EventArgs e)
        {
            SignIn a = new SignIn();
            this.Hide();
            a.Show();
        }

        private void TextBox_Password_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }
        public string SaveUsername()
        {
            string username = SignIn.usname;
            return username;
        }
        private void Button_SignIn_Click(object sender, EventArgs e)
        {
            
            string displayname = TextBox_Displayname.Text;
            string email = Textbox_Email.Text;
            string phonenumber = Textbox_PhoneNumber.Text;
            string cmnd = TextBox_CMND.Text;
            string address = Textbox_Address.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True");
            con.Open();
            if (SaveUsername().Length<1 || displayname.Length < 1 || email.Length < 1 || phonenumber.Length < 1 || cmnd.Length < 1 || address.Length < 1)
            {
                MessageBox.Show("Nhập thiếu thông tin!", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string sql = "update Account " +
                    "set DisplayName = N'"+displayname+"', " + " Email = '" + email + "', "
                    + " PhoneNumber = '" + phonenumber + "', "+ " CMND = '" + cmnd + "', "+ " Address = N'" + address + "' "+
                    "where Username='"+SaveUsername()+"'";
                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
