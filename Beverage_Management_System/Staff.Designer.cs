
namespace Beverage_Management_System
{
    partial class Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.dtGridView_Staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(37, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 47);
            this.label12.TabIndex = 23;
            this.label12.Text = "ALL STAFF";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bt_Delete);
            this.panel6.Controls.Add(this.dtGridView_Staff);
            this.panel6.Controls.Add(this.txt_Search);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.guna2Button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel6.Size = new System.Drawing.Size(1245, 699);
            this.panel6.TabIndex = 32;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Delete.BackColor = System.Drawing.Color.Transparent;
            this.bt_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bt_Delete.Location = new System.Drawing.Point(862, 91);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(105, 50);
            this.bt_Delete.TabIndex = 89;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // dtGridView_Staff
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dtGridView_Staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dtGridView_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView_Staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridView_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView_Staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtGridView_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dtGridView_Staff.ColumnHeadersHeight = 40;
            this.dtGridView_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.USERNAME,
            this.PASSWORD,
            this.NAME,
            this.DOB,
            this.SEX,
            this.PHONE,
            this.ADDRESS,
            this.ROLE});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView_Staff.DefaultCellStyle = dataGridViewCellStyle36;
            this.dtGridView_Staff.EnableHeadersVisualStyles = false;
            this.dtGridView_Staff.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridView_Staff.Location = new System.Drawing.Point(45, 169);
            this.dtGridView_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView_Staff.Name = "dtGridView_Staff";
            this.dtGridView_Staff.ReadOnly = true;
            this.dtGridView_Staff.RowHeadersVisible = false;
            this.dtGridView_Staff.RowHeadersWidth = 60;
            this.dtGridView_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView_Staff.Size = new System.Drawing.Size(1159, 492);
            this.dtGridView_Staff.TabIndex = 34;
            this.dtGridView_Staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_Staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridView_Staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridView_Staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridView_Staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridView_Staff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_Staff.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridView_Staff.ThemeStyle.HeaderStyle.Height = 40;
            this.dtGridView_Staff.ThemeStyle.ReadOnly = true;
            this.dtGridView_Staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGridView_Staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtGridView_Staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridView_Staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Staff.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridView_Staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_Staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtGridView_Staff.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGridView_Staff_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle27;
            this.ID.FillWeight = 15F;
            this.ID.HeaderText = "  ID";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERNAME.DefaultCellStyle = dataGridViewCellStyle28;
            this.USERNAME.FillWeight = 50F;
            this.USERNAME.HeaderText = "   USERNAME";
            this.USERNAME.MinimumWidth = 7;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            this.USERNAME.Width = 170;
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PASSWORD.DefaultCellStyle = dataGridViewCellStyle29;
            this.PASSWORD.FillWeight = 8.825108F;
            this.PASSWORD.HeaderText = "   PASSWORD";
            this.PASSWORD.MinimumWidth = 7;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Width = 160;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NAME.DefaultCellStyle = dataGridViewCellStyle30;
            this.NAME.FillWeight = 11.18557F;
            this.NAME.HeaderText = "       FULL NAME";
            this.NAME.MinimumWidth = 7;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 200;
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DOB.DefaultCellStyle = dataGridViewCellStyle31;
            this.DOB.FillWeight = 4.47423F;
            this.DOB.HeaderText = "       DOB";
            this.DOB.MinimumWidth = 7;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 130;
            // 
            // SEX
            // 
            this.SEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SEX.DefaultCellStyle = dataGridViewCellStyle32;
            this.SEX.FillWeight = 3.355673F;
            this.SEX.HeaderText = "   SEX";
            this.SEX.MinimumWidth = 7;
            this.SEX.Name = "SEX";
            this.SEX.ReadOnly = true;
            this.SEX.Width = 90;
            // 
            // PHONE
            // 
            this.PHONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PHONE.DefaultCellStyle = dataGridViewCellStyle33;
            this.PHONE.FillWeight = 4.47423F;
            this.PHONE.HeaderText = "      PHONE";
            this.PHONE.MinimumWidth = 7;
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            this.PHONE.Width = 150;
            // 
            // ADDRESS
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ADDRESS.DefaultCellStyle = dataGridViewCellStyle34;
            this.ADDRESS.FillWeight = 10.06702F;
            this.ADDRESS.HeaderText = "         ADDRESS";
            this.ADDRESS.MinimumWidth = 7;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // ROLE
            // 
            this.ROLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ROLE.DefaultCellStyle = dataGridViewCellStyle35;
            this.ROLE.FillWeight = 25.24015F;
            this.ROLE.HeaderText = " ROLE";
            this.ROLE.MinimumWidth = 7;
            this.ROLE.Name = "ROLE";
            this.ROLE.ReadOnly = true;
            this.ROLE.Width = 85;
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txt_Search.BorderRadius = 25;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.Parent = this.txt_Search;
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.FocusedState.Parent = this.txt_Search;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.IconLeft = global::Beverage_Management_System.Properties.Resources.search1;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txt_Search.Location = new System.Drawing.Point(45, 91);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search ID or Full Name";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(237, 50);
            this.txt_Search.TabIndex = 33;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.guna2Button4.BorderRadius = 25;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2Button4.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = global::Beverage_Management_System.Properties.Resources.ic_adduser;
            this.guna2Button4.Location = new System.Drawing.Point(973, 91);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(231, 50);
            this.guna2Button4.TabIndex = 22;
            this.guna2Button4.Text = "Add a new staff member";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 699);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Staff";
            this.Text = "Form1";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        public Guna.UI2.WinForms.Guna2DataGridView dtGridView_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE;
    }
}