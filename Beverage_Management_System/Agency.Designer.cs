
namespace Beverage_Management_System
{
    partial class Agency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.dtGridView_Agency = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btt_Update = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Agency)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(47, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 52);
            this.label12.TabIndex = 26;
            this.label12.Text = "AGENCY";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtGridView_Agency
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGridView_Agency.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridView_Agency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView_Agency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView_Agency.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridView_Agency.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView_Agency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView_Agency.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_Agency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridView_Agency.ColumnHeadersHeight = 40;
            this.dtGridView_Agency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.ADDRESS,
            this.PHONE,
            this.ITEM});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView_Agency.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtGridView_Agency.EnableHeadersVisualStyles = false;
            this.dtGridView_Agency.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridView_Agency.Location = new System.Drawing.Point(56, 189);
            this.dtGridView_Agency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGridView_Agency.Name = "dtGridView_Agency";
            this.dtGridView_Agency.ReadOnly = true;
            this.dtGridView_Agency.RowHeadersVisible = false;
            this.dtGridView_Agency.RowHeadersWidth = 60;
            this.dtGridView_Agency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView_Agency.Size = new System.Drawing.Size(1347, 801);
            this.dtGridView_Agency.TabIndex = 35;
            this.dtGridView_Agency.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_Agency.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridView_Agency.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridView_Agency.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridView_Agency.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridView_Agency.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_Agency.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridView_Agency.ThemeStyle.HeaderStyle.Height = 40;
            this.dtGridView_Agency.ThemeStyle.ReadOnly = true;
            this.dtGridView_Agency.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGridView_Agency.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dtGridView_Agency.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridView_Agency.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Agency.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridView_Agency.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Agency.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtGridView_Agency.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_Agency_CellContentDoubleClick);
            // 
            // btt_Update
            // 
            this.btt_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_Update.BackColor = System.Drawing.Color.Transparent;
            this.btt_Update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_Update.BorderRadius = 25;
            this.btt_Update.BorderThickness = 1;
            this.btt_Update.CheckedState.Parent = this.btt_Update;
            this.btt_Update.CustomImages.Parent = this.btt_Update;
            this.btt_Update.DisabledState.Parent = this.btt_Update;
            this.btt_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_Update.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Update.ForeColor = System.Drawing.Color.White;
            this.btt_Update.HoverState.Parent = this.btt_Update;
            this.btt_Update.Image = global::Beverage_Management_System.Properties.Resources.update_arrows;
            this.btt_Update.ImageSize = new System.Drawing.Size(15, 15);
            this.btt_Update.Location = new System.Drawing.Point(1054, 105);
            this.btt_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Update.Name = "btt_Update";
            this.btt_Update.ShadowDecoration.Parent = this.btt_Update;
            this.btt_Update.Size = new System.Drawing.Size(118, 62);
            this.btt_Update.TabIndex = 91;
            this.btt_Update.Text = "Update";
            this.btt_Update.Click += new System.EventHandler(this.btt_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delete.BackColor = System.Drawing.Color.Transparent;
            this.bt_Delete.BorderColor = System.Drawing.Color.Firebrick;
            this.bt_Delete.BorderRadius = 25;
            this.bt_Delete.BorderThickness = 1;
            this.bt_Delete.CheckedState.Parent = this.bt_Delete;
            this.bt_Delete.CustomImages.Parent = this.bt_Delete;
            this.bt_Delete.DisabledState.Parent = this.bt_Delete;
            this.bt_Delete.FillColor = System.Drawing.Color.Firebrick;
            this.bt_Delete.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.ForeColor = System.Drawing.Color.White;
            this.bt_Delete.HoverState.Parent = this.bt_Delete;
            this.bt_Delete.Image = global::Beverage_Management_System.Properties.Resources.delete2;
            this.bt_Delete.ImageSize = new System.Drawing.Size(18, 18);
            this.bt_Delete.Location = new System.Drawing.Point(929, 105);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(118, 62);
            this.bt_Delete.TabIndex = 90;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2TextBox1.BorderRadius = 25;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::Beverage_Management_System.Properties.Resources.search1;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(56, 105);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search ID or Agency Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(322, 62);
            this.guna2TextBox1.TabIndex = 34;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.guna2Button1.Location = new System.Drawing.Point(1179, 105);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(224, 62);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "Add a new agency";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.FillWeight = 126.1364F;
            this.ID.HeaderText = " ID";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NAME.DefaultCellStyle = dataGridViewCellStyle4;
            this.NAME.FillWeight = 193.4091F;
            this.NAME.HeaderText = "    NAME";
            this.NAME.MinimumWidth = 7;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 230;
            // 
            // ADDRESS
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ADDRESS.DefaultCellStyle = dataGridViewCellStyle5;
            this.ADDRESS.FillWeight = 16.81819F;
            this.ADDRESS.HeaderText = "           ADDRESS";
            this.ADDRESS.MinimumWidth = 8;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PHONE.DefaultCellStyle = dataGridViewCellStyle6;
            this.PHONE.FillWeight = 16.81819F;
            this.PHONE.HeaderText = "     PHONE";
            this.PHONE.MinimumWidth = 8;
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            this.PHONE.Width = 200;
            // 
            // ITEM
            // 
            this.ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ITEM.DefaultCellStyle = dataGridViewCellStyle7;
            this.ITEM.FillWeight = 16.81819F;
            this.ITEM.HeaderText = "       ITEM";
            this.ITEM.MinimumWidth = 8;
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Width = 200;
            // 
            // Agency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 1049);
            this.Controls.Add(this.btt_Update);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.dtGridView_Agency);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Agency";
            this.Text = "Agency";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Agency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2DataGridView dtGridView_Agency;
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        private Guna.UI2.WinForms.Guna2Button btt_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
    }
}