
namespace VideoRentalStore
{
    partial class ShoppingCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Summary = new System.Windows.Forms.Panel();
            this.Panel_TotalProduct = new System.Windows.Forms.Panel();
            this.Label_ShowShippingCost = new System.Windows.Forms.Label();
            this.Label_ShowTotalProduct = new System.Windows.Forms.Label();
            this.Label_ShippingCost = new System.Windows.Forms.Label();
            this.Label_TotalProduct = new System.Windows.Forms.Label();
            this.Panel_Total = new System.Windows.Forms.Panel();
            this.Label_TotalCost = new System.Windows.Forms.Label();
            this.Panel_SummaryTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Payment = new System.Windows.Forms.Label();
            this.label_Product = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Summary.SuspendLayout();
            this.Panel_TotalProduct.SuspendLayout();
            this.Panel_Total.SuspendLayout();
            this.Panel_SummaryTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping cart items";
            // 
            // Panel_Summary
            // 
            this.Panel_Summary.Controls.Add(this.Panel_TotalProduct);
            this.Panel_Summary.Controls.Add(this.Panel_Total);
            this.Panel_Summary.Controls.Add(this.Panel_SummaryTitle);
            this.Panel_Summary.Location = new System.Drawing.Point(720, 112);
            this.Panel_Summary.Name = "Panel_Summary";
            this.Panel_Summary.Size = new System.Drawing.Size(299, 355);
            this.Panel_Summary.TabIndex = 1;
            // 
            // Panel_TotalProduct
            // 
            this.Panel_TotalProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Panel_TotalProduct.Controls.Add(this.Label_ShowShippingCost);
            this.Panel_TotalProduct.Controls.Add(this.Label_ShowTotalProduct);
            this.Panel_TotalProduct.Controls.Add(this.Label_ShippingCost);
            this.Panel_TotalProduct.Controls.Add(this.Label_TotalProduct);
            this.Panel_TotalProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_TotalProduct.Location = new System.Drawing.Point(0, 63);
            this.Panel_TotalProduct.Name = "Panel_TotalProduct";
            this.Panel_TotalProduct.Size = new System.Drawing.Size(299, 227);
            this.Panel_TotalProduct.TabIndex = 2;
            // 
            // Label_ShowShippingCost
            // 
            this.Label_ShowShippingCost.AutoSize = true;
            this.Label_ShowShippingCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowShippingCost.ForeColor = System.Drawing.Color.White;
            this.Label_ShowShippingCost.Location = new System.Drawing.Point(19, 136);
            this.Label_ShowShippingCost.Name = "Label_ShowShippingCost";
            this.Label_ShowShippingCost.Size = new System.Drawing.Size(40, 21);
            this.Label_ShowShippingCost.TabIndex = 4;
            this.Label_ShowShippingCost.Text = "Free";
            // 
            // Label_ShowTotalProduct
            // 
            this.Label_ShowTotalProduct.AutoSize = true;
            this.Label_ShowTotalProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShowTotalProduct.ForeColor = System.Drawing.Color.White;
            this.Label_ShowTotalProduct.Location = new System.Drawing.Point(19, 57);
            this.Label_ShowTotalProduct.Name = "Label_ShowTotalProduct";
            this.Label_ShowTotalProduct.Size = new System.Drawing.Size(105, 21);
            this.Label_ShowTotalProduct.TabIndex = 3;
            this.Label_ShowTotalProduct.Text = "500 000 VND";
            // 
            // Label_ShippingCost
            // 
            this.Label_ShippingCost.AutoSize = true;
            this.Label_ShippingCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShippingCost.ForeColor = System.Drawing.Color.White;
            this.Label_ShippingCost.Location = new System.Drawing.Point(19, 95);
            this.Label_ShippingCost.Name = "Label_ShippingCost";
            this.Label_ShippingCost.Size = new System.Drawing.Size(116, 21);
            this.Label_ShippingCost.TabIndex = 2;
            this.Label_ShippingCost.Text = "Shipping Cost:";
            // 
            // Label_TotalProduct
            // 
            this.Label_TotalProduct.AutoSize = true;
            this.Label_TotalProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalProduct.ForeColor = System.Drawing.Color.White;
            this.Label_TotalProduct.Location = new System.Drawing.Point(19, 17);
            this.Label_TotalProduct.Name = "Label_TotalProduct";
            this.Label_TotalProduct.Size = new System.Drawing.Size(112, 21);
            this.Label_TotalProduct.TabIndex = 1;
            this.Label_TotalProduct.Text = "Total product:";
            // 
            // Panel_Total
            // 
            this.Panel_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Panel_Total.Controls.Add(this.Label_TotalCost);
            this.Panel_Total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Total.Location = new System.Drawing.Point(0, 290);
            this.Panel_Total.Name = "Panel_Total";
            this.Panel_Total.Size = new System.Drawing.Size(299, 65);
            this.Panel_Total.TabIndex = 1;
            // 
            // Label_TotalCost
            // 
            this.Label_TotalCost.AutoSize = true;
            this.Label_TotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalCost.ForeColor = System.Drawing.Color.White;
            this.Label_TotalCost.Location = new System.Drawing.Point(19, 24);
            this.Label_TotalCost.Name = "Label_TotalCost";
            this.Label_TotalCost.Size = new System.Drawing.Size(49, 21);
            this.Label_TotalCost.TabIndex = 0;
            this.Label_TotalCost.Text = "Total:";
            // 
            // Panel_SummaryTitle
            // 
            this.Panel_SummaryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Panel_SummaryTitle.Controls.Add(this.label2);
            this.Panel_SummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SummaryTitle.Location = new System.Drawing.Point(0, 0);
            this.Panel_SummaryTitle.Name = "Panel_SummaryTitle";
            this.Panel_SummaryTitle.Size = new System.Drawing.Size(299, 63);
            this.Panel_SummaryTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Summary";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Label_Price);
            this.panel2.Controls.Add(this.Label_Payment);
            this.panel2.Controls.Add(this.label_Product);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 588);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.White;
            this.Label_Price.Location = new System.Drawing.Point(563, 20);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(59, 30);
            this.Label_Price.TabIndex = 3;
            this.Label_Price.Text = "Price";
            this.Label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Payment
            // 
            this.Label_Payment.AutoSize = true;
            this.Label_Payment.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Payment.ForeColor = System.Drawing.Color.White;
            this.Label_Payment.Location = new System.Drawing.Point(390, 20);
            this.Label_Payment.Name = "Label_Payment";
            this.Label_Payment.Size = new System.Drawing.Size(96, 30);
            this.Label_Payment.TabIndex = 2;
            this.Label_Payment.Text = "Payment";
            this.Label_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Payment.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.ForeColor = System.Drawing.Color.White;
            this.label_Product.Location = new System.Drawing.Point(15, 20);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(89, 30);
            this.label_Product.TabIndex = 1;
            this.label_Product.Text = "Product";
            this.label_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Checkout";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::VideoRentalStore.Properties.Resources.checkout;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(720, 473);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(299, 55);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Checkout";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1044, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Panel_Summary);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.Panel_Summary.ResumeLayout(false);
            this.Panel_TotalProduct.ResumeLayout(false);
            this.Panel_TotalProduct.PerformLayout();
            this.Panel_Total.ResumeLayout(false);
            this.Panel_Total.PerformLayout();
            this.Panel_SummaryTitle.ResumeLayout(false);
            this.Panel_SummaryTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Summary;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel Panel_Total;
        private System.Windows.Forms.Panel Panel_SummaryTitle;
        private System.Windows.Forms.Panel Panel_TotalProduct;
        private System.Windows.Forms.Label Label_ShowShippingCost;
        private System.Windows.Forms.Label Label_ShowTotalProduct;
        private System.Windows.Forms.Label Label_ShippingCost;
        private System.Windows.Forms.Label Label_TotalProduct;
        private System.Windows.Forms.Label Label_TotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label Label_Payment;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Panel panel1;
    }
}