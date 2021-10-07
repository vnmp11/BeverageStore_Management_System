
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.DtaGridView_IGF = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_IGF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BARTENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btt_Add = new Guna.UI2.WinForms.Guna2Button();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_IGF)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(579, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(378, 39);
            this.label12.TabIndex = 99;
            this.label12.Text = "IMPORT GOODS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DtaGridView_IGF
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtaGridView_IGF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DtaGridView_IGF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaGridView_IGF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtaGridView_IGF.BackgroundColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridView_IGF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_IGF.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridView_IGF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DtaGridView_IGF.ColumnHeadersHeight = 32;
            this.DtaGridView_IGF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_IGF,
            this.ID_BARTENDER,
            this.DATE,
            this.STATUS});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtaGridView_IGF.DefaultCellStyle = dataGridViewCellStyle6;
            this.DtaGridView_IGF.EnableHeadersVisualStyles = false;
            this.DtaGridView_IGF.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_IGF.Location = new System.Drawing.Point(172, 196);
            this.DtaGridView_IGF.Name = "DtaGridView_IGF";
            this.DtaGridView_IGF.RowHeadersVisible = false;
            this.DtaGridView_IGF.RowHeadersWidth = 62;
            this.DtaGridView_IGF.RowTemplate.Height = 28;
            this.DtaGridView_IGF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaGridView_IGF.Size = new System.Drawing.Size(1125, 779);
            this.DtaGridView_IGF.TabIndex = 100;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_IGF.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtaGridView_IGF.ThemeStyle.HeaderStyle.Height = 32;
            this.DtaGridView_IGF.ThemeStyle.ReadOnly = false;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.Height = 28;
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtaGridView_IGF.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_IGF.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGridView_IGF_CellContentDoubleClick);
            // 
            // ID_IGF
            // 
            this.ID_IGF.HeaderText = "ID IMPORT GOODS";
            this.ID_IGF.MinimumWidth = 8;
            this.ID_IGF.Name = "ID_IGF";
            this.ID_IGF.ReadOnly = true;
            // 
            // ID_BARTENDER
            // 
            this.ID_BARTENDER.HeaderText = "ID_BARTENDER";
            this.ID_BARTENDER.MinimumWidth = 8;
            this.ID_BARTENDER.Name = "ID_BARTENDER";
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE CREATED";
            this.DATE.MinimumWidth = 8;
            this.DATE.Name = "DATE";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 8;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.bt_Delete.FillColor = System.Drawing.Color.White;
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Delete.HoverState.Parent = this.bt_Delete;
            this.bt_Delete.ImageOffset = new System.Drawing.Point(2, 0);
            this.bt_Delete.Location = new System.Drawing.Point(871, 103);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(143, 62);
            this.bt_Delete.TabIndex = 102;
            this.bt_Delete.Text = "DELETE";
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
            this.btt_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Add.ForeColor = System.Drawing.Color.White;
            this.btt_Add.HoverState.Parent = this.btt_Add;
            this.btt_Add.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.btt_Add.Location = new System.Drawing.Point(1039, 103);
            this.btt_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Add.Name = "btt_Add";
            this.btt_Add.ShadowDecoration.Parent = this.btt_Add;
            this.btt_Add.Size = new System.Drawing.Size(258, 62);
            this.btt_Add.TabIndex = 101;
            this.btt_Add.Text = "Add a new import goods";
            this.btt_Add.Click += new System.EventHandler(this.btt_Add_Click);
            // 
            // search
            // 
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.search.BorderRadius = 25;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.Parent = this.search;
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.FocusedState.Parent = this.search;
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.HoverState.Parent = this.search;
            this.search.IconLeft = global::Beverage_Management_System.Properties.Resources.search__1_;
            this.search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.search.Location = new System.Drawing.Point(172, 103);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(304, 62);
            this.search.TabIndex = 103;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 1049);
            this.Controls.Add(this.search);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.btt_Add);
            this.Controls.Add(this.DtaGridView_IGF);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_IGF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView DtaGridView_IGF;
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        private Guna.UI2.WinForms.Guna2Button btt_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_IGF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BARTENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn STATUS;
        private Guna.UI2.WinForms.Guna2TextBox search;
    }
}