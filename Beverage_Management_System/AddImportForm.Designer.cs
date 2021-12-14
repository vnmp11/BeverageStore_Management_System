
namespace Beverage_Management_System
{
    partial class AddImportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddImportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.DtaGridView_Warehouse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVENTORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ID_GIForm = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btt_clearAll = new Guna.UI2.WinForms.Guna2Button();
            this.btt_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.dtaGV_GIForm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_GIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_GIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY_GIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Warehouse)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_GIForm)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(415, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(372, 39);
            this.label12.TabIndex = 96;
            this.label12.Text = "ADD IMPORT FORM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DtaGridView_Warehouse
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaGridView_Warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DtaGridView_Warehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaGridView_Warehouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtaGridView_Warehouse.BackgroundColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridView_Warehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_Warehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridView_Warehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaGridView_Warehouse.ColumnHeadersHeight = 32;
            this.DtaGridView_Warehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCT,
            this.NAME,
            this.INVENTORY});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtaGridView_Warehouse.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtaGridView_Warehouse.EnableHeadersVisualStyles = false;
            this.DtaGridView_Warehouse.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Warehouse.Location = new System.Drawing.Point(45, 169);
            this.DtaGridView_Warehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtaGridView_Warehouse.Name = "DtaGridView_Warehouse";
            this.DtaGridView_Warehouse.ReadOnly = true;
            this.DtaGridView_Warehouse.RowHeadersVisible = false;
            this.DtaGridView_Warehouse.RowHeadersWidth = 62;
            this.DtaGridView_Warehouse.RowTemplate.Height = 35;
            this.DtaGridView_Warehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaGridView_Warehouse.Size = new System.Drawing.Size(429, 532);
            this.DtaGridView_Warehouse.TabIndex = 97;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.Height = 32;
            this.DtaGridView_Warehouse.ThemeStyle.ReadOnly = true;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.Height = 35;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_Warehouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridView_Warehouse_CellContentClick);
            this.DtaGridView_Warehouse.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridView_Warehouse_CellContentDoubleClick);
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.HeaderText = "ID";
            this.ID_PRODUCT.MinimumWidth = 8;
            this.ID_PRODUCT.Name = "ID_PRODUCT";
            this.ID_PRODUCT.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // INVENTORY
            // 
            this.INVENTORY.HeaderText = "INVENTORY";
            this.INVENTORY.MinimumWidth = 8;
            this.INVENTORY.Name = "INVENTORY";
            this.INVENTORY.ReadOnly = true;
            // 
            // txt_ID_GIForm
            // 
            this.txt_ID_GIForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_ID_GIForm.BorderRadius = 6;
            this.txt_ID_GIForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID_GIForm.DefaultText = "1";
            this.txt_ID_GIForm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID_GIForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID_GIForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_GIForm.DisabledState.Parent = this.txt_ID_GIForm;
            this.txt_ID_GIForm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID_GIForm.Enabled = false;
            this.txt_ID_GIForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_GIForm.FocusedState.Parent = this.txt_ID_GIForm;
            this.txt_ID_GIForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ID_GIForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_ID_GIForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID_GIForm.HoverState.Parent = this.txt_ID_GIForm;
            this.txt_ID_GIForm.Location = new System.Drawing.Point(33, 15);
            this.txt_ID_GIForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ID_GIForm.Name = "txt_ID_GIForm";
            this.txt_ID_GIForm.PasswordChar = '\0';
            this.txt_ID_GIForm.PlaceholderText = "";
            this.txt_ID_GIForm.SelectedText = "";
            this.txt_ID_GIForm.SelectionStart = 1;
            this.txt_ID_GIForm.ShadowDecoration.Parent = this.txt_ID_GIForm;
            this.txt_ID_GIForm.Size = new System.Drawing.Size(65, 45);
            this.txt_ID_GIForm.TabIndex = 100;
            this.txt_ID_GIForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btt_clearAll);
            this.panel1.Controls.Add(this.btt_Pay);
            this.panel1.Controls.Add(this.txt_ID_GIForm);
            this.panel1.Controls.Add(this.dtaGV_GIForm);
            this.panel1.Location = new System.Drawing.Point(493, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 599);
            this.panel1.TabIndex = 101;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button1.Location = new System.Drawing.Point(170, 519);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(42, 62);
            this.guna2Button1.TabIndex = 105;
            this.guna2Button1.Text = "  ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btt_clearAll
            // 
            this.btt_clearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btt_clearAll.BackColor = System.Drawing.Color.Transparent;
            this.btt_clearAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_clearAll.BorderRadius = 5;
            this.btt_clearAll.BorderThickness = 1;
            this.btt_clearAll.CheckedState.Parent = this.btt_clearAll;
            this.btt_clearAll.CustomImages.Parent = this.btt_clearAll;
            this.btt_clearAll.DisabledState.Parent = this.btt_clearAll;
            this.btt_clearAll.FillColor = System.Drawing.Color.White;
            this.btt_clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_clearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_clearAll.HoverState.Parent = this.btt_clearAll;
            this.btt_clearAll.Location = new System.Drawing.Point(33, 519);
            this.btt_clearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_clearAll.Name = "btt_clearAll";
            this.btt_clearAll.ShadowDecoration.Parent = this.btt_clearAll;
            this.btt_clearAll.Size = new System.Drawing.Size(130, 62);
            this.btt_clearAll.TabIndex = 104;
            this.btt_clearAll.Text = "CLEAR ALL";
            this.btt_clearAll.Click += new System.EventHandler(this.btt_clearAll_Click);
            // 
            // btt_Pay
            // 
            this.btt_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_Pay.BorderColor = System.Drawing.Color.Transparent;
            this.btt_Pay.BorderRadius = 5;
            this.btt_Pay.BorderThickness = 1;
            this.btt_Pay.CheckedState.Parent = this.btt_Pay;
            this.btt_Pay.CustomImages.Parent = this.btt_Pay;
            this.btt_Pay.DisabledState.Parent = this.btt_Pay;
            this.btt_Pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Pay.ForeColor = System.Drawing.Color.White;
            this.btt_Pay.HoverState.Parent = this.btt_Pay;
            this.btt_Pay.Image = global::Beverage_Management_System.Properties.Resources.confirm;
            this.btt_Pay.Location = new System.Drawing.Point(505, 519);
            this.btt_Pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Pay.Name = "btt_Pay";
            this.btt_Pay.ShadowDecoration.Parent = this.btt_Pay;
            this.btt_Pay.Size = new System.Drawing.Size(84, 62);
            this.btt_Pay.TabIndex = 103;
            this.btt_Pay.Click += new System.EventHandler(this.btt_Pay_Click);
            // 
            // dtaGV_GIForm
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtaGV_GIForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtaGV_GIForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGV_GIForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGV_GIForm.BackgroundColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtaGV_GIForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtaGV_GIForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGV_GIForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtaGV_GIForm.ColumnHeadersHeight = 32;
            this.dtaGV_GIForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_GIF,
            this.NAME_GIF,
            this.QUANTITY_GIF});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGV_GIForm.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtaGV_GIForm.EnableHeadersVisualStyles = false;
            this.dtaGV_GIForm.GridColor = System.Drawing.SystemColors.Control;
            this.dtaGV_GIForm.Location = new System.Drawing.Point(33, 68);
            this.dtaGV_GIForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtaGV_GIForm.Name = "dtaGV_GIForm";
            this.dtaGV_GIForm.RowHeadersVisible = false;
            this.dtaGV_GIForm.RowHeadersWidth = 62;
            this.dtaGV_GIForm.RowTemplate.Height = 28;
            this.dtaGV_GIForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGV_GIForm.Size = new System.Drawing.Size(557, 419);
            this.dtaGV_GIForm.TabIndex = 102;
            this.dtaGV_GIForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtaGV_GIForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtaGV_GIForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtaGV_GIForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtaGV_GIForm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtaGV_GIForm.ThemeStyle.HeaderStyle.Height = 32;
            this.dtaGV_GIForm.ThemeStyle.ReadOnly = false;
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.Height = 28;
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dtaGV_GIForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID_GIF
            // 
            this.ID_GIF.HeaderText = "ID";
            this.ID_GIF.MinimumWidth = 8;
            this.ID_GIF.Name = "ID_GIF";
            // 
            // NAME_GIF
            // 
            this.NAME_GIF.HeaderText = "NAME";
            this.NAME_GIF.MinimumWidth = 8;
            this.NAME_GIF.Name = "NAME_GIF";
            // 
            // QUANTITY_GIF
            // 
            this.QUANTITY_GIF.HeaderText = "QUANTITY";
            this.QUANTITY_GIF.MinimumWidth = 8;
            this.QUANTITY_GIF.Name = "QUANTITY_GIF";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-15, -8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 89);
            this.panel2.TabIndex = 110;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1105, 20);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 56);
            this.guna2ImageButton1.TabIndex = 108;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(99, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 48);
            this.label1.TabIndex = 109;
            this.label1.Text = "INVENTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(165, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 111;
            this.label2.Text = "DETAILS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1148, 738);
            this.Controls.Add(this.DtaGridView_Warehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddImportForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Warehouse)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_GIForm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView DtaGridView_Warehouse;
        public Guna.UI2.WinForms.Guna2TextBox txt_ID_GIForm;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtaGV_GIForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_GIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY_GIF;
        private Guna.UI2.WinForms.Guna2Button btt_Pay;
        private Guna.UI2.WinForms.Guna2Button btt_clearAll;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVENTORY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}