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
                this.Panel_SwtichForm.Controls[0].Dispose();
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
                if (senderBtn != null)
                {
                    DeactivateButton();

                    this.CurrentButton = (Bunifu.Framework.UI.BunifuFlatButton)senderBtn;
                    /*
                    this.CurrentButton.IconMarginLeft += 30;
                    this.CurrentButton.BackColor = Color.White;



                    //Left border button
                    LeftBorderBtn.Location = new Point(0, this.CurrentButton.Location.Y);
                    LeftBorderBtn.Visible = true;
                    LeftBorderBtn.BringToFront();
                    */
                    this.CurrentButton.Activecolor = Color.Green;
                    this.CurrentButton.Normalcolor = Color.Green;
                    this.CurrentButton.OnHovercolor = Color.Green;


                }


            }
        }
        private void DeactivateButton()
        {
            if (CurrentButton != null)
            {

                CurrentButton.Normalcolor = Color.FromArgb(45, 45, 45);
                CurrentButton.OnHovercolor = Color.FromArgb(90, 90, 90);



            }
        }
        private void Button_AccountManagement_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();

            
            Account_Management grid = new Account_Management() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Button_AccountInfo_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();

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
                this.Panel_SwtichForm.Controls[0].Dispose();

            // Add New Form (Grid_YeuCauThueMua)
            Manage_Stock grid = new Manage_Stock() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();

            // Add New Form (Grid_YeuCauThueMua)
            Report grid = new Report() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Main_Staff_Load(object sender, EventArgs e)
        {
           
        }
    }
}
