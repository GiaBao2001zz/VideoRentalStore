﻿
namespace VideoRentalStore
{
    partial class Account_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Management));
            this.DataGrid_AccountManagement = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_DisplayName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_PhoneNum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_CMND = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccountManagement)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_AccountManagement
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DataGrid_AccountManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DataGrid_AccountManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_AccountManagement.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid_AccountManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_AccountManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_AccountManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGrid_AccountManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_AccountManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUsername,
            this.txtDisplayName,
            this.txtPassword,
            this.txtPhoneNumber,
            this.txtEmail,
            this.txtDateCreate,
            this.txtCMND,
            this.txtAddress,
            this.txtType});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_AccountManagement.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataGrid_AccountManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid_AccountManagement.DoubleBuffered = true;
            this.DataGrid_AccountManagement.EnableHeadersVisualStyles = false;
            this.DataGrid_AccountManagement.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGrid_AccountManagement.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid_AccountManagement.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_AccountManagement.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_AccountManagement.MultiSelect = false;
            this.DataGrid_AccountManagement.Name = "DataGrid_AccountManagement";
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
            this.DataGrid_AccountManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_AccountManagement_CellContentClick);
            this.DataGrid_AccountManagement.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_AccountManagement_CellValueChanged);
            // 
            // txtType
            // 
            this.txtType.DataPropertyName = "Type";
            this.txtType.FillWeight = 40F;
            this.txtType.HeaderText = "Type";
            this.txtType.MinimumWidth = 6;
            this.txtType.Name = "txtType";
            // 
            // txtAddress
            // 
            this.txtAddress.DataPropertyName = "Address";
            this.txtAddress.FillWeight = 70F;
            this.txtAddress.HeaderText = "Address";
            this.txtAddress.MinimumWidth = 6;
            this.txtAddress.Name = "txtAddress";
            // 
            // txtCMND
            // 
            this.txtCMND.DataPropertyName = "CMND";
            this.txtCMND.HeaderText = "CMND";
            this.txtCMND.MinimumWidth = 6;
            this.txtCMND.Name = "txtCMND";
            // 
            // txtDateCreate
            // 
            this.txtDateCreate.DataPropertyName = "DateCreate";
            this.txtDateCreate.FillWeight = 90F;
            this.txtDateCreate.HeaderText = "DateCreate";
            this.txtDateCreate.MinimumWidth = 6;
            this.txtDateCreate.Name = "txtDateCreate";
            // 
            // txtEmail
            // 
            this.txtEmail.DataPropertyName = "Email";
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.MinimumWidth = 6;
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataPropertyName = "PhoneNumber";
            this.txtPhoneNumber.HeaderText = "PhoneNumber";
            this.txtPhoneNumber.MinimumWidth = 6;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            // 
            // txtPassword
            // 
            this.txtPassword.DataPropertyName = "PassWord";
            this.txtPassword.FillWeight = 90F;
            this.txtPassword.HeaderText = "Password";
            this.txtPassword.MinimumWidth = 6;
            this.txtPassword.Name = "txtPassword";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.DataPropertyName = "DisplayName";
            this.txtDisplayName.HeaderText = "DisplayName";
            this.txtDisplayName.MinimumWidth = 6;
            this.txtDisplayName.Name = "txtDisplayName";
            // 
            // txtUsername
            // 
            this.txtUsername.DataPropertyName = "Username";
            this.txtUsername.HeaderText = "Username";
            this.txtUsername.MinimumWidth = 6;
            this.txtUsername.Name = "txtUsername";
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
            // TextBox_DisplayName
            // 
            this.TextBox_DisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DisplayName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_DisplayName.ForeColor = System.Drawing.Color.White;
            this.TextBox_DisplayName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_DisplayName.HintText = "";
            this.TextBox_DisplayName.isPassword = false;
            this.TextBox_DisplayName.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_DisplayName.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_DisplayName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_DisplayName.LineThickness = 5;
            this.TextBox_DisplayName.Location = new System.Drawing.Point(1200, 9);
            this.TextBox_DisplayName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_DisplayName.Name = "TextBox_DisplayName";
            this.TextBox_DisplayName.Size = new System.Drawing.Size(186, 40);
            this.TextBox_DisplayName.TabIndex = 23;
            this.TextBox_DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.White;
            this.TextBox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Password.HintText = "";
            this.TextBox_Password.isPassword = false;
            this.TextBox_Password.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Password.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Password.LineThickness = 5;
            this.TextBox_Password.Location = new System.Drawing.Point(1200, 67);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(186, 40);
            this.TextBox_Password.TabIndex = 24;
            this.TextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_PhoneNum
            // 
            this.TextBox_PhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_PhoneNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PhoneNum.ForeColor = System.Drawing.Color.White;
            this.TextBox_PhoneNum.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_PhoneNum.HintText = "";
            this.TextBox_PhoneNum.isPassword = false;
            this.TextBox_PhoneNum.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_PhoneNum.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_PhoneNum.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_PhoneNum.LineThickness = 5;
            this.TextBox_PhoneNum.Location = new System.Drawing.Point(1200, 125);
            this.TextBox_PhoneNum.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_PhoneNum.Name = "TextBox_PhoneNum";
            this.TextBox_PhoneNum.Size = new System.Drawing.Size(186, 40);
            this.TextBox_PhoneNum.TabIndex = 25;
            this.TextBox_PhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Email.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Email.ForeColor = System.Drawing.Color.White;
            this.TextBox_Email.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Email.HintText = "";
            this.TextBox_Email.isPassword = false;
            this.TextBox_Email.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Email.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Email.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Email.LineThickness = 5;
            this.TextBox_Email.Location = new System.Drawing.Point(1200, 183);
            this.TextBox_Email.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(186, 40);
            this.TextBox_Email.TabIndex = 26;
            this.TextBox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_CMND
            // 
            this.TextBox_CMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_CMND.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CMND.ForeColor = System.Drawing.Color.White;
            this.TextBox_CMND.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_CMND.HintText = "";
            this.TextBox_CMND.isPassword = false;
            this.TextBox_CMND.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_CMND.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_CMND.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_CMND.LineThickness = 5;
            this.TextBox_CMND.Location = new System.Drawing.Point(1200, 241);
            this.TextBox_CMND.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_CMND.Name = "TextBox_CMND";
            this.TextBox_CMND.Size = new System.Drawing.Size(186, 40);
            this.TextBox_CMND.TabIndex = 27;
            this.TextBox_CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Address.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Address.ForeColor = System.Drawing.Color.White;
            this.TextBox_Address.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Address.HintText = "";
            this.TextBox_Address.isPassword = false;
            this.TextBox_Address.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Address.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Address.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Address.LineThickness = 5;
            this.TextBox_Address.Location = new System.Drawing.Point(1200, 299);
            this.TextBox_Address.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(186, 40);
            this.TextBox_Address.TabIndex = 28;
            this.TextBox_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1078, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "DisName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1074, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1074, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "PhoneNum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1074, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1074, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 38);
            this.label5.TabIndex = 33;
            this.label5.Text = "CMND";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(1074, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 38);
            this.label6.TabIndex = 34;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Button_Add
            // 
            this.Button_Add.ActiveBorderThickness = 1;
            this.Button_Add.ActiveCornerRadius = 20;
            this.Button_Add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Add.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Add.BackgroundImage")));
            this.Button_Add.ButtonText = "Add";
            this.Button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Add.IdleBorderThickness = 1;
            this.Button_Add.IdleCornerRadius = 20;
            this.Button_Add.IdleFillColor = System.Drawing.Color.White;
            this.Button_Add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Add.Location = new System.Drawing.Point(1114, 372);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(245, 50);
            this.Button_Add.TabIndex = 35;
            this.Button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Edit
            // 
            this.Button_Edit.ActiveBorderThickness = 1;
            this.Button_Edit.ActiveCornerRadius = 20;
            this.Button_Edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Edit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Edit.BackgroundImage")));
            this.Button_Edit.ButtonText = "Edit";
            this.Button_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Edit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_Edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Edit.IdleBorderThickness = 1;
            this.Button_Edit.IdleCornerRadius = 20;
            this.Button_Edit.IdleFillColor = System.Drawing.Color.White;
            this.Button_Edit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Edit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Edit.Location = new System.Drawing.Point(1114, 434);
            this.Button_Edit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(245, 50);
            this.Button_Edit.TabIndex = 36;
            this.Button_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Delete
            // 
            this.Button_Delete.ActiveBorderThickness = 1;
            this.Button_Delete.ActiveCornerRadius = 20;
            this.Button_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Delete.BackgroundImage")));
            this.Button_Delete.ButtonText = "Delete";
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.IdleBorderThickness = 1;
            this.Button_Delete.IdleCornerRadius = 20;
            this.Button_Delete.IdleFillColor = System.Drawing.Color.White;
            this.Button_Delete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Delete.Location = new System.Drawing.Point(1114, 496);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(245, 50);
            this.Button_Delete.TabIndex = 37;
            this.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1392, 814);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.TextBox_CMND);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_PhoneNum);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_DisplayName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Account_Management";
            this.Text = "Manage_Stock";
            this.Load += new System.EventHandler(this.Account_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AccountManagement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid_AccountManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtType;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DisplayName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Password;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_PhoneNum;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Email;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_CMND;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Add;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Delete;
    }
}