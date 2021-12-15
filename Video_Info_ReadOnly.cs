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
    public partial class Video_Info_ReadOnly : Form
    {
        public Video_Info_ReadOnly()
        {
            InitializeComponent();
            LoadInfo();
            
        }
        private void LoadInfo()
        {
            

            if (Int32.Parse(Label_ShowQuantity.Text) <= 0)
            {
                Label_ShowQuantity.ForeColor = Color.Red;
            }    
            else
            {
                Label_ShowQuantity.ForeColor = Color.LimeGreen;
            }    
        }
    }
}
