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
            string payment = "Buy";
            string idVideo = TextBox_idVideo.Text;
            if (CheckDiscAlreadyInCart(payment) == false)
            {
                Main_User main_User = (Main_User)ParentForm;

                string userName = main_User.UserName;
                float price = float.Parse(Label_ShowPrice.Text, new CultureInfo("vi-VN").NumberFormat);                                          

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
            }
            else
            {
                UpdateQuantity(idVideo, payment);
                MessageBox.Show("This disc already in cart. We will increase the number of disc in your cart");
            }
        }

        private void Button_Rent_Click(object sender, EventArgs e)
        {
            string payment = "Rent";
            string idVideo = TextBox_idVideo.Text;
            if (CheckDiscAlreadyInCart(payment) == false)
            {
                Main_User main_User = (Main_User)ParentForm;

                string userName = main_User.UserName;
                double price = (double.Parse(Label_ShowPrice.Text, new CultureInfo("vi-VN").NumberFormat)) * 0.1;                            

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
            }
            else
            {
                UpdateQuantity(idVideo, payment);
                MessageBox.Show("This disc already in cart. We will increase the number of disc in your cart");
            }
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
                                return true;
                            }
                        }                       
                        return false;
                    }
                }
            }
        }

        private void UpdateQuantity(string idVideo, string payment)
        {           
            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE AddToCart SET Quantity = ISNULL(Quantity, 0) + 1 Where idVideo = @idVideo and Payment = @payment";

                command.Parameters.AddWithValue("@idVideo", idVideo);
                command.Parameters.AddWithValue("@payment", payment);
                

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE AddToCart SET CurrentPrice = Quantity * Price Where idVideo = @idVideo and Payment = @payment";

                command.Parameters.AddWithValue("@idVideo", idVideo);
                command.Parameters.AddWithValue("@payment", payment);


                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            Main_User main_User = new Main_User();
            if (main_User.Panel_SwitchForm.Controls.Count > 0)
                main_User.Panel_SwitchForm.Controls[0].Dispose();

            Video_Shelf video_Info = new Video_Shelf() { Dock = DockStyle.Fill, TopLevel = false };
            main_User.Panel_SwitchForm.Controls.Add(video_Info);
            video_Info.Show();
            this.Close();
        }
    }
}
