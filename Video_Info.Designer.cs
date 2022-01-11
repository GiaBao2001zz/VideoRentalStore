
namespace VideoRentalStore
{
    partial class Video_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Info));
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.TextBox_VideoName = new System.Windows.Forms.TextBox();
            this.pictureBox_Disc = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Quantity = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Textbox_VideoQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_VideoPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_VideoCategory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Category = new System.Windows.Forms.Label();
            this.Label_Director = new System.Windows.Forms.Label();
            this.Label_Actor = new System.Windows.Forms.Label();
            this.TextBox_VideoActors = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Provider = new System.Windows.Forms.Label();
            this.TextBox_VideoProvider = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_VideoDirector = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Description.Location = new System.Drawing.Point(514, 417);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(401, 196);
            this.TextBox_Description.TabIndex = 26;
            this.TextBox_Description.Text = resources.GetString("TextBox_Description.Text");
            this.TextBox_Description.TextChanged += new System.EventHandler(this.TextBox_Description_TextChanged);
            // 
            // TextBox_VideoName
            // 
            this.TextBox_VideoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBox_VideoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_VideoName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoName.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoName.Location = new System.Drawing.Point(560, 336);
            this.TextBox_VideoName.Multiline = true;
            this.TextBox_VideoName.Name = "TextBox_VideoName";
            this.TextBox_VideoName.ReadOnly = true;
            this.TextBox_VideoName.Size = new System.Drawing.Size(326, 75);
            this.TextBox_VideoName.TabIndex = 27;
            this.TextBox_VideoName.Text = "The Promised Neverland";
            // 
            // pictureBox_Disc
            // 
            this.pictureBox_Disc.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.pictureBox_Disc.Location = new System.Drawing.Point(514, 19);
            this.pictureBox_Disc.Name = "pictureBox_Disc";
            this.pictureBox_Disc.Size = new System.Drawing.Size(401, 283);
            this.pictureBox_Disc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Disc.TabIndex = 25;
            this.pictureBox_Disc.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Quantity);
            this.panel1.Controls.Add(this.Label_Price);
            this.panel1.Controls.Add(this.Textbox_VideoQuantity);
            this.panel1.Controls.Add(this.TextBox_VideoPrice);
            this.panel1.Controls.Add(this.TextBox_VideoCategory);
            this.panel1.Controls.Add(this.Label_Category);
            this.panel1.Controls.Add(this.Label_Director);
            this.panel1.Controls.Add(this.Label_Actor);
            this.panel1.Controls.Add(this.TextBox_VideoActors);
            this.panel1.Controls.Add(this.Label_Provider);
            this.panel1.Controls.Add(this.TextBox_VideoProvider);
            this.panel1.Controls.Add(this.TextBox_VideoDirector);
            this.panel1.Location = new System.Drawing.Point(31, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 748);
            this.panel1.TabIndex = 36;
            // 
            // Label_Quantity
            // 
            this.Label_Quantity.AutoSize = true;
            this.Label_Quantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Quantity.ForeColor = System.Drawing.Color.White;
            this.Label_Quantity.Location = new System.Drawing.Point(58, 151);
            this.Label_Quantity.Name = "Label_Quantity";
            this.Label_Quantity.Size = new System.Drawing.Size(112, 32);
            this.Label_Quantity.TabIndex = 40;
            this.Label_Quantity.Text = "In stocks:";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.White;
            this.Label_Price.Location = new System.Drawing.Point(58, 32);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(149, 32);
            this.Label_Price.TabIndex = 39;
            this.Label_Price.Text = "Price  (VNĐ):";
            // 
            // Textbox_VideoQuantity
            // 
            this.Textbox_VideoQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_VideoQuantity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_VideoQuantity.ForeColor = System.Drawing.Color.White;
            this.Textbox_VideoQuantity.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_VideoQuantity.HintText = "";
            this.Textbox_VideoQuantity.isPassword = false;
            this.Textbox_VideoQuantity.LineFocusedColor = System.Drawing.Color.Green;
            this.Textbox_VideoQuantity.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_VideoQuantity.LineMouseHoverColor = System.Drawing.Color.Green;
            this.Textbox_VideoQuantity.LineThickness = 5;
            this.Textbox_VideoQuantity.Location = new System.Drawing.Point(64, 190);
            this.Textbox_VideoQuantity.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Textbox_VideoQuantity.Name = "Textbox_VideoQuantity";
            this.Textbox_VideoQuantity.Size = new System.Drawing.Size(308, 53);
            this.Textbox_VideoQuantity.TabIndex = 38;
            this.Textbox_VideoQuantity.Text = "12";
            this.Textbox_VideoQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_VideoPrice
            // 
            this.TextBox_VideoPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoPrice.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoPrice.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoPrice.HintText = "";
            this.TextBox_VideoPrice.isPassword = false;
            this.TextBox_VideoPrice.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoPrice.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoPrice.LineThickness = 5;
            this.TextBox_VideoPrice.Location = new System.Drawing.Point(64, 71);
            this.TextBox_VideoPrice.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoPrice.Name = "TextBox_VideoPrice";
            this.TextBox_VideoPrice.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoPrice.TabIndex = 37;
            this.TextBox_VideoPrice.Text = "50000";
            this.TextBox_VideoPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_VideoCategory
            // 
            this.TextBox_VideoCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoCategory.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoCategory.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoCategory.HintText = "";
            this.TextBox_VideoCategory.isPassword = false;
            this.TextBox_VideoCategory.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoCategory.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoCategory.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoCategory.LineThickness = 5;
            this.TextBox_VideoCategory.Location = new System.Drawing.Point(64, 304);
            this.TextBox_VideoCategory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoCategory.Name = "TextBox_VideoCategory";
            this.TextBox_VideoCategory.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoCategory.TabIndex = 36;
            this.TextBox_VideoCategory.Text = "Chikitori";
            this.TextBox_VideoCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_Category
            // 
            this.Label_Category.AutoSize = true;
            this.Label_Category.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Category.ForeColor = System.Drawing.Color.White;
            this.Label_Category.Location = new System.Drawing.Point(58, 256);
            this.Label_Category.Name = "Label_Category";
            this.Label_Category.Size = new System.Drawing.Size(116, 32);
            this.Label_Category.TabIndex = 35;
            this.Label_Category.Text = "Category:";
            // 
            // Label_Director
            // 
            this.Label_Director.AutoSize = true;
            this.Label_Director.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Director.ForeColor = System.Drawing.Color.White;
            this.Label_Director.Location = new System.Drawing.Point(58, 384);
            this.Label_Director.Name = "Label_Director";
            this.Label_Director.Size = new System.Drawing.Size(105, 32);
            this.Label_Director.TabIndex = 30;
            this.Label_Director.Text = "Director:";
            // 
            // Label_Actor
            // 
            this.Label_Actor.AutoSize = true;
            this.Label_Actor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Actor.ForeColor = System.Drawing.Color.White;
            this.Label_Actor.Location = new System.Drawing.Point(58, 498);
            this.Label_Actor.Name = "Label_Actor";
            this.Label_Actor.Size = new System.Drawing.Size(86, 32);
            this.Label_Actor.TabIndex = 31;
            this.Label_Actor.Text = "Actors:";
            // 
            // TextBox_VideoActors
            // 
            this.TextBox_VideoActors.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoActors.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoActors.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoActors.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoActors.HintText = "";
            this.TextBox_VideoActors.isPassword = false;
            this.TextBox_VideoActors.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoActors.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoActors.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoActors.LineThickness = 5;
            this.TextBox_VideoActors.Location = new System.Drawing.Point(64, 537);
            this.TextBox_VideoActors.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoActors.Name = "TextBox_VideoActors";
            this.TextBox_VideoActors.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoActors.TabIndex = 32;
            this.TextBox_VideoActors.Text = "Chikitori";
            this.TextBox_VideoActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_Provider
            // 
            this.Label_Provider.AutoSize = true;
            this.Label_Provider.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Provider.ForeColor = System.Drawing.Color.White;
            this.Label_Provider.Location = new System.Drawing.Point(58, 617);
            this.Label_Provider.Name = "Label_Provider";
            this.Label_Provider.Size = new System.Drawing.Size(108, 32);
            this.Label_Provider.TabIndex = 33;
            this.Label_Provider.Text = "Provider:";
            // 
            // TextBox_VideoProvider
            // 
            this.TextBox_VideoProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoProvider.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoProvider.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoProvider.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoProvider.HintText = "";
            this.TextBox_VideoProvider.isPassword = false;
            this.TextBox_VideoProvider.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoProvider.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoProvider.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoProvider.LineThickness = 5;
            this.TextBox_VideoProvider.Location = new System.Drawing.Point(64, 658);
            this.TextBox_VideoProvider.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoProvider.Name = "TextBox_VideoProvider";
            this.TextBox_VideoProvider.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoProvider.TabIndex = 34;
            this.TextBox_VideoProvider.Text = "Chikitori";
            this.TextBox_VideoProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_VideoDirector
            // 
            this.TextBox_VideoDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoDirector.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoDirector.ForeColor = System.Drawing.Color.White;
            this.TextBox_VideoDirector.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoDirector.HintText = "";
            this.TextBox_VideoDirector.isPassword = false;
            this.TextBox_VideoDirector.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoDirector.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoDirector.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoDirector.LineThickness = 5;
            this.TextBox_VideoDirector.Location = new System.Drawing.Point(64, 423);
            this.TextBox_VideoDirector.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoDirector.Name = "TextBox_VideoDirector";
            this.TextBox_VideoDirector.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoDirector.TabIndex = 24;
            this.TextBox_VideoDirector.Text = "Chikitori";
            this.TextBox_VideoDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.ActiveBorderThickness = 1;
            this.Button_Cancel.ActiveCornerRadius = 20;
            this.Button_Cancel.ActiveFillColor = System.Drawing.Color.Red;
            this.Button_Cancel.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Cancel.BackgroundImage")));
            this.Button_Cancel.ButtonText = "Cancel";
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.Color.Red;
            this.Button_Cancel.IdleBorderThickness = 1;
            this.Button_Cancel.IdleCornerRadius = 20;
            this.Button_Cancel.IdleFillColor = System.Drawing.Color.White;
            this.Button_Cancel.IdleForecolor = System.Drawing.Color.Red;
            this.Button_Cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Cancel.Location = new System.Drawing.Point(540, 650);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(153, 41);
            this.Button_Cancel.TabIndex = 37;
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Update";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(734, 650);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(152, 41);
            this.bunifuThinButton22.TabIndex = 38;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Video_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(961, 583);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.TextBox_VideoName);
            this.Controls.Add(this.pictureBox_Disc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video_Info";
            this.Text = "Video_Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox_Disc;
        public System.Windows.Forms.TextBox TextBox_Description;
        public System.Windows.Forms.TextBox TextBox_VideoName;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Label_Quantity;
        public System.Windows.Forms.Label Label_Price;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_VideoQuantity;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoPrice;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoCategory;
        public System.Windows.Forms.Label Label_Category;
        public System.Windows.Forms.Label Label_Director;
        public System.Windows.Forms.Label Label_Actor;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoActors;
        public System.Windows.Forms.Label Label_Provider;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoProvider;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoDirector;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}