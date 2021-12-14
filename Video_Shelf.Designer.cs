
namespace VideoRentalStore
{
    partial class Video_Shelf
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
            this.Panel_ControlButton = new System.Windows.Forms.Panel();
            this.Panel_ShowVideo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_ControlButton
            // 
            this.Panel_ControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Panel_ControlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_ControlButton.Location = new System.Drawing.Point(0, 562);
            this.Panel_ControlButton.Name = "Panel_ControlButton";
            this.Panel_ControlButton.Size = new System.Drawing.Size(1028, 60);
            this.Panel_ControlButton.TabIndex = 0;
            // 
            // Panel_ShowVideo
            // 
            this.Panel_ShowVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Panel_ShowVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ShowVideo.Location = new System.Drawing.Point(0, 0);
            this.Panel_ShowVideo.Name = "Panel_ShowVideo";
            this.Panel_ShowVideo.Size = new System.Drawing.Size(1028, 562);
            this.Panel_ShowVideo.TabIndex = 1;
            // 
            // Video_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.Panel_ShowVideo);
            this.Controls.Add(this.Panel_ControlButton);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Video_Shelf";
            this.Text = "Video_Shelf";
            this.Load += new System.EventHandler(this.Video_Shelf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_ControlButton;
        private System.Windows.Forms.Panel Panel_ShowVideo;
    }
}