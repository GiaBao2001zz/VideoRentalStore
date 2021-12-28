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
    public partial class History_Payment : Form
    {
        public History_Payment()
        {
            InitializeComponent();
            Load_DataGrid();
            
        }
        string connectionSTR = @"Data Source = ADMJIN; Initial Catalog = VideoRentalStore1; Integrated Security = True";
        //string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
        
        private void Load_DataGrid()
        {
            SqlConnection Sqlcon = new SqlConnection(connectionSTR);
            Sqlcon.Open();
            string str = "select id,userName,idVideo,DateRequest,Type from Request";
            SqlDataAdapter sqlDa = new SqlDataAdapter(str, Sqlcon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid_AccountManagement.DataSource = dtbl;
        }

         void DataGrid_ManageStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(DataGrid_AccountManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
               
                //Hiện thông tin khi click vào Cell
                DataGrid_AccountManagement.CurrentRow.Selected = true;

                Label_UserName.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
                Label_IDVideo.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["idVideo"].FormattedValue.ToString();
                Label_DateRequest.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["DateRequest"].FormattedValue.ToString();
                Label_Price.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                Label_Type.Text = DataGrid_AccountManagement.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
             
            }
            else
            {
                Load_DataGrid();
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                int index = DataGrid_AccountManagement.SelectedRows[0].Index;
                string username = DataGrid_AccountManagement.Rows[DataGrid_AccountManagement.SelectedRows[0].Index].
                    Cells["id"].Value.ToString();
              

                SqlConnection Sqlcon = new SqlConnection(connectionSTR);
                Sqlcon.Open();
                string str = "delete Request where id ='" + username + "'";
                SqlCommand cmd = new SqlCommand(str, Sqlcon);
                cmd.ExecuteNonQuery();
                Sqlcon.Close();

                DataGrid_AccountManagement.Rows.RemoveAt(index);

                Label_UserName.Text = "";
                Label_IDVideo.Text = "";
                Label_DateRequest.Text = "";
                Label_Price.Text = "";
                Label_Type.Text = "";
            }

        }

    }
}
