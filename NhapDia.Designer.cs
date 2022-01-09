
namespace VideoRentalStore
{
    partial class NhapDia
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
            this.DragControl_NhapDia = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Elipse_NhapDia = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label_NhapDia = new System.Windows.Forms.Label();
            this.TextBox_TenDia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_DiscID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_SL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_ProviderID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_ORInputWithFile = new System.Windows.Forms.Label();
            this.btn_ImportDisc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextBox_Category = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_ImagePath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox_Disc = new System.Windows.Forms.PictureBox();
            this.TextBox_Director = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.TextBox_Actor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl_NhapDia
            // 
            this.DragControl_NhapDia.Fixed = true;
            this.DragControl_NhapDia.Horizontal = true;
            this.DragControl_NhapDia.TargetControl = this;
            this.DragControl_NhapDia.Vertical = true;
            // 
            // Elipse_NhapDia
            // 
            this.Elipse_NhapDia.ElipseRadius = 10;
            this.Elipse_NhapDia.TargetControl = this;
            // 
            // Label_NhapDia
            // 
            this.Label_NhapDia.AutoSize = true;
            this.Label_NhapDia.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label_NhapDia.Location = new System.Drawing.Point(73, 31);
            this.Label_NhapDia.Name = "Label_NhapDia";
            this.Label_NhapDia.Size = new System.Drawing.Size(274, 45);
            this.Label_NhapDia.TabIndex = 0;
            this.Label_NhapDia.Text = "Put disk into shelf";
            this.Label_NhapDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_TenDia
            // 
            this.TextBox_TenDia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_TenDia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_TenDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_TenDia.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_TenDia.HintText = "Name of the disk";
            this.TextBox_TenDia.isPassword = false;
            this.TextBox_TenDia.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_TenDia.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_TenDia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_TenDia.LineThickness = 3;
            this.TextBox_TenDia.Location = new System.Drawing.Point(76, 124);
            this.TextBox_TenDia.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_TenDia.Name = "TextBox_TenDia";
            this.TextBox_TenDia.Size = new System.Drawing.Size(340, 44);
            this.TextBox_TenDia.TabIndex = 3;
            this.TextBox_TenDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_TenDia.OnValueChanged += new System.EventHandler(this.TextBox_TenDia_OnValueChanged);
            // 
            // TextBox_DiscID
            // 
            this.TextBox_DiscID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DiscID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_DiscID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_DiscID.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_DiscID.HintText = "ID";
            this.TextBox_DiscID.isPassword = false;
            this.TextBox_DiscID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_DiscID.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_DiscID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_DiscID.LineThickness = 3;
            this.TextBox_DiscID.Location = new System.Drawing.Point(19, 91);
            this.TextBox_DiscID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DiscID.Name = "TextBox_DiscID";
            this.TextBox_DiscID.Size = new System.Drawing.Size(340, 44);
            this.TextBox_DiscID.TabIndex = 4;
            this.TextBox_DiscID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Price.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Price.HintText = "Price (VND)";
            this.TextBox_Price.isPassword = false;
            this.TextBox_Price.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Price.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Price.LineThickness = 3;
            this.TextBox_Price.Location = new System.Drawing.Point(19, 143);
            this.TextBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(340, 44);
            this.TextBox_Price.TabIndex = 5;
            this.TextBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Price.OnValueChanged += new System.EventHandler(this.TextBox_Price_OnValueChanged);
            // 
            // TextBox_SL
            // 
            this.TextBox_SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_SL.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_SL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_SL.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_SL.HintText = "Quantity";
            this.TextBox_SL.isPassword = false;
            this.TextBox_SL.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_SL.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_SL.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_SL.LineThickness = 3;
            this.TextBox_SL.Location = new System.Drawing.Point(19, 195);
            this.TextBox_SL.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_SL.Name = "TextBox_SL";
            this.TextBox_SL.Size = new System.Drawing.Size(340, 44);
            this.TextBox_SL.TabIndex = 6;
            this.TextBox_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_ProviderID
            // 
            this.TextBox_ProviderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ProviderID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_ProviderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_ProviderID.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_ProviderID.HintText = "Provider";
            this.TextBox_ProviderID.isPassword = false;
            this.TextBox_ProviderID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_ProviderID.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_ProviderID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_ProviderID.LineThickness = 3;
            this.TextBox_ProviderID.Location = new System.Drawing.Point(19, 247);
            this.TextBox_ProviderID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ProviderID.Name = "TextBox_ProviderID";
            this.TextBox_ProviderID.Size = new System.Drawing.Size(340, 44);
            this.TextBox_ProviderID.TabIndex = 7;
            this.TextBox_ProviderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_ORInputWithFile
            // 
            this.Label_ORInputWithFile.AutoSize = true;
            this.Label_ORInputWithFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ORInputWithFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ORInputWithFile.ForeColor = System.Drawing.Color.Blue;
            this.Label_ORInputWithFile.Location = new System.Drawing.Point(353, 47);
            this.Label_ORInputWithFile.Name = "Label_ORInputWithFile";
            this.Label_ORInputWithFile.Size = new System.Drawing.Size(221, 21);
            this.Label_ORInputWithFile.TabIndex = 8;
            this.Label_ORInputWithFile.Text = "Or import your goods with file";
            this.Label_ORInputWithFile.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_ImportDisc
            // 
            this.btn_ImportDisc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ImportDisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ImportDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ImportDisc.BorderRadius = 0;
            this.btn_ImportDisc.ButtonText = "Import";
            this.btn_ImportDisc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImportDisc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ImportDisc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ImportDisc.Iconimage = null;
            this.btn_ImportDisc.Iconimage_right = null;
            this.btn_ImportDisc.Iconimage_right_Selected = null;
            this.btn_ImportDisc.Iconimage_Selected = null;
            this.btn_ImportDisc.IconMarginLeft = 0;
            this.btn_ImportDisc.IconMarginRight = 0;
            this.btn_ImportDisc.IconRightVisible = true;
            this.btn_ImportDisc.IconRightZoom = 0D;
            this.btn_ImportDisc.IconVisible = true;
            this.btn_ImportDisc.IconZoom = 90D;
            this.btn_ImportDisc.IsTab = false;
            this.btn_ImportDisc.Location = new System.Drawing.Point(481, 334);
            this.btn_ImportDisc.Name = "btn_ImportDisc";
            this.btn_ImportDisc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ImportDisc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_ImportDisc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ImportDisc.selected = false;
            this.btn_ImportDisc.Size = new System.Drawing.Size(214, 48);
            this.btn_ImportDisc.TabIndex = 9;
            this.btn_ImportDisc.Text = "Import";
            this.btn_ImportDisc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImportDisc.Textcolor = System.Drawing.Color.White;
            this.btn_ImportDisc.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_ImportDisc.Click += new System.EventHandler(this.btnImportDisc_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cancel";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(481, 400);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(214, 48);
            this.bunifuFlatButton2.TabIndex = 10;
            this.bunifuFlatButton2.Text = "Cancel";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // TextBox_Category
            // 
            this.TextBox_Category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Category.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Category.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Category.HintText = "Category";
            this.TextBox_Category.isPassword = false;
            this.TextBox_Category.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Category.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Category.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Category.LineThickness = 3;
            this.TextBox_Category.Location = new System.Drawing.Point(19, 299);
            this.TextBox_Category.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Category.Name = "TextBox_Category";
            this.TextBox_Category.Size = new System.Drawing.Size(340, 44);
            this.TextBox_Category.TabIndex = 11;
            this.TextBox_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Category.OnValueChanged += new System.EventHandler(this.TextBox_Category_OnValueChanged);
            // 
            // TextBox_ImagePath
            // 
            this.TextBox_ImagePath.Location = new System.Drawing.Point(541, 476);
            this.TextBox_ImagePath.Name = "TextBox_ImagePath";
            this.TextBox_ImagePath.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ImagePath.TabIndex = 12;
            this.TextBox_ImagePath.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox_Disc
            // 
            this.pictureBox_Disc.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.pictureBox_Disc.Location = new System.Drawing.Point(481, 98);
            this.pictureBox_Disc.Name = "pictureBox_Disc";
            this.pictureBox_Disc.Size = new System.Drawing.Size(214, 210);
            this.pictureBox_Disc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Disc.TabIndex = 1;
            this.pictureBox_Disc.TabStop = false;
            this.pictureBox_Disc.Click += new System.EventHandler(this.pictureBoxDisc_Click);
            // 
            // TextBox_Director
            // 
            this.TextBox_Director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Director.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Director.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Director.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Director.HintText = "Director";
            this.TextBox_Director.isPassword = false;
            this.TextBox_Director.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Director.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Director.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Director.LineThickness = 3;
            this.TextBox_Director.Location = new System.Drawing.Point(19, 351);
            this.TextBox_Director.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Director.Name = "TextBox_Director";
            this.TextBox_Director.Size = new System.Drawing.Size(340, 44);
            this.TextBox_Director.TabIndex = 14;
            this.TextBox_Director.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Director.OnValueChanged += new System.EventHandler(this.TextBoxDirector_OnValueChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_Description);
            this.panel1.Controls.Add(this.Label_Description);
            this.panel1.Controls.Add(this.TextBox_Actor);
            this.panel1.Controls.Add(this.TextBox_Director);
            this.panel1.Controls.Add(this.TextBox_Category);
            this.panel1.Controls.Add(this.TextBox_Price);
            this.panel1.Controls.Add(this.TextBox_DiscID);
            this.panel1.Controls.Add(this.TextBox_SL);
            this.panel1.Controls.Add(this.TextBox_ProviderID);
            this.panel1.Location = new System.Drawing.Point(57, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 683);
            this.panel1.TabIndex = 13;
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Description.Location = new System.Drawing.Point(19, 483);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(340, 163);
            this.TextBox_Description.TabIndex = 40;
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Label_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Description.Location = new System.Drawing.Point(21, 463);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(80, 17);
            this.Label_Description.TabIndex = 39;
            this.Label_Description.Text = "Description";
            // 
            // TextBox_Actor
            // 
            this.TextBox_Actor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Actor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBox_Actor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Actor.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Actor.HintText = "Actor";
            this.TextBox_Actor.isPassword = false;
            this.TextBox_Actor.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Actor.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Actor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Actor.LineThickness = 3;
            this.TextBox_Actor.Location = new System.Drawing.Point(19, 403);
            this.TextBox_Actor.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Actor.Name = "TextBox_Actor";
            this.TextBox_Actor.Size = new System.Drawing.Size(340, 44);
            this.TextBox_Actor.TabIndex = 15;
            this.TextBox_Actor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Actor.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged_1);
            // 
            // NhapDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(752, 521);
            this.Controls.Add(this.TextBox_ImagePath);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btn_ImportDisc);
            this.Controls.Add(this.Label_ORInputWithFile);
            this.Controls.Add(this.TextBox_TenDia);
            this.Controls.Add(this.pictureBox_Disc);
            this.Controls.Add(this.Label_NhapDia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NhapDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl_NhapDia;
        private Bunifu.Framework.UI.BunifuElipse Elipse_NhapDia;
        private System.Windows.Forms.PictureBox pictureBox_Disc;
        private System.Windows.Forms.Label Label_NhapDia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DiscID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_TenDia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_ProviderID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_SL;
        private System.Windows.Forms.Label Label_ORInputWithFile;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ImportDisc;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Category;
        private System.Windows.Forms.TextBox TextBox_ImagePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Director;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Actor;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.TextBox TextBox_Description;
    }
}