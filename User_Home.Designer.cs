
namespace VideoRentalStore
{
    partial class User_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel_BestOfTheDay = new System.Windows.Forms.Panel();
            this.Panel_BestOfTheDayText = new VideoRentalStore.GradiantPanel();
            this.Label_NameOfBanner = new System.Windows.Forms.Label();
            this.Label_TiltleBestOfTheDay = new System.Windows.Forms.Label();
            this.PictureBox_BestOfTheDay = new System.Windows.Forms.PictureBox();
            this.Panel_Fade = new System.Windows.Forms.Panel();
            this.Panel_Recommend = new System.Windows.Forms.Panel();
            this.Label_Recommend = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_BestOfTheDay.SuspendLayout();
            this.Panel_BestOfTheDayText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BestOfTheDay)).BeginInit();
            this.Panel_Recommend.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_BestOfTheDay
            // 
            this.Panel_BestOfTheDay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_BestOfTheDay.Controls.Add(this.Panel_BestOfTheDayText);
            this.Panel_BestOfTheDay.Controls.Add(this.Label_TiltleBestOfTheDay);
            this.Panel_BestOfTheDay.Controls.Add(this.PictureBox_BestOfTheDay);
            this.Panel_BestOfTheDay.Controls.Add(this.Panel_Fade);
            this.Panel_BestOfTheDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_BestOfTheDay.Location = new System.Drawing.Point(0, 0);
            this.Panel_BestOfTheDay.Name = "Panel_BestOfTheDay";
            this.Panel_BestOfTheDay.Size = new System.Drawing.Size(1163, 587);
            this.Panel_BestOfTheDay.TabIndex = 0;
            // 
            // Panel_BestOfTheDayText
            // 
            this.Panel_BestOfTheDayText.Angle = 0F;
            this.Panel_BestOfTheDayText.BackColor = System.Drawing.Color.Transparent;
            this.Panel_BestOfTheDayText.BottomColor = System.Drawing.Color.Empty;
            this.Panel_BestOfTheDayText.Controls.Add(this.Label_NameOfBanner);
            this.Panel_BestOfTheDayText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_BestOfTheDayText.Location = new System.Drawing.Point(0, 464);
            this.Panel_BestOfTheDayText.Name = "Panel_BestOfTheDayText";
            this.Panel_BestOfTheDayText.Size = new System.Drawing.Size(1163, 123);
            this.Panel_BestOfTheDayText.TabIndex = 5;
            this.Panel_BestOfTheDayText.TopColor = System.Drawing.Color.Empty;
            // 
            // Label_NameOfBanner
            // 
            this.Label_NameOfBanner.AutoSize = true;
            this.Label_NameOfBanner.BackColor = System.Drawing.Color.Transparent;
            this.Label_NameOfBanner.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NameOfBanner.ForeColor = System.Drawing.Color.White;
            this.Label_NameOfBanner.Location = new System.Drawing.Point(27, 0);
            this.Label_NameOfBanner.Name = "Label_NameOfBanner";
            this.Label_NameOfBanner.Size = new System.Drawing.Size(441, 47);
            this.Label_NameOfBanner.TabIndex = 0;
            this.Label_NameOfBanner.Text = "Super hero movies of 2021";
            // 
            // Label_TiltleBestOfTheDay
            // 
            this.Label_TiltleBestOfTheDay.AutoSize = true;
            this.Label_TiltleBestOfTheDay.BackColor = System.Drawing.Color.Transparent;
            this.Label_TiltleBestOfTheDay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TiltleBestOfTheDay.ForeColor = System.Drawing.Color.White;
            this.Label_TiltleBestOfTheDay.Location = new System.Drawing.Point(28, 38);
            this.Label_TiltleBestOfTheDay.Name = "Label_TiltleBestOfTheDay";
            this.Label_TiltleBestOfTheDay.Size = new System.Drawing.Size(192, 37);
            this.Label_TiltleBestOfTheDay.TabIndex = 3;
            this.Label_TiltleBestOfTheDay.Text = "Best of the day";
            // 
            // PictureBox_BestOfTheDay
            // 
            this.PictureBox_BestOfTheDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_BestOfTheDay.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_BestOfTheDay.Name = "PictureBox_BestOfTheDay";
            this.PictureBox_BestOfTheDay.Size = new System.Drawing.Size(1163, 587);
            this.PictureBox_BestOfTheDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_BestOfTheDay.TabIndex = 4;
            this.PictureBox_BestOfTheDay.TabStop = false;
            // 
            // Panel_Fade
            // 
            this.Panel_Fade.Location = new System.Drawing.Point(3, 3);
            this.Panel_Fade.Name = "Panel_Fade";
            this.Panel_Fade.Size = new System.Drawing.Size(1012, 554);
            this.Panel_Fade.TabIndex = 6;
            // 
            // Panel_Recommend
            // 
            this.Panel_Recommend.Controls.Add(this.Label_Recommend);
            this.Panel_Recommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Recommend.Location = new System.Drawing.Point(0, 587);
            this.Panel_Recommend.Name = "Panel_Recommend";
            this.Panel_Recommend.Size = new System.Drawing.Size(1163, 800);
            this.Panel_Recommend.TabIndex = 1;
            this.Panel_Recommend.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Label_Recommend
            // 
            this.Label_Recommend.AutoSize = true;
            this.Label_Recommend.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Recommend.ForeColor = System.Drawing.Color.White;
            this.Label_Recommend.Location = new System.Drawing.Point(35, 37);
            this.Label_Recommend.Name = "Label_Recommend";
            this.Label_Recommend.Size = new System.Drawing.Size(279, 37);
            this.Label_Recommend.TabIndex = 0;
            this.Label_Recommend.Text = "Recommeded for you";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // User_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1180, 661);
            this.Controls.Add(this.Panel_Recommend);
            this.Controls.Add(this.Panel_BestOfTheDay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Home";
            this.Text = "User_Home";
            this.Panel_BestOfTheDay.ResumeLayout(false);
            this.Panel_BestOfTheDay.PerformLayout();
            this.Panel_BestOfTheDayText.ResumeLayout(false);
            this.Panel_BestOfTheDayText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BestOfTheDay)).EndInit();
            this.Panel_Recommend.ResumeLayout(false);
            this.Panel_Recommend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_BestOfTheDay;
        private System.Windows.Forms.Label Label_TiltleBestOfTheDay;
        private System.Windows.Forms.PictureBox PictureBox_BestOfTheDay;
        private GradiantPanel Panel_BestOfTheDayText;
        private System.Windows.Forms.Label Label_NameOfBanner;
        private System.Windows.Forms.Panel Panel_Recommend;
        private System.Windows.Forms.Label Label_Recommend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel_Fade;
    }
}