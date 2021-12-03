
namespace VideoRentalStore
{
    partial class Account_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Info));
            this.TextBox_UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_DateCreated = new System.Windows.Forms.Label();
            this.Label_PhoneNumber = new System.Windows.Forms.Label();
            this.Label_DisplayName = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.TextBox_DisplayName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_ShowDateCreated = new System.Windows.Forms.Label();
            this.TextBox_PhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_ChangeInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_UserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_UserName.ForeColor = System.Drawing.Color.White;
            this.TextBox_UserName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_UserName.HintText = "";
            this.TextBox_UserName.isPassword = false;
            this.TextBox_UserName.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_UserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_UserName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_UserName.LineThickness = 5;
            this.TextBox_UserName.Location = new System.Drawing.Point(82, 62);
            this.TextBox_UserName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(308, 53);
            this.TextBox_UserName.TabIndex = 20;
            this.TextBox_UserName.Text = "Chikitori";
            this.TextBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_UserName.OnValueChanged += new System.EventHandler(this.TextBox_UserName_OnValueChanged);
            // 
            // Label_DateCreated
            // 
            this.Label_DateCreated.AutoSize = true;
            this.Label_DateCreated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DateCreated.ForeColor = System.Drawing.Color.White;
            this.Label_DateCreated.Location = new System.Drawing.Point(78, 380);
            this.Label_DateCreated.Name = "Label_DateCreated";
            this.Label_DateCreated.Size = new System.Drawing.Size(114, 21);
            this.Label_DateCreated.TabIndex = 16;
            this.Label_DateCreated.Text = "DATE CREATED";
            // 
            // Label_PhoneNumber
            // 
            this.Label_PhoneNumber.AutoSize = true;
            this.Label_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.Label_PhoneNumber.Location = new System.Drawing.Point(471, 34);
            this.Label_PhoneNumber.Name = "Label_PhoneNumber";
            this.Label_PhoneNumber.Size = new System.Drawing.Size(130, 21);
            this.Label_PhoneNumber.TabIndex = 15;
            this.Label_PhoneNumber.Text = "PHONE NUMBER";
            // 
            // Label_DisplayName
            // 
            this.Label_DisplayName.AutoSize = true;
            this.Label_DisplayName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DisplayName.ForeColor = System.Drawing.Color.White;
            this.Label_DisplayName.Location = new System.Drawing.Point(79, 142);
            this.Label_DisplayName.Name = "Label_DisplayName";
            this.Label_DisplayName.Size = new System.Drawing.Size(117, 21);
            this.Label_DisplayName.TabIndex = 14;
            this.Label_DisplayName.Text = "DISPLAY NAME";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.ForeColor = System.Drawing.Color.White;
            this.Label_Email.Location = new System.Drawing.Point(78, 266);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(54, 21);
            this.Label_Email.TabIndex = 12;
            this.Label_Email.Text = "EMAIL";
            this.Label_Email.Click += new System.EventHandler(this.Label_Email_Click);
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_UserName.ForeColor = System.Drawing.Color.FloralWhite;
            this.Label_UserName.Location = new System.Drawing.Point(78, 34);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(92, 21);
            this.Label_UserName.TabIndex = 11;
            this.Label_UserName.Text = "USERNAME";
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
            this.TextBox_DisplayName.Location = new System.Drawing.Point(82, 170);
            this.TextBox_DisplayName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_DisplayName.Name = "TextBox_DisplayName";
            this.TextBox_DisplayName.Size = new System.Drawing.Size(308, 53);
            this.TextBox_DisplayName.TabIndex = 21;
            this.TextBox_DisplayName.Text = "Nguyễn Trọng Tính";
            this.TextBox_DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.TextBox_Email.Location = new System.Drawing.Point(82, 294);
            this.TextBox_Email.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(308, 53);
            this.TextBox_Email.TabIndex = 22;
            this.TextBox_Email.Text = "tinh258456@gmail.com";
            this.TextBox_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_ShowDateCreated
            // 
            this.Label_ShowDateCreated.AutoSize = true;
            this.Label_ShowDateCreated.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowDateCreated.ForeColor = System.Drawing.Color.White;
            this.Label_ShowDateCreated.Location = new System.Drawing.Point(78, 401);
            this.Label_ShowDateCreated.Name = "Label_ShowDateCreated";
            this.Label_ShowDateCreated.Size = new System.Drawing.Size(115, 30);
            this.Label_ShowDateCreated.TabIndex = 19;
            this.Label_ShowDateCreated.Text = "23/11/2001";
            // 
            // TextBox_PhoneNumber
            // 
            this.TextBox_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.TextBox_PhoneNumber.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_PhoneNumber.HintText = "";
            this.TextBox_PhoneNumber.isPassword = false;
            this.TextBox_PhoneNumber.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_PhoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_PhoneNumber.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_PhoneNumber.LineThickness = 5;
            this.TextBox_PhoneNumber.Location = new System.Drawing.Point(475, 62);
            this.TextBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
            this.TextBox_PhoneNumber.Size = new System.Drawing.Size(246, 53);
            this.TextBox_PhoneNumber.TabIndex = 23;
            this.TextBox_PhoneNumber.Text = "0335544529";
            this.TextBox_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.ActiveBorderThickness = 1;
            this.Button_Cancel.ActiveCornerRadius = 20;
            this.Button_Cancel.ActiveFillColor = System.Drawing.Color.Red;
            this.Button_Cancel.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Cancel.ActiveLineColor = System.Drawing.Color.Red;
            this.Button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Cancel.BackgroundImage")));
            this.Button_Cancel.ButtonText = "Cancel";
            this.Button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Cancel.IdleBorderThickness = 1;
            this.Button_Cancel.IdleCornerRadius = 20;
            this.Button_Cancel.IdleFillColor = System.Drawing.Color.White;
            this.Button_Cancel.IdleForecolor = System.Drawing.Color.Red;
            this.Button_Cancel.IdleLineColor = System.Drawing.Color.Red;
            this.Button_Cancel.Location = new System.Drawing.Point(411, 419);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(153, 41);
            this.Button_Cancel.TabIndex = 25;
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_ChangeInfo
            // 
            this.Button_ChangeInfo.ActiveBorderThickness = 1;
            this.Button_ChangeInfo.ActiveCornerRadius = 20;
            this.Button_ChangeInfo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_ChangeInfo.ActiveForecolor = System.Drawing.Color.White;
            this.Button_ChangeInfo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_ChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ChangeInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_ChangeInfo.BackgroundImage")));
            this.Button_ChangeInfo.ButtonText = "Confirm";
            this.Button_ChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChangeInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ChangeInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_ChangeInfo.IdleBorderThickness = 1;
            this.Button_ChangeInfo.IdleCornerRadius = 20;
            this.Button_ChangeInfo.IdleFillColor = System.Drawing.Color.White;
            this.Button_ChangeInfo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_ChangeInfo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_ChangeInfo.Location = new System.Drawing.Point(573, 419);
            this.Button_ChangeInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_ChangeInfo.Name = "Button_ChangeInfo";
            this.Button_ChangeInfo.Size = new System.Drawing.Size(148, 41);
            this.Button_ChangeInfo.TabIndex = 24;
            this.Button_ChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_ChangeInfo.Click += new System.EventHandler(this.Button_ChangeInfo_Click);
            // 
            // Account_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(753, 489);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_ChangeInfo);
            this.Controls.Add(this.TextBox_PhoneNumber);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_DisplayName);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.Label_ShowDateCreated);
            this.Controls.Add(this.Label_DateCreated);
            this.Controls.Add(this.Label_PhoneNumber);
            this.Controls.Add(this.Label_DisplayName);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account_Info";
            this.Text = "Account_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_UserName;
        private System.Windows.Forms.Label Label_DateCreated;
        private System.Windows.Forms.Label Label_PhoneNumber;
        private System.Windows.Forms.Label Label_DisplayName;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_UserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_DisplayName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Email;
        private System.Windows.Forms.Label Label_ShowDateCreated;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_PhoneNumber;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_ChangeInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Cancel;
    }
}