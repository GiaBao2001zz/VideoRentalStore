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
    public partial class Account_Info : Form
    {
        public Account_Info()
        {
            InitializeComponent();
            Button_ChangeInfo.Visible = false;
            Button_Cancel.Visible = false;
            
       }

        private void Label_Email_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_UserName_OnValueChanged(object sender, EventArgs e)
        {

            Button_ChangeInfo.Visible = true;
            Button_Cancel.Visible = true;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Button_ChangeInfo.Visible = false;
            Button_Cancel.Visible = false;
        }

        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
