
namespace VideoRentalStore
{
    partial class Grid_YeuCauThueMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid_YeuCauThueMua));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Label_RequestCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Button_History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_ActiveRequest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_ButtonContainer = new System.Windows.Forms.Panel();
            this.Button_ViewInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_ChuyenHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panel_GridContainer = new System.Windows.Forms.Panel();
            this.DataGrid_YCThueMua = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Panel_Title.SuspendLayout();
            this.Panel_ButtonContainer.SuspendLayout();
            this.Panel_GridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_YCThueMua)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Panel_Title.Controls.Add(this.Label_RequestCount);
            this.Panel_Title.Controls.Add(this.Button_History);
            this.Panel_Title.Controls.Add(this.Button_ActiveRequest);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1044, 50);
            this.Panel_Title.TabIndex = 1;
            // 
            // Label_RequestCount
            // 
            this.Label_RequestCount.AutoSize = true;
            this.Label_RequestCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RequestCount.ForeColor = System.Drawing.Color.Snow;
            this.Label_RequestCount.Location = new System.Drawing.Point(202, 9);
            this.Label_RequestCount.Name = "Label_RequestCount";
            this.Label_RequestCount.Size = new System.Drawing.Size(0, 32);
            this.Label_RequestCount.TabIndex = 5;
            // 
            // Button_History
            // 
            this.Button_History.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_History.BorderRadius = 0;
            this.Button_History.ButtonText = "History";
            this.Button_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_History.DisabledColor = System.Drawing.Color.Gray;
            this.Button_History.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_History.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Button_History.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_History.Iconimage = global::VideoRentalStore.Properties.Resources.payment;
            this.Button_History.Iconimage_right = null;
            this.Button_History.Iconimage_right_Selected = null;
            this.Button_History.Iconimage_Selected = null;
            this.Button_History.IconMarginLeft = 0;
            this.Button_History.IconMarginRight = 0;
            this.Button_History.IconRightVisible = true;
            this.Button_History.IconRightZoom = 0D;
            this.Button_History.IconVisible = true;
            this.Button_History.IconZoom = 70D;
            this.Button_History.IsTab = false;
            this.Button_History.Location = new System.Drawing.Point(294, 0);
            this.Button_History.Margin = new System.Windows.Forms.Padding(4);
            this.Button_History.Name = "Button_History";
            this.Button_History.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_History.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_History.selected = false;
            this.Button_History.Size = new System.Drawing.Size(294, 50);
            this.Button_History.TabIndex = 4;
            this.Button_History.Text = "History";
            this.Button_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_History.Textcolor = System.Drawing.Color.White;
            this.Button_History.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_History.Click += new System.EventHandler(this.Button_History_Click);
            // 
            // Button_ActiveRequest
            // 
            this.Button_ActiveRequest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ActiveRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ActiveRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_ActiveRequest.BorderRadius = 0;
            this.Button_ActiveRequest.ButtonText = "Active Request";
            this.Button_ActiveRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ActiveRequest.DisabledColor = System.Drawing.Color.Gray;
            this.Button_ActiveRequest.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_ActiveRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Button_ActiveRequest.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_ActiveRequest.Iconimage = global::VideoRentalStore.Properties.Resources.Active_Request;
            this.Button_ActiveRequest.Iconimage_right = null;
            this.Button_ActiveRequest.Iconimage_right_Selected = null;
            this.Button_ActiveRequest.Iconimage_Selected = null;
            this.Button_ActiveRequest.IconMarginLeft = 0;
            this.Button_ActiveRequest.IconMarginRight = 0;
            this.Button_ActiveRequest.IconRightVisible = true;
            this.Button_ActiveRequest.IconRightZoom = 0D;
            this.Button_ActiveRequest.IconVisible = true;
            this.Button_ActiveRequest.IconZoom = 80D;
            this.Button_ActiveRequest.IsTab = false;
            this.Button_ActiveRequest.Location = new System.Drawing.Point(0, 0);
            this.Button_ActiveRequest.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ActiveRequest.Name = "Button_ActiveRequest";
            this.Button_ActiveRequest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ActiveRequest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_ActiveRequest.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_ActiveRequest.selected = false;
            this.Button_ActiveRequest.Size = new System.Drawing.Size(294, 50);
            this.Button_ActiveRequest.TabIndex = 3;
            this.Button_ActiveRequest.Text = "Active Request";
            this.Button_ActiveRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ActiveRequest.Textcolor = System.Drawing.Color.White;
            this.Button_ActiveRequest.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ActiveRequest.Click += new System.EventHandler(this.Button_ActiveRequest_Click);
            // 
            // Panel_ButtonContainer
            // 
            this.Panel_ButtonContainer.Controls.Add(this.Button_ViewInfo);
            this.Panel_ButtonContainer.Controls.Add(this.Button_ChuyenHang);
            this.Panel_ButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_ButtonContainer.Location = new System.Drawing.Point(0, 600);
            this.Panel_ButtonContainer.Name = "Panel_ButtonContainer";
            this.Panel_ButtonContainer.Size = new System.Drawing.Size(1044, 61);
            this.Panel_ButtonContainer.TabIndex = 2;
            // 
            // Button_ViewInfo
            // 
            this.Button_ViewInfo.ActiveBorderThickness = 1;
            this.Button_ViewInfo.ActiveCornerRadius = 20;
            this.Button_ViewInfo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_ViewInfo.ActiveForecolor = System.Drawing.Color.White;
            this.Button_ViewInfo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_ViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ViewInfo.BackColor = System.Drawing.SystemColors.Control;
            this.Button_ViewInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_ViewInfo.BackgroundImage")));
            this.Button_ViewInfo.ButtonText = "View Request";
            this.Button_ViewInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ViewInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ViewInfo.ForeColor = System.Drawing.Color.SeaShell;
            this.Button_ViewInfo.IdleBorderThickness = 1;
            this.Button_ViewInfo.IdleCornerRadius = 20;
            this.Button_ViewInfo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ViewInfo.IdleForecolor = System.Drawing.Color.SeaShell;
            this.Button_ViewInfo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ViewInfo.Location = new System.Drawing.Point(671, 9);
            this.Button_ViewInfo.Margin = new System.Windows.Forms.Padding(6);
            this.Button_ViewInfo.Name = "Button_ViewInfo";
            this.Button_ViewInfo.Size = new System.Drawing.Size(187, 40);
            this.Button_ViewInfo.TabIndex = 1;
            this.Button_ViewInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_ChuyenHang
            // 
            this.Button_ChuyenHang.ActiveBorderThickness = 1;
            this.Button_ChuyenHang.ActiveCornerRadius = 20;
            this.Button_ChuyenHang.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_ChuyenHang.ActiveForecolor = System.Drawing.Color.White;
            this.Button_ChuyenHang.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_ChuyenHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ChuyenHang.BackColor = System.Drawing.SystemColors.Control;
            this.Button_ChuyenHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_ChuyenHang.BackgroundImage")));
            this.Button_ChuyenHang.ButtonText = "Comeplete Request";
            this.Button_ChuyenHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChuyenHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ChuyenHang.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_ChuyenHang.IdleBorderThickness = 1;
            this.Button_ChuyenHang.IdleCornerRadius = 20;
            this.Button_ChuyenHang.IdleFillColor = System.Drawing.Color.White;
            this.Button_ChuyenHang.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_ChuyenHang.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_ChuyenHang.Location = new System.Drawing.Point(868, 8);
            this.Button_ChuyenHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_ChuyenHang.Name = "Button_ChuyenHang";
            this.Button_ChuyenHang.Size = new System.Drawing.Size(163, 41);
            this.Button_ChuyenHang.TabIndex = 0;
            this.Button_ChuyenHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_ChuyenHang.Click += new System.EventHandler(this.Button_ChuyenHang_Click);
            // 
            // Panel_GridContainer
            // 
            this.Panel_GridContainer.Controls.Add(this.DataGrid_YCThueMua);
            this.Panel_GridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_GridContainer.Location = new System.Drawing.Point(0, 50);
            this.Panel_GridContainer.Name = "Panel_GridContainer";
            this.Panel_GridContainer.Size = new System.Drawing.Size(1044, 550);
            this.Panel_GridContainer.TabIndex = 3;
            // 
            // DataGrid_YCThueMua
            // 
            this.DataGrid_YCThueMua.AllowUserToAddRows = false;
            this.DataGrid_YCThueMua.AllowUserToDeleteRows = false;
            this.DataGrid_YCThueMua.AllowUserToResizeColumns = false;
            this.DataGrid_YCThueMua.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid_YCThueMua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_YCThueMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_YCThueMua.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_YCThueMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_YCThueMua.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_YCThueMua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_YCThueMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_YCThueMua.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_YCThueMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_YCThueMua.DoubleBuffered = true;
            this.DataGrid_YCThueMua.EnableHeadersVisualStyles = false;
            this.DataGrid_YCThueMua.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGrid_YCThueMua.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DataGrid_YCThueMua.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_YCThueMua.MultiSelect = false;
            this.DataGrid_YCThueMua.Name = "DataGrid_YCThueMua";
            this.DataGrid_YCThueMua.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_YCThueMua.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid_YCThueMua.RowHeadersWidth = 100;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DataGrid_YCThueMua.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid_YCThueMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_YCThueMua.ShowCellErrors = false;
            this.DataGrid_YCThueMua.ShowCellToolTips = false;
            this.DataGrid_YCThueMua.ShowEditingIcon = false;
            this.DataGrid_YCThueMua.ShowRowErrors = false;
            this.DataGrid_YCThueMua.Size = new System.Drawing.Size(1044, 550);
            this.DataGrid_YCThueMua.TabIndex = 3;
            this.DataGrid_YCThueMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_YCThueMua_CellClick);
            // 
            // Grid_YeuCauThueMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.Panel_GridContainer);
            this.Controls.Add(this.Panel_ButtonContainer);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grid_YeuCauThueMua";
            this.Text = "Grid_YeuCauThueMua";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.Panel_ButtonContainer.ResumeLayout(false);
            this.Panel_GridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_YCThueMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Title;
        private Bunifu.Framework.UI.BunifuFlatButton Button_History;
        private Bunifu.Framework.UI.BunifuFlatButton Button_ActiveRequest;
        private System.Windows.Forms.Panel Panel_ButtonContainer;
        private System.Windows.Forms.Panel Panel_GridContainer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_YCThueMua;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_ViewInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_ChuyenHang;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_RequestCount;
    }
}