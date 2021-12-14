using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class Account_Settings : Form
    {
        public Account_Settings()
        {
            InitializeComponent();
        }

        public void Button_Account_Info_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_Switching.Controls.Count > 0)
                this.Panel_Switching.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            Account_Info grid = new Account_Info() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_Switching.Controls.Add(grid);
            grid.Show();
        }
        
       
    private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_Switching.Controls.Count > 0)
                this.Panel_Switching.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            Password_Change grid = new Password_Change() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_Switching.Controls.Add(grid);
            grid.Show();
        }

        private void Button_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out? ", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Login form2 = new Login();
                
                
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Login")
                        Application.OpenForms[i].Hide();
                }
    

                form2.ShowDialog();

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Login")
                        Application.OpenForms[i].Close();
                }
                

                


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
    }
}
