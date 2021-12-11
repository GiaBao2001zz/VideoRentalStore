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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        public static string usname;

        private void Button_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_Password_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_Password.isPassword = true;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_PasswordAgain.isPassword = true;
        }

        private void Button_SignIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMJIN;Initial Catalog=VideoRentalStore;Integrated Security=True");

            con.Open();
            string tk = TextBox_UserName.Text;
  
            string mk = TextBox_Password.Text;
            string mka = TextBox_PasswordAgain.Text;


            //Check if Username Already exists

            string check = "SELECT Username FROM Account WHERE Username = '" +tk+ " ' ";
            SqlCommand command = new SqlCommand(check, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable i = new DataTable();
            
            adapter.Fill(i);
            if (tk.Length < 4 || mk.Length < 4 || tk.Length > 20 || mk.Length > 20)
            {
                MessageBox.Show("Vui lòng dùng tài khoản và mật khẩu từ 4-20 ký tự! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                if (mk != mka)
                {
                    MessageBox.Show("Xác thực mật khẩu không trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (i.Rows.Count > 0)

                {

                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string type = "INSERT INTO Account ( Username , Password) VALUES ( '" + tk + "  ' , '" + mk + " ')";
                    command = new SqlCommand(type, con);

                    command.ExecuteNonQuery();
                    con.Close();
                    usname = tk;
                    
                    SignIn_Info x = new SignIn_Info();
                    x.SaveUsername();

                    this.Hide();
                    x.Show();
                    
                }
            }
            con.Close();
        }
    }
}
