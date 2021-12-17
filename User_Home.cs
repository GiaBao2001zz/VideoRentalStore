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

            //Fade Panel
            Panel_Fade.Parent = Panel_BestOfTheDay;
            Panel_Fade.Dock = DockStyle.Fill;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    

