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
    public partial class Video_Info : Form
    {
        public Video_Info()
        {
            InitializeComponent();

            //Check if Description need to have scrollbars or not
            if (TextBox_Description.TextLength > 600)
            {
                TextBox_Description.ScrollBars = ScrollBars.Vertical;
            }


        }
        public string UserName;
        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_VideoProvider_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label_Actor_Click(object sender, EventArgs e)
        {

        }

        private void Label_Director_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
