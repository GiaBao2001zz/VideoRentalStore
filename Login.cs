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
    }
}
