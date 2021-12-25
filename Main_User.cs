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
    public partial class Main_User : Form
    {
        
        private Bunifu.Framework.UI.BunifuFlatButton CurrentButton;
        public Main_User()
        {
            InitializeComponent();
            
          

            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);

            // Add New Form 
            User_Home grid = new User_Home() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);

            grid.Button_Action.Click += (s, args) => this.ActivateBuy();
            grid.Button_Comedy.Click += (s, args) => this.ActivateBuy();
            grid.Button_Drama.Click += (s, args) => this.ActivateBuy();
            grid.Button_Fantasy.Click += (s, args) => this.ActivateBuy();
            grid.Button_Historical.Click += (s, args) => this.ActivateBuy();
            grid.Button_Horror.Click += (s, args) => this.ActivateBuy();
            grid.Button_Musicals.Click += (s, args) => this.ActivateBuy();
            grid.Button_Romance.Click += (s, args) => this.ActivateBuy();
            grid.Button_SciFi.Click += (s, args) => this.ActivateBuy();
            grid.Button_Sports.Click += (s, args) => this.ActivateBuy();
            grid.Show();
            DoubleBuffered = true;

        }
        public string UserName;
        private void ActivateBtn(object senderBtn)
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
        public void ActivateBuy()
        {
            CurrentButton = Button_RentDisc;
            ActivateBtn(CurrentButton);
        }    
        private void DeactivateButton()
        {
            if (CurrentButton != null)
            {

                CurrentButton.Normalcolor = Color.FromArgb(45, 45, 45);
                CurrentButton.OnHovercolor = Color.FromArgb(90, 90, 90);



            }
        }
            private void Button_RentVideo_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                 this.Panel_SwtichForm.Controls[0].Dispose();
               


            // Add New Form 
            Video_Shelf grid = new Video_Shelf() { Dock = DockStyle.Fill, TopLevel = false };
           // this.Closed += (s, args) => grid.Close();
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
            
            

        }

        private void Button_Cart_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();

            // Add New Form 
            ShoppingCart grid = new ShoppingCart() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();

            // Add New Form 
            History_Payment grid = new History_Payment() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
        }

        private void Button_AccoutInfo_Click(object sender, EventArgs e)
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

        private void Button_ContactUs_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();
        }

        private void Button_ContactUs_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            int count = Application.OpenForms.Count;
            MessageBox.Show(count.ToString());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DeactivateButton();
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls[0].Dispose();


            // Add New Form (Grid_YeuCauThueMua)
            User_Home grid = new User_Home() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();
            grid.Button_Action.Click += (s, args) => this.ActivateBuy();
            grid.Button_Comedy.Click += (s, args) => this.ActivateBuy();
            grid.Button_Drama.Click += (s, args) => this.ActivateBuy();
            grid.Button_Fantasy.Click += (s, args) => this.ActivateBuy();
            grid.Button_Historical.Click += (s, args) => this.ActivateBuy();
            grid.Button_Horror.Click += (s, args) => this.ActivateBuy();
            grid.Button_Musicals.Click += (s, args) => this.ActivateBuy();
            grid.Button_Romance.Click += (s, args) => this.ActivateBuy();
            grid.Button_SciFi.Click += (s, args) => this.ActivateBuy();
            grid.Button_Sports.Click += (s, args) => this.ActivateBuy();
        }

        private void Main_User_Load(object sender, EventArgs e)
        {
            

        }
    }
}
