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
    public partial class Video_Shelf : Form
    {
        public Video_Shelf()
        {
            InitializeComponent();
        }

        public void ShowImage()
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Name, Thumbnail FROM Video";
                    int count = 0;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            count++;
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        int x = 0;
                        int y = 50;
                        PictureBox[] picturebox = new PictureBox[count];
                        Label[] label = new Label[count];
                        int index = 0;
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            if ((x % 4 == 0) && (index != 0))
                            {
                                y = y + 300; // Mỗi hàng 4 hình, tọa độ tấm hình đầu tiên (20,150)
                                x = 0;
                            }
                            picturebox[index] = new PictureBox();
                            label[index] = new Label();
                            picturebox[index].Image = Image.FromFile(value2.ToString());                  
                            picturebox[index].SizeMode = PictureBoxSizeMode.Zoom;
                            picturebox[index].Location = new Point(x * 250 +60, y);
                            picturebox[index].Size = new Size(200, 200);
                            label[index].Text = (string)value1;
                            label[index].Font = new Font("Circular", 10);
                            label[index].Size = new Size(150, 70);
                            label[index].ForeColor = Color.White;
                            label[index].TextAlign = ContentAlignment.MiddleCenter;
                            label[index].AutoSize = false;
                            label[index].Location = new Point(x * 250 + 85, y + 200 );
                            this.Controls.Add(picturebox[index]);
                            this.Controls.Add(label[index]);
                            picturebox[index].BringToFront();
                            label[index].BringToFront();
                            index++;
                            x++;
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void Video_Shelf_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            ShowImage();
        }
    }
}
