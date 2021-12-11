
namespace VideoRentalStore
{
    partial class NhapDia2
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
            this.Button_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Import = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox_Disc = new System.Windows.Forms.PictureBox();
            this.Label_TenDia = new System.Windows.Forms.Label();
            this.Label_Actor = new System.Windows.Forms.Label();
            this.Label_Director = new System.Windows.Forms.Label();
            this.TextBox_VideoDirector = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Actor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Description = new System.Windows.Forms.Label();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Cancel.BorderRadius = 0;
            this.Button_Cancel.ButtonText = "Cancel";
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Cancel.Iconimage = null;
            this.Button_Cancel.Iconimage_right = null;
            this.Button_Cancel.Iconimage_right_Selected = null;
            this.Button_Cancel.Iconimage_Selected = null;
            this.Button_Cancel.IconMarginLeft = 0;
            this.Button_Cancel.IconMarginRight = 0;
            this.Button_Cancel.IconRightVisible = true;
            this.Button_Cancel.IconRightZoom = 0D;
            this.Button_Cancel.IconVisible = true;
            this.Button_Cancel.IconZoom = 90D;
            this.Button_Cancel.IsTab = false;
            this.Button_Cancel.Location = new System.Drawing.Point(481, 400);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Cancel.OnHovercolor = System.Drawing.Color.Red;
            this.Button_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Cancel.selected = false;
            this.Button_Cancel.Size = new System.Drawing.Size(214, 48);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Cancel.Textcolor = System.Drawing.Color.White;
            this.Button_Cancel.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Import
            // 
            this.Button_Import.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Import.BorderRadius = 0;
            this.Button_Import.ButtonText = "Import";
            this.Button_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Import.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Import.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Import.Iconimage = null;
            this.Button_Import.Iconimage_right = null;
            this.Button_Import.Iconimage_right_Selected = null;
            this.Button_Import.Iconimage_Selected = null;
            this.Button_Import.IconMarginLeft = 0;
            this.Button_Import.IconMarginRight = 0;
            this.Button_Import.IconRightVisible = true;
            this.Button_Import.IconRightZoom = 0D;
            this.Button_Import.IconVisible = true;
            this.Button_Import.IconZoom = 90D;
            this.Button_Import.IsTab = false;
            this.Button_Import.Location = new System.Drawing.Point(481, 334);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Import.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Import.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Import.selected = false;
            this.Button_Import.Size = new System.Drawing.Size(214, 48);
            this.Button_Import.TabIndex = 12;
            this.Button_Import.Text = "Import";
            this.Button_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Import.Textcolor = System.Drawing.Color.White;
            this.Button_Import.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // pictureBox_Disc
            // 
            this.pictureBox_Disc.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.pictureBox_Disc.Location = new System.Drawing.Point(481, 98);
            this.pictureBox_Disc.Name = "pictureBox_Disc";
            this.pictureBox_Disc.Size = new System.Drawing.Size(214, 210);
            this.pictureBox_Disc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Disc.TabIndex = 11;
            this.pictureBox_Disc.TabStop = false;
            // 
            // Label_TenDia
            // 
            this.Label_TenDia.AutoSize = true;
            this.Label_TenDia.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label_TenDia.Location = new System.Drawing.Point(73, 31);
            this.Label_TenDia.Name = "Label_TenDia";
            this.Label_TenDia.Size = new System.Drawing.Size(105, 45);
            this.Label_TenDia.TabIndex = 14;
            this.Label_TenDia.Text = "Name";
            // 
            // Label_Actor
            // 
            this.Label_Actor.AutoSize = true;
            this.Label_Actor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Actor.ForeColor = System.Drawing.Color.Black;
            this.Label_Actor.Location = new System.Drawing.Point(64, 209);
            this.Label_Actor.Name = "Label_Actor";
            this.Label_Actor.Size = new System.Drawing.Size(93, 32);
            this.Label_Actor.TabIndex = 36;
            this.Label_Actor.Text = "Actors :";
            // 
            // Label_Director
            // 
            this.Label_Director.AutoSize = true;
            this.Label_Director.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Director.ForeColor = System.Drawing.Color.Black;
            this.Label_Director.Location = new System.Drawing.Point(64, 100);
            this.Label_Director.Name = "Label_Director";
            this.Label_Director.Size = new System.Drawing.Size(112, 32);
            this.Label_Director.TabIndex = 35;
            this.Label_Director.Text = "Director :";
            // 
            // TextBox_VideoDirector
            // 
            this.TextBox_VideoDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_VideoDirector.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_VideoDirector.ForeColor = System.Drawing.Color.Black;
            this.TextBox_VideoDirector.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_VideoDirector.HintText = "";
            this.TextBox_VideoDirector.isPassword = false;
            this.TextBox_VideoDirector.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_VideoDirector.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_VideoDirector.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_VideoDirector.LineThickness = 5;
            this.TextBox_VideoDirector.Location = new System.Drawing.Point(70, 139);
            this.TextBox_VideoDirector.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_VideoDirector.Name = "TextBox_VideoDirector";
            this.TextBox_VideoDirector.Size = new System.Drawing.Size(308, 53);
            this.TextBox_VideoDirector.TabIndex = 34;
            this.TextBox_VideoDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Actor
            // 
            this.TextBox_Actor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Actor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Actor.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Actor.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Actor.HintText = "";
            this.TextBox_Actor.isPassword = false;
            this.TextBox_Actor.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Actor.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Actor.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Actor.LineThickness = 5;
            this.TextBox_Actor.Location = new System.Drawing.Point(70, 248);
            this.TextBox_Actor.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_Actor.Name = "TextBox_Actor";
            this.TextBox_Actor.Size = new System.Drawing.Size(308, 53);
            this.TextBox_Actor.TabIndex = 37;
            this.TextBox_Actor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.ForeColor = System.Drawing.Color.Black;
            this.Label_Description.Location = new System.Drawing.Point(64, 320);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(141, 32);
            this.Label_Description.TabIndex = 38;
            this.Label_Description.Text = "Description:";
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Description.Location = new System.Drawing.Point(70, 364);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(356, 123);
            this.TextBox_Description.TabIndex = 39;
            // 
            // NhapDia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 521);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.TextBox_Actor);
            this.Controls.Add(this.Label_Actor);
            this.Controls.Add(this.Label_Director);
            this.Controls.Add(this.TextBox_VideoDirector);
            this.Controls.Add(this.Label_TenDia);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Import);
            this.Controls.Add(this.pictureBox_Disc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapDia2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapDia2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Button_Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Import;
        private System.Windows.Forms.PictureBox pictureBox_Disc;
        private System.Windows.Forms.Label Label_TenDia;
        private System.Windows.Forms.Label Label_Actor;
        private System.Windows.Forms.Label Label_Director;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_VideoDirector;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Actor;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.TextBox TextBox_Description;
    }
}