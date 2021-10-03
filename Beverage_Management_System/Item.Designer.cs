
namespace Beverage_Management_System
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_NameProduct = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pB_ProductImage = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(83, 19);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(197, 26);
            this.lb_NameProduct.TabIndex = 87;
            this.lb_NameProduct.Text = "Coca cola";
            this.lb_NameProduct.Click += new System.EventHandler(this.lb_NameProduct_Click);
            // 
            // lb_price
            // 
            this.lb_price.BackColor = System.Drawing.Color.Transparent;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.Color.DimGray;
            this.lb_price.Location = new System.Drawing.Point(83, 50);
            this.lb_price.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(95, 26);
            this.lb_price.TabIndex = 87;
            this.lb_price.Text = "10000";
            this.lb_price.TextChanged += new System.EventHandler(this.lb_price_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(217, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 87;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_total.Location = new System.Drawing.Point(266, 48);
            this.lb_total.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(95, 26);
            this.lb_total.TabIndex = 87;
            this.lb_total.Text = "10000";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_total.TextChanged += new System.EventHandler(this.lb_total_TextChanged);
            // 
            // lb_quantity
            // 
            this.lb_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_quantity.Location = new System.Drawing.Point(236, 48);
            this.lb_quantity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(24, 26);
            this.lb_quantity.TabIndex = 87;
            this.lb_quantity.Text = "2";
            this.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pB_ProductImage);
            this.guna2Panel1.Controls.Add(this.lb_total);
            this.guna2Panel1.Controls.Add(this.lb_NameProduct);
            this.guna2Panel1.Controls.Add(this.lb_quantity);
            this.guna2Panel1.Controls.Add(this.lb_price);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(377, 98);
            this.guna2Panel1.TabIndex = 88;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pB_ProductImage
            // 
            this.pB_ProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pB_ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pB_ProductImage.Image")));
            this.pB_ProductImage.Location = new System.Drawing.Point(21, 15);
            this.pB_ProductImage.Name = "pB_ProductImage";
            this.pB_ProductImage.Size = new System.Drawing.Size(56, 61);
            this.pB_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_ProductImage.TabIndex = 88;
            this.pB_ProductImage.TabStop = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(377, 98);
            this.Load += new System.EventHandler(this.Item_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label lb_NameProduct;
        public System.Windows.Forms.Label lb_total;
        public System.Windows.Forms.Label lb_price;
        public System.Windows.Forms.Label lb_quantity;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public System.Windows.Forms.PictureBox pB_ProductImage;
    }
}
