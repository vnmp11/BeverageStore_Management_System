﻿
namespace Beverage_Management_System
{
    partial class UpdateItem
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_ok = new Guna.UI2.WinForms.Guna2Button();
            this.txb_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_minus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_plus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_remove = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Location = new System.Drawing.Point(-88, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 57);
            this.panel1.TabIndex = 2;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(147, 10);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(189, 41);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Quantity";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Location = new System.Drawing.Point(345, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(39, 45);
            this.guna2ImageButton1.TabIndex = 110;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btt_ok
            // 
            this.btt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_ok.BorderColor = System.Drawing.Color.Transparent;
            this.btt_ok.BorderRadius = 10;
            this.btt_ok.BorderThickness = 1;
            this.btt_ok.CheckedState.Parent = this.btt_ok;
            this.btt_ok.CustomImages.Parent = this.btt_ok;
            this.btt_ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ok.ForeColor = System.Drawing.Color.White;
            this.btt_ok.HoverState.Parent = this.btt_ok;
            this.btt_ok.Location = new System.Drawing.Point(173, 134);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.ShadowDecoration.Parent = this.btt_ok;
            this.btt_ok.Size = new System.Drawing.Size(110, 40);
            this.btt_ok.TabIndex = 115;
            this.btt_ok.Text = "Ok";
            this.btt_ok.Click += new System.EventHandler(this.btt_ok_Click);
            // 
            // txb_quantity
            // 
            this.txb_quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_quantity.BorderRadius = 5;
            this.txb_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_quantity.DefaultText = "1";
            this.txb_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_quantity.DisabledState.Parent = this.txb_quantity;
            this.txb_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_quantity.FocusedState.Parent = this.txb_quantity;
            this.txb_quantity.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_quantity.HoverState.Parent = this.txb_quantity;
            this.txb_quantity.Location = new System.Drawing.Point(109, 72);
            this.txb_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.PasswordChar = '\0';
            this.txb_quantity.PlaceholderText = "";
            this.txb_quantity.SelectedText = "";
            this.txb_quantity.SelectionStart = 1;
            this.txb_quantity.ShadowDecoration.Parent = this.txb_quantity;
            this.txb_quantity.Size = new System.Drawing.Size(90, 44);
            this.txb_quantity.TabIndex = 112;
            this.txb_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_quantity_KeyPress);
            // 
            // btt_minus
            // 
            this.btt_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_minus.CheckedState.Parent = this.btt_minus;
            this.btt_minus.HoverState.Image = global::Beverage_Management_System.Properties.Resources.minus1;
            this.btt_minus.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_minus.HoverState.Parent = this.btt_minus;
            this.btt_minus.Image = global::Beverage_Management_System.Properties.Resources.minus1;
            this.btt_minus.Location = new System.Drawing.Point(63, 72);
            this.btt_minus.Name = "btt_minus";
            this.btt_minus.PressedState.Parent = this.btt_minus;
            this.btt_minus.Size = new System.Drawing.Size(39, 45);
            this.btt_minus.TabIndex = 113;
            this.btt_minus.Click += new System.EventHandler(this.btt_minus_Click);
            // 
            // btt_plus
            // 
            this.btt_plus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_plus.CheckedState.Parent = this.btt_plus;
            this.btt_plus.HoverState.Image = global::Beverage_Management_System.Properties.Resources.add__1_;
            this.btt_plus.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_plus.HoverState.Parent = this.btt_plus;
            this.btt_plus.Image = global::Beverage_Management_System.Properties.Resources.add__1_;
            this.btt_plus.Location = new System.Drawing.Point(206, 72);
            this.btt_plus.Name = "btt_plus";
            this.btt_plus.PressedState.Parent = this.btt_plus;
            this.btt_plus.Size = new System.Drawing.Size(39, 45);
            this.btt_plus.TabIndex = 114;
            this.btt_plus.Click += new System.EventHandler(this.btt_plus_Click);
            // 
            // btt_remove
            // 
            this.btt_remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_remove.BorderColor = System.Drawing.Color.Transparent;
            this.btt_remove.BorderRadius = 10;
            this.btt_remove.BorderThickness = 1;
            this.btt_remove.CheckedState.Parent = this.btt_remove;
            this.btt_remove.CustomImages.Parent = this.btt_remove;
            this.btt_remove.FillColor = System.Drawing.Color.DarkRed;
            this.btt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_remove.ForeColor = System.Drawing.Color.White;
            this.btt_remove.HoverState.Parent = this.btt_remove;
            this.btt_remove.Location = new System.Drawing.Point(31, 134);
            this.btt_remove.Name = "btt_remove";
            this.btt_remove.ShadowDecoration.Parent = this.btt_remove;
            this.btt_remove.Size = new System.Drawing.Size(110, 40);
            this.btt_remove.TabIndex = 115;
            this.btt_remove.Text = "Remove";
            this.btt_remove.Click += new System.EventHandler(this.btt_remove_Click);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 196);
            this.Controls.Add(this.btt_remove);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.txb_quantity);
            this.Controls.Add(this.btt_minus);
            this.Controls.Add(this.btt_plus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItem";
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lb_Title;
        public Guna.UI2.WinForms.Guna2Button btt_remove;
        public Guna.UI2.WinForms.Guna2Button btt_ok;
        public Guna.UI2.WinForms.Guna2TextBox txb_quantity;
        private Guna.UI2.WinForms.Guna2ImageButton btt_minus;
        private Guna.UI2.WinForms.Guna2ImageButton btt_plus;
    }
}