
namespace Beverage_Management_System
{
    partial class DetailOrder
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_NameProduct = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.btt_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_quatityItem = new System.Windows.Forms.Label();
            this.lb_InStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb_NameProduct
            // 
            this.lb_NameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lb_NameProduct.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.lb_NameProduct.Location = new System.Drawing.Point(60, 12);
            this.lb_NameProduct.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_NameProduct.Name = "lb_NameProduct";
            this.lb_NameProduct.Size = new System.Drawing.Size(197, 26);
            this.lb_NameProduct.TabIndex = 88;
            this.lb_NameProduct.Text = "Coca cola";
            this.lb_NameProduct.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.lb_total.Location = new System.Drawing.Point(469, 28);
            this.lb_total.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(119, 26);
            this.lb_total.TabIndex = 89;
            this.lb_total.Text = "10000";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_total.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // lb_price
            // 
            this.lb_price.BackColor = System.Drawing.Color.Transparent;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.Color.DimGray;
            this.lb_price.Location = new System.Drawing.Point(60, 40);
            this.lb_price.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(95, 26);
            this.lb_price.TabIndex = 91;
            this.lb_price.Text = "10000";
            this.lb_price.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.CheckedState.Parent = this.btt_delete;
            this.btt_delete.HoverState.Image = global::Beverage_Management_System.Properties.Resources.delete;
            this.btt_delete.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.btt_delete.HoverState.Parent = this.btt_delete;
            this.btt_delete.Image = global::Beverage_Management_System.Properties.Resources.delete;
            this.btt_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btt_delete.ImageRotate = 0F;
            this.btt_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btt_delete.Location = new System.Drawing.Point(19, 17);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_delete.PressedState.Parent = this.btt_delete;
            this.btt_delete.ShadowDecoration.Parent = this.btt_delete;
            this.btt_delete.Size = new System.Drawing.Size(35, 37);
            this.btt_delete.TabIndex = 92;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(359, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
            this.label1.TabIndex = 88;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // txb_quatityItem
            // 
            this.txb_quatityItem.BackColor = System.Drawing.Color.Transparent;
            this.txb_quatityItem.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_quatityItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txb_quatityItem.Location = new System.Drawing.Point(377, 28);
            this.txb_quatityItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.txb_quatityItem.Name = "txb_quatityItem";
            this.txb_quatityItem.Size = new System.Drawing.Size(35, 26);
            this.txb_quatityItem.TabIndex = 88;
            this.txb_quatityItem.Text = "1";
            this.txb_quatityItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txb_quatityItem.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // lb_InStock
            // 
            this.lb_InStock.BackColor = System.Drawing.Color.Transparent;
            this.lb_InStock.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.lb_InStock.Location = new System.Drawing.Point(211, 28);
            this.lb_InStock.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_InStock.Name = "lb_InStock";
            this.lb_InStock.Size = new System.Drawing.Size(46, 26);
            this.lb_InStock.TabIndex = 89;
            this.lb_InStock.Text = "100";
            this.lb_InStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_InStock.Click += new System.EventHandler(this.DetailOrder_Click);
            // 
            // DetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.lb_InStock);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.txb_quatityItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_NameProduct);
            this.Name = "DetailOrder";
            this.Size = new System.Drawing.Size(620, 76);
            this.Load += new System.EventHandler(this.DetailOrder_Load);
            this.Click += new System.EventHandler(this.DetailOrder_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label lb_NameProduct;
        public System.Windows.Forms.Label lb_total;
        public System.Windows.Forms.Label lb_price;
        private Guna.UI2.WinForms.Guna2ImageButton btt_delete;
        public System.Windows.Forms.Label txb_quatityItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_InStock;
    }
}
