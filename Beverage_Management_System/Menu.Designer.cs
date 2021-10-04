﻿
namespace Beverage_Management_System
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_QtyItem = new System.Windows.Forms.Label();
            this.lb_subTotal = new System.Windows.Forms.Label();
            this.lb_Tax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.cb_KindofDrink = new Guna.UI2.WinForms.Guna2ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.layoutPl_product = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_IdOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_searchMenu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_clearAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btt_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.pl_Order = new System.Windows.Forms.FlowLayoutPanel();
            this.detailOrder1 = new Beverage_Management_System.DetailOrder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.pl_Order.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.lb_QtyItem);
            this.panel2.Controls.Add(this.lb_subTotal);
            this.panel2.Controls.Add(this.lb_Tax);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(57, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 224);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(57, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 1);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(17, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total Payable:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_total.Location = new System.Drawing.Point(399, 135);
            this.lb_total.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(206, 29);
            this.lb_total.TabIndex = 83;
            this.lb_total.Text = "0";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_total.TextChanged += new System.EventHandler(this.lb_total_TextChanged);
            this.lb_total.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_QtyItem
            // 
            this.lb_QtyItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_QtyItem.Font = new System.Drawing.Font("Microsoft Tai Le", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QtyItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_QtyItem.Location = new System.Drawing.Point(379, 174);
            this.lb_QtyItem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_QtyItem.Name = "lb_QtyItem";
            this.lb_QtyItem.Size = new System.Drawing.Size(224, 30);
            this.lb_QtyItem.TabIndex = 83;
            this.lb_QtyItem.Text = "0";
            this.lb_QtyItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_QtyItem.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_subTotal
            // 
            this.lb_subTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_subTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_subTotal.Location = new System.Drawing.Point(408, 30);
            this.lb_subTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_subTotal.Name = "lb_subTotal";
            this.lb_subTotal.Size = new System.Drawing.Size(197, 30);
            this.lb_subTotal.TabIndex = 83;
            this.lb_subTotal.Text = "0";
            this.lb_subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_subTotal.TextChanged += new System.EventHandler(this.lb_subTotal_TextChanged);
            this.lb_subTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_Tax
            // 
            this.lb_Tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Tax.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_Tax.Location = new System.Drawing.Point(400, 72);
            this.lb_Tax.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lb_Tax.Name = "lb_Tax";
            this.lb_Tax.Size = new System.Drawing.Size(205, 30);
            this.lb_Tax.TabIndex = 83;
            this.lb_Tax.Text = "0";
            this.lb_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_Tax.TextChanged += new System.EventHandler(this.lb_Tax_TextChanged);
            this.lb_Tax.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 83;
            this.label3.Text = "Tax:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 83;
            this.label2.Text = "Sub Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(17, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 83;
            this.label1.Text = "Items Quantity:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(536, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 31);
            this.label12.TabIndex = 90;
            this.label12.Text = "PLACE ORDER";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_KindofDrink
            // 
            this.cb_KindofDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_KindofDrink.BackColor = System.Drawing.Color.Transparent;
            this.cb_KindofDrink.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_KindofDrink.BorderRadius = 5;
            this.cb_KindofDrink.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_KindofDrink.DropDownHeight = 200;
            this.cb_KindofDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KindofDrink.FocusedColor = System.Drawing.Color.Empty;
            this.cb_KindofDrink.FocusedState.Parent = this.cb_KindofDrink;
            this.cb_KindofDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_KindofDrink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_KindofDrink.FormattingEnabled = true;
            this.cb_KindofDrink.HoverState.Parent = this.cb_KindofDrink;
            this.cb_KindofDrink.IntegralHeight = false;
            this.cb_KindofDrink.ItemHeight = 30;
            this.cb_KindofDrink.Items.AddRange(new object[] {
            ""});
            this.cb_KindofDrink.ItemsAppearance.Parent = this.cb_KindofDrink;
            this.cb_KindofDrink.Location = new System.Drawing.Point(1083, 75);
            this.cb_KindofDrink.Name = "cb_KindofDrink";
            this.cb_KindofDrink.ShadowDecoration.Parent = this.cb_KindofDrink;
            this.cb_KindofDrink.Size = new System.Drawing.Size(147, 36);
            this.cb_KindofDrink.TabIndex = 94;
            this.cb_KindofDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_KindofDrink.TextChanged += new System.EventHandler(this.cb_KindofDrink_TextChanged);
            // 
            // layoutPl_product
            // 
            this.layoutPl_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPl_product.AutoScroll = true;
            this.layoutPl_product.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.layoutPl_product.Location = new System.Drawing.Point(781, 128);
            this.layoutPl_product.Name = "layoutPl_product";
            this.layoutPl_product.Size = new System.Drawing.Size(449, 593);
            this.layoutPl_product.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(68, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 98;
            this.label9.Text = "Number:";
            // 
            // txb_IdOrder
            // 
            this.txb_IdOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_IdOrder.BorderRadius = 6;
            this.txb_IdOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_IdOrder.DefaultText = "39";
            this.txb_IdOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_IdOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_IdOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_IdOrder.DisabledState.Parent = this.txb_IdOrder;
            this.txb_IdOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_IdOrder.Enabled = false;
            this.txb_IdOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_IdOrder.FocusedState.Parent = this.txb_IdOrder;
            this.txb_IdOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_IdOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_IdOrder.HoverState.Parent = this.txb_IdOrder;
            this.txb_IdOrder.Location = new System.Drawing.Point(156, 75);
            this.txb_IdOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_IdOrder.Name = "txb_IdOrder";
            this.txb_IdOrder.PasswordChar = '\0';
            this.txb_IdOrder.PlaceholderText = "";
            this.txb_IdOrder.SelectedText = "";
            this.txb_IdOrder.SelectionStart = 2;
            this.txb_IdOrder.ShadowDecoration.Parent = this.txb_IdOrder;
            this.txb_IdOrder.Size = new System.Drawing.Size(58, 36);
            this.txb_IdOrder.TabIndex = 99;
            this.txb_IdOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_searchMenu
            // 
            this.txb_searchMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_searchMenu.BorderRadius = 18;
            this.txb_searchMenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_searchMenu.DefaultText = "";
            this.txb_searchMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_searchMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_searchMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_searchMenu.DisabledState.Parent = this.txb_searchMenu;
            this.txb_searchMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_searchMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_searchMenu.FocusedState.Parent = this.txb_searchMenu;
            this.txb_searchMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_searchMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_searchMenu.HoverState.Parent = this.txb_searchMenu;
            this.txb_searchMenu.IconLeft = global::Beverage_Management_System.Properties.Resources.search__1_;
            this.txb_searchMenu.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txb_searchMenu.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txb_searchMenu.Location = new System.Drawing.Point(788, 75);
            this.txb_searchMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_searchMenu.Name = "txb_searchMenu";
            this.txb_searchMenu.PasswordChar = '\0';
            this.txb_searchMenu.PlaceholderText = "";
            this.txb_searchMenu.SelectedText = "";
            this.txb_searchMenu.ShadowDecoration.Parent = this.txb_searchMenu;
            this.txb_searchMenu.Size = new System.Drawing.Size(197, 36);
            this.txb_searchMenu.TabIndex = 91;
            this.txb_searchMenu.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // btt_clearAll
            // 
            this.btt_clearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btt_clearAll.BackColor = System.Drawing.Color.Transparent;
            this.btt_clearAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_clearAll.BorderRadius = 7;
            this.btt_clearAll.BorderThickness = 1;
            this.btt_clearAll.CheckedState.Parent = this.btt_clearAll;
            this.btt_clearAll.CustomImages.Parent = this.btt_clearAll;
            this.btt_clearAll.FillColor = System.Drawing.Color.White;
            this.btt_clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_clearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_clearAll.HoverState.Parent = this.btt_clearAll;
            this.btt_clearAll.Image = ((System.Drawing.Image)(resources.GetObject("btt_clearAll.Image")));
            this.btt_clearAll.Location = new System.Drawing.Point(788, 742);
            this.btt_clearAll.Name = "btt_clearAll";
            this.btt_clearAll.ShadowDecoration.Parent = this.btt_clearAll;
            this.btt_clearAll.Size = new System.Drawing.Size(136, 50);
            this.btt_clearAll.TabIndex = 89;
            this.btt_clearAll.Text = "CLEAR ALL";
            this.btt_clearAll.Click += new System.EventHandler(this.btt_clearAll_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 7;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(966, 742);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(129, 50);
            this.guna2Button2.TabIndex = 88;
            this.guna2Button2.Text = "PRINT";
            // 
            // btt_Pay
            // 
            this.btt_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_Pay.BorderColor = System.Drawing.Color.Transparent;
            this.btt_Pay.BorderRadius = 7;
            this.btt_Pay.BorderThickness = 1;
            this.btt_Pay.CheckedState.Parent = this.btt_Pay;
            this.btt_Pay.CustomImages.Parent = this.btt_Pay;
            this.btt_Pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Pay.ForeColor = System.Drawing.Color.White;
            this.btt_Pay.HoverState.Parent = this.btt_Pay;
            this.btt_Pay.Image = global::Beverage_Management_System.Properties.Resources.coin;
            this.btt_Pay.Location = new System.Drawing.Point(1101, 742);
            this.btt_Pay.Name = "btt_Pay";
            this.btt_Pay.ShadowDecoration.Parent = this.btt_Pay;
            this.btt_Pay.Size = new System.Drawing.Size(129, 50);
            this.btt_Pay.TabIndex = 88;
            this.btt_Pay.Text = "PAYMENT";
            this.btt_Pay.Click += new System.EventHandler(this.btt_Pay_Click);
            // 
            // pl_Order
            // 
            this.pl_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pl_Order.AutoScroll = true;
            this.pl_Order.BackColor = System.Drawing.Color.White;
            this.pl_Order.Controls.Add(this.detailOrder1);
            this.pl_Order.Location = new System.Drawing.Point(57, 191);
            this.pl_Order.Margin = new System.Windows.Forms.Padding(5);
            this.pl_Order.Name = "pl_Order";
            this.pl_Order.Size = new System.Drawing.Size(654, 362);
            this.pl_Order.TabIndex = 100;
            // 
            // detailOrder1
            // 
            this.detailOrder1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailOrder1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.detailOrder1.LabelIn_Stock = "100";
            this.detailOrder1.LabelName = "Coca cola";
            this.detailOrder1.LabelPrice = "10000";
            this.detailOrder1.LabelTotal_Price = "10000";
            this.detailOrder1.Location = new System.Drawing.Point(3, 3);
            this.detailOrder1.Name = "detailOrder1";
            this.detailOrder1.NumberRicQuantity = "1";
            this.detailOrder1.Size = new System.Drawing.Size(507, 0);
            this.detailOrder1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(60, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 105);
            this.panel1.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(520, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 31);
            this.label7.TabIndex = 96;
            this.label7.Text = "Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(338, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 96;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(192, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 31);
            this.label8.TabIndex = 96;
            this.label8.Text = "In stock";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(60, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 31);
            this.label6.TabIndex = 96;
            this.label6.Text = "Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 839);
            this.Controls.Add(this.pl_Order);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_IdOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.layoutPl_product);
            this.Controls.Add(this.cb_KindofDrink);
            this.Controls.Add(this.txb_searchMenu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btt_clearAll);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btt_Pay);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pl_Order.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_subTotal;
        private System.Windows.Forms.Label lb_Tax;
        private Guna.UI2.WinForms.Guna2Button btt_Pay;
        private Guna.UI2.WinForms.Guna2Button btt_clearAll;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txb_searchMenu;
        private Guna.UI2.WinForms.Guna2ComboBox cb_KindofDrink;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.FlowLayoutPanel layoutPl_product;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox txb_IdOrder;
        public System.Windows.Forms.Label lb_QtyItem;
        public System.Windows.Forms.FlowLayoutPanel pl_Order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label7;
        private DetailOrder detailOrder1;
        private System.Windows.Forms.Label label8;
    }
}