
namespace VideoRentalStore
{
    partial class History_Payment
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
            this.DataGrid_AccountManagement = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_IDVideo = new System.Windows.Forms.Label();
            this.Label_DateRequest = new System.Windows.Forms.Label();
            this.Button_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccountManagement)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_AccountManagement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DataGrid_AccountManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_AccountManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_AccountManagement.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_AccountManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_AccountManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_AccountManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_AccountManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_AccountManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userName,
            this.idVideo,
            this.DateRequest,
            this.Price,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_AccountManagement.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_AccountManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_AccountManagement.DoubleBuffered = true;
            this.DataGrid_AccountManagement.EnableHeadersVisualStyles = false;
            this.DataGrid_AccountManagement.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGrid_AccountManagement.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_AccountManagement.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_AccountManagement.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_AccountManagement.MultiSelect = false;
            this.DataGrid_AccountManagement.Name = "DataGrid_AccountManagement";
            this.DataGrid_AccountManagement.ReadOnly = true;
            this.DataGrid_AccountManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_AccountManagement.RowHeadersVisible = false;
            this.DataGrid_AccountManagement.RowHeadersWidth = 51;
            this.DataGrid_AccountManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_AccountManagement.ShowCellErrors = false;
            this.DataGrid_AccountManagement.ShowCellToolTips = false;
            this.DataGrid_AccountManagement.ShowEditingIcon = false;
            this.DataGrid_AccountManagement.ShowRowErrors = false;
            this.DataGrid_AccountManagement.Size = new System.Drawing.Size(1071, 814);
            this.DataGrid_AccountManagement.TabIndex = 1;
            this.DataGrid_AccountManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_ManageStock_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 20F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "userName";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // idVideo
            // 
            this.idVideo.DataPropertyName = "idVideo";
            this.idVideo.HeaderText = "idVideo";
            this.idVideo.MinimumWidth = 6;
            this.idVideo.Name = "idVideo";
            this.idVideo.ReadOnly = true;
            // 
            // DateRequest
            // 
            this.DateRequest.DataPropertyName = "DateRequest";
            this.DateRequest.HeaderText = "DateRequest";
            this.DateRequest.MinimumWidth = 6;
            this.DateRequest.Name = "DateRequest";
            this.DateRequest.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 30F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGrid_AccountManagement);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 814);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1077, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID Video";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1077, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1077, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1077, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 38);
            this.label5.TabIndex = 33;
            this.label5.Text = "Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(1078, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 38);
            this.label8.TabIndex = 41;
            this.label8.Text = "UserName";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_UserName
            // 
            this.Label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserName.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_UserName.Location = new System.Drawing.Point(1220, 20);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(165, 38);
            this.Label_UserName.TabIndex = 43;
            this.Label_UserName.Text = "UserName";
            this.Label_UserName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Type
            // 
            this.Label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Type.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Type.Location = new System.Drawing.Point(1220, 220);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(165, 38);
            this.Label_Type.TabIndex = 44;
            this.Label_Type.Text = "Type";
            this.Label_Type.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_Price
            // 
            this.Label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_Price.Location = new System.Drawing.Point(1220, 170);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(165, 38);
            this.Label_Price.TabIndex = 46;
            this.Label_Price.Text = "Price";
            this.Label_Price.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_IDVideo
            // 
            this.Label_IDVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IDVideo.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_IDVideo.Location = new System.Drawing.Point(1220, 70);
            this.Label_IDVideo.Name = "Label_IDVideo";
            this.Label_IDVideo.Size = new System.Drawing.Size(165, 38);
            this.Label_IDVideo.TabIndex = 47;
            this.Label_IDVideo.Text = "IDVideo";
            this.Label_IDVideo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Label_DateRequest
            // 
            this.Label_DateRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DateRequest.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_DateRequest.Location = new System.Drawing.Point(1220, 120);
            this.Label_DateRequest.Name = "Label_DateRequest";
            this.Label_DateRequest.Size = new System.Drawing.Size(165, 38);
            this.Label_DateRequest.TabIndex = 48;
            this.Label_DateRequest.Text = "DateRequest";
            this.Label_DateRequest.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Button_Delete
            // 
            this.Button_Delete.ActiveBorderThickness = 1;
            this.Button_Delete.ActiveCornerRadius = 20;
            this.Button_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Delete.BackgroundImage = global::VideoRentalStore.Properties.Resources.Sorry;
            this.Button_Delete.ButtonText = "Delete";
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.IdleBorderThickness = 1;
            this.Button_Delete.IdleCornerRadius = 20;
            this.Button_Delete.IdleFillColor = System.Drawing.Color.White;
            this.Button_Delete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.Location = new System.Drawing.Point(1100, 364);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(245, 50);
            this.Button_Delete.TabIndex = 37;
            this.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // History_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1392, 814);
            this.Controls.Add(this.Label_DateRequest);
            this.Controls.Add(this.Label_IDVideo);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Label_UserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "History_Payment";
            this.Text = "Manage_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccountManagement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_AccountManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_IDVideo;
        private System.Windows.Forms.Label Label_DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}