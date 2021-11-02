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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_CancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_Password_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_Password.isPassword = true;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_PasswordAgain.isPassword = true;
        }
    }
}
