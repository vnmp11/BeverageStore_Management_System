
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
            this.pB_ProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Price
            // 
            this.lb_Price.BackColor = System.Drawing.Color.Transparent;
            this.lb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_Price.Location = new System.Drawing.Point(35, 128);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(68, 18);
            this.lb_Price.TabIndex = 87;
            this.lb_Price.Text = "12000";
            this.lb_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Price.TextChanged += new System.EventHandler(this.lb_Price_TextChanged);
            this.lb_Price.Click += new System.EventHandler(this.lb_Price_Click);
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(19, 106);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(95, 26);
            this.lb_NameProduct.TabIndex = 86;
            this.lb_NameProduct.Text = "Coca cola";
            this.lb_NameProduct.Click += new System.EventHandler(this.lb_NameProduct_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pB_ProductImage
            // 
            this.pB_ProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pB_ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pB_ProductImage.Image")));
            this.pB_ProductImage.Location = new System.Drawing.Point(21, 10);
            this.pB_ProductImage.Name = "pB_ProductImage";
            this.pB_ProductImage.Size = new System.Drawing.Size(82, 93);
            this.pB_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_ProductImage.TabIndex = 85;
            this.pB_ProductImage.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.pB_ProductImage);
            this.Controls.Add(this.lb_NameProduct);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(130, 160);
            this.Load += new System.EventHandler(this.Product_Load);
            this.Click += new System.EventHandler(this.Product_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label lb_Price;
        public System.Windows.Forms.Label lb_NameProduct;
        public System.Windows.Forms.PictureBox pB_ProductImage;
    }
}
