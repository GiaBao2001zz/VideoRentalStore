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
    public partial class Request_Detail : Form
    {
        public Request_Detail(int id)
        {
            InitializeComponent();
            ID = id;
            Load_Info();
        }
        private int ID;
        private void Load_Info()
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");

            string query = "SELECT Request.id AS 'ID', Account.DisplayName AS 'Customer Name' ,Account.Address ,Account.Email, Account.PhoneNumber,Account.CMND, Request.idVideo AS 'Video ID', Video.Name AS 'Video Name', Request.Price, Request.Quantity,Video.Thumbnail, Request.DateDelivered AS 'Transaction date', Request.Type FROM Request INNER JOIN Video ON Request.idVideo = Video.id  INNER JOIN Account ON Request.userName = Account.Username Where Request.ID = '" + ID+"'";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();

            Label_ShowCustomerName.Text = dt.Rows[0]["Customer Name"].ToString();
            Label_ShowAddress.Text = dt.Rows[0]["Address"].ToString();
            Label_ShowEmail.Text = dt.Rows[0]["Email"].ToString();
            Label_ShowPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
            Label_ShowCMND.Text = dt.Rows[0]["CMND"].ToString();
            Label_ShowVideoID.Text = dt.Rows[0]["Video ID"].ToString();
            Label_ShowType.Text = dt.Rows[0]["Type"].ToString();
            Label_VideoName.Text = dt.Rows[0]["Video Name"].ToString();
            Label_ShowQuantity.Text = dt.Rows[0]["Quantity"].ToString();
            string link = dt.Rows[0]["Thumbnail"].ToString();
            PictureBox_Video.Image = Image.FromFile(link.ToString());

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        private void Button_ChangeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=VideoRentalStore;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionSTR);
                connection.Open();

                string query = "SELECT Request.id AS 'ID', Account.DisplayName AS 'Customer Name' ,Account.Address ,Account.Email, Account.PhoneNumber,Account.CMND, Request.idVideo AS 'Video ID', Video.Name AS 'Video Name', Request.Price, Request.Quantity,Video.Thumbnail, Request.DateDelivered AS 'Transaction date', Request.Type FROM Request INNER JOIN Video ON Request.idVideo = Video.id  INNER JOIN Account ON Request.userName = Account.Username Where Request.ID = '" + ID + "'";

                SqlCommand command = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                string VideoID = dt.Rows[0]["Video ID"].ToString();
                string Quantity = dt.Rows[0]["Quantity"].ToString();
                string type = "UPDATE Request SET Status = 'Completed' Where id ='" + ID + "' UPDATE Video SET Quantity = Video.Quantity - " + Quantity + " Where id = '" + VideoID + "'";
                SqlCommand cmd = new SqlCommand(type, connection);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Accept Request successfully!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        */
        
    }
}
