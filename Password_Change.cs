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
    public partial class Password_Change : Form
    {
        public Password_Change(string username)
        {
            InitializeComponent();
            LoadInfo();
            this.UserName = username;
            

        }
        private string UserName;
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
        private void LoadInfo()
        {
            TextBox_OldPassword.Text = null;
            TextBox_Password.Text = null;
            TextBox_PasswordAgain.Text = null;
            
            Button_Cancel.Visible = false;
            Button_ChangeInfo.Visible = false;
            this.ActiveControl = null;  //this = form
        }    
        

        private void TextBox_Password_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_Password.isPassword = true;
            Button_Cancel.Visible = true;
            Button_ChangeInfo.Visible = true;
            
        }

        

      

       
        private void TextBox_OldPassword_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_OldPassword.isPassword = true;
            Button_Cancel.Visible = true;
            Button_ChangeInfo.Visible = true;
        }

        private void TextBox_PasswordAgain_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_PasswordAgain.isPassword = true;
            Button_Cancel.Visible = true;
            Button_ChangeInfo.Visible = true;
        }

        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");


            string query = "Select PassWord from Account Where Username = '" + UserName + "'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable PW = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(PW);

            connection.Close();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to chang your Password? ", "Changing Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (TextBox_OldPassword.Text != PW.Rows[0][0].ToString()) 
                {
                    MessageBox.Show("Old Password does not match! Please try again! ", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TextBox_Password.Text != TextBox_PasswordAgain.Text)
                {
                    MessageBox.Show("New Password confirmation does not match! Please try again! ", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (TextBox_Password.Text.Length < 4 || TextBox_Password.Text.Length > 20)
                {
                    MessageBox.Show("Password can not be less than 4 or more than 20 characters! Please try again ", "Changing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                    string ChangePW = "UPDATE Account SET PassWord = @PassWord WHERE Username = '" + UserName + "'";
                    SqlCommand cmd = new SqlCommand(ChangePW, con);





                    cmd.Parameters.AddWithValue("@PassWord", TextBox_Password.Text);
                    
                


                con.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i != 0)
                    {
                        MessageBox.Show("Change Password Successfully");
                        LoadInfo();
                    }
                    con.Close();
                }
            }
        }
    }
}
