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

        private void Label_ShowCategory_Click(object sender, EventArgs e)
        {

        }

        private void Button_Buy_Click(object sender, EventArgs e)
        {
            Main_User main_User = (Main_User)ParentForm;

            string userName = main_User.Label_UserName.Text;
            float price = float.Parse(Label_ShowPrice.Text, new CultureInfo("vi-VN").NumberFormat);
            MessageBox.Show(price.ToString());
            string idVideo = TextBox_idVideo.Text;
            string payment = "Buy";


            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            string query =
            "INSERT INTO AddToCart (Username ,Price, CurrentPrice, idVideo, Payment)" +
            " VALUES (@userName, @price, @price, @idVideo, @payment)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@userName", userName));
            cmd.Parameters.Add(new SqlParameter("@price", price));
            cmd.Parameters.Add(new SqlParameter("@idVideo", idVideo));
            cmd.Parameters.Add(new SqlParameter("@payment", payment));


            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Add To Cart Successfully");
            }
            //CheckDiscAlreadyInCart(payment);
        }

        private void Button_Rent_Click(object sender, EventArgs e)
        {
            Main_User main_User = (Main_User)ParentForm;

            string userName = main_User.Label_UserName.Text;
            double price = (double.Parse(Label_ShowPrice.Text, new CultureInfo("vi-VN").NumberFormat)) * 0.1;
            string idVideo = TextBox_idVideo.Text;
            string payment = "Rent";

            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
            string query =
            "INSERT INTO AddToCart (Username ,Price, CurrentPrice, idVideo, Payment)" +
            " VALUES (@userName, @price, @price, @idVideo, @payment)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@userName", userName));
            cmd.Parameters.Add(new SqlParameter("@price", price));
            cmd.Parameters.Add(new SqlParameter("@idVideo", idVideo));
            cmd.Parameters.Add(new SqlParameter("@payment", payment));


            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Add To Cart Successfully");
            }
            //CheckDiscAlreadyInCart(payment);
        }

        private bool CheckDiscAlreadyInCart(string payment)
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT idVideo, Payment FROM AddToCart";
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("idVideo");
                        var indexOfColumn2 = reader.GetOrdinal("Payment");
                       
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                           
                            if(TextBox_idVideo.Text == value1.ToString() && payment == value2.ToString())
                            {
                                MessageBox.Show("This disc already in your cart");
                                return true;
                            }
                        }
                        MessageBox.Show("Thêm vào giỏ thành công");
                        return false;
                    }
                }
            }
        }
    }
}
