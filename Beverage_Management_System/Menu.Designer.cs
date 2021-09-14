
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.product1 = new Beverage_Management_System.Product();
            this.product2 = new Beverage_Management_System.Product();
            this.product3 = new Beverage_Management_System.Product();
            this.product4 = new Beverage_Management_System.Product();
            this.product5 = new Beverage_Management_System.Product();
            this.product6 = new Beverage_Management_System.Product();
            this.product7 = new Beverage_Management_System.Product();
            this.product8 = new Beverage_Management_System.Product();
            this.product9 = new Beverage_Management_System.Product();
            this.product10 = new Beverage_Management_System.Product();
            this.product11 = new Beverage_Management_System.Product();
            this.product12 = new Beverage_Management_System.Product();
            this.product13 = new Beverage_Management_System.Product();
            this.product14 = new Beverage_Management_System.Product();
            this.product15 = new Beverage_Management_System.Product();
            this.product16 = new Beverage_Management_System.Product();
            this.product17 = new Beverage_Management_System.Product();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(44, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "In Stock";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 153);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(53, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 1);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total Payable:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(534, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 26);
            this.label8.TabIndex = 83;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(534, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 26);
            this.label7.TabIndex = 83;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(534, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 26);
            this.label6.TabIndex = 83;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(534, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 83;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 83;
            this.label3.Text = "Tax:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 83;
            this.label2.Text = "Sub Total: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 83;
            this.label1.Text = "Items Quantity:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox5.BorderRadius = 5;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.Enabled = false;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Location = new System.Drawing.Point(460, 752);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(164, 40);
            this.guna2TextBox5.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(44, 762);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 26);
            this.label9.TabIndex = 83;
            this.label9.Text = "Cash:";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label10.Location = new System.Drawing.Point(377, 759);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 26);
            this.label10.TabIndex = 83;
            this.label10.Text = "Change:";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(106, 752);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(164, 40);
            this.guna2TextBox1.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(536, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 31);
            this.label12.TabIndex = 90;
            this.label12.Text = "PLACE ORDER";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Poppins", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Soda",
            "Beer"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(1039, 49);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(191, 36);
            this.guna2ComboBox1.TabIndex = 94;
            this.guna2ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.product1);
            this.flowLayoutPanel1.Controls.Add(this.product2);
            this.flowLayoutPanel1.Controls.Add(this.product3);
            this.flowLayoutPanel1.Controls.Add(this.product4);
            this.flowLayoutPanel1.Controls.Add(this.product5);
            this.flowLayoutPanel1.Controls.Add(this.product6);
            this.flowLayoutPanel1.Controls.Add(this.product7);
            this.flowLayoutPanel1.Controls.Add(this.product8);
            this.flowLayoutPanel1.Controls.Add(this.product9);
            this.flowLayoutPanel1.Controls.Add(this.product10);
            this.flowLayoutPanel1.Controls.Add(this.product11);
            this.flowLayoutPanel1.Controls.Add(this.product12);
            this.flowLayoutPanel1.Controls.Add(this.product13);
            this.flowLayoutPanel1.Controls.Add(this.product14);
            this.flowLayoutPanel1.Controls.Add(this.product15);
            this.flowLayoutPanel1.Controls.Add(this.product16);
            this.flowLayoutPanel1.Controls.Add(this.product17);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(692, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 629);
            this.flowLayoutPanel1.TabIndex = 96;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox2.BorderRadius = 15;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeft = global::Beverage_Management_System.Properties.Resources.search__1_;
            this.guna2TextBox2.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.guna2TextBox2.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBox2.Location = new System.Drawing.Point(705, 55);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(260, 30);
            this.guna2TextBox2.TabIndex = 91;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(705, 742);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(142, 50);
            this.guna2Button1.TabIndex = 89;
            this.guna2Button1.Text = "DELETE";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 25;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Button2.Font = new System.Drawing.Font("Poppins SemiBold", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(935, 742);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(142, 50);
            this.guna2Button2.TabIndex = 88;
            this.guna2Button2.Text = "PRINT";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 25;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.guna2Button3.Font = new System.Drawing.Font("Poppins SemiBold", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::Beverage_Management_System.Properties.Resources.coin;
            this.guna2Button3.Location = new System.Drawing.Point(1088, 742);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(142, 50);
            this.guna2Button3.TabIndex = 88;
            this.guna2Button3.Text = "PAYMENT";
            // 
            // product1
            // 
            this.product1.BackColor = System.Drawing.Color.White;
            this.product1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product1.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product1.ImageProduct")));
            this.product1.LabelPrice = "12000";
            this.product1.LabelProduct = "Coca cola";
            this.product1.Location = new System.Drawing.Point(391, 3);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(120, 150);
            this.product1.TabIndex = 0;
            // 
            // product2
            // 
            this.product2.BackColor = System.Drawing.Color.White;
            this.product2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product2.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product2.ImageProduct")));
            this.product2.LabelPrice = "12000";
            this.product2.LabelProduct = "Coca cola";
            this.product2.Location = new System.Drawing.Point(265, 3);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(120, 150);
            this.product2.TabIndex = 0;
            // 
            // product3
            // 
            this.product3.BackColor = System.Drawing.Color.White;
            this.product3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product3.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product3.ImageProduct")));
            this.product3.LabelPrice = "12000";
            this.product3.LabelProduct = "Coca cola";
            this.product3.Location = new System.Drawing.Point(139, 3);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(120, 150);
            this.product3.TabIndex = 1;
            // 
            // product4
            // 
            this.product4.BackColor = System.Drawing.Color.White;
            this.product4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product4.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product4.ImageProduct")));
            this.product4.LabelPrice = "12000";
            this.product4.LabelProduct = "Coca cola";
            this.product4.Location = new System.Drawing.Point(13, 3);
            this.product4.Name = "product4";
            this.product4.Size = new System.Drawing.Size(120, 150);
            this.product4.TabIndex = 2;
            // 
            // product5
            // 
            this.product5.BackColor = System.Drawing.Color.White;
            this.product5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product5.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product5.ImageProduct")));
            this.product5.LabelPrice = "12000";
            this.product5.LabelProduct = "Coca cola";
            this.product5.Location = new System.Drawing.Point(391, 159);
            this.product5.Name = "product5";
            this.product5.Size = new System.Drawing.Size(120, 150);
            this.product5.TabIndex = 3;
            // 
            // product6
            // 
            this.product6.BackColor = System.Drawing.Color.White;
            this.product6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product6.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product6.ImageProduct")));
            this.product6.LabelPrice = "12000";
            this.product6.LabelProduct = "Coca cola";
            this.product6.Location = new System.Drawing.Point(265, 159);
            this.product6.Name = "product6";
            this.product6.Size = new System.Drawing.Size(120, 150);
            this.product6.TabIndex = 4;
            // 
            // product7
            // 
            this.product7.BackColor = System.Drawing.Color.White;
            this.product7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product7.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product7.ImageProduct")));
            this.product7.LabelPrice = "12000";
            this.product7.LabelProduct = "Coca cola";
            this.product7.Location = new System.Drawing.Point(139, 159);
            this.product7.Name = "product7";
            this.product7.Size = new System.Drawing.Size(120, 150);
            this.product7.TabIndex = 5;
            // 
            // product8
            // 
            this.product8.BackColor = System.Drawing.Color.White;
            this.product8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product8.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product8.ImageProduct")));
            this.product8.LabelPrice = "12000";
            this.product8.LabelProduct = "Coca cola";
            this.product8.Location = new System.Drawing.Point(13, 159);
            this.product8.Name = "product8";
            this.product8.Size = new System.Drawing.Size(120, 150);
            this.product8.TabIndex = 6;
            // 
            // product9
            // 
            this.product9.BackColor = System.Drawing.Color.White;
            this.product9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product9.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product9.ImageProduct")));
            this.product9.LabelPrice = "12000";
            this.product9.LabelProduct = "Coca cola";
            this.product9.Location = new System.Drawing.Point(391, 315);
            this.product9.Name = "product9";
            this.product9.Size = new System.Drawing.Size(120, 150);
            this.product9.TabIndex = 7;
            // 
            // product10
            // 
            this.product10.BackColor = System.Drawing.Color.White;
            this.product10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product10.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product10.ImageProduct")));
            this.product10.LabelPrice = "12000";
            this.product10.LabelProduct = "Coca cola";
            this.product10.Location = new System.Drawing.Point(265, 315);
            this.product10.Name = "product10";
            this.product10.Size = new System.Drawing.Size(120, 150);
            this.product10.TabIndex = 8;
            // 
            // product11
            // 
            this.product11.BackColor = System.Drawing.Color.White;
            this.product11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product11.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product11.ImageProduct")));
            this.product11.LabelPrice = "12000";
            this.product11.LabelProduct = "Coca cola";
            this.product11.Location = new System.Drawing.Point(139, 315);
            this.product11.Name = "product11";
            this.product11.Size = new System.Drawing.Size(120, 150);
            this.product11.TabIndex = 9;
            // 
            // product12
            // 
            this.product12.BackColor = System.Drawing.Color.White;
            this.product12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product12.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product12.ImageProduct")));
            this.product12.LabelPrice = "12000";
            this.product12.LabelProduct = "Coca cola";
            this.product12.Location = new System.Drawing.Point(13, 315);
            this.product12.Name = "product12";
            this.product12.Size = new System.Drawing.Size(120, 150);
            this.product12.TabIndex = 10;
            // 
            // product13
            // 
            this.product13.BackColor = System.Drawing.Color.White;
            this.product13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product13.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product13.ImageProduct")));
            this.product13.LabelPrice = "12000";
            this.product13.LabelProduct = "Coca cola";
            this.product13.Location = new System.Drawing.Point(391, 471);
            this.product13.Name = "product13";
            this.product13.Size = new System.Drawing.Size(120, 150);
            this.product13.TabIndex = 11;
            // 
            // product14
            // 
            this.product14.BackColor = System.Drawing.Color.White;
            this.product14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product14.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product14.ImageProduct")));
            this.product14.LabelPrice = "12000";
            this.product14.LabelProduct = "Coca cola";
            this.product14.Location = new System.Drawing.Point(265, 471);
            this.product14.Name = "product14";
            this.product14.Size = new System.Drawing.Size(120, 150);
            this.product14.TabIndex = 12;
            // 
            // product15
            // 
            this.product15.BackColor = System.Drawing.Color.White;
            this.product15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product15.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product15.ImageProduct")));
            this.product15.LabelPrice = "12000";
            this.product15.LabelProduct = "Coca cola";
            this.product15.Location = new System.Drawing.Point(139, 471);
            this.product15.Name = "product15";
            this.product15.Size = new System.Drawing.Size(120, 150);
            this.product15.TabIndex = 13;
            // 
            // product16
            // 
            this.product16.BackColor = System.Drawing.Color.White;
            this.product16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product16.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product16.ImageProduct")));
            this.product16.LabelPrice = "12000";
            this.product16.LabelProduct = "Coca cola";
            this.product16.Location = new System.Drawing.Point(13, 471);
            this.product16.Name = "product16";
            this.product16.Size = new System.Drawing.Size(120, 150);
            this.product16.TabIndex = 14;
            // 
            // product17
            // 
            this.product17.BackColor = System.Drawing.Color.White;
            this.product17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product17.ImageProduct = ((System.Drawing.Image)(resources.GetObject("product17.ImageProduct")));
            this.product17.LabelPrice = "12000";
            this.product17.LabelProduct = "Coca cola";
            this.product17.Location = new System.Drawing.Point(391, 627);
            this.product17.Name = "product17";
            this.product17.Size = new System.Drawing.Size(120, 150);
            this.product17.TabIndex = 15;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 839);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Product product1;
        private Product product2;
        private Product product3;
        private Product product4;
        private Product product5;
        private Product product6;
        private Product product7;
        private Product product8;
        private Product product9;
        private Product product10;
        private Product product11;
        private Product product12;
        private Product product13;
        private Product product14;
        private Product product15;
        private Product product16;
        private Product product17;
    }
}