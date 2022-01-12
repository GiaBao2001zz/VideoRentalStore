using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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


            LoadRequest();
            Label_RequestCount.Visible = true;
            Label_RequestCount.BackColor = Color.Green;
            Button_ActiveRequest.Activecolor = Color.Green;
            Button_ActiveRequest.OnHovercolor = Color.Green;
            Button_ActiveRequest.Normalcolor = Color.Green;

            Button_History.Normalcolor = Color.FromArgb(60, 60, 60);
            Button_History.OnHovercolor = Color.FromArgb(90, 90, 90);
        }

        void LoadRequest()
        {
            Button_ViewInfo.Visible = false;
            Button_ChuyenHang.Visible = false;
            Button_RejectRequest.Visible = false;
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT Request.id, Account.DisplayName,Account.Address, Request.idVideo, Request.DateRequest,Request.Price,Request.Quantity,Request.Type FROM Request JOIN Account ON Request.userName = Account.Username WHERE  Request.Status = 'Waiting'; ";
                

            connection.Open();                  

            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();

            DataGrid_YCThueMua.DataSource = data;
            DataGrid_YCThueMua.ReadOnly = true;

                DataGrid_YCThueMua.Columns[0].HeaderText = "ID";
                DataGrid_YCThueMua.Columns[1].HeaderText = "Customer Name";
                DataGrid_YCThueMua.Columns[2].HeaderText = "Adress";
                DataGrid_YCThueMua.Columns[3].HeaderText = "Video ID";
                DataGrid_YCThueMua.Columns[4].HeaderText = "Date Request";
                DataGrid_YCThueMua.Columns[5].HeaderText = "Price";
                DataGrid_YCThueMua.Columns[6].HeaderText = "Quantity";
                DataGrid_YCThueMua.Columns[7].HeaderText = "Type";
                DataGrid_YCThueMua.Columns[0].FillWeight = 5;
                DataGrid_YCThueMua.Columns[1].FillWeight = 20;
                DataGrid_YCThueMua.Columns[2].FillWeight = 20;
                DataGrid_YCThueMua.Columns[3].FillWeight = 10;
                DataGrid_YCThueMua.Columns[4].FillWeight = 10;
                DataGrid_YCThueMua.Columns[5].FillWeight = 15;
                DataGrid_YCThueMua.Columns[6].FillWeight = 10;
                DataGrid_YCThueMua.Columns[7].FillWeight = 10;
            //Request count

            //int countstring = int.Parse(DataGrid_YCThueMua.RowCount);
            Label_RequestCount.Text = DataGrid_YCThueMua.RowCount.ToString();

            //Update Font,Size,etc
            UpdateFont(DataGrid_YCThueMua);
            DataGrid_YCThueMua.RowTemplate.Height = 30;
            //Set currency format
            DataGrid_YCThueMua.Columns[5].DefaultCellStyle.Format = "C0";

            DataGrid_YCThueMua.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");


        }

        private void LoadHistory()
        {
            Button_ViewInfo.Visible = false;
            Button_ChuyenHang.Visible = false;
            Button_RejectRequest.Visible = false;
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionSTR);

        string query = "SELECT Request.id, Account.DisplayName,Account.Address, Request.idVideo, Request.DateRequest,Request.Price,Request.Quantity,Request.Type FROM Request JOIN Account ON Request.userName = Account.Username WHERE  Request.Status = 'Completed';";


        connection.Open();                  

            SqlCommand command = new SqlCommand(query, connection);
        DataTable data = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        adapter.Fill(data);

            connection.Close();

            DataGrid_YCThueMua.DataSource = data;
            DataGrid_YCThueMua.ReadOnly = true;

            DataGrid_YCThueMua.Columns[0].HeaderText = "ID";
            DataGrid_YCThueMua.Columns[1].HeaderText = "Customer Name";
            DataGrid_YCThueMua.Columns[2].HeaderText = "Adress";
            DataGrid_YCThueMua.Columns[3].HeaderText = "Video ID";
            DataGrid_YCThueMua.Columns[4].HeaderText = "Date Request";
            DataGrid_YCThueMua.Columns[5].HeaderText = "Price";
            DataGrid_YCThueMua.Columns[6].HeaderText = "Quantity";
            DataGrid_YCThueMua.Columns[7].HeaderText = "Type";
            DataGrid_YCThueMua.Columns[0].FillWeight = 5;
            DataGrid_YCThueMua.Columns[1].FillWeight = 20;
            DataGrid_YCThueMua.Columns[2].FillWeight = 20;
            DataGrid_YCThueMua.Columns[3].FillWeight = 10;
            DataGrid_YCThueMua.Columns[4].FillWeight = 10;
            DataGrid_YCThueMua.Columns[5].FillWeight = 15;
            DataGrid_YCThueMua.Columns[6].FillWeight = 10;
            DataGrid_YCThueMua.Columns[7].FillWeight = 10;


            //Request count

            //int countstring = int.Parse(DataGrid_YCThueMua.RowCount);
            Label_RequestCount.Text = DataGrid_YCThueMua.RowCount.ToString();

            //Update Font,Size,etc
            UpdateFont(DataGrid_YCThueMua);
            //update currency format
            DataGrid_YCThueMua.Columns[5].DefaultCellStyle.Format = "C0";

            DataGrid_YCThueMua.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_YCThueMua_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGrid_YCThueMua_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button_ActiveRequest_Click(object sender, EventArgs e)
        {
            LoadRequest();
            Label_RequestCount.Visible = true;
            Label_RequestCount.BackColor = Color.Green;
            Button_ActiveRequest.Activecolor = Color.Green;
            Button_ActiveRequest.OnHovercolor = Color.Green;
            Button_ActiveRequest.Normalcolor = Color.Green;

            Button_History.Normalcolor = Color.FromArgb(60, 60, 60);
            Button_History.OnHovercolor = Color.FromArgb(90, 90, 90);
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            LoadHistory();
            Label_RequestCount.Visible = false;
            Button_History.Activecolor = Color.Green;
            Button_History.OnHovercolor = Color.Green;
            Button_History.Normalcolor = Color.Green;

            Button_ActiveRequest.Normalcolor = Color.FromArgb(60, 60, 60);
            Button_ActiveRequest.OnHovercolor = Color.FromArgb(90, 90, 90);

        }

        private void Button_ChuyenHang_Click(object sender, EventArgs e)
        {
            
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string ID = DataGrid_YCThueMua.SelectedRows[0].Cells["id"].Value.ToString();
            string VideoID = DataGrid_YCThueMua.SelectedRows[0].Cells["idVideo"].Value.ToString();
            string Quantity = DataGrid_YCThueMua.SelectedRows[0].Cells["Quantity"].Value.ToString();
            string type = "UPDATE Request SET Status = 'Completed' Where id ='" + ID + "' UPDATE Video SET Quantity = Video.Quantity - "+ Quantity+" Where id = '" + VideoID +"'";
            SqlCommand command = new SqlCommand(type, connection);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Accept Request successfully!");
            LoadRequest();
            


            
              
            
                   
                


            
        }

        private void DataGrid_YCThueMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Button_ChuyenHang.Visible = true;
            Button_ViewInfo.Visible = true;
            Button_RejectRequest.Visible = true;
        }

        private void Button_ViewInfo_Click(object sender, EventArgs e)
        {
           string value = DataGrid_YCThueMua.SelectedRows[0].Cells["ID"].Value.ToString();

            
            Request_Detail grid = new Request_Detail(Int32.Parse(value)) { Dock = DockStyle.Fill, TopLevel = true };
            
            grid.ShowDialog();
            LoadRequest();
        }

        private void Button_RejectRequest_Click(object sender, EventArgs e)
        {

            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            string ID = DataGrid_YCThueMua.SelectedRows[0].Cells["id"].Value.ToString();
            string VideoID = DataGrid_YCThueMua.SelectedRows[0].Cells["idVideo"].Value.ToString();
            string Quantity = DataGrid_YCThueMua.SelectedRows[0].Cells["Quantity"].Value.ToString();
            string type = "UPDATE Request SET Status = 'Rejected' Where id ='" + ID +"";
            SqlCommand command = new SqlCommand(type, connection);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Reject Request successfully!");
            LoadRequest();
        }
    }
}
