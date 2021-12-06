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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            

        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
           
                TextBox_Password.isPassword = true;
            
        }

        private void UserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label_TitleLogin_Click(object sender, EventArgs e)
        {

        }

        private void Button_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label_CreateAccount_Click(object sender, EventArgs e)
        {

            this.Hide();
            var Signin =new SignIn();
            Signin.Show();
            


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMJIN;Initial Catalog=VideoRentalStore;Integrated Security=True");
            try
            {
                con.Open();
                string tk = TextBox_UserName.Text;
                string mk = TextBox_Password.Text;
                string sql = "select *from Account where Username ='"+tk+"' and PassWord ='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    string type = "select Type from Account where Username ='" + tk + "' and PassWord ='" + mk + "'";

                    SqlCommand command = new SqlCommand(type, con);
                    DataTable data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    con.Close();
                    string a = data.Rows[0]["Type"].ToString();

                    MessageBox.Show(a);

                    /*if (Convert.ToInt32(a) == 0)
                    {
                        
                        Main_Staff x = new Main_Staff();
                        this.Hide();
                        x.Show();
                    }
                    else
                    {
                        Main_User y = new Main_User();
                        y.Show();
                    }*/
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }

        }

        private void Label_RememberMe_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_RememberMe_OnChange(object sender, EventArgs e)
        {

        }
        // DragControl





    }
}
