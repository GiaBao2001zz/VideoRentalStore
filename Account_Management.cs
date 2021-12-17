using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoRentalStore
{
    public partial class Account_Management : Form
    {
        public Account_Management()
        {
            InitializeComponent();
            Load_DataGrid();
        }
        //string connectionSTR = @"Data Source = ADMJIN; Initial Catalog = VideoRentalStore; Integrated Security = True";
        string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
        private void Load_DataGrid()
        {
            SqlConnection Sqlcon = new SqlConnection(connectionSTR);
            Sqlcon.Open();
            string str = "select * from Account";
            SqlDataAdapter sqlDa = new SqlDataAdapter(str, Sqlcon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid_AccountManagement.DataSource = dtbl;
        }

         void DataGrid_ManageStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_AccountManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_AccountManagement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Account_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
