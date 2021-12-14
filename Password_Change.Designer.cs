
namespace VideoRentalStore
{
    partial class Password_Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Change));
            this.TextBox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_OldPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_DisplayName = new System.Windows.Forms.Label();
            this.Label_PasswordAgain = new System.Windows.Forms.Label();
            this.Label_OldPassword = new System.Windows.Forms.Label();
            this.Button_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_ChangeInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextBox_PasswordAgain = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.White;
            this.TextBox_Password.HintForeColor = System.Drawing.Color.White;
            this.TextBox_Password.HintText = "";
            this.TextBox_Password.isPassword = true;
            this.TextBox_Password.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Password.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_Password.LineThickness = 5;
            this.TextBox_Password.Location = new System.Drawing.Point(83, 173);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(308, 53);
            this.TextBox_Password.TabIndex = 27;
            this.TextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Password.OnValueChanged += new System.EventHandler(this.TextBox_Password_OnValueChanged);
            // 
            // TextBox_OldPassword
            // 
            this.TextBox_OldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_OldPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OldPassword.ForeColor = System.Drawing.Color.White;
            this.TextBox_OldPassword.HintForeColor = System.Drawing.Color.White;
            this.TextBox_OldPassword.HintText = "";
            this.TextBox_OldPassword.isPassword = false;
            this.TextBox_OldPassword.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_OldPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_OldPassword.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_OldPassword.LineThickness = 5;
            this.TextBox_OldPassword.Location = new System.Drawing.Point(83, 65);
            this.TextBox_OldPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_OldPassword.Name = "TextBox_OldPassword";
            this.TextBox_OldPassword.Size = new System.Drawing.Size(308, 53);
            this.TextBox_OldPassword.TabIndex = 26;
            this.TextBox_OldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_OldPassword.OnValueChanged += new System.EventHandler(this.TextBox_OldPassword_OnValueChanged);
            // 
            // Label_DisplayName
            // 
            this.Label_DisplayName.AutoSize = true;
            this.Label_DisplayName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DisplayName.ForeColor = System.Drawing.Color.White;
            this.Label_DisplayName.Location = new System.Drawing.Point(80, 145);
            this.Label_DisplayName.Name = "Label_DisplayName";
            this.Label_DisplayName.Size = new System.Drawing.Size(228, 21);
            this.Label_DisplayName.TabIndex = 25;
            this.Label_DisplayName.Text = "ENTER YOUR NEW PASSWORD";
            // 
            // Label_PasswordAgain
            // 
            this.Label_PasswordAgain.AutoSize = true;
            this.Label_PasswordAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PasswordAgain.ForeColor = System.Drawing.Color.White;
            this.Label_PasswordAgain.Location = new System.Drawing.Point(79, 269);
            this.Label_PasswordAgain.Name = "Label_PasswordAgain";
            this.Label_PasswordAgain.Size = new System.Drawing.Size(240, 21);
            this.Label_PasswordAgain.TabIndex = 24;
            this.Label_PasswordAgain.Text = "ENTER YOUR PASSWORD AGAIN";
            // 
            // Label_OldPassword
            // 
            this.Label_OldPassword.AutoSize = true;
            this.Label_OldPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_OldPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.Label_OldPassword.Location = new System.Drawing.Point(79, 37);
            this.Label_OldPassword.Name = "Label_OldPassword";
            this.Label_OldPassword.Size = new System.Drawing.Size(224, 21);
            this.Label_OldPassword.TabIndex = 23;
            this.Label_OldPassword.Text = "ENTER YOUR OLD PASSWORD";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.ActiveBorderThickness = 1;
            this.Button_Cancel.ActiveCornerRadius = 20;
            this.Button_Cancel.ActiveFillColor = System.Drawing.Color.Red;
            this.Button_Cancel.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Cancel.ActiveLineColor = System.Drawing.Color.Red;
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Button_Cancel.Location = new System.Drawing.Point(413, 416);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(153, 41);
            this.Button_Cancel.TabIndex = 30;
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
            this.Button_ChangeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Button_ChangeInfo.Location = new System.Drawing.Point(575, 416);
            this.Button_ChangeInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_ChangeInfo.Name = "Button_ChangeInfo";
            this.Button_ChangeInfo.Size = new System.Drawing.Size(148, 41);
            this.Button_ChangeInfo.TabIndex = 29;
            this.Button_ChangeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_ChangeInfo.Click += new System.EventHandler(this.Button_ChangeInfo_Click);
            // 
            // TextBox_PasswordAgain
            // 
            this.TextBox_PasswordAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_PasswordAgain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_PasswordAgain.ForeColor = System.Drawing.Color.White;
            this.TextBox_PasswordAgain.HintForeColor = System.Drawing.Color.White;
            this.TextBox_PasswordAgain.HintText = "";
            this.TextBox_PasswordAgain.isPassword = true;
            this.TextBox_PasswordAgain.LineFocusedColor = System.Drawing.Color.Green;
            this.TextBox_PasswordAgain.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_PasswordAgain.LineMouseHoverColor = System.Drawing.Color.Green;
            this.TextBox_PasswordAgain.LineThickness = 5;
            this.TextBox_PasswordAgain.Location = new System.Drawing.Point(83, 297);
            this.TextBox_PasswordAgain.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TextBox_PasswordAgain.Name = "TextBox_PasswordAgain";
            this.TextBox_PasswordAgain.Size = new System.Drawing.Size(308, 53);
            this.TextBox_PasswordAgain.TabIndex = 31;
            this.TextBox_PasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_PasswordAgain.OnValueChanged += new System.EventHandler(this.TextBox_PasswordAgain_OnValueChanged);
            // 
            // Password_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(753, 489);
            this.Controls.Add(this.TextBox_PasswordAgain);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_ChangeInfo);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_OldPassword);
            this.Controls.Add(this.Label_DisplayName);
            this.Controls.Add(this.Label_PasswordAgain);
            this.Controls.Add(this.Label_OldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Password_Change";
            this.Text = "Password_Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_OldPassword;
        private System.Windows.Forms.Label Label_DisplayName;
        private System.Windows.Forms.Label Label_PasswordAgain;
        private System.Windows.Forms.Label Label_OldPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_ChangeInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_PasswordAgain;
    }
}