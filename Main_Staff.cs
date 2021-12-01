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
    
    public partial class Main_Staff : Form
    {
        public bool SwitchForm = false;
        public Main_Staff()
        {
            
            InitializeComponent();
            
        }

        private void Button_Request_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_SwtichForm.Controls.Count > 0)
                this.Panel_SwtichForm.Controls.RemoveAt(0);
            
            // Add New Form (Grid_YeuCauThueMua)
            Grid_YeuCauThueMua grid = new Grid_YeuCauThueMua() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_SwtichForm.Controls.Add(grid);
            grid.Show();

           
            
           

        }
    }
}
