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
    public partial class Account_Settings : Form
    {
        public Account_Settings()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // Check if is there any form already opened in Switch Form Panel
            if (this.Panel_Switching.Controls.Count > 0)
                this.Panel_Switching.Controls.RemoveAt(0);

            // Add New Form (Grid_YeuCauThueMua)
            Account_Info grid = new Account_Info() { Dock = DockStyle.Fill, TopLevel = false };
            this.Panel_Switching.Controls.Add(grid);
            grid.Show();
        }
    }
}
