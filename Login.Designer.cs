
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CheckBox_RememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Label_RememberMe = new System.Windows.Forms.Label();
            this.Label_TitleLogin = new System.Windows.Forms.Label();
            this.Label_DontHaveAccount = new System.Windows.Forms.Label();
            this.Label_CreateAccount = new System.Windows.Forms.Label();
            this.Label_NameOfStore = new System.Windows.Forms.Label();
            this.Label_StoreInfo = new System.Windows.Forms.Label();
            this.Label_ForgotPass = new System.Windows.Forms.Label();
            this.Button_CancelLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Picture_Store_SM3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Picture_Store_SM2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Picture_Store_SM1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Picture_StoreLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_StoreLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_UserName, "TextBox_UserName");
            this.TextBox_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_UserName.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_UserName.HintText = "Username";
            this.TextBox_UserName.isPassword = false;
            this.TextBox_UserName.LineFocusedColor = System.Drawing.Color.Red;
            this.TextBox_UserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_UserName.LineMouseHoverColor = System.Drawing.Color.Red;
            this.TextBox_UserName.LineThickness = 4;
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_UserName.OnValueChanged += new System.EventHandler(this.UserName_OnValueChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.Picture_Store_SM3);
            this.panel1.Controls.Add(this.Picture_Store_SM2);
            this.panel1.Controls.Add(this.Picture_Store_SM1);
            this.panel1.Controls.Add(this.Label_StoreInfo);
            this.panel1.Controls.Add(this.Label_NameOfStore);
            this.panel1.Controls.Add(this.Picture_StoreLogo);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBox_Password, "TextBox_Password");
            this.TextBox_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox_Password.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Password.HintText = "Password";
            this.TextBox_Password.isPassword = true;
            this.TextBox_Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBox_Password.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox_Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBox_Password.LineThickness = 4;
            this.TextBox_Password.Name = "TextBox_Password";
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
            resources.ApplyResources(this.CheckBox_RememberMe, "CheckBox_RememberMe");
            this.CheckBox_RememberMe.Name = "CheckBox_RememberMe";
            // 
            // Label_RememberMe
            // 
            resources.ApplyResources(this.Label_RememberMe, "Label_RememberMe");
            this.Label_RememberMe.Name = "Label_RememberMe";
            // 
            // Label_TitleLogin
            // 
            resources.ApplyResources(this.Label_TitleLogin, "Label_TitleLogin");
            this.Label_TitleLogin.Name = "Label_TitleLogin";
            this.Label_TitleLogin.Click += new System.EventHandler(this.Label_TitleLogin_Click);
            // 
            // Label_DontHaveAccount
            // 
            resources.ApplyResources(this.Label_DontHaveAccount, "Label_DontHaveAccount");
            this.Label_DontHaveAccount.Name = "Label_DontHaveAccount";
            // 
            // Label_CreateAccount
            // 
            resources.ApplyResources(this.Label_CreateAccount, "Label_CreateAccount");
            this.Label_CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_CreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.Label_CreateAccount.Name = "Label_CreateAccount";
            // 
            // Label_NameOfStore
            // 
            resources.ApplyResources(this.Label_NameOfStore, "Label_NameOfStore");
            this.Label_NameOfStore.ForeColor = System.Drawing.Color.White;
            this.Label_NameOfStore.Name = "Label_NameOfStore";
            // 
            // Label_StoreInfo
            // 
            resources.ApplyResources(this.Label_StoreInfo, "Label_StoreInfo");
            this.Label_StoreInfo.ForeColor = System.Drawing.Color.White;
            this.Label_StoreInfo.Name = "Label_StoreInfo";
            // 
            // Label_ForgotPass
            // 
            resources.ApplyResources(this.Label_ForgotPass, "Label_ForgotPass");
            this.Label_ForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ForgotPass.ForeColor = System.Drawing.Color.Blue;
            this.Label_ForgotPass.Name = "Label_ForgotPass";
            // 
            // Button_CancelLogin
            // 
            this.Button_CancelLogin.ActiveBorderThickness = 1;
            this.Button_CancelLogin.ActiveCornerRadius = 20;
            this.Button_CancelLogin.ActiveFillColor = System.Drawing.Color.Red;
            this.Button_CancelLogin.ActiveForecolor = System.Drawing.Color.White;
            this.Button_CancelLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Button_CancelLogin, "Button_CancelLogin");
            this.Button_CancelLogin.ButtonText = "Cancel";
            this.Button_CancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CancelLogin.ForeColor = System.Drawing.Color.Red;
            this.Button_CancelLogin.IdleBorderThickness = 1;
            this.Button_CancelLogin.IdleCornerRadius = 20;
            this.Button_CancelLogin.IdleFillColor = System.Drawing.Color.White;
            this.Button_CancelLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_CancelLogin.Name = "Button_CancelLogin";
            this.Button_CancelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Login
            // 
            this.Button_Login.ActiveBorderThickness = 1;
            this.Button_Login.ActiveCornerRadius = 20;
            this.Button_Login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.ActiveForecolor = System.Drawing.Color.White;
            this.Button_Login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Button_Login, "Button_Login");
            this.Button_Login.ButtonText = "Log In";
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.IdleBorderThickness = 1;
            this.Button_Login.IdleCornerRadius = 20;
            this.Button_Login.IdleFillColor = System.Drawing.Color.White;
            this.Button_Login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Picture_Store_SM3
            // 
            this.Picture_Store_SM3.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Store_SM3.Image = global::VideoRentalStore.Properties.Resources.instagram;
            this.Picture_Store_SM3.ImageActive = null;
            resources.ApplyResources(this.Picture_Store_SM3, "Picture_Store_SM3");
            this.Picture_Store_SM3.Name = "Picture_Store_SM3";
            this.Picture_Store_SM3.TabStop = false;
            this.Picture_Store_SM3.Zoom = 10;
            // 
            // Picture_Store_SM2
            // 
            this.Picture_Store_SM2.BackColor = System.Drawing.Color.SeaGreen;
            this.Picture_Store_SM2.Image = global::VideoRentalStore.Properties.Resources.twitter;
            this.Picture_Store_SM2.ImageActive = null;
            resources.ApplyResources(this.Picture_Store_SM2, "Picture_Store_SM2");
            this.Picture_Store_SM2.Name = "Picture_Store_SM2";
            this.Picture_Store_SM2.TabStop = false;
            this.Picture_Store_SM2.Zoom = 10;
            // 
            // Picture_Store_SM1
            // 
            this.Picture_Store_SM1.BackColor = System.Drawing.Color.SeaGreen;
            this.Picture_Store_SM1.Image = global::VideoRentalStore.Properties.Resources.facebook;
            this.Picture_Store_SM1.ImageActive = null;
            resources.ApplyResources(this.Picture_Store_SM1, "Picture_Store_SM1");
            this.Picture_Store_SM1.Name = "Picture_Store_SM1";
            this.Picture_Store_SM1.TabStop = false;
            this.Picture_Store_SM1.Zoom = 10;
            // 
            // Picture_StoreLogo
            // 
            this.Picture_StoreLogo.Image = global::VideoRentalStore.Properties.Resources.Logo;
            resources.ApplyResources(this.Picture_StoreLogo, "Picture_StoreLogo");
            this.Picture_StoreLogo.Name = "Picture_StoreLogo";
            this.Picture_StoreLogo.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_CancelLogin);
            this.Controls.Add(this.Label_ForgotPass);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Label_CreateAccount);
            this.Controls.Add(this.Label_DontHaveAccount);
            this.Controls.Add(this.Label_TitleLogin);
            this.Controls.Add(this.Label_RememberMe);
            this.Controls.Add(this.CheckBox_RememberMe);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBox_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Store_SM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_StoreLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_UserName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
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
    }
}

