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
    public partial class Manage_Stock : Form
    {
        public Manage_Stock()
        {
            InitializeComponent();
            Load_DataGrid();
        }

        

        private void Button_Import_Click(object sender, EventArgs e)
        {
            NhapDia form = new NhapDia();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void Load_DataGrid()
        {
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT id, Name, Price, Quantity,Provider  FROM Video ";


            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            connection.Close();

            DataGrid_ManageStock.DataSource = data;
            DataGrid_ManageStock.ReadOnly = true;

            DataGrid_ManageStock.Columns[0].HeaderText = "ID";
            DataGrid_ManageStock.Columns[1].HeaderText = "Name";
            DataGrid_ManageStock.Columns[2].HeaderText = "Price";
            DataGrid_ManageStock.Columns[3].HeaderText = "Quantity";
            DataGrid_ManageStock.Columns[4].HeaderText = "Provider";
            DataGrid_ManageStock.Columns[0].FillWeight = 5;
            DataGrid_ManageStock.Columns[1].FillWeight = 35;
            DataGrid_ManageStock.Columns[2].FillWeight = 20;
            DataGrid_ManageStock.Columns[3].FillWeight = 20;
            DataGrid_ManageStock.Columns[4].FillWeight = 20;


        }

         void DataGrid_ManageStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();

            var value2 = DataGrid_ManageStock.SelectedRows[0].Cells["id"].Value; //Tostring 
            

            string type = "SELECT Thumbnail FROM Video WHERE id = @value2" /*+ value2*/;
            SqlCommand command = new SqlCommand(type, connection);
            command.Parameters.AddWithValue("@value2", value2);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            command.ExecuteNonQuery();
            connection.Close();
            string link = data.Rows[0][0].ToString();

            PictureBox_Thumbnail.Image = Image.FromFile(link.ToString());
            
        }

        private void Button_Import_Click_1(object sender, EventArgs e)
        {
            NhapDia form = new NhapDia();
            
            form.ShowDialog();
        }

        private void Button_ShowInfo_Click(object sender, EventArgs e)
        {
            Main_Staff main_Staff = (Main_Staff)ParentForm;
            var value = DataGrid_ManageStock.SelectedRows[0].Cells["id"].Value; //Tostring 
            Video_Info video_Info = new Video_Info(value.ToString()) { Dock = DockStyle.Fill, TopLevel = false };
            main_Staff.Panel_SwtichForm.Controls.Add(video_Info);
            video_Info.Show();
            video_Info.BringToFront();
        }
    }
}
