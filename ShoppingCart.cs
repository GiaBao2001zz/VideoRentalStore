using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                    command.CommandText = "SELECT Name, Thumbnail, Payment, AddToCart.Price  FROM (Video INNER JOIN AddToCart ON Video.id = AddToCart.idVideo) INNER JOIN Account ON Account.Username = AddToCart.Username WHERE Account.Username = @userName";
                    int count = 0;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("Payment");
                        var indexOfColumn4 = reader.GetOrdinal("Price");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            count++;
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("Payment");
                        var indexOfColumn4 = reader.GetOrdinal("Price");
                        int x = 0;
                        int y = 80; //70
                        PictureBox[] picturebox = new PictureBox[count];
                        Label[] nameVideo = new Label[count];
                        Label[] payment = new Label[count];
                        Label[] price = new Label[count];
                        int index = 0;
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
                            var value4 = reader.GetValue(indexOfColumn4);
                            if ((x % 1 == 0) && (index != 0))
                            {
                                y = y + 250; // Mỗi hàng 4 hình
                                x = 0;
                            }
                            picturebox[index] = new PictureBox();
                            nameVideo[index] = new Label();
                            payment[index] = new Label();
                            price[index] = new Label();

                            picturebox[index].Image = Image.FromFile(value2.ToString());
                            picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                            picturebox[index].Location = new Point(x * 250 + 15, y);
                            picturebox[index].Size = new Size(150, 200); //150,200
                            picturebox[index].Tag = value3;

                            nameVideo[index].Text = (string)value1;
                            nameVideo[index].Font = new Font("Segoe UI", 13);
                            nameVideo[index].Size = new Size(175, 50);
                            nameVideo[index].ForeColor = Color.White;
                            nameVideo[index].TextAlign = ContentAlignment.TopLeft;
                            nameVideo[index].AutoSize = false;
                            nameVideo[index].Location = new Point(x * 250 + 180, y + 10);

                            payment[index].Text = (string)value3;
                            payment[index].Font = new Font("Segoe UI", 13);
                            payment[index].Size = new Size(175, 50);
                            payment[index].ForeColor = Color.White;
                            payment[index].AutoSize = false;
                            payment[index].TextAlign = ContentAlignment.TopLeft;
                            payment[index].Location = new Point(x * 250 + 390, y + 10);

                            price[index].Text = (string)value4.ToString();
                            price[index].Font = new Font("Segoe UI", 13);
                            price[index].Size = new Size(175, 50);
                            price[index].ForeColor = Color.White;
                            price[index].AutoSize = false;
                            price[index].TextAlign = ContentAlignment.TopLeft;
                            price[index].Location = new Point(x * 250 + 563, y + 10);

                            //picturebox[index].MouseEnter += new EventHandler(this.HoverMouseEnter);
                            //picturebox[index].MouseLeave += new EventHandler(this.HoverMouseLeave);
                            //picturebox[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Active);

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

                            nameVideo[index].BringToFront();
                            picturebox[index].BringToFront();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.White, 1);
                var point1 = new Point(10, 5);
                var point2 = new Point(650, 5);
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
                    command.CommandText = "SELECT Video.id, Payment  FROM (Video INNER JOIN AddToCart ON Video.id = AddToCart.idVideo) INNER JOIN Account ON Account.Username = AddToCart.Username WHERE Account.Username = @userName";
                    connection.Open();
                    int i = 0;
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("id");
                        var indexOfColumn2 = reader.GetOrdinal("Payment");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True");
                            string query = "INSERT INTO Request ( userName , idVideo, DateRequest, DateDelivered, Type, Status) " +
                                "VALUES (@userName, @idVideo, @dateRequest, @dateDelivered, @type, @status)";
                            SqlCommand cmd = new SqlCommand(query, con);


                            string userName = main_User.Label_UserName.Text;
                            string idVideo = (string)value1;
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
        }
    }

