
namespace Beverage_Management_System
{
    partial class GoodsImportBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GOODS_IMPORT_FORM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BARTENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_CREATED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Details = new System.Windows.Forms.Label();
            this.fLayoutPl_Details = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.btt_Browse = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV.BackgroundColor = System.Drawing.Color.White;
            this.dataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV.ColumnHeadersHeight = 40;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_GOODS_IMPORT_FORM,
            this.ID_BARTENDER,
            this.DATE_CREATED,
            this.TOTAL_PRICE});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGV.EnableHeadersVisualStyles = false;
            this.dataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGV.Location = new System.Drawing.Point(47, 190);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGV.RowHeadersVisible = false;
            this.dataGV.RowHeadersWidth = 70;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(665, 528);
            this.dataGV.TabIndex = 99;
            this.dataGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dataGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dataGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGV.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGV.ThemeStyle.ReadOnly = true;
            this.dataGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV.ThemeStyle.RowsStyle.Height = 22;
            this.dataGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.FillWeight = 8F;
            this.ID.HeaderText = "    ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // ID_GOODS_IMPORT_FORM
            // 
            this.ID_GOODS_IMPORT_FORM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_GOODS_IMPORT_FORM.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID_GOODS_IMPORT_FORM.FillWeight = 13F;
            this.ID_GOODS_IMPORT_FORM.HeaderText = "  ID FORM";
            this.ID_GOODS_IMPORT_FORM.MinimumWidth = 7;
            this.ID_GOODS_IMPORT_FORM.Name = "ID_GOODS_IMPORT_FORM";
            this.ID_GOODS_IMPORT_FORM.ReadOnly = true;
            this.ID_GOODS_IMPORT_FORM.Width = 120;
            // 
            // ID_BARTENDER
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_BARTENDER.DefaultCellStyle = dataGridViewCellStyle5;
            this.ID_BARTENDER.FillWeight = 8F;
            this.ID_BARTENDER.HeaderText = "      BARTENDER";
            this.ID_BARTENDER.MinimumWidth = 7;
            this.ID_BARTENDER.Name = "ID_BARTENDER";
            this.ID_BARTENDER.ReadOnly = true;
            // 
            // DATE_CREATED
            // 
            this.DATE_CREATED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_CREATED.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATE_CREATED.FillWeight = 15F;
            this.DATE_CREATED.HeaderText = "     CREATED";
            this.DATE_CREATED.MinimumWidth = 7;
            this.DATE_CREATED.Name = "DATE_CREATED";
            this.DATE_CREATED.ReadOnly = true;
            this.DATE_CREATED.Width = 170;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TOTAL_PRICE.DefaultCellStyle = dataGridViewCellStyle7;
            this.TOTAL_PRICE.FillWeight = 20F;
            this.TOTAL_PRICE.HeaderText = "        TOTAL";
            this.TOTAL_PRICE.MinimumWidth = 7;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            this.TOTAL_PRICE.Width = 170;
            // 
            // lb_Details
            // 
            this.lb_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lb_Details.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Details.ForeColor = System.Drawing.Color.White;
            this.lb_Details.Location = new System.Drawing.Point(742, 190);
            this.lb_Details.Name = "lb_Details";
            this.lb_Details.Size = new System.Drawing.Size(388, 33);
            this.lb_Details.TabIndex = 108;
            this.lb_Details.Text = "DETAILS";
            this.lb_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLayoutPl_Details
            // 
            this.fLayoutPl_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLayoutPl_Details.AutoScroll = true;
            this.fLayoutPl_Details.BackColor = System.Drawing.Color.White;
            this.fLayoutPl_Details.Location = new System.Drawing.Point(736, 224);
            this.fLayoutPl_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLayoutPl_Details.Name = "fLayoutPl_Details";
            this.fLayoutPl_Details.Size = new System.Drawing.Size(417, 415);
            this.fLayoutPl_Details.TabIndex = 107;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.lb_Details;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 26F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(363, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(509, 44);
            this.label12.TabIndex = 109;
            this.label12.Text = "GOODS IMPORT BILL";
            // 
            // btt_Browse
            // 
            this.btt_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_Browse.BorderColor = System.Drawing.Color.Transparent;
            this.btt_Browse.BorderRadius = 5;
            this.btt_Browse.BorderThickness = 1;
            this.btt_Browse.CheckedState.Parent = this.btt_Browse;
            this.btt_Browse.CustomImages.Parent = this.btt_Browse;
            this.btt_Browse.DisabledState.Parent = this.btt_Browse;
            this.btt_Browse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_Browse.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Browse.ForeColor = System.Drawing.Color.White;
            this.btt_Browse.HoverState.Parent = this.btt_Browse;
            this.btt_Browse.Image = global::Beverage_Management_System.Properties.Resources.confirm;
            this.btt_Browse.Location = new System.Drawing.Point(968, 667);
            this.btt_Browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_Browse.Name = "btt_Browse";
            this.btt_Browse.ShadowDecoration.Parent = this.btt_Browse;
            this.btt_Browse.Size = new System.Drawing.Size(183, 51);
            this.btt_Browse.TabIndex = 106;
            this.btt_Browse.Text = "BROWSE";
            this.btt_Browse.Click += new System.EventHandler(this.btt_Browse_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
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
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.IconLeft = global::Beverage_Management_System.Properties.Resources.search__1_;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txt_Search.Location = new System.Drawing.Point(47, 133);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search ID or ID Form or Bartender";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(319, 46);
            this.txt_Search.TabIndex = 100;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // GoodsImportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1205, 778);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_Details);
            this.Controls.Add(this.fLayoutPl_Details);
            this.Controls.Add(this.btt_Browse);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsImportBill";
            this.Text = "GoodsImportBill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dataGV;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2Button btt_Browse;
        private System.Windows.Forms.Label lb_Details;
        private System.Windows.Forms.FlowLayoutPanel fLayoutPl_Details;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GOODS_IMPORT_FORM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BARTENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_CREATED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
    }
}