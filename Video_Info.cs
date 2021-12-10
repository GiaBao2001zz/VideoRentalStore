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

        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
