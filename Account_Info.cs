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
    
    public partial class Account_Info : Form
    {
        public Account_Info(string username)
        {

            InitializeComponent();
            this.UserName = username;
            
            LoadInfo();
            


        }
        private string UserName; 
        private void LoadInfo()
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            
            string query = "Select DisplayName , PhoneNumber , Email , DateCreate , CMND , Address from Account Where Username = '" + UserName + "'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();
       
            TextBox_DisplayName.Text = data.Rows[0][0].ToString();
            TextBox_PhoneNumber.Text = data.Rows[0][1].ToString();
            TextBox_Email.Text = data.Rows[0][2].ToString();

            Label_ShowDateCreated.Text = data.Rows[0][3].ToString();
            TextBox_Cmnd.Text = data.Rows[0][4].ToString();
            TextBox_Address.Text = data.Rows[0][5].ToString();
            Label_ShowUserName.Text = UserName;

           

            this.ActiveControl = null;  //this = form
            Button_ChangeInfo.Visible = false;
            Button_Cancel.Visible = false;
        }


        private void Label_Email_Click(object sender, EventArgs e)
        {

        }

        

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.InitializeComponent();
            LoadInfo();
            this.ActiveControl = null;  //this = form
            Button_ChangeInfo.Visible = false;
            Button_Cancel.Visible = false;
        }

       
        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to chang your Account infomation? ", "Changing Account Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                string query = "UPDATE Account SET DisplayName = @DisplayName  , PhoneNumber = @PhoneNumber , Email= @Email , CMND=  @CMND, Address =  @Address WHERE Username = '" + UserName + "'";
                SqlCommand cmd = new SqlCommand(query, con);




                cmd.Parameters.AddWithValue("@DisplayName", TextBox_DisplayName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", TextBox_PhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Email", TextBox_Email.Text);
                cmd.Parameters.AddWithValue("@CMND", TextBox_Cmnd.Text);
                cmd.Parameters.AddWithValue("@Address", TextBox_Address.Text);


                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Change Account Infomation Successfully");
                    LoadInfo();
                }
                con.Close();
            }
        }
        private void TextBox_UserName_OnValueChanged(object sender, EventArgs e)
        {

            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }
        private void TextBox_DisplayName_OnValueChanged(object sender, EventArgs e)
        {
            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void TextBox_Email_OnValueChanged(object sender, EventArgs e)
        {
            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void TextBox_PhoneNumber_OnValueChanged(object sender, EventArgs e)
        {
            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void TextBox_Address_OnValueChanged(object sender, EventArgs e)
        {
            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void TextBox_Cmnd_OnValueChanged(object sender, EventArgs e)
        {
            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void TextBox_Email_Enter(object sender, EventArgs e)
        {

        }

        private void Label_ShowUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
