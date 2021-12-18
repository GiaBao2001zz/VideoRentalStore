using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data.SqlClient;

namespace VideoRentalStore
{
    public partial class User_Home : Form
    {
        public User_Home()
        {
            InitializeComponent();
            Load_Home();
            
            

        }
        private void Load_Home()
        {
            Label_NameOfBanner.Parent = Panel_BestOfTheDayText;
            Label_NameOfBanner.BackColor = Color.Transparent;


            Panel_BestOfTheDayText.Parent = PictureBox_BestOfTheDay;
            //Label Best of the day Text

            Panel_BestOfTheDayText.TopColor = Color.FromArgb(220, Color.Black);
            Panel_BestOfTheDayText.BottomColor = Color.FromArgb(0, Color.Black);
            Panel_BestOfTheDayText.Angle = -30;
            Panel_BestOfTheDayText.BorderStyle = BorderStyle.None;

            //Label Tiltle BOTD
            Label_TiltleBestOfTheDay.Parent = PictureBox_BestOfTheDay;
            //PictureBox
            string workingDirectory = Environment.CurrentDirectory;
            string text = Directory.GetParent(workingDirectory).Parent.FullName;
     
            Image image = Image.FromFile(@"" + text + "\\Resources\\Fantasy\\1.png");
            this.PictureBox_BestOfTheDay.Image = image;

          

            //Recommend
            string[] Recommend = new string[3];
            Recommend[0] = "Harry Potter";
            Recommend[1] = "Toy Story";
            Recommend[2] = "Fast & Furious";
            Load_Thumbnails(Recommend);

            //Hide scrollbars
            Panel_RecommendItems.HorizontalScroll.Maximum = 0;
            Panel_RecommendItems.AutoScroll = false;
            Panel_RecommendItems.VerticalScroll.Visible = false;
            Panel_RecommendItems.AutoScroll = true;
        }
        private void Load_Thumbnails(string[] str)
        {
            using (var connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = VideoRentalStore; Integrated Security = True"))
            {


                int x = 0;
                int y = 30;
                int z = 0;
                int count = 0;

                int index = 0;


                for (int str_index = 0; str_index < 3; str_index++)
                {

                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT TOP 3 Thumbnail, id FROM Video WHERE Name LIKE '%" + str[str_index] + "%'; ";



                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn2 = reader.GetOrdinal("Thumbnail");
                        while (reader.Read())
                        {
                            var value2 = reader.GetValue(indexOfColumn2);
                            count++;
                        }
                    }



                    PictureBox[] picturebox = new PictureBox[count];
                    Label[] label = new Label[count];

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var indexOfColumn2 = reader.GetOrdinal("Thumbnail");

                            var value2 = reader.GetValue(indexOfColumn2);


                            if (index % 3 == 0 && index != 0)
                            {
                                z += 80;
                                
                            }
                            if (index % 3 == 2 )
                            {
                                Panel filter = new Panel();
                                filter.Location = new Point((x + 1) * 140 + 35 + (80 *(index/3)), y);
                                filter.Size = new Size(80, 200);
                                this.Panel_RecommendItems.Controls.Add(filter);
                                filter.BackColor = Color.Transparent;
                                filter.BringToFront();
                            }    
                                if (index % 3 == 0)
                                {

                                    label[index] = new Label();
                                    label[index].Location = new Point(x * 140 + 35 + z, y + 220);
                                    label[index].Text = str[str_index];
                                    label[index].Font = new Font("Segoe UI Semibold", 18, FontStyle.Bold);

                                    label[index].ForeColor = Color.White;
                                    label[index].AutoSize = true;
                                    label[index].TextAlign = ContentAlignment.MiddleCenter;
                                    // label[index].Size = new Size(175, 70);
                                    this.Panel_RecommendItems.Controls.Add(label[index]);
                                    label[index].BringToFront();



                                }

                                picturebox[index] = new PictureBox();

                                picturebox[index].Image = Image.FromFile(value2.ToString());
                                picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                                picturebox[index].Location = new Point(x * 140 + 35 + z, y);
                                picturebox[index].Size = new Size(140, 200); //150,200




                                //picturebox[index].MouseEnter += new EventHandler(this.HoverMouseEnter);
                                //picturebox[index].MouseLeave += new EventHandler(this.HoverMouseLeave);
                                //picturebox[index].MouseClick += new System.Windows.Forms.MouseEventHandler(this.Active);



                                this.Panel_RecommendItems.Controls.Add(picturebox[index]);


                                picturebox[index].BringToFront();

                                index++;
                                x++;

                            }
                        }
                        connection.Close();
                    }


                

            }
        }


        internal int i = 1;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 5) i = 1;
            else i++;

            string workingDirectory = Environment.CurrentDirectory;
            string text = Directory.GetParent(workingDirectory).Parent.FullName;

            Image image = Image.FromFile(@"" + text + "\\Resources\\Fantasy\\" + i + ".png");
            this.PictureBox_BestOfTheDay.Image = image;
        }
   
        
    }
}
    

