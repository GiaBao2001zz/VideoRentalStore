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
    
    public partial class Main_Staff : Form
    {
        public bool SwitchForm = false;
        private Panel LeftBorderBtn;
        private Bunifu.Framework.UI.BunifuFlatButton CurrentButton;
        public Main_Staff()
        {
            
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(10, 60);
            Panel_Menu.Controls.Add(LeftBorderBtn);
            LeftBorderBtn.BackColor = Color.White;

        }

        private void Button_Request_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);

            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);
            // Add New Form (Grid_YeuCauThueMua)
            Grid_YeuCauThueMua grid = new Grid_YeuCauThueMua() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();

            
            

           
            
           

        }
        public string UserName;
        private void ActivateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                DeactivateButton();
                this.CurrentButton = (Bunifu.Framework.UI.BunifuFlatButton)senderBtn;
                this.CurrentButton.IconMarginLeft += 30;
                this.CurrentButton.BackColor = Color.White;



                //Left border button
                LeftBorderBtn.Location = new Point(0, this.CurrentButton.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();


            }
        }
        private void DeactivateButton()
        {
            if (CurrentButton != null)
            {

                CurrentButton.BackColor = Color.FromArgb(43, 43, 43);
                CurrentButton.IconMarginLeft -= 30;



            }
        }
        private void Button_AccountManagement_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            //Account_Settings grid = new Account_Settings() { Dock = DockStyle.Fill, TopLevel = false };
           // this.Panel_SwtichForm.Controls.Add(grid);
            //grid.Show();
        }

        private void Button_AccountInfo_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            Account_Settings grid = new Account_Settings(UserName) { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Main_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       

            private void Button_ManageGood_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            Manage_Stock grid = new Manage_Stock() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Main_Staff_Load(object sender, EventArgs e)
        {
           
        }
    }
}
