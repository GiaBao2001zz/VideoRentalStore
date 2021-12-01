
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Label_NhapDia.Size = new System.Drawing.Size(272, 45);
            this.Label_NhapDia.TabIndex = 0;
            this.Label_NhapDia.Text = "Put disk into shell";
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
            this.TextBox_DiscID.Location = new System.Drawing.Point(76, 194);
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
            this.TextBox_Price.Location = new System.Drawing.Point(76, 264);
            this.TextBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(340, 44);
            this.TextBox_Price.TabIndex = 5;
            this.TextBox_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.TextBox_SL.Location = new System.Drawing.Point(76, 334);
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
            this.TextBox_ProviderID.HintText = "Provider ID";
            this.TextBox_ProviderID.isPassword = false;
            this.TextBox_ProviderID.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_ProviderID.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_ProviderID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_ProviderID.LineThickness = 3;
            this.TextBox_ProviderID.Location = new System.Drawing.Point(76, 404);
            this.TextBox_ProviderID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ProviderID.Name = "TextBox_ProviderID";
            this.TextBox_ProviderID.Size = new System.Drawing.Size(340, 44);
            this.TextBox_ProviderID.TabIndex = 7;
            this.TextBox_ProviderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_ORInputWithFile
            // 
            this.Label_ORInputWithFile.AutoSize = true;
            this.Label_ORInputWithFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label_ORInputWithFile.ForeColor = System.Drawing.Color.Blue;
            this.Label_ORInputWithFile.Location = new System.Drawing.Point(351, 52);
            this.Label_ORInputWithFile.Name = "Label_ORInputWithFile";
            this.Label_ORInputWithFile.Size = new System.Drawing.Size(195, 19);
            this.Label_ORInputWithFile.TabIndex = 8;
            this.Label_ORInputWithFile.Text = "Or import your goods with file";
            this.Label_ORInputWithFile.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Import";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(481, 334);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(214, 48);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Import";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.pictureBox1.Location = new System.Drawing.Point(526, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NhapDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 521);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Label_ORInputWithFile);
            this.Controls.Add(this.TextBox_ProviderID);
            this.Controls.Add(this.TextBox_SL);
            this.Controls.Add(this.TextBox_Price);
            this.Controls.Add(this.TextBox_DiscID);
            this.Controls.Add(this.TextBox_TenDia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_NhapDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NhapDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl_NhapDia;
        private Bunifu.Framework.UI.BunifuElipse Elipse_NhapDia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_NhapDia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DiscID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_TenDia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_ProviderID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_SL;
        private System.Windows.Forms.Label Label_ORInputWithFile;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}