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
    public partial class Password_Change : Form
    {
        public Password_Change()
        {
            InitializeComponent();
            

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Password_Change_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_Password_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_Password.isPassword = true;
            
        }

        private void TextBox_PasswordAgain_OnValueChanged(object sender, EventArgs e)
        {
            TextBox_PasswordAgain.isPassword = true;
        }
    }
}
