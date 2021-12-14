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
                    command.CommandText = "SELECT Name, Thumbnail, id FROM Video";
                    int count = 0;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("id");
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3); 
                            count++;
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("Name");
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        var indexOfColumn3 = reader.GetOrdinal("id");
                        int x = 0;
                        int y = 50;
                        PictureBox[] picturebox = new PictureBox[count];
                        Label[] label = new Label[count];
                        int index = 0;
                        while (reader.Read())
                        {
                            var value1 = reader.GetValue(indexOfColumn1);
                            var value2 = reader.GetValue(indexOfColumn2);
                            var value3 = reader.GetValue(indexOfColumn3);
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
                            picturebox[index].Tag = value3;
                            label[index].Text = (string)value1;
                            label[index].Font = new Font("Circular", 10);
                            label[index].Size = new Size(150, 70);
                            label[index].ForeColor = Color.White;
                            label[index].AutoSize = false;
                            label[index].TextAlign = ContentAlignment.MiddleCenter;
                            label[index].AutoSize = false;
                            label[index].Location = new Point(x * 250 + 85, y + 200 );

                            var imageSize = picturebox[index].Image.Size;
                            var fitSize = picturebox[index].ClientSize;
                            //picturebox[index].SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                            //    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;

                            picturebox[index].MouseEnter += new EventHandler(this.HoverMouseEnter);
                            picturebox[index].MouseLeave += new EventHandler(this.HoverMouseLeave);
                            picturebox[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Active);
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

        internal void Active(object sender, MouseEventArgs e)
        {
            //Show form Video_Info
            
            Main_User main_User = (Main_User)ParentForm;
            if (main_User.Panel_SwtichForm.Controls.Count > 0)
                main_User.Panel_SwtichForm.Controls.RemoveAt(0);
            Video_Info video_Info = new Video_Info() { Dock = DockStyle.Fill, TopLevel = false };
            main_User.Panel_SwtichForm.Controls.Add(video_Info);
            video_Info.Show();

            //Show infomation of disc
            PictureBox picture = sender as PictureBox;
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.AddWithValue("@id", picture.Tag.ToString());
                    command.CommandText = "SELECT Name, Price, Quantity, Director, Actor, Decription, Thumbnail, Provider, Category FROM Video WHERE id=@id";                    
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var nameVideo = reader.GetOrdinal("Name");
                        var priceVideo = reader.GetOrdinal("Price");
                        var quantityVideo = reader.GetOrdinal("Quantity");
                        var directorVideo = reader.GetOrdinal("Director");
                        var actorVideo = reader.GetOrdinal("Actor");
                        var descriptionVideo = reader.GetOrdinal("Decription");
                        var thumbnailVideo = reader.GetOrdinal("Thumbnail");
                        var providerVideo = reader.GetOrdinal("Provider");
                        var categoryVideo = reader.GetOrdinal("Category");
                        while (reader.Read())
                        {
                            var nameVideo_data = reader.GetValue(nameVideo);
                            var priceVideo_data = reader.GetValue(priceVideo);
                            var quantityVideo_data = reader.GetValue(quantityVideo);
                            var directorVideo_data = reader.GetValue(directorVideo);
                            var actorVideo_data = reader.GetValue(actorVideo);
                            var descriptionVideo_data = reader.GetValue(descriptionVideo);
                            var thumbnailVideo_data = reader.GetValue(thumbnailVideo);
                            var providerVideo_data = reader.GetValue(providerVideo);
                            var categoryVideo_data = reader.GetValue(categoryVideo);

                            video_Info.pictureBox_Disc.Image = Image.FromFile(thumbnailVideo_data.ToString());
                            video_Info.TextBox_VideoName.Text = nameVideo_data.ToString();
                            video_Info.TextBox_VideoPrice.Text = priceVideo_data.ToString();
                            video_Info.Textbox_VideoQuantity.Text = quantityVideo_data.ToString();
                            video_Info.TextBox_VideoDirector.Text = directorVideo_data.ToString();
                            video_Info.TextBox_VideoActors.Text = actorVideo_data.ToString();
                            video_Info.TextBox_Description.Text = descriptionVideo_data.ToString();
                            video_Info.TextBox_VideoProvider.Text = providerVideo_data.ToString();
                            video_Info.TextBox_VideoCategory.Text = categoryVideo_data.ToString();

                            //Set read-only = true                           
                            video_Info.TextBox_VideoName.ReadOnly = true;
                            

                        }
                    }
                }
            }
        }

        internal void HoverMouseEnter(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.SetBounds(picture.Left - 10, picture.Top - 7, picture.Width + 20, picture.Height + 20);//15, 10  5, 2
            picture.Cursor = Cursors.Hand;
        }
        internal void HoverMouseLeave(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.SetBounds(picture.Left + 10, picture.Top + 7, picture.Width - 20, picture.Height - 20);
        }

        private void Video_Shelf_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            ShowImage();
        }
    }
}
