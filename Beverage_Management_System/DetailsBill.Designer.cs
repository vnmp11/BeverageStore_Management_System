﻿
namespace Beverage_Management_System
{
    partial class DetailsBill
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
            this.lb_NameProduct = new System.Windows.Forms.Label();
            this.lb_ID_Title = new System.Windows.Forms.Label();
            this.lb_ID_Product = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(24, 7);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(240, 21);
            this.lb_NameProduct.TabIndex = 88;
            this.lb_NameProduct.Text = "Coca cola";
            // 
            // lb_ID_Title
            // 
            this.lb_ID_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_ID_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lb_ID_Title.Location = new System.Drawing.Point(24, 36);
            this.lb_ID_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lb_ID_Title.Name = "lb_ID_Title";
            this.lb_ID_Title.Size = new System.Drawing.Size(115, 21);
            this.lb_ID_Title.TabIndex = 89;
            this.lb_ID_Title.Text = "ID Products:";
            // 
            // lb_ID_Product
            // 
            this.lb_ID_Product.BackColor = System.Drawing.Color.Transparent;
            this.lb_ID_Product.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID_Product.ForeColor = System.Drawing.Color.DimGray;
            this.lb_ID_Product.Location = new System.Drawing.Point(108, 36);
            this.lb_ID_Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lb_ID_Product.Name = "lb_ID_Product";
            this.lb_ID_Product.Size = new System.Drawing.Size(39, 21);
            this.lb_ID_Product.TabIndex = 90;
            this.lb_ID_Product.Text = "3";
            // 
            // lb_quantity
            // 
            this.lb_quantity.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_quantity.Location = new System.Drawing.Point(219, 36);
            this.lb_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(36, 21);
            this.lb_quantity.TabIndex = 91;
            this.lb_quantity.Text = "2";
            this.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(206, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_total.Location = new System.Drawing.Point(268, 36);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(117, 21);
            this.lb_total.TabIndex = 93;
            this.lb_total.Text = "10000";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetailsBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_ID_Product);
            this.Controls.Add(this.lb_ID_Title);
            this.Controls.Add(this.lb_NameProduct);
            this.Name = "DetailsBill";
            this.Size = new System.Drawing.Size(400, 68);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lb_NameProduct;
        public System.Windows.Forms.Label lb_ID_Title;
        public System.Windows.Forms.Label lb_ID_Product;
        public System.Windows.Forms.Label lb_quantity;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_total;
    }
}
