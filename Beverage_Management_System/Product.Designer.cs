
namespace Beverage_Management_System
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_NameProduct = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pB_ProductImage = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.BackColor = System.Drawing.Color.Transparent;
            this.lb_Price.Font = new System.Drawing.Font("Poppins SemiBold", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_Price.Location = new System.Drawing.Point(45, 117);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(56, 26);
            this.lb_Price.TabIndex = 87;
            this.lb_Price.Text = "12000";
            this.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Price.Click += new System.EventHandler(this.lb_Price_Click);
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.AutoSize = true;
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Poppins", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(16, 93);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(82, 25);
            this.lb_NameProduct.TabIndex = 86;
            this.lb_NameProduct.Text = "Coca cola";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.pB_ProductImage);
            this.guna2Panel1.Controls.Add(this.lb_Price);
            this.guna2Panel1.Controls.Add(this.lb_NameProduct);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(114, 144);
            this.guna2Panel1.TabIndex = 88;
            // 
            // pB_ProductImage
            // 
            this.pB_ProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pB_ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pB_ProductImage.Image")));
            this.pB_ProductImage.Location = new System.Drawing.Point(19, 10);
            this.pB_ProductImage.Name = "pB_ProductImage";
            this.pB_ProductImage.Size = new System.Drawing.Size(78, 80);
            this.pB_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_ProductImage.TabIndex = 85;
            this.pB_ProductImage.TabStop = false;
            this.pB_ProductImage.Click += new System.EventHandler(this.pB_ProductImage_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Product";
            this.Size = new System.Drawing.Size(120, 150);
            this.Click += new System.EventHandler(this.Product_Click);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_NameProduct;
        private System.Windows.Forms.PictureBox pB_ProductImage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
