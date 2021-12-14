
namespace VideoRentalStore
{
    partial class Account_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Label_AccountType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Switching = new System.Windows.Forms.Panel();
            this.Button_LogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_ChangePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_AccountInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_LogOut);
            this.panel1.Controls.Add(this.Button_ChangePassword);
            this.panel1.Controls.Add(this.Button_AccountInfo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Label_AccountType);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 244);
            this.panel4.TabIndex = 0;
            // 
            // Label_AccountType
            // 
            this.Label_AccountType.AutoSize = true;
            this.Label_AccountType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AccountType.ForeColor = System.Drawing.Color.White;
            this.Label_AccountType.Location = new System.Drawing.Point(97, 194);
            this.Label_AccountType.Name = "Label_AccountType";
            this.Label_AccountType.Size = new System.Drawing.Size(49, 25);
            this.Label_AccountType.TabIndex = 1;
            this.Label_AccountType.Text = "Staff";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 94);
            this.panel2.TabIndex = 1;
            // 
            // Panel_Switching
            // 
            this.Panel_Switching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Switching.Location = new System.Drawing.Point(259, 94);
            this.Panel_Switching.Name = "Panel_Switching";
            this.Panel_Switching.Size = new System.Drawing.Size(769, 528);
            this.Panel_Switching.TabIndex = 2;
            // 
            // Button_LogOut
            // 
            this.Button_LogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_LogOut.BorderRadius = 0;
            this.Button_LogOut.ButtonText = "Log Out";
            this.Button_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_LogOut.DisabledColor = System.Drawing.Color.Gray;
            this.Button_LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_LogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_LogOut.Iconimage = global::VideoRentalStore.Properties.Resources.log_out;
            this.Button_LogOut.Iconimage_right = null;
            this.Button_LogOut.Iconimage_right_Selected = null;
            this.Button_LogOut.Iconimage_Selected = null;
            this.Button_LogOut.IconMarginLeft = 0;
            this.Button_LogOut.IconMarginRight = 0;
            this.Button_LogOut.IconRightVisible = true;
            this.Button_LogOut.IconRightZoom = 0D;
            this.Button_LogOut.IconVisible = true;
            this.Button_LogOut.IconZoom = 50D;
            this.Button_LogOut.IsTab = false;
            this.Button_LogOut.Location = new System.Drawing.Point(0, 366);
            this.Button_LogOut.Name = "Button_LogOut";
            this.Button_LogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_LogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_LogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_LogOut.selected = false;
            this.Button_LogOut.Size = new System.Drawing.Size(259, 61);
            this.Button_LogOut.TabIndex = 3;
            this.Button_LogOut.Text = "Log Out";
            this.Button_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_LogOut.Textcolor = System.Drawing.Color.White;
            this.Button_LogOut.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LogOut.Click += new System.EventHandler(this.Button_LogOut_Click);
            // 
            // Button_ChangePassword
            // 
            this.Button_ChangePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_ChangePassword.BorderRadius = 0;
            this.Button_ChangePassword.ButtonText = "Change Password";
            this.Button_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.Button_ChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_ChangePassword.Iconimage = global::VideoRentalStore.Properties.Resources.refresh;
            this.Button_ChangePassword.Iconimage_right = null;
            this.Button_ChangePassword.Iconimage_right_Selected = null;
            this.Button_ChangePassword.Iconimage_Selected = null;
            this.Button_ChangePassword.IconMarginLeft = 0;
            this.Button_ChangePassword.IconMarginRight = 0;
            this.Button_ChangePassword.IconRightVisible = true;
            this.Button_ChangePassword.IconRightZoom = 0D;
            this.Button_ChangePassword.IconVisible = true;
            this.Button_ChangePassword.IconZoom = 50D;
            this.Button_ChangePassword.IsTab = false;
            this.Button_ChangePassword.Location = new System.Drawing.Point(0, 305);
            this.Button_ChangePassword.Name = "Button_ChangePassword";
            this.Button_ChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_ChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_ChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_ChangePassword.selected = false;
            this.Button_ChangePassword.Size = new System.Drawing.Size(259, 61);
            this.Button_ChangePassword.TabIndex = 2;
            this.Button_ChangePassword.Text = "Change Password";
            this.Button_ChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_ChangePassword.Textcolor = System.Drawing.Color.White;
            this.Button_ChangePassword.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ChangePassword.Click += new System.EventHandler(this.Button_ChangePassword_Click);
            // 
            // Button_AccountInfo
            // 
            this.Button_AccountInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_AccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_AccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_AccountInfo.BorderRadius = 0;
            this.Button_AccountInfo.ButtonText = "Account Infomation";
            this.Button_AccountInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AccountInfo.DisabledColor = System.Drawing.Color.Gray;
            this.Button_AccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AccountInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_AccountInfo.Iconimage = global::VideoRentalStore.Properties.Resources.information;
            this.Button_AccountInfo.Iconimage_right = null;
            this.Button_AccountInfo.Iconimage_right_Selected = null;
            this.Button_AccountInfo.Iconimage_Selected = null;
            this.Button_AccountInfo.IconMarginLeft = 0;
            this.Button_AccountInfo.IconMarginRight = 0;
            this.Button_AccountInfo.IconRightVisible = true;
            this.Button_AccountInfo.IconRightZoom = 0D;
            this.Button_AccountInfo.IconVisible = true;
            this.Button_AccountInfo.IconZoom = 50D;
            this.Button_AccountInfo.IsTab = false;
            this.Button_AccountInfo.Location = new System.Drawing.Point(0, 244);
            this.Button_AccountInfo.Name = "Button_AccountInfo";
            this.Button_AccountInfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_AccountInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Button_AccountInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_AccountInfo.selected = false;
            this.Button_AccountInfo.Size = new System.Drawing.Size(259, 61);
            this.Button_AccountInfo.TabIndex = 1;
            this.Button_AccountInfo.Text = "Account Infomation";
            this.Button_AccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_AccountInfo.Textcolor = System.Drawing.Color.White;
            this.Button_AccountInfo.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AccountInfo.Click += new System.EventHandler(this.Button_Account_Info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Account_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Switching);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account_Settings";
            this.Text = "Account_Settings";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel Panel_Switching;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_AccountType;
        private Bunifu.Framework.UI.BunifuFlatButton Button_ChangePassword;
        internal Bunifu.Framework.UI.BunifuFlatButton Button_AccountInfo;
        private Bunifu.Framework.UI.BunifuFlatButton Button_LogOut;
    }
}