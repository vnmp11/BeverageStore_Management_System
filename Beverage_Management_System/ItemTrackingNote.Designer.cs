
namespace Beverage_Management_System
{
    partial class ItemTrackingNote
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
            this.lb_quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ID_Title = new System.Windows.Forms.Label();
            this.lb_NameProduct = new System.Windows.Forms.Label();
            this.lb_ID_Product = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lb_quantity
            // 
            this.lb_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_quantity.Location = new System.Drawing.Point(333, 51);
            this.lb_quantity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(54, 32);
            this.lb_quantity.TabIndex = 95;
            this.lb_quantity.Text = "2";
            this.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(313, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 32);
            this.label2.TabIndex = 96;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ID_Title
            // 
            this.lb_ID_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_ID_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lb_ID_Title.Location = new System.Drawing.Point(27, 56);
            this.lb_ID_Title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.lb_ID_Title.Name = "lb_ID_Title";
            this.lb_ID_Title.Size = new System.Drawing.Size(172, 32);
            this.lb_ID_Title.TabIndex = 94;
            this.lb_ID_Title.Text = "ID Products:";
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(27, 18);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(360, 32);
            this.lb_NameProduct.TabIndex = 93;
            this.lb_NameProduct.Text = "Coca cola";
            // 
            // lb_ID_Product
            // 
            this.lb_ID_Product.BackColor = System.Drawing.Color.Transparent;
            this.lb_ID_Product.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_Product.ForeColor = System.Drawing.Color.DimGray;
            this.lb_ID_Product.Location = new System.Drawing.Point(154, 55);
            this.lb_ID_Product.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.lb_ID_Product.Name = "lb_ID_Product";
            this.lb_ID_Product.Size = new System.Drawing.Size(58, 32);
            this.lb_ID_Product.TabIndex = 97;
            this.lb_ID_Product.Text = "3";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ItemTrackingNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.lb_ID_Product);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_ID_Title);
            this.Controls.Add(this.lb_NameProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemTrackingNote";
            this.Size = new System.Drawing.Size(446, 105);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lb_quantity;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_ID_Title;
        public System.Windows.Forms.Label lb_NameProduct;
        public System.Windows.Forms.Label lb_ID_Product;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
