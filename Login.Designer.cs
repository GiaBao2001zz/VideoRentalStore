
namespace VideoRentalStore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextBox_UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Elipse_Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_StoreInfo = new System.Windows.Forms.Panel();
            this.Picture_Store_SM3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Picture_Store_SM2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Picture_Store_SM1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label_StoreInfo = new System.Windows.Forms.Label();
            this.Label_NameOfStore = new System.Windows.Forms.Label();
            this.Picture_StoreLogo = new System.Windows.Forms.PictureBox();
            this.TextBox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CheckBox_RememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Label_RememberMe = new System.Windows.Forms.Label();
            this.Label_TitleLogin = new System.Windows.Forms.Label();
            this.Label_DontHaveAccount = new System.Windows.Forms.Label();
            this.Label_CreateAccount = new System.Windows.Forms.Label();
            this.Label_ForgotPass = new System.Windows.Forms.Label();
            this.DragControl_Login = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Button_CancelLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panel_StoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_StoreLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_UserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_UserName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_UserName.HintText = "Username";
            this.TextBox_UserName.isPassword = false;
            this.TextBox_UserName.LineFocusedColor = System.Drawing.Color.Red;
            this.TextBox_UserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_UserName.LineMouseHoverColor = System.Drawing.Color.Red;
            this.TextBox_UserName.LineThickness = 4;
            this.TextBox_UserName.Location = new System.Drawing.Point(611, 311);
            this.TextBox_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(609, 54);
            this.TextBox_UserName.TabIndex = 1;
            this.TextBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_UserName.OnValueChanged += new System.EventHandler(this.UserName_OnValueChanged);
            // 
            // Elipse_Login
            // 
            this.Elipse_Login.ElipseRadius = 20;
            this.Elipse_Login.TargetControl = this;
            // 
            // Panel_StoreInfo
            // 
            this.Panel_StoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Panel_StoreInfo.Controls.Add(this.Picture_Store_SM3);
            this.Panel_StoreInfo.Controls.Add(this.Picture_Store_SM2);
            this.Panel_StoreInfo.Controls.Add(this.Picture_Store_SM1);
            this.Panel_StoreInfo.Controls.Add(this.Label_StoreInfo);
            this.Panel_StoreInfo.Controls.Add(this.Label_NameOfStore);
            this.Panel_StoreInfo.Controls.Add(this.Picture_StoreLogo);
            this.Panel_StoreInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_StoreInfo.Location = new System.Drawing.Point(0, 0);
            this.Panel_StoreInfo.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_StoreInfo.Name = "Panel_StoreInfo";
            this.Panel_StoreInfo.Size = new System.Drawing.Size(479, 703);
            this.Panel_StoreInfo.TabIndex = 0;
            // 
            // Picture_Store_SM3
            // 
            this.Picture_Store_SM3.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Store_SM3.Image = global::VideoRentalStore.Properties.Resources.instagram;
            this.Picture_Store_SM3.ImageActive = null;
            this.Picture_Store_SM3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Picture_Store_SM3.Location = new System.Drawing.Point(343, 561);
            this.Picture_Store_SM3.Margin = new System.Windows.Forms.Padding(4);
            this.Picture_Store_SM3.Name = "Picture_Store_SM3";
            this.Picture_Store_SM3.Size = new System.Drawing.Size(95, 87);
            this.Picture_Store_SM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Store_SM3.TabIndex = 4;
            this.Picture_Store_SM3.TabStop = false;
            this.Picture_Store_SM3.Zoom = 10;
            // 
            // Picture_Store_SM2
            // 
            this.Picture_Store_SM2.BackColor = System.Drawing.Color.SeaGreen;
            this.Picture_Store_SM2.Image = global::VideoRentalStore.Properties.Resources.twitter;
            this.Picture_Store_SM2.ImageActive = null;
            this.Picture_Store_SM2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Picture_Store_SM2.Location = new System.Drawing.Point(191, 561);
            this.Picture_Store_SM2.Margin = new System.Windows.Forms.Padding(4);
            this.Picture_Store_SM2.Name = "Picture_Store_SM2";
            this.Picture_Store_SM2.Size = new System.Drawing.Size(95, 87);
            this.Picture_Store_SM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Store_SM2.TabIndex = 3;
            this.Picture_Store_SM2.TabStop = false;
            this.Picture_Store_SM2.Zoom = 10;
            // 
            // Picture_Store_SM1
            // 
            this.Picture_Store_SM1.BackColor = System.Drawing.Color.SeaGreen;
            this.Picture_Store_SM1.Image = global::VideoRentalStore.Properties.Resources.facebook;
            this.Picture_Store_SM1.ImageActive = null;
            this.Picture_Store_SM1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Picture_Store_SM1.Location = new System.Drawing.Point(44, 561);
            this.Picture_Store_SM1.Margin = new System.Windows.Forms.Padding(4);
            this.Picture_Store_SM1.Name = "Picture_Store_SM1";
            this.Picture_Store_SM1.Size = new System.Drawing.Size(95, 87);
            this.Picture_Store_SM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Store_SM1.TabIndex = 2;
            this.Picture_Store_SM1.TabStop = false;
            this.Picture_Store_SM1.Zoom = 10;
            // 
            // Label_StoreInfo
            // 
            this.Label_StoreInfo.AutoSize = true;
            this.Label_StoreInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_StoreInfo.ForeColor = System.Drawing.Color.White;
            this.Label_StoreInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_StoreInfo.Location = new System.Drawing.Point(80, 474);
            this.Label_StoreInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_StoreInfo.Name = "Label_StoreInfo";
            this.Label_StoreInfo.Size = new System.Drawing.Size(280, 56);
            this.Label_StoreInfo.TabIndex = 1;
            this.Label_StoreInfo.Text = "Want to know more about us? \r\nCheck out our social media!";
            // 
            // Label_NameOfStore
            // 
            this.Label_NameOfStore.AutoSize = true;
            this.Label_NameOfStore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Underline);
            this.Label_NameOfStore.ForeColor = System.Drawing.Color.White;
            this.Label_NameOfStore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_NameOfStore.Location = new System.Drawing.Point(79, 229);
            this.Label_NameOfStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NameOfStore.Name = "Label_NameOfStore";
            this.Label_NameOfStore.Size = new System.Drawing.Size(280, 162);
            this.Label_NameOfStore.TabIndex = 0;
            this.Label_NameOfStore.Text = "Name of \r\nthe store";
            this.Label_NameOfStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Picture_StoreLogo
            // 
            this.Picture_StoreLogo.Image = global::VideoRentalStore.Properties.Resources.Logo;
            this.Picture_StoreLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Picture_StoreLogo.Location = new System.Drawing.Point(133, 41);
            this.Picture_StoreLogo.Margin = new System.Windows.Forms.Padding(4);
            this.Picture_StoreLogo.Name = "Picture_StoreLogo";
            this.Picture_StoreLogo.Size = new System.Drawing.Size(183, 161);
            this.Picture_StoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_StoreLogo.TabIndex = 0;
            this.Picture_StoreLogo.TabStop = false;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Password.HintText = "Password";
            this.TextBox_Password.isPassword = true;
            this.TextBox_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Password.LineThickness = 4;
            this.TextBox_Password.Location = new System.Drawing.Point(611, 399);
            this.TextBox_Password.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(609, 54);
            this.TextBox_Password.TabIndex = 2;
            this.TextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            // 
            // CheckBox_RememberMe
            // 
            this.CheckBox_RememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBox_RememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckBox_RememberMe.Checked = true;
            this.CheckBox_RememberMe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckBox_RememberMe.ForeColor = System.Drawing.Color.White;
            this.CheckBox_RememberMe.Location = new System.Drawing.Point(611, 516);
            this.CheckBox_RememberMe.Margin = new System.Windows.Forms.Padding(5);
            this.CheckBox_RememberMe.Name = "CheckBox_RememberMe";
            this.CheckBox_RememberMe.Size = new System.Drawing.Size(20, 20);
            this.CheckBox_RememberMe.TabIndex = 0;
            this.CheckBox_RememberMe.OnChange += new System.EventHandler(this.CheckBox_RememberMe_OnChange);
            // 
            // Label_RememberMe
            // 
            this.Label_RememberMe.AutoSize = true;
            this.Label_RememberMe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_RememberMe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_RememberMe.Location = new System.Drawing.Point(645, 513);
            this.Label_RememberMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_RememberMe.Name = "Label_RememberMe";
            this.Label_RememberMe.Size = new System.Drawing.Size(139, 28);
            this.Label_RememberMe.TabIndex = 0;
            this.Label_RememberMe.Text = "Remember Me";
            this.Label_RememberMe.Click += new System.EventHandler(this.Label_RememberMe_Click);
            // 
            // Label_TitleLogin
            // 
            this.Label_TitleLogin.AutoSize = true;
            this.Label_TitleLogin.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.Label_TitleLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_TitleLogin.Location = new System.Drawing.Point(597, 76);
            this.Label_TitleLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TitleLogin.Name = "Label_TitleLogin";
            this.Label_TitleLogin.Size = new System.Drawing.Size(163, 72);
            this.Label_TitleLogin.TabIndex = 0;
            this.Label_TitleLogin.Text = "Login";
            this.Label_TitleLogin.Click += new System.EventHandler(this.Label_TitleLogin_Click);
            // 
            // Label_DontHaveAccount
            // 
            this.Label_DontHaveAccount.AutoSize = true;
            this.Label_DontHaveAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label_DontHaveAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_DontHaveAccount.Location = new System.Drawing.Point(605, 176);
            this.Label_DontHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DontHaveAccount.Name = "Label_DontHaveAccount";
            this.Label_DontHaveAccount.Size = new System.Drawing.Size(315, 28);
            this.Label_DontHaveAccount.TabIndex = 0;
            this.Label_DontHaveAccount.Text = "Don\'t have an account? Create one";
            // 
            // Label_CreateAccount
            // 
            this.Label_CreateAccount.AutoSize = true;
            this.Label_CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_CreateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.Label_CreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.Label_CreateAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_CreateAccount.Location = new System.Drawing.Point(947, 176);
            this.Label_CreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CreateAccount.Name = "Label_CreateAccount";
            this.Label_CreateAccount.Size = new System.Drawing.Size(72, 28);
            this.Label_CreateAccount.TabIndex = 0;
            this.Label_CreateAccount.Text = "Sign in";
            this.Label_CreateAccount.Click += new System.EventHandler(this.Label_CreateAccount_Click);
            // 
            // Label_ForgotPass
            // 
            this.Label_ForgotPass.AutoSize = true;
            this.Label_ForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ForgotPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
            this.Label_ForgotPass.ForeColor = System.Drawing.Color.Blue;
            this.Label_ForgotPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_ForgotPass.Location = new System.Drawing.Point(1041, 513);
            this.Label_ForgotPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ForgotPass.Name = "Label_ForgotPass";
            this.Label_ForgotPass.Size = new System.Drawing.Size(169, 28);
            this.Label_ForgotPass.TabIndex = 3;
            this.Label_ForgotPass.Text = "Forgot password?";
            // 
            // DragControl_Login
            // 
            this.DragControl_Login.Fixed = true;
            this.DragControl_Login.Horizontal = true;
            this.DragControl_Login.TargetControl = this;
            this.DragControl_Login.Vertical = true;
            // 
            // Button_CancelLogin
            // 
            this.Button_CancelLogin.ActiveBorderThickness = 1;
            this.Button_CancelLogin.ActiveCornerRadius = 20;
            this.Button_CancelLogin.ActiveFillColor = System.Drawing.Color.Red;
            this.Button_CancelLogin.ActiveForecolor = System.Drawing.Color.White;
            this.Button_CancelLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.Button_CancelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_CancelLogin.BackgroundImage")));
            this.Button_CancelLogin.ButtonText = "Cancel";
            this.Button_CancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CancelLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_CancelLogin.ForeColor = System.Drawing.Color.Red;
            this.Button_CancelLogin.IdleBorderThickness = 1;
            this.Button_CancelLogin.IdleCornerRadius = 20;
            this.Button_CancelLogin.IdleFillColor = System.Drawing.Color.White;
            this.Button_CancelLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.Location = new System.Drawing.Point(945, 585);
            this.Button_CancelLogin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_CancelLogin.Name = "Button_CancelLogin";
            this.Button_CancelLogin.Size = new System.Drawing.Size(275, 64);
            this.Button_CancelLogin.TabIndex = 4;
            this.Button_CancelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_CancelLogin.Click += new System.EventHandler(this.Button_CancelLogin_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.ActiveBorderThickness = 1;
            this.Button_Login.ActiveCornerRadius = 20;
            this.Button_Login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Login.BackgroundImage")));
            this.Button_Login.ButtonText = "Log In";
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Button_Login.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.IdleBorderThickness = 1;
            this.Button_Login.IdleCornerRadius = 20;
            this.Button_Login.IdleFillColor = System.Drawing.Color.White;
            this.Button_Login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.Location = new System.Drawing.Point(593, 585);
            this.Button_Login.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(275, 64);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(this.Button_CancelLogin);
            this.Controls.Add(this.Label_ForgotPass);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Label_CreateAccount);
            this.Controls.Add(this.Label_DontHaveAccount);
            this.Controls.Add(this.Label_TitleLogin);
            this.Controls.Add(this.Label_RememberMe);
            this.Controls.Add(this.CheckBox_RememberMe);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Panel_StoreInfo);
            this.Controls.Add(this.TextBox_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Panel_StoreInfo.ResumeLayout(false);
            this.Panel_StoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_StoreLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_UserName;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Login;
        private System.Windows.Forms.Panel Panel_StoreInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Password;
        private System.Windows.Forms.Label Label_DontHaveAccount;
        private System.Windows.Forms.Label Label_TitleLogin;
        private System.Windows.Forms.Label Label_RememberMe;
        private Bunifu.Framework.UI.BunifuCheckbox CheckBox_RememberMe;
        private System.Windows.Forms.Label Label_CreateAccount;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Login;
        private Bunifu.Framework.UI.BunifuImageButton Picture_Store_SM1;
        private System.Windows.Forms.Label Label_StoreInfo;
        private System.Windows.Forms.Label Label_NameOfStore;
        private System.Windows.Forms.PictureBox Picture_StoreLogo;
        private System.Windows.Forms.Label Label_ForgotPass;
        private Bunifu.Framework.UI.BunifuImageButton Picture_Store_SM3;
        private Bunifu.Framework.UI.BunifuImageButton Picture_Store_SM2;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_CancelLogin;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_Login;
    }
}

