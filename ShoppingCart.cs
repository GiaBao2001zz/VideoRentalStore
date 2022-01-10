using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }
        //Global variable
        int[] currentQuantity;
        float[] currentPrice;
        int maxQuantity;
        Label[] quantity;
        string[] idVideo;
        Label[] payment;
        Label[] increaseQuantity;
        Label[] decreaseQuantity;
        Label[] price;
        Label[] remove;

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            panel2.AutoScroll = true;
            ShowImage();

        }

        const int SB_HORZ = 0;



        [DllImport("user32.dll")]

        static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);



        protected override void OnShown(EventArgs e)

        {

            ShowScrollBar(this.panel2.Handle, SB_HORZ, false);

            base.OnShown(e);

        }

        public void ShowImage()
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    Main_User main_User = (Main_User)ParentForm;
                    command.Parameters.AddWithValue("@userName", main_User.Label_UserName.Text);
                    command.CommandText =
                    "SELECT Video.id, Name, Thumbnail, Payment, AddToCart.Price, Video.Quantity AS VideoQuantity, AddToCart.Quantity AS AddToCartQuantity " +
                    "FROM (Video INNER JOIN AddToCart ON Video.id = AddToCart.idVideo) INNER JOIN Account ON Account.Username = AddToCart.Username " +
                    "WHERE Account.Username = @userName";
                    int count = 0;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("Payment");
                        var indexOfColumn4 = reader.GetOrdinal("Price");
                        var indexOfColumn5 = reader.GetOrdinal("VideoQuantity");
                        var indexOfColumn6 = reader.GetOrdinal("AddToCartQuantity");
                        var indexOfColumn7 = reader.GetOrdinal("id");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            var value5 = reader.GetValue(indexOfColumn5);
                            var value6 = reader.GetValue(indexOfColumn6);
                            var value7 = reader.GetValue(indexOfColumn7);

                            count++;
                            maxQuantity = (int)Convert.ToDouble(value5);
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("Payment");
                        var indexOfColumn4 = reader.GetOrdinal("Price");
                        var indexOfColumn5 = reader.GetOrdinal("VideoQuantity");
                        var indexOfColumn6 = reader.GetOrdinal("AddToCartQuantity");
                        var indexOfColumn7 = reader.GetOrdinal("id");
                        int x = 0;
                        int y = 0;
                        PictureBox[] picturebox = new PictureBox[count];
                        Label[] nameVideo = new Label[count];
                        price = new Label[count];
                        currentPrice = new float[count];
                        Panel[] divider = new Panel[count];
                        quantity = new Label[count];
                        increaseQuantity = new Label[count];
                        decreaseQuantity = new Label[count];
                        currentQuantity = new int[count];
                        payment = new Label[count];
                        idVideo = new string[count];
                        remove = new Label[count];
                        int index = 0;
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            var value5 = reader.GetValue(indexOfColumn5);
                            var value6 = reader.GetValue(indexOfColumn6);
                            var value7 = reader.GetValue(indexOfColumn7);
                            if ((x % 1 == 0) && (index != 0))
                            {
                                y = y + 250;
                                x = 0;
                            }
                            picturebox[index] = new PictureBox();
                            nameVideo[index] = new Label();
                            payment[index] = new Label();
                            price[index] = new Label();
                            decreaseQuantity[index] = new Label();
                            increaseQuantity[index] = new Label();
                            quantity[index] = new Label();
                            remove[index] = new Label();
                            currentQuantity[index] = Int32.Parse(value6.ToString());
                            idVideo[index] = value7.ToString();
                            currentPrice[index] = Int32.Parse(value4.ToString());

                            picturebox[index].Image = Image.FromFile(value2.ToString());
                            picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                            picturebox[index].Location = new Point(x * 250 + 15, y);
                            picturebox[index].Size = new Size(150, 200); //150,200
                            picturebox[index].Tag = value3;

                            remove[index].Text = "Remove";
                            remove[index].Font = new Font("Segoe UI", 13);
                            remove[index].Size = new Size(175, 50);
                            remove[index].ForeColor = Color.White;
                            remove[index].AutoSize = false;
                            remove[index].TextAlign = ContentAlignment.TopLeft;
                            remove[index].Location = new Point(x * 250 + 600, y + 178);
                            remove[index].Tag = index;
                            remove[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveItem);

                            nameVideo[index].Text = (string)value1;
                            nameVideo[index].Font = new Font("Segoe UI", 13);
                            nameVideo[index].Size = new Size(175, 50);
                            nameVideo[index].ForeColor = Color.White;
                            nameVideo[index].TextAlign = ContentAlignment.TopLeft;
                            nameVideo[index].AutoSize = false;
                            nameVideo[index].Location = new Point(x * 250 + 180, y + 10);

                            payment[index].Text = (string)value3;
                            payment[index].Font = new Font("Segoe UI", 13);
                            payment[index].Size = new Size(175, 50); //175, 50
                            payment[index].ForeColor = Color.White;
                            payment[index].AutoSize = false;
                            payment[index].TextAlign = ContentAlignment.TopLeft;
                            payment[index].Location = new Point(x * 250 + 475, y + 10);

                            price[index].Text = (currentPrice[index] * currentQuantity[index]).ToString();
                            price[index].Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(price[index].Text));
                            price[index].Font = new Font("Segoe UI", 13);
                            price[index].Size = new Size(175, 50); //175, 50
                            price[index].ForeColor = Color.White;
                            price[index].AutoSize = false;
                            price[index].TextAlign = ContentAlignment.TopLeft;
                            price[index].Location = new Point(x * 250 + 600, y + 10);

                            decreaseQuantity[index].Text = "-";
                            decreaseQuantity[index].Font = new Font("Segoe UI", 13);
                            decreaseQuantity[index].Size = new Size(20, 25);
                            decreaseQuantity[index].ForeColor = Color.White;
                            decreaseQuantity[index].AutoSize = false;
                            decreaseQuantity[index].TextAlign = ContentAlignment.TopLeft;
                            decreaseQuantity[index].Location = new Point(x * 250 + 340, y + 10);
                            decreaseQuantity[index].Tag = index;
                            decreaseQuantity[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.DecreaseQuantity);

                            increaseQuantity[index].Text = "+";
                            increaseQuantity[index].Font = new Font("Segoe UI", 13);
                            increaseQuantity[index].Size = new Size(20, 25);
                            increaseQuantity[index].ForeColor = Color.White;
                            increaseQuantity[index].AutoSize = false;
                            increaseQuantity[index].TextAlign = ContentAlignment.TopLeft;
                            increaseQuantity[index].Location = new Point(x * 250 + 390, y + 10);
                            increaseQuantity[index].Tag = index;
                            increaseQuantity[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.IncreaseQuantity);

                            quantity[index].Text = currentQuantity[index].ToString();
                            quantity[index].Font = new Font("Segoe UI", 13);
                            quantity[index].Size = new Size(20, 50); //20, 50
                            quantity[index].ForeColor = Color.White;
                            quantity[index].AutoSize = true;
                            quantity[index].TextAlign = ContentAlignment.MiddleCenter;
                            quantity[index].Location = new Point(x * 250 + 360, y + 10);

                            remove[index].BringToFront();

                            if (index < count - 1)
                            {
                                divider[index] = new Panel();
                                divider[index].Location = new Point(x * 250, y + 220);
                                divider[index].Size = new Size(714, 10);
                                divider[index].Paint += new System.Windows.Forms.PaintEventHandler(this.divider_Paint);
                                divider[index].BringToFront();
                            }

                            //Thêm khoảng cách khi scrollbar kéo đến cuối cùng
                            if (index == count - 1)
                            {
                                Label label_empty = new Label();
                                label_empty.Location = new Point(x * 250 + 15, y + 175);
                                label_empty.Size = new Size(175, 70);
                                panel2.Controls.Add(label_empty);
                            }

                            float totalProduct = 0;
                            for (int i = 0; i < currentPrice.Length; i++)
                            {
                                totalProduct = totalProduct + (currentPrice[i] * currentQuantity[i]);
                            }

                            Label_ShowTotalProduct.Text = totalProduct.ToString();
                            Label_ShowTotal.Text = totalProduct.ToString();
                            Label_ShowTotalProduct.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotalProduct.Text)) + " VND";
                            Label_ShowTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotal.Text)) + " VND";

                            if (currentQuantity[index] == 1)
                            {
                                decreaseQuantity[index].Enabled = false;
                            }
                            if (currentQuantity[index] == Int32.Parse(value5.ToString()) || currentQuantity[index] > Int32.Parse(value5.ToString()))
                            {
                                increaseQuantity[index].Enabled = false;
                            }
                            if (currentQuantity[index] > 1 && currentQuantity[index] < Int32.Parse(value5.ToString()))
                            {
                                decreaseQuantity[index].Enabled = true;
                                increaseQuantity[index].Enabled = true;
                            }

                            //Make rounded corner picturebox
                            Rectangle r = new Rectangle(0, 0, picturebox[index].Width, picturebox[index].Height);
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            int d = 10;
                            gp.AddArc(r.X, r.Y, d, d, 180, 90);
                            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                            picturebox[index].Region = new Region(gp);

                            panel2.Controls.Add(picturebox[index]);
                            panel2.Controls.Add(nameVideo[index]);
                            panel2.Controls.Add(payment[index]);
                            panel2.Controls.Add(price[index]);
                            panel2.Controls.Add(divider[index]);
                            panel2.Controls.Add(decreaseQuantity[index]);
                            panel2.Controls.Add(increaseQuantity[index]);
                            panel2.Controls.Add(quantity[index]);
                            panel2.Controls.Add(remove[index]);

                            nameVideo[index].BringToFront();
                            picturebox[index].BringToFront();
                            decreaseQuantity[index].BringToFront();
                            quantity[index].BringToFront();
                            increaseQuantity[index].BringToFront();
                            payment[index].BringToFront();
                            price[index].BringToFront();

                            index++;
                            x++;
                        }
                    }
                    connection.Close();
                }
            }
        }

        internal void DecreaseQuantity(object sender, MouseEventArgs e)
        {
            Label decreaseQuantity2 = sender as Label;
            int index = Int32.Parse(decreaseQuantity2.Tag.ToString());
            currentQuantity[index] = currentQuantity[index] - 1;
            quantity[index].Text = currentQuantity[index].ToString();

            Main_User main_User = (Main_User)ParentForm;
            string userName = main_User.Label_UserName.Text;
            string idVideo2 = idVideo[index];
            string payment2 = payment[index].Text;
            int quantity2 = currentQuantity[index];
            float price2 = currentPrice[index] * currentQuantity[index];

            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE AddToCart SET Quantity = @quantity, CurrentPrice = @price Where UserName = @userName and idVideo = @idVideo and Payment = @payment";

                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@idVideo", idVideo2);
                command.Parameters.AddWithValue("@payment", payment2);
                command.Parameters.AddWithValue("@quantity", quantity2);
                command.Parameters.AddWithValue("@price", price2);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }

            if (currentQuantity[index] == 1)
            {
                decreaseQuantity[index].Enabled = false;
            }
            else
            {
                increaseQuantity[index].Enabled = true;
            }

            price[index].Text = (currentPrice[index] * currentQuantity[index]).ToString();
            price[index].Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(price[index].Text));

            float totalProduct = 0;
            for (int i = 0; i < currentPrice.Length; i++)
            {
                totalProduct = totalProduct + (currentPrice[i] * currentQuantity[i]);
            }
            Label_ShowTotalProduct.Text = totalProduct.ToString();
            Label_ShowTotal.Text = totalProduct.ToString();
            Label_ShowTotalProduct.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotalProduct.Text)) + " VND";
            Label_ShowTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotal.Text)) + " VND";
        }

        internal void IncreaseQuantity(object sender, MouseEventArgs e)
        {
            Label increaseQuantity2 = sender as Label;
            int index = Int32.Parse(increaseQuantity2.Tag.ToString());
            currentQuantity[index] = currentQuantity[index] + 1;
            quantity[index].Text = currentQuantity[index].ToString();

            Main_User main_User = (Main_User)ParentForm;
            string userName = main_User.Label_UserName.Text;
            string idVideo2 = idVideo[index];
            string payment2 = payment[index].Text;
            int quantity2 = currentQuantity[index];
            float price2 = currentPrice[index] * currentQuantity[index];
            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE AddToCart SET Quantity = @quantity, CurrentPrice = @price Where UserName = @userName and idVideo = @idVideo and Payment = @payment";

                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@idVideo", idVideo2);
                command.Parameters.AddWithValue("@payment", payment2);
                command.Parameters.AddWithValue("@quantity", quantity2);
                command.Parameters.AddWithValue("@price", price2);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }

            if (currentQuantity[index] == maxQuantity || currentQuantity[index] > maxQuantity)
            {
                increaseQuantity[index].Enabled = false;
            }
            else
            {
                decreaseQuantity[index].Enabled = true;
            }

            price[index].Text = (currentPrice[index] * currentQuantity[index]).ToString();
            price[index].Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", float.Parse(price[index].Text));

            float totalProduct = 0;
            for (int i = 0; i < currentPrice.Length; i++)
            {
                totalProduct = totalProduct + (currentPrice[i] * currentQuantity[i]);
            }
            Label_ShowTotalProduct.Text = totalProduct.ToString();
            Label_ShowTotal.Text = totalProduct.ToString();
            Label_ShowTotalProduct.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotalProduct.Text)) + " VND";
            Label_ShowTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotal.Text)) + " VND";
        }

        private void RemoveItem(object sender, MouseEventArgs e)
        {
            Label labelRemove = sender as Label;
            int index = Int32.Parse(labelRemove.Tag.ToString());
            string idVideo2 = idVideo[index];
            string payment2 = payment[index].Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM AddToCart Where idVideo = @idVideo and Payment = @payment";

                command.Parameters.AddWithValue("@idVideo", idVideo2);
                command.Parameters.AddWithValue("@payment", payment2);


                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            panel2.Controls.Clear();
            ShowImage();
            UpdateTotalPriceProduct();
        }

        private void UpdateTotalPriceProduct()
        {
            float totalProduct = 0;

            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CurrentPrice FROM AddToCart";
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("CurrentPrice");

                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);

                            if (value1 != null)
                            {
                                totalProduct = totalProduct + Int32.Parse(value1.ToString());
                            }
                        }
                    }
                }
            }
            Label_ShowTotalProduct.Text = totalProduct.ToString();
            Label_ShowTotal.Text = totalProduct.ToString();
            Label_ShowTotalProduct.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotalProduct.Text)) + " VND";
            Label_ShowTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Int32.Parse(Label_ShowTotal.Text)) + " VND";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void divider_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(10, 5);
                var point2 = new Point(670, 5);
                g.DrawLine(p, point1, point2);
                g.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(10, 5);
                var point2 = new Point(670, 5);
                g.DrawLine(p, point1, point2);
                g.Dispose();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Main_User main_User = (Main_User)ParentForm;
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.AddWithValue("@userName", main_User.Label_UserName.Text);
                    command.CommandText =
                    "SELECT Video.id, Payment, AddToCart.CurrentPrice AS Price, AddToCart.Quantity AS Quantity  FROM " +
                    "(Video INNER JOIN AddToCart ON Video.id = AddToCart.idVideo) INNER JOIN Account ON Account.Username = AddToCart.Username " +
                    "WHERE Account.Username = @userName";
                    connection.Open();
                    int i = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("id");
                        var indexOfColumn2 = reader.GetOrdinal("Payment");
                        var indexOfColumn3 = reader.GetOrdinal("Price");
                        var indexOfColumn4 = reader.GetOrdinal("Quantity");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                            string query = "INSERT INTO Request ( userName , idVideo, DateRequest, DateDelivered, Type, Status, Price, Quantity) " +
                                "VALUES (@userName, @idVideo, @dateRequest, @dateDelivered, @type, @status, @price, @quantity)";
                            SqlCommand cmd = new SqlCommand(query, con);


                            string userName = main_User.Label_UserName.Text;
                            string idVideo = (string)value1;
                            float price = float.Parse(value3.ToString());
                            int quantity = Int32.Parse(value4.ToString());
                            DateTime dateRequest = DateTime.Now;
                            DateTime dateDelivered = dateRequest.AddDays(7);
                            string type = "";
                            if (value2.ToString() == "Buy")
                            {
                                type = "Buy";
                            }
                            else
                            {
                                type = "Rent";
                            }
                            string status = "Waiting";

                            cmd.Parameters.AddWithValue("@userName", userName);
                            cmd.Parameters.AddWithValue("@idVideo", idVideo);
                            cmd.Parameters.AddWithValue("@dateRequest", dateRequest);
                            cmd.Parameters.AddWithValue("@dateDelivered", dateDelivered);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@quantity", quantity);

                            con.Open();
                            i = cmd.ExecuteNonQuery();

                            con.Close();
                        }
                        if (i != 0)
                        {
                            MessageBox.Show("Send Request Successfully");
                            //Delete item cart after checkout
                            try
                            {
                                string query = "DELETE FROM AddToCart";
                                using (SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
                                {
                                    con.Open();
                                    using (SqlCommand cmd = new SqlCommand(query, con))
                                    {
                                        cmd.ExecuteNonQuery();

                                        //this.panel2.Controls.Clear();
                                        //ShoppingCart_Load(sender, e);
                                        this.panel2.Controls.Clear();
                                        ShowImage();
                                        UpdateTotalPriceProduct();
                                    }
                                    con.Close();
                                }
                            }
                            catch (SystemException ex)
                            {
                                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                            }
                        }
                    }
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_ShowTotalProduct_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(0, 5);
                var point2 = new Point(299, 5);
                g.DrawLine(p, point1, point2);
                g.Dispose();
            }
        }
    }
}
