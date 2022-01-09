
namespace VideoRentalStore
{
    partial class Import_Disk_WithFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Button_ImportFile = new System.Windows.Forms.Button();
            this.ComboBox_Sheet = new System.Windows.Forms.ComboBox();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.Label_Sheet = new System.Windows.Forms.Label();
            this.DataGridView_Import = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Button_Import = new Bunifu.Framework.UI.BunifuFlatButton();
            this.videoRentalStoreDataSet = new VideoRentalStore.VideoRentalStoreDataSet();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoTableAdapter = new VideoRentalStore.VideoRentalStoreDataSetTableAdapters.VideoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbnailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 10;
            this.Elipse_Form.TargetControl = this;
            // 
            // Button_ImportFile
            // 
            this.Button_ImportFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ImportFile.Location = new System.Drawing.Point(813, 425);
            this.Button_ImportFile.Name = "Button_ImportFile";
            this.Button_ImportFile.Size = new System.Drawing.Size(75, 23);
            this.Button_ImportFile.TabIndex = 1;
            this.Button_ImportFile.Text = "...";
            this.Button_ImportFile.UseVisualStyleBackColor = true;
            this.Button_ImportFile.Click += new System.EventHandler(this.Button_ImportFile_Click);
            // 
            // ComboBox_Sheet
            // 
            this.ComboBox_Sheet.FormattingEnabled = true;
            this.ComboBox_Sheet.Location = new System.Drawing.Point(98, 451);
            this.ComboBox_Sheet.Name = "ComboBox_Sheet";
            this.ComboBox_Sheet.Size = new System.Drawing.Size(99, 21);
            this.ComboBox_Sheet.TabIndex = 2;
            this.ComboBox_Sheet.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Sheet_SelectedIndexChanged);
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Location = new System.Drawing.Point(98, 425);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.ReadOnly = true;
            this.TextBox_FilePath.Size = new System.Drawing.Size(709, 20);
            this.TextBox_FilePath.TabIndex = 3;
            this.TextBox_FilePath.Text = "Read excel *.xls or .xlsx*";
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_FileName.Location = new System.Drawing.Point(12, 425);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(66, 17);
            this.Label_FileName.TabIndex = 4;
            this.Label_FileName.Text = "File Name";
            this.Label_FileName.Click += new System.EventHandler(this.Label_FileName_Click);
            // 
            // Label_Sheet
            // 
            this.Label_Sheet.AutoSize = true;
            this.Label_Sheet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sheet.Location = new System.Drawing.Point(12, 455);
            this.Label_Sheet.Name = "Label_Sheet";
            this.Label_Sheet.Size = new System.Drawing.Size(40, 17);
            this.Label_Sheet.TabIndex = 5;
            this.Label_Sheet.Text = "Sheet";
            // 
            // DataGridView_Import
            // 
            this.DataGridView_Import.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView_Import.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Import.AutoGenerateColumns = false;
            this.DataGridView_Import.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Import.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Import.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Import.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_Import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Import.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.decriptionDataGridViewTextBoxColumn,
            this.thumbnailDataGridViewTextBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DataGridView_Import.DataSource = this.videoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Import.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_Import.DoubleBuffered = true;
            this.DataGridView_Import.EnableHeadersVisualStyles = false;
            this.DataGridView_Import.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGridView_Import.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView_Import.Location = new System.Drawing.Point(13, 13);
            this.DataGridView_Import.Name = "DataGridView_Import";
            this.DataGridView_Import.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Import.RowHeadersVisible = false;
            this.DataGridView_Import.Size = new System.Drawing.Size(875, 397);
            this.DataGridView_Import.TabIndex = 6;
            this.DataGridView_Import.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Import_CellContentClick);
            // 
            // Button_Import
            // 
            this.Button_Import.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Import.BorderRadius = 0;
            this.Button_Import.ButtonText = "Import";
            this.Button_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Import.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Import.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Import.Iconimage = global::VideoRentalStore.Properties.Resources.import;
            this.Button_Import.Iconimage_right = null;
            this.Button_Import.Iconimage_right_Selected = null;
            this.Button_Import.Iconimage_Selected = null;
            this.Button_Import.IconMarginLeft = 0;
            this.Button_Import.IconMarginRight = 0;
            this.Button_Import.IconRightVisible = true;
            this.Button_Import.IconRightZoom = 0D;
            this.Button_Import.IconVisible = true;
            this.Button_Import.IconZoom = 60D;
            this.Button_Import.IsTab = false;
            this.Button_Import.Location = new System.Drawing.Point(647, 490);
            this.Button_Import.Name = "Button_Import";
            this.Button_Import.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Import.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Button_Import.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Import.selected = false;
            this.Button_Import.Size = new System.Drawing.Size(241, 48);
            this.Button_Import.TabIndex = 7;
            this.Button_Import.Text = "Import";
            this.Button_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Import.Textcolor = System.Drawing.Color.White;
            this.Button_Import.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Import.Click += new System.EventHandler(this.Button_Import_Click);
            // 
            // videoRentalStoreDataSet
            // 
            this.videoRentalStoreDataSet.DataSetName = "VideoRentalStoreDataSet";
            this.videoRentalStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataMember = "Video";
            this.videoBindingSource.DataSource = this.videoRentalStoreDataSet;
            // 
            // videoTableAdapter
            // 
            this.videoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            // 
            // decriptionDataGridViewTextBoxColumn
            // 
            this.decriptionDataGridViewTextBoxColumn.DataPropertyName = "Decription";
            this.decriptionDataGridViewTextBoxColumn.HeaderText = "Decription";
            this.decriptionDataGridViewTextBoxColumn.Name = "decriptionDataGridViewTextBoxColumn";
            // 
            // thumbnailDataGridViewTextBoxColumn
            // 
            this.thumbnailDataGridViewTextBoxColumn.DataPropertyName = "Thumbnail";
            this.thumbnailDataGridViewTextBoxColumn.HeaderText = "Thumbnail";
            this.thumbnailDataGridViewTextBoxColumn.Name = "thumbnailDataGridViewTextBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(427, 490);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(214, 48);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "Cancel";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Import_Disk_WithFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.Button_Import);
            this.Controls.Add(this.DataGridView_Import);
            this.Controls.Add(this.Label_Sheet);
            this.Controls.Add(this.Label_FileName);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.ComboBox_Sheet);
            this.Controls.Add(this.Button_ImportFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Import_Disk_WithFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read excel *.xls or .xlsx*";
            this.Load += new System.EventHandler(this.Import_Disk_WithFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.ComboBox ComboBox_Sheet;
        private System.Windows.Forms.Button Button_ImportFile;
        private System.Windows.Forms.Label Label_Sheet;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridView_Import;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Import;
        private VideoRentalStoreDataSet videoRentalStoreDataSet;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private VideoRentalStoreDataSetTableAdapters.VideoTableAdapter videoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}