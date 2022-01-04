
namespace VideoRentalStore
{
    partial class Report
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
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.Panel_DashBoard = new System.Windows.Forms.Panel();
            this.Label_DashBoard = new System.Windows.Forms.Label();
            this.Panel_StoreStatus = new System.Windows.Forms.Panel();
            this.Panel_TotalProfit = new System.Windows.Forms.Panel();
            this.Elipse_TotalProfit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradiantPanel1 = new VideoRentalStore.GradiantPanel();
            this.Panel_Title.SuspendLayout();
            this.Panel_DashBoard.SuspendLayout();
            this.Panel_TotalProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.Controls.Add(this.Label_DashBoard);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(1044, 100);
            this.Panel_Title.TabIndex = 0;
            // 
            // Panel_DashBoard
            // 
            this.Panel_DashBoard.Controls.Add(this.Panel_TotalProfit);
            this.Panel_DashBoard.Controls.Add(this.Panel_StoreStatus);
            this.Panel_DashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_DashBoard.Location = new System.Drawing.Point(0, 100);
            this.Panel_DashBoard.Name = "Panel_DashBoard";
            this.Panel_DashBoard.Size = new System.Drawing.Size(1044, 561);
            this.Panel_DashBoard.TabIndex = 1;
            // 
            // Label_DashBoard
            // 
            this.Label_DashBoard.AutoSize = true;
            this.Label_DashBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DashBoard.ForeColor = System.Drawing.Color.White;
            this.Label_DashBoard.Location = new System.Drawing.Point(43, 29);
            this.Label_DashBoard.Name = "Label_DashBoard";
            this.Label_DashBoard.Size = new System.Drawing.Size(179, 45);
            this.Label_DashBoard.TabIndex = 0;
            this.Label_DashBoard.Text = "Dashboard";
            // 
            // Panel_StoreStatus
            // 
            this.Panel_StoreStatus.Location = new System.Drawing.Point(20, 10);
            this.Panel_StoreStatus.Name = "Panel_StoreStatus";
            this.Panel_StoreStatus.Size = new System.Drawing.Size(200, 100);
            this.Panel_StoreStatus.TabIndex = 1;
            // 
            // Panel_TotalProfit
            // 
            this.Panel_TotalProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Panel_TotalProfit.Controls.Add(this.gradiantPanel1);
            this.Panel_TotalProfit.Location = new System.Drawing.Point(20, 140);
            this.Panel_TotalProfit.Name = "Panel_TotalProfit";
            this.Panel_TotalProfit.Size = new System.Drawing.Size(200, 100);
            this.Panel_TotalProfit.TabIndex = 2;
            // 
            // Elipse_TotalProfit
            // 
            this.Elipse_TotalProfit.ElipseRadius = 10;
            this.Elipse_TotalProfit.TargetControl = this.Panel_TotalProfit;
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.Angle = 0F;
            this.gradiantPanel1.BackgroundImage = global::VideoRentalStore.Properties.Resources.Profit;
            this.gradiantPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gradiantPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradiantPanel1.Location = new System.Drawing.Point(30, 30);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(40, 40);
            this.gradiantPanel1.TabIndex = 0;
            this.gradiantPanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.Panel_DashBoard);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            this.Panel_DashBoard.ResumeLayout(false);
            this.Panel_TotalProfit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Label Label_DashBoard;
        private System.Windows.Forms.Panel Panel_DashBoard;
        private System.Windows.Forms.Panel Panel_TotalProfit;
        private System.Windows.Forms.Panel Panel_StoreStatus;
        private Bunifu.Framework.UI.BunifuElipse Elipse_TotalProfit;
        private GradiantPanel gradiantPanel1;
    }
}