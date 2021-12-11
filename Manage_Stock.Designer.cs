
namespace VideoRentalStore
{
    partial class Manage_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_ThumbNail = new System.Windows.Forms.Panel();
            this.Panel_Buttons = new System.Windows.Forms.Panel();
            this.Button_Import = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_ShowInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGrid_ManageStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.PictureBox_Thumbnail = new System.Windows.Forms.PictureBox();
            this.Panel_ThumbNail.SuspendLayout();
            this.Panel_Buttons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ManageStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ThumbNail
            // 
            this.Panel_ThumbNail.Controls.Add(this.Panel_Buttons);
            this.Panel_ThumbNail.Controls.Add(this.panel1);
            this.Panel_ThumbNail.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_ThumbNail.Location = new System.Drawing.Point(690, 0);
            this.Panel_ThumbNail.Name = "Panel_ThumbNail";
            this.Panel_ThumbNail.Size = new System.Drawing.Size(354, 661);
            this.Panel_ThumbNail.TabIndex = 1;
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.Controls.Add(this.Button_Import);
            this.Panel_Buttons.Controls.Add(this.Button_Delete);
            this.Panel_Buttons.Controls.Add(this.Button_ShowInfo);
            this.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Buttons.Location = new System.Drawing.Point(0, 243);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(354, 236);
            this.Panel_Buttons.TabIndex = 4;
            // 
            // Button_Import
            // 
            this.Button_Import.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Import.BorderRadius = 0;
            this.Button_Import.ButtonText = "Import New Disk";
            this.Button_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Import.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Import.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.Button_Import.Location = new System.Drawing.Point(0, 128);
            this.Button_Import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Import.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Button_Import.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Import.selected = false;
            this.Button_Import.Size = new System.Drawing.Size(354, 64);
            this.Button_Import.TabIndex = 5;
            this.Button_Import.Text = "Import New Disk";
            this.Button_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Import.Textcolor = System.Drawing.Color.White;
            this.Button_Import.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click_1);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Delete.BorderRadius = 0;
            this.Button_Delete.ButtonText = "Delete Disk";
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Delete.Iconimage = null;
            this.Button_Delete.Iconimage_right = null;
            this.Button_Delete.Iconimage_right_Selected = null;
            this.Button_Delete.Iconimage_Selected = null;
            this.Button_Delete.IconMarginLeft = 0;
            this.Button_Delete.IconMarginRight = 0;
            this.Button_Delete.IconRightVisible = true;
            this.Button_Delete.IconRightZoom = 0D;
            this.Button_Delete.IconVisible = true;
            this.Button_Delete.IconZoom = 90D;
            this.Button_Delete.IsTab = false;
            this.Button_Delete.Location = new System.Drawing.Point(0, 64);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Button_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Delete.selected = false;
            this.Button_Delete.Size = new System.Drawing.Size(354, 64);
            this.Button_Delete.TabIndex = 4;
            this.Button_Delete.Text = "Delete Disk";
            this.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Delete.Textcolor = System.Drawing.Color.White;
            this.Button_Delete.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Button_ShowInfo
            // 
            this.Button_ShowInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_ShowInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ShowInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_ShowInfo.BorderRadius = 0;
            this.Button_ShowInfo.ButtonText = "Show Infomation";
            this.Button_ShowInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ShowInfo.DisabledColor = System.Drawing.Color.Gray;
            this.Button_ShowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ShowInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_ShowInfo.Iconimage = null;
            this.Button_ShowInfo.Iconimage_right = null;
            this.Button_ShowInfo.Iconimage_right_Selected = null;
            this.Button_ShowInfo.Iconimage_Selected = null;
            this.Button_ShowInfo.IconMarginLeft = 0;
            this.Button_ShowInfo.IconMarginRight = 0;
            this.Button_ShowInfo.IconRightVisible = true;
            this.Button_ShowInfo.IconRightZoom = 0D;
            this.Button_ShowInfo.IconVisible = true;
            this.Button_ShowInfo.IconZoom = 90D;
            this.Button_ShowInfo.IsTab = false;
            this.Button_ShowInfo.Location = new System.Drawing.Point(0, 0);
            this.Button_ShowInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_ShowInfo.Name = "Button_ShowInfo";
            this.Button_ShowInfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ShowInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Button_ShowInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_ShowInfo.selected = false;
            this.Button_ShowInfo.Size = new System.Drawing.Size(354, 64);
            this.Button_ShowInfo.TabIndex = 3;
            this.Button_ShowInfo.Text = "Show Infomation";
            this.Button_ShowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_ShowInfo.Textcolor = System.Drawing.Color.White;
            this.Button_ShowInfo.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PictureBox_Thumbnail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 243);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGrid_ManageStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 661);
            this.panel2.TabIndex = 2;
            // 
            // DataGrid_ManageStock
            // 
            this.DataGrid_ManageStock.AllowUserToAddRows = false;
            this.DataGrid_ManageStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DataGrid_ManageStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_ManageStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_ManageStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_ManageStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_ManageStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_ManageStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_ManageStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_ManageStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_ManageStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_ManageStock.DoubleBuffered = true;
            this.DataGrid_ManageStock.EnableHeadersVisualStyles = false;
            this.DataGrid_ManageStock.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGrid_ManageStock.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_ManageStock.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_ManageStock.MultiSelect = false;
            this.DataGrid_ManageStock.Name = "DataGrid_ManageStock";
            this.DataGrid_ManageStock.ReadOnly = true;
            this.DataGrid_ManageStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_ManageStock.RowHeadersVisible = false;
            this.DataGrid_ManageStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_ManageStock.ShowCellErrors = false;
            this.DataGrid_ManageStock.ShowCellToolTips = false;
            this.DataGrid_ManageStock.ShowEditingIcon = false;
            this.DataGrid_ManageStock.ShowRowErrors = false;
            this.DataGrid_ManageStock.Size = new System.Drawing.Size(690, 661);
            this.DataGrid_ManageStock.TabIndex = 1;
            this.DataGrid_ManageStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_ManageStock_CellClick);
            // 
            // PictureBox_Thumbnail
            // 
            this.PictureBox_Thumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Thumbnail.Image = global::VideoRentalStore.Properties.Resources.DiskThumbnail_PlaceHolder;
            this.PictureBox_Thumbnail.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Thumbnail.Name = "PictureBox_Thumbnail";
            this.PictureBox_Thumbnail.Size = new System.Drawing.Size(354, 243);
            this.PictureBox_Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Thumbnail.TabIndex = 30;
            this.PictureBox_Thumbnail.TabStop = false;
            // 
            // Manage_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_ThumbNail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Stock";
            this.Text = "Manage_Stock";
            this.Panel_ThumbNail.ResumeLayout(false);
            this.Panel_Buttons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_ManageStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_ThumbNail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_ManageStock;
        private System.Windows.Forms.Panel Panel_Buttons;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Import;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton Button_ShowInfo;
        private System.Windows.Forms.PictureBox PictureBox_Thumbnail;
    }
}