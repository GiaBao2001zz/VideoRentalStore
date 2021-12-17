
namespace VideoRentalStore
{
    partial class Video_Info_ReadOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Info_ReadOnly));
            this.Label_Actor = new System.Windows.Forms.Label();
            this.Label_Director = new System.Windows.Forms.Label();
            this.Label_Category = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Quantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Discription = new System.Windows.Forms.Panel();
            this.Label_Discription = new System.Windows.Forms.Label();
            this.Label_ShowActor = new System.Windows.Forms.Label();
            this.Label_ShowDirector = new System.Windows.Forms.Label();
            this.Label_ShowCategory = new System.Windows.Forms.Label();
            this.Label_ShowQuantity = new System.Windows.Forms.Label();
            this.Label_ShowPrice = new System.Windows.Forms.Label();
            this.TextBox_VideoName = new System.Windows.Forms.TextBox();
            this.Button_Rent = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_Buy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox_Disc = new System.Windows.Forms.PictureBox();
            this.TextBox_idVideo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.Panel_Discription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Actor
            // 
            this.Label_Actor.AutoSize = true;
            this.Label_Actor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Actor.ForeColor = System.Drawing.Color.White;
            this.Label_Actor.Location = new System.Drawing.Point(60, 260);
            this.Label_Actor.Name = "Label_Actor";
            this.Label_Actor.Size = new System.Drawing.Size(85, 32);
            this.Label_Actor.TabIndex = 31;
            this.Label_Actor.Text = "Actors:";
            // 
            // Label_Director
            // 
            this.Label_Director.AutoSize = true;
            this.Label_Director.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Director.ForeColor = System.Drawing.Color.White;
            this.Label_Director.Location = new System.Drawing.Point(60, 200);
            this.Label_Director.Name = "Label_Director";
            this.Label_Director.Size = new System.Drawing.Size(104, 32);
            this.Label_Director.TabIndex = 30;
            this.Label_Director.Text = "Director:";
            // 
            // Label_Category
            // 
            this.Label_Category.AutoSize = true;
            this.Label_Category.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Category.ForeColor = System.Drawing.Color.White;
            this.Label_Category.Location = new System.Drawing.Point(60, 140);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(115, 32);
            this.Label_Category.TabIndex = 35;
            this.Label_Category.Text = "Category:";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.White;
            this.Label_Price.Location = new System.Drawing.Point(60, 20);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(148, 32);
            this.Label_Price.TabIndex = 41;
            this.Label_Price.Text = "Price  (VNĐ):";
            // 
            // Label_Quantity
            // 
            this.Label_Quantity.AutoSize = true;
            this.Label_Quantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Quantity.ForeColor = System.Drawing.Color.White;
            this.Label_Quantity.Location = new System.Drawing.Point(60, 80);
            this.Label_Quantity.Name = "Label_Quantity";
            this.Label_Quantity.Size = new System.Drawing.Size(111, 32);
            this.Label_Quantity.TabIndex = 42;
            this.Label_Quantity.Text = "In stocks:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_idVideo);
            this.panel1.Controls.Add(this.Panel_Discription);
            this.panel1.Controls.Add(this.Label_ShowActor);
            this.panel1.Controls.Add(this.Label_ShowDirector);
            this.panel1.Controls.Add(this.Label_ShowCategory);
            this.panel1.Controls.Add(this.Label_ShowQuantity);
            this.panel1.Controls.Add(this.Label_ShowPrice);
            this.panel1.Controls.Add(this.Label_Quantity);
            this.panel1.Controls.Add(this.Label_Price);
            this.panel1.Controls.Add(this.Label_Category);
            this.panel1.Controls.Add(this.Label_Director);
            this.panel1.Controls.Add(this.Label_Actor);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 726);
            this.panel1.TabIndex = 43;
            // 
            // Panel_Discription
            // 
            this.Panel_Discription.AutoScroll = true;
            this.Panel_Discription.Controls.Add(this.Label_Discription);
            this.Panel_Discription.Location = new System.Drawing.Point(66, 325);
            this.Panel_Discription.Name = "Panel_Discription";
            this.Panel_Discription.Size = new System.Drawing.Size(465, 211);
            this.Panel_Discription.TabIndex = 48;
            // 
            // Label_Discription
            // 
            this.Label_Discription.AutoSize = true;
            this.Label_Discription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Discription.ForeColor = System.Drawing.Color.White;
            this.Label_Discription.Location = new System.Drawing.Point(3, 0);
            this.Label_Discription.MaximumSize = new System.Drawing.Size(420, 0);
            this.Label_Discription.Name = "Label_Discription";
            this.Label_Discription.Size = new System.Drawing.Size(420, 273);
            this.Label_Discription.TabIndex = 49;
            this.Label_Discription.Text = resources.GetString("Label_Discription.Text");
            // 
            // Label_ShowActor
            // 
            this.Label_ShowActor.AutoSize = true;
            this.Label_ShowActor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowActor.ForeColor = System.Drawing.Color.White;
            this.Label_ShowActor.Location = new System.Drawing.Point(232, 260);
            this.Label_ShowActor.Name = "Label_ShowActor";
            this.Label_ShowActor.Size = new System.Drawing.Size(158, 32);
            this.Label_ShowActor.TabIndex = 47;
            this.Label_ShowActor.Text = "Elson , Chime";
            // 
            // Label_ShowDirector
            // 
            this.Label_ShowDirector.AutoSize = true;
            this.Label_ShowDirector.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowDirector.ForeColor = System.Drawing.Color.White;
            this.Label_ShowDirector.Location = new System.Drawing.Point(232, 200);
            this.Label_ShowDirector.Name = "Label_ShowDirector";
            this.Label_ShowDirector.Size = new System.Drawing.Size(103, 32);
            this.Label_ShowDirector.TabIndex = 46;
            this.Label_ShowDirector.Text = "Chikitori";
            // 
            // Label_ShowCategory
            // 
            this.Label_ShowCategory.AutoSize = true;
            this.Label_ShowCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowCategory.ForeColor = System.Drawing.Color.White;
            this.Label_ShowCategory.Location = new System.Drawing.Point(232, 140);
            this.Label_ShowCategory.Name = "Label_ShowCategory";
            this.Label_ShowCategory.Size = new System.Drawing.Size(83, 32);
            this.Label_ShowCategory.TabIndex = 45;
            this.Label_ShowCategory.Text = "Horror";
            this.Label_ShowCategory.Click += new System.EventHandler(this.Label_ShowCategory_Click);
            // 
            // Label_ShowQuantity
            // 
            this.Label_ShowQuantity.AutoSize = true;
            this.Label_ShowQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowQuantity.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_ShowQuantity.Location = new System.Drawing.Point(232, 80);
            this.Label_ShowQuantity.Name = "Label_ShowQuantity";
            this.Label_ShowQuantity.Size = new System.Drawing.Size(53, 32);
            this.Label_ShowQuantity.TabIndex = 44;
            this.Label_ShowQuantity.Text = "123";
            // 
            // Label_ShowPrice
            // 
            this.Label_ShowPrice.AutoSize = true;
            this.Label_ShowPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowPrice.ForeColor = System.Drawing.Color.Yellow;
            this.Label_ShowPrice.Location = new System.Drawing.Point(232, 20);
            this.Label_ShowPrice.Name = "Label_ShowPrice";
            this.Label_ShowPrice.Size = new System.Drawing.Size(86, 32);
            this.Label_ShowPrice.TabIndex = 43;
            this.Label_ShowPrice.Text = "50 000";
            // 
            // TextBox_VideoName
            // 
            this.TextBox_VideoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBox_VideoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_VideoName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoName.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoName.Location = new System.Drawing.Point(662, 424);
            this.TextBox_VideoName.Multiline = true;
            this.TextBox_VideoName.Name = "TextBox_VideoName";
            this.TextBox_VideoName.ReadOnly = true;
            this.TextBox_VideoName.Size = new System.Drawing.Size(326, 75);
            this.TextBox_VideoName.TabIndex = 46;
            this.TextBox_VideoName.Text = "The Promised Neverland";
            this.TextBox_VideoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_Rent
            // 
            this.Button_Rent.ActiveBorderThickness = 1;
            this.Button_Rent.ActiveCornerRadius = 20;
            this.Button_Rent.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Rent.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Rent.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Rent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Rent.BackgroundImage")));
            this.Button_Rent.ButtonText = "Rent";
            this.Button_Rent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Rent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Rent.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Rent.IdleBorderThickness = 1;
            this.Button_Rent.IdleCornerRadius = 20;
            this.Button_Rent.IdleFillColor = System.Drawing.Color.White;
            this.Button_Rent.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Rent.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Rent.Location = new System.Drawing.Point(627, 559);
            this.Button_Rent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Rent.Name = "Button_Rent";
            this.Button_Rent.Size = new System.Drawing.Size(173, 52);
            this.Button_Rent.TabIndex = 48;
            this.Button_Rent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Rent.Click += new System.EventHandler(this.Button_Rent_Click);
            // 
            // Button_Buy
            // 
            this.Button_Buy.ActiveBorderThickness = 1;
            this.Button_Buy.ActiveCornerRadius = 20;
            this.Button_Buy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Buy.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Buy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Buy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Buy.BackgroundImage")));
            this.Button_Buy.ButtonText = "Buy";
            this.Button_Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Buy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Buy.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Buy.IdleBorderThickness = 1;
            this.Button_Buy.IdleCornerRadius = 20;
            this.Button_Buy.IdleFillColor = System.Drawing.Color.White;
            this.Button_Buy.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Buy.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Buy.Location = new System.Drawing.Point(837, 559);
            this.Button_Buy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Buy.Name = "Button_Buy";
            this.Button_Buy.Size = new System.Drawing.Size(173, 52);
            this.Button_Buy.TabIndex = 47;
            this.Button_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Buy.Click += new System.EventHandler(this.Button_Buy_Click);
            // 
            // pictureBox_Disc
            // 
            this.pictureBox_Disc.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.pictureBox_Disc.Location = new System.Drawing.Point(662, 56);
            this.pictureBox_Disc.Name = "pictureBox_Disc";
            this.pictureBox_Disc.Size = new System.Drawing.Size(325, 325);
            this.pictureBox_Disc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Disc.TabIndex = 44;
            this.pictureBox_Disc.TabStop = false;
            // 
            // TextBox_idVideo
            // 
            this.TextBox_idVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_idVideo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_idVideo.ForeColor = System.Drawing.Color.White;
            this.TextBox_idVideo.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_idVideo.HintText = "";
            this.TextBox_idVideo.isPassword = false;
            this.TextBox_idVideo.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_idVideo.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_idVideo.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_idVideo.LineThickness = 5;
            this.TextBox_idVideo.Location = new System.Drawing.Point(97, 545);
            this.TextBox_idVideo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_idVideo.Name = "TextBox_idVideo";
            this.TextBox_idVideo.Size = new System.Drawing.Size(308, 53);
            this.TextBox_idVideo.TabIndex = 49;
            this.TextBox_idVideo.Text = "Chikitori";
            this.TextBox_idVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_idVideo.Visible = false;
            // 
            // Video_Info_ReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.Button_Rent);
            this.Controls.Add(this.Button_Buy);
            this.Controls.Add(this.TextBox_VideoName);
            this.Controls.Add(this.pictureBox_Disc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video_Info_ReadOnly";
            this.Text = "Video_Info_ReadOnly";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Discription.ResumeLayout(false);
            this.Panel_Discription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_Actor;
        public System.Windows.Forms.Label Label_Director;
        public System.Windows.Forms.Label Label_Category;
        public System.Windows.Forms.Label Label_Price;
        public System.Windows.Forms.Label Label_Quantity;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TextBox_VideoName;
        public System.Windows.Forms.PictureBox pictureBox_Disc;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Buy;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Rent;
        private System.Windows.Forms.Panel Panel_Discription;
        public System.Windows.Forms.Label Label_ShowQuantity;
        public System.Windows.Forms.Label Label_ShowPrice;
        public System.Windows.Forms.Label Label_ShowActor;
        public System.Windows.Forms.Label Label_ShowDirector;
        public System.Windows.Forms.Label Label_ShowCategory;
        public System.Windows.Forms.Label Label_Discription;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_idVideo;
    }
}