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
        private Panel LeftBorderBtn;
        private Bunifu.Framework.UI.BunifuFlatButton CurrentButton;
        public Main_User()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(10, 60);
            Panel_Menu.Controls.Add(LeftBorderBtn);
            LeftBorderBtn.BackColor = Color.White;
            
        }

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
            private void Button_RentVideo_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
           
        }

        private void Button_Cart_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Button_AccoutInfo_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Button_ContactUs_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Button_ContactUs_Click_1(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
