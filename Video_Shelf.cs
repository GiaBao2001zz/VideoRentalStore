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
                                y = y + 325; // Mỗi hàng 4 hình
                                x = 0;
                            }
                            picturebox[index] = new PictureBox();
                            label[index] = new Label();
                            picturebox[index].Image = Image.FromFile(value2.ToString());
                            picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                            picturebox[index].Location = new Point(x * 250 +60, y);
                            picturebox[index].Size = new Size(175, 250); //150,200
                            picturebox[index].Tag = value3;                         
                            label[index].Text = (string)value1;
                            label[index].Font = new Font("Segoe UI", 13);
                            label[index].Size = new Size(175, 70);
                            label[index].ForeColor = Color.White;
                            label[index].AutoSize = false;
                            label[index].TextAlign = ContentAlignment.MiddleCenter;
                            label[index].AutoSize = false;
                            label[index].Location = new Point(x * 250 + 60, y + 245 );
                            picturebox[index].MouseEnter += new EventHandler(this.HoverMouseEnter);
                            picturebox[index].MouseLeave += new EventHandler(this.HoverMouseLeave);
                            picturebox[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Active);

                            //Make rounded corner picturebox
                            Rectangle r = new Rectangle(0, 0, picturebox[index].Width, picturebox[index].Height);
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            int d = 10;
                            gp.AddArc(r.X, r.Y, d, d, 180, 90);
                            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                            picturebox[index].Region = new Region(gp);

                            this.Controls.Add(picturebox[index]);
                            this.Controls.Add(label[index]);                                                     
                            label[index].BringToFront();
                            picturebox[index].BringToFront();
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
            Video_Info_ReadOnly video_Info = new Video_Info_ReadOnly() { Dock = DockStyle.Fill, TopLevel = false };
            main_User.Panel_SwtichForm.Controls.Add(video_Info);
            video_Info.Show();

            //Show infomation of disc
            PictureBox picture = sender as PictureBox;
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.AddWithValue("@id", picture.Tag.ToString());
                    command.CommandText = "SELECT Name, Price, Quantity, Director, Actor, Decription, Thumbnail, Provider, Category, id FROM Video WHERE id=@id";                    
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
                        var idVideo = reader.GetOrdinal("id");
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
                            var idVideo_data = reader.GetValue(idVideo);

                            video_Info.pictureBox_Disc.Image = Image.FromFile(thumbnailVideo_data.ToString());
                            video_Info.TextBox_VideoName.Text = nameVideo_data.ToString();
                            video_Info.Label_ShowPrice.Text = priceVideo_data.ToString();
                            video_Info.Label_ShowQuantity.Text = quantityVideo_data.ToString();
                            video_Info.Label_ShowDirector.Text = directorVideo_data.ToString();
                            video_Info.Label_ShowActor.Text = actorVideo_data.ToString();
                            video_Info.Label_Discription.Text = descriptionVideo_data.ToString();
                            video_Info.Label_Category.Text = categoryVideo_data.ToString();
                            video_Info.TextBox_idVideo.Text = idVideo_data.ToString();
                           
                        }
                    }
                }
            }
        }

        internal void HoverMouseEnter(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.SetBounds(picture.Left - 5, picture.Top - 2, picture.Width + 15, picture.Height + 10);//15, 10  5, 2
            picture.Cursor = Cursors.Hand;
        }
        internal void HoverMouseLeave(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.SetBounds(picture.Left + 5, picture.Top + 2, picture.Width - 15, picture.Height - 10);
        }

        private void Video_Shelf_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            ShowImage();
        }
    }
}
