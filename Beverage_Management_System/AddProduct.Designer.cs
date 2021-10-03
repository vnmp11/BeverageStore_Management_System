
namespace Beverage_Management_System
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pB_Product = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_Save = new Guna.UI2.WinForms.Guna2Button();
            this.btt_close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cb_KindOfProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Unit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_Goods = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Product)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(209, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 31);
            this.label12.TabIndex = 80;
            this.label12.Text = "PRODUCT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(48, 149);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(83, 31);
            this.guna2Button2.TabIndex = 22;
            this.guna2Button2.Text = "BROWSE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pB_Product);
            this.panel5.Controls.Add(this.guna2Button2);
            this.panel5.Location = new System.Drawing.Point(23, 108);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 224);
            this.panel5.TabIndex = 78;
            // 
            // pB_Product
            // 
            this.pB_Product.Image = ((System.Drawing.Image)(resources.GetObject("pB_Product.Image")));
            this.pB_Product.Location = new System.Drawing.Point(21, 0);
            this.pB_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pB_Product.Name = "pB_Product";
            this.pB_Product.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pB_Product.ShadowDecoration.Parent = this.pB_Product;
            this.pB_Product.Size = new System.Drawing.Size(135, 133);
            this.pB_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_Product.TabIndex = 23;
            this.pB_Product.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label14.Location = new System.Drawing.Point(-44, 423);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "DOB";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label13.Location = new System.Drawing.Point(-44, 583);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 69;
            this.label13.Text = "Role";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(-44, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(217, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Name.BorderRadius = 5;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.Parent = this.txt_Name;
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.FocusedState.Parent = this.txt_Name;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.HoverState.Parent = this.txt_Name;
            this.txt_Name.Location = new System.Drawing.Point(297, 87);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "";
            this.txt_Name.SelectedText = "";
            this.txt_Name.ShadowDecoration.Parent = this.txt_Name;
            this.txt_Name.Size = new System.Drawing.Size(235, 36);
            this.txt_Name.TabIndex = 83;
            // 
            // txt_Price
            // 
            this.txt_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Price.BorderRadius = 5;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.Parent = this.txt_Price;
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.FocusedState.Parent = this.txt_Price;
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.HoverState.Parent = this.txt_Price;
            this.txt_Price.Location = new System.Drawing.Point(297, 319);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.SelectedText = "";
            this.txt_Price.ShadowDecoration.Parent = this.txt_Price;
            this.txt_Price.Size = new System.Drawing.Size(231, 36);
            this.txt_Price.TabIndex = 83;
            this.txt_Price.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(217, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(217, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "Kind";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(217, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Unit";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(215, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Qty";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Quantity.BorderRadius = 5;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.DefaultText = "";
            this.txt_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantity.DisabledState.Parent = this.txt_Quantity;
            this.txt_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantity.FocusedState.Parent = this.txt_Quantity;
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantity.HoverState.Parent = this.txt_Quantity;
            this.txt_Quantity.Location = new System.Drawing.Point(297, 277);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.PasswordChar = '\0';
            this.txt_Quantity.PlaceholderText = "";
            this.txt_Quantity.SelectedText = "";
            this.txt_Quantity.ShadowDecoration.Parent = this.txt_Quantity;
            this.txt_Quantity.Size = new System.Drawing.Size(231, 36);
            this.txt_Quantity.TabIndex = 83;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox2_KeyPress);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.Location = new System.Drawing.Point(513, 14);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(39, 46);
            this.guna2ImageButton1.TabIndex = 88;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.bt_Save.BorderRadius = 25;
            this.bt_Save.BorderThickness = 1;
            this.bt_Save.CheckedState.Parent = this.bt_Save;
            this.bt_Save.CustomImages.Parent = this.bt_Save;
            this.bt_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.ForeColor = System.Drawing.Color.White;
            this.bt_Save.HoverState.Parent = this.bt_Save;
            this.bt_Save.Image = global::Beverage_Management_System.Properties.Resources.update_arrows;
            this.bt_Save.Location = new System.Drawing.Point(212, 405);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.ShadowDecoration.Parent = this.bt_Save;
            this.bt_Save.Size = new System.Drawing.Size(141, 50);
            this.bt_Save.TabIndex = 87;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // btt_close
            // 
            this.btt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_close.CheckedState.Parent = this.btt_close;
            this.btt_close.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btt_close.HoverState.Parent = this.btt_close;
            this.btt_close.Image = ((System.Drawing.Image)(resources.GetObject("btt_close.Image")));
            this.btt_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btt_close.Location = new System.Drawing.Point(567, 53);
            this.btt_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_close.Name = "btt_close";
            this.btt_close.PressedState.Parent = this.btt_close;
            this.btt_close.Size = new System.Drawing.Size(39, 46);
            this.btt_close.TabIndex = 79;
            // 
            // cb_KindOfProduct
            // 
            this.cb_KindOfProduct.BackColor = System.Drawing.Color.Transparent;
            this.cb_KindOfProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_KindOfProduct.BorderRadius = 5;
            this.cb_KindOfProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_KindOfProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_KindOfProduct.FocusedColor = System.Drawing.Color.Empty;
            this.cb_KindOfProduct.FocusedState.Parent = this.cb_KindOfProduct;
            this.cb_KindOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_KindOfProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_KindOfProduct.FormattingEnabled = true;
            this.cb_KindOfProduct.HoverState.Parent = this.cb_KindOfProduct;
            this.cb_KindOfProduct.ItemHeight = 30;
            this.cb_KindOfProduct.ItemsAppearance.Parent = this.cb_KindOfProduct;
            this.cb_KindOfProduct.Location = new System.Drawing.Point(297, 182);
            this.cb_KindOfProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_KindOfProduct.Name = "cb_KindOfProduct";
            this.cb_KindOfProduct.ShadowDecoration.Parent = this.cb_KindOfProduct;
            this.cb_KindOfProduct.Size = new System.Drawing.Size(232, 36);
            this.cb_KindOfProduct.TabIndex = 94;
            this.cb_KindOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_KindOfProduct.SelectedIndexChanged += new System.EventHandler(this.cb_KindOfProduct_SelectedIndexChanged);
            // 
            // cb_Unit
            // 
            this.cb_Unit.BackColor = System.Drawing.Color.Transparent;
            this.cb_Unit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_Unit.BorderRadius = 5;
            this.cb_Unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Unit.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Unit.FocusedState.Parent = this.cb_Unit;
            this.cb_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.HoverState.Parent = this.cb_Unit;
            this.cb_Unit.ItemHeight = 30;
            this.cb_Unit.ItemsAppearance.Parent = this.cb_Unit;
            this.cb_Unit.Location = new System.Drawing.Point(297, 232);
            this.cb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.ShadowDecoration.Parent = this.cb_Unit;
            this.cb_Unit.Size = new System.Drawing.Size(232, 36);
            this.cb_Unit.TabIndex = 95;
            this.cb_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Location = new System.Drawing.Point(-3, -6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 64);
            this.panel2.TabIndex = 110;
            // 
            // cb_Goods
            // 
            this.cb_Goods.BackColor = System.Drawing.Color.Transparent;
            this.cb_Goods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_Goods.BorderRadius = 5;
            this.cb_Goods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Goods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Goods.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Goods.FocusedState.Parent = this.cb_Goods;
            this.cb_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Goods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.cb_Goods.FormattingEnabled = true;
            this.cb_Goods.HoverState.Parent = this.cb_Goods;
            this.cb_Goods.ItemHeight = 30;
            this.cb_Goods.ItemsAppearance.Parent = this.cb_Goods;
            this.cb_Goods.Location = new System.Drawing.Point(298, 135);
            this.cb_Goods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Goods.Name = "cb_Goods";
            this.cb_Goods.ShadowDecoration.Parent = this.cb_Goods;
            this.cb_Goods.Size = new System.Drawing.Size(232, 36);
            this.cb_Goods.TabIndex = 111;
            this.cb_Goods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(215, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 112;
            this.label6.Text = "Goods";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(563, 476);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Goods);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.cb_Unit);
            this.Controls.Add(this.cb_KindOfProduct);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox pB_Product;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ImageButton btt_close;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bt_Save;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Quantity;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Unit;
        private Guna.UI2.WinForms.Guna2ComboBox cb_KindOfProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Goods;
    }
}