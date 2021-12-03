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
    public partial class Grid_YeuCauThueMua : Form
    {
        public Grid_YeuCauThueMua()
        {
            InitializeComponent();
           LoadHistory();
        }

        void LoadHistory()
        {
            string connectionSTR = @"Data Source =.\sqlexpress; Initial Catalog = VideoRentalStore; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT * FROM HISTORY";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();

            DataGrid_YCThueMua.DataSource = data;
            DataGrid_YCThueMua.ReadOnly = true;
            
                DataGrid_YCThueMua.Columns[0].FillWeight = 5;
                DataGrid_YCThueMua.Columns[1].FillWeight = 30;
                DataGrid_YCThueMua.Columns[2].FillWeight = 30;
                DataGrid_YCThueMua.Columns[3].FillWeight = 15;
                DataGrid_YCThueMua.Columns[4].FillWeight = 15;
                DataGrid_YCThueMua.Columns[5].FillWeight = 10;

            //Request count

            //int countstring = int.Parse(DataGrid_YCThueMua.RowCount);
            Label_RequestCount.Text = DataGrid_YCThueMua.RowCount.ToString();

            //Update Font,Size,etc
            UpdateFont(DataGrid_YCThueMua);
            DataGrid_YCThueMua.RowTemplate.Height = 30;
            

        }

        private void UpdateFont(Bunifu.Framework.UI.BunifuCustomDataGrid a)
        {
            //Change cell font
            foreach (DataGridViewColumn c in a.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 18F, GraphicsUnit.Pixel);
                
            }
        }
        private void DataGrid_YCThueMua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_YCThueMua_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_YCThueMua_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_YCThueMua_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
