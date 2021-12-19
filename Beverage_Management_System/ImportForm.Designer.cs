
namespace Beverage_Management_System
{
    partial class ImportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btt_Add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtaGridView_IGF = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_IGF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BARTENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARTENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_IGF)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(80, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(507, 47);
            this.label12.TabIndex = 99;
            this.label12.Text = "GOODS IMPORT FORMS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.bt_Delete.Location = new System.Drawing.Point(832, 129);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(105, 50);
            this.bt_Delete.TabIndex = 102;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // btt_Add
            // 
            this.btt_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_Add.BorderColor = System.Drawing.Color.Transparent;
            this.btt_Add.BorderRadius = 25;
            this.btt_Add.BorderThickness = 1;
            this.btt_Add.CheckedState.Parent = this.btt_Add;
            this.btt_Add.CustomImages.Parent = this.btt_Add;
            this.btt_Add.DisabledState.Parent = this.btt_Add;
            this.btt_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_Add.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Add.ForeColor = System.Drawing.Color.White;
            this.btt_Add.HoverState.Parent = this.btt_Add;
            this.btt_Add.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.btt_Add.Location = new System.Drawing.Point(943, 129);
            this.btt_Add.Name = "btt_Add";
            this.btt_Add.ShadowDecoration.Parent = this.btt_Add;
            this.btt_Add.Size = new System.Drawing.Size(261, 50);
            this.btt_Add.TabIndex = 101;
            this.btt_Add.Text = "Add a new goods import form";
            this.btt_Add.Click += new System.EventHandler(this.btt_Add_Click);
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
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.IconLeft = global::Beverage_Management_System.Properties.Resources.search1;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txt_Search.Location = new System.Drawing.Point(88, 129);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search ID or Bartender\'s Full Name";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(328, 50);
            this.txt_Search.TabIndex = 103;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // DtaGridView_IGF
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DtaGridView_IGF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtaGridView_IGF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaGridView_IGF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtaGridView_IGF.BackgroundColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridView_IGF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DtaGridView_IGF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridView_IGF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DtaGridView_IGF.ColumnHeadersHeight = 40;
            this.DtaGridView_IGF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_IGF,
            this.ID_BARTENDER,
            this.BARTENDER,
            this.DATE,
            this.STATUS});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtaGridView_IGF.DefaultCellStyle = dataGridViewCellStyle14;
            this.DtaGridView_IGF.EnableHeadersVisualStyles = false;
            this.DtaGridView_IGF.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_IGF.Location = new System.Drawing.Point(88, 213);
            this.DtaGridView_IGF.Margin = new System.Windows.Forms.Padding(4);
            this.DtaGridView_IGF.Name = "DtaGridView_IGF";
            this.DtaGridView_IGF.ReadOnly = true;
            this.DtaGridView_IGF.RowHeadersVisible = false;
            this.DtaGridView_IGF.RowHeadersWidth = 60;
            this.DtaGridView_IGF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaGridView_IGF.Size = new System.Drawing.Size(1116, 547);
            this.DtaGridView_IGF.TabIndex = 104;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.Height = 40;
            this.DtaGridView_IGF.ThemeStyle.ReadOnly = true;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.Height = 22;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridView_IGF_CellDoubleClick);
            // 
            // ID_IGF
            // 
            this.ID_IGF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_IGF.DefaultCellStyle = dataGridViewCellStyle10;
            this.ID_IGF.FillWeight = 50F;
            this.ID_IGF.HeaderText = "  ID";
            this.ID_IGF.MinimumWidth = 7;
            this.ID_IGF.Name = "ID_IGF";
            this.ID_IGF.ReadOnly = true;
            this.ID_IGF.Width = 70;
            // 
            // ID_BARTENDER
            // 
            this.ID_BARTENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_BARTENDER.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID_BARTENDER.HeaderText = "  ID BARTENDER";
            this.ID_BARTENDER.MinimumWidth = 8;
            this.ID_BARTENDER.Name = "ID_BARTENDER";
            this.ID_BARTENDER.ReadOnly = true;
            this.ID_BARTENDER.Width = 200;
            // 
            // BARTENDER
            // 
            this.BARTENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BARTENDER.DefaultCellStyle = dataGridViewCellStyle12;
            this.BARTENDER.HeaderText = "                              BARTENDER";
            this.BARTENDER.MinimumWidth = 8;
            this.BARTENDER.Name = "BARTENDER";
            this.BARTENDER.ReadOnly = true;
            this.BARTENDER.Width = 450;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE.DefaultCellStyle = dataGridViewCellStyle13;
            this.DATE.HeaderText = "           CREATED DATE";
            this.DATE.MinimumWidth = 8;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 287;
            // 
            // STATUS
            // 
            this.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STATUS.HeaderText = " STATUS";
            this.STATUS.MinimumWidth = 8;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STATUS.Width = 115;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 839);
            this.Controls.Add(this.DtaGridView_IGF);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.btt_Add);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_IGF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        private Guna.UI2.WinForms.Guna2Button btt_Add;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        public Guna.UI2.WinForms.Guna2DataGridView DtaGridView_IGF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IGF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BARTENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARTENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn STATUS;
    }
}