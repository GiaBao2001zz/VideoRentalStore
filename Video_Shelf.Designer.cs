
namespace VideoRentalStore
{
    partial class Video_Shelf
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
            this.Panel_ControlButton = new System.Windows.Forms.Panel();
            this.Panel_ShowVideo = new System.Windows.Forms.Panel();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.ComboBox_Category = new System.Windows.Forms.ComboBox();
            this.Button_Search = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextBox_Search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Elipse_SearchBar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_ComboBox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_ShowVideo.SuspendLayout();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ControlButton
            // 
            this.Panel_ControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Panel_ControlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_ControlButton.Location = new System.Drawing.Point(0, 608);
            this.Panel_ControlButton.Name = "Panel_ControlButton";
            this.Panel_ControlButton.Size = new System.Drawing.Size(1028, 14);
            this.Panel_ControlButton.TabIndex = 0;
            // 
            // Panel_ShowVideo
            // 
            this.Panel_ShowVideo.AutoScroll = true;
            this.Panel_ShowVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Panel_ShowVideo.Controls.Add(this.Panel_Search);
            this.Panel_ShowVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ShowVideo.Location = new System.Drawing.Point(0, 0);
            this.Panel_ShowVideo.Name = "Panel_ShowVideo";
            this.Panel_ShowVideo.Size = new System.Drawing.Size(1028, 608);
            this.Panel_ShowVideo.TabIndex = 1;
            this.Panel_ShowVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_ShowVideo_Paint);
            // 
            // Panel_Search
            // 
            this.Panel_Search.AutoScroll = true;
            this.Panel_Search.Controls.Add(this.ComboBox_Category);
            this.Panel_Search.Controls.Add(this.Button_Search);
            this.Panel_Search.Controls.Add(this.TextBox_Search);
            this.Panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Search.Location = new System.Drawing.Point(0, 0);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(1028, 100);
            this.Panel_Search.TabIndex = 1;
            // 
            // ComboBox_Category
            // 
            this.ComboBox_Category.BackColor = System.Drawing.Color.White;
            this.ComboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Category.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Category.ForeColor = System.Drawing.Color.Black;
            this.ComboBox_Category.FormattingEnabled = true;
            this.ComboBox_Category.Items.AddRange(new object[] {
            "All",
            "Action",
            "Comedy",
            "Drama",
            "Fantasy",
            "Historical",
            "Horror",
            "Musicals",
            "Romance",
            "Sci-Fi",
            "Sports",
            "Thriller",
            "Western",
            ""});
            this.ComboBox_Category.Location = new System.Drawing.Point(423, 13);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.Size = new System.Drawing.Size(128, 40);
            this.ComboBox_Category.TabIndex = 2;
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.Transparent;
            this.Button_Search.Image = global::VideoRentalStore.Properties.Resources.search;
            this.Button_Search.ImageActive = null;
            this.Button_Search.Location = new System.Drawing.Point(945, 12);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(50, 45);
            this.Button_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Search.TabIndex = 1;
            this.Button_Search.TabStop = false;
            this.Button_Search.Zoom = 10;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click_1);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.BackColor = System.Drawing.Color.White;
            this.TextBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Search.ForeColor = System.Drawing.Color.White;
            this.TextBox_Search.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Search.HintText = "Search";
            this.TextBox_Search.isPassword = false;
            this.TextBox_Search.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Search.LineIdleColor = System.Drawing.Color.Green;
            this.TextBox_Search.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Search.LineThickness = 4;
            this.TextBox_Search.Location = new System.Drawing.Point(558, 13);
            this.TextBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(370, 44);
            this.TextBox_Search.TabIndex = 0;
            this.TextBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Search_KeyDown);
            // 
            // Elipse_SearchBar
            // 
            this.Elipse_SearchBar.ElipseRadius = 10;
            this.Elipse_SearchBar.TargetControl = this.TextBox_Search;
            // 
            // Elipse_ComboBox
            // 
            this.Elipse_ComboBox.ElipseRadius = 15;
            this.Elipse_ComboBox.TargetControl = this.ComboBox_Category;
            // 
            // Video_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.Panel_ShowVideo);
            this.Controls.Add(this.Panel_ControlButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video_Shelf";
            this.Text = "Video_Shelf";
            this.Load += new System.EventHandler(this.Video_Shelf_Load);
            this.Panel_ShowVideo.ResumeLayout(false);
            this.Panel_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_ControlButton;
        private System.Windows.Forms.Panel Panel_ShowVideo;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.ComboBox ComboBox_Category;
        private Bunifu.Framework.UI.BunifuImageButton Button_Search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Search;
        private Bunifu.Framework.UI.BunifuElipse Elipse_SearchBar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_ComboBox;
    }
}