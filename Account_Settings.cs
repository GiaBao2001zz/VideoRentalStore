using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class Account_Settings : Form
    {
        public Account_Settings(string username)
        {
            

            InitializeComponent();

             this.UserName = username;
            Label_AccountType.Text = Get_DisplayName(username);

        }
        private string UserName; 
        public void Button_Account_Info_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_Switching.Controls.Count > 0)
                this.Panel_Switching.Controls[0].Dispose();

            // Add New Form (Grid_YeuCauThueMua)
            Account_Info grid = new Account_Info(UserName) { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_Switching.Controls.Add(grid);
            grid.Show();
            
        }
        
       
    private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_Switching.Controls.Count > 0)
                this.Panel_Switching.Controls[0].Dispose();

            // Add New Form (Grid_YeuCauThueMua)
            Password_Change grid = new Password_Change(UserName) { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_Switching.Controls.Add(grid);
            grid.Show();
        }
     private string Get_DisplayName(string user)
        {
            //Label_UserName.Text = Get_DisplayName(UserName);

            //MessageBox.Show(user);

            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "Select DisplayName FROM Account WHERE Username = '" + user + "'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();
            data.Rows[0]["DisplayName"].ToString();
            return data.Rows[0]["DisplayName"].ToString();
        }
        private void Button_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out? ", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               
                
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Login")
                        Application.OpenForms[i].Hide();
                }
                if (this.Controls.Count > 1)
                    this.Controls[0].Dispose();
               
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "Login")
                        Application.OpenForms[i].Show();
                }
               












            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
    }
}
