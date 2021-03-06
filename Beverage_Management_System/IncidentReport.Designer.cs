
namespace Beverage_Management_System
{
    partial class IncidentReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGV_Report = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txb_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_addReport = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ID_REPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ORDER_FORM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Report
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_Report.BackgroundColor = System.Drawing.Color.White;
            this.dataGV_Report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV_Report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_Report.ColumnHeadersHeight = 40;
            this.dataGV_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REPORT,
            this.ID_ORDER_FORM,
            this.REASON,
            this.SOLUTION,
            this.FINE,
            this.DATE});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Report.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGV_Report.EnableHeadersVisualStyles = false;
            this.dataGV_Report.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGV_Report.Location = new System.Drawing.Point(42, 195);
            this.dataGV_Report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGV_Report.Name = "dataGV_Report";
            this.dataGV_Report.ReadOnly = true;
            this.dataGV_Report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Report.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGV_Report.RowHeadersVisible = false;
            this.dataGV_Report.RowHeadersWidth = 70;
            this.dataGV_Report.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Report.Size = new System.Drawing.Size(1272, 704);
            this.dataGV_Report.TabIndex = 125;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGV_Report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGV_Report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dataGV_Report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGV_Report.ThemeStyle.ReadOnly = true;
            this.dataGV_Report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGV_Report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV_Report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGV_Report.ThemeStyle.RowsStyle.Height = 22;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGV_Report.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Report_CellContentDoubleClick);
            this.dataGV_Report.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGV_Report_CellMouseDoubleClick);
            // 
            // txb_Search
            // 
            this.txb_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txb_Search.BorderRadius = 25;
            this.txb_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Search.DefaultText = "";
            this.txb_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Search.DisabledState.Parent = this.txb_Search;
            this.txb_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Search.FocusedState.Parent = this.txb_Search;
            this.txb_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.txb_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Search.HoverState.Parent = this.txb_Search;
            this.txb_Search.IconLeft = global::Beverage_Management_System.Properties.Resources.search1;
            this.txb_Search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txb_Search.Location = new System.Drawing.Point(42, 104);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.PasswordChar = '\0';
            this.txb_Search.PlaceholderText = "Search ID or ID Order Form";
            this.txb_Search.SelectedText = "";
            this.txb_Search.ShadowDecoration.Parent = this.txb_Search;
            this.txb_Search.Size = new System.Drawing.Size(294, 62);
            this.txb_Search.TabIndex = 126;
            this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
            this.txb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Search_KeyDown);
            this.txb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Search_KeyPress);
            // 
            // btt_addReport
            // 
            this.btt_addReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_addReport.BorderColor = System.Drawing.Color.Transparent;
            this.btt_addReport.BorderRadius = 25;
            this.btt_addReport.BorderThickness = 1;
            this.btt_addReport.CheckedState.Parent = this.btt_addReport;
            this.btt_addReport.CustomImages.Parent = this.btt_addReport;
            this.btt_addReport.DisabledState.Parent = this.btt_addReport;
            this.btt_addReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_addReport.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_addReport.ForeColor = System.Drawing.Color.White;
            this.btt_addReport.HoverState.Parent = this.btt_addReport;
            this.btt_addReport.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.btt_addReport.Location = new System.Drawing.Point(1090, 104);
            this.btt_addReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_addReport.Name = "btt_addReport";
            this.btt_addReport.ShadowDecoration.Parent = this.btt_addReport;
            this.btt_addReport.Size = new System.Drawing.Size(224, 62);
            this.btt_addReport.TabIndex = 124;
            this.btt_addReport.Text = "Add a new report";
            this.btt_addReport.Click += new System.EventHandler(this.btt_addReport_Click);
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
            this.bt_Delete.Location = new System.Drawing.Point(965, 104);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(118, 62);
            this.bt_Delete.TabIndex = 127;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(33, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(440, 52);
            this.label12.TabIndex = 28;
            this.label12.Text = "INCIDENT REPORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ID_REPORT
            // 
            this.ID_REPORT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_REPORT.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_REPORT.FillWeight = 5F;
            this.ID_REPORT.Frozen = true;
            this.ID_REPORT.HeaderText = " ID";
            this.ID_REPORT.MinimumWidth = 8;
            this.ID_REPORT.Name = "ID_REPORT";
            this.ID_REPORT.ReadOnly = true;
            this.ID_REPORT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_REPORT.Width = 60;
            // 
            // ID_ORDER_FORM
            // 
            this.ID_ORDER_FORM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_ORDER_FORM.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID_ORDER_FORM.FillWeight = 7F;
            this.ID_ORDER_FORM.Frozen = true;
            this.ID_ORDER_FORM.HeaderText = "   ORDER FORM";
            this.ID_ORDER_FORM.MinimumWidth = 7;
            this.ID_ORDER_FORM.Name = "ID_ORDER_FORM";
            this.ID_ORDER_FORM.ReadOnly = true;
            this.ID_ORDER_FORM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_ORDER_FORM.Width = 200;
            // 
            // REASON
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REASON.DefaultCellStyle = dataGridViewCellStyle5;
            this.REASON.FillWeight = 50F;
            this.REASON.HeaderText = "   REASON";
            this.REASON.MinimumWidth = 7;
            this.REASON.Name = "REASON";
            this.REASON.ReadOnly = true;
            this.REASON.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SOLUTION
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SOLUTION.DefaultCellStyle = dataGridViewCellStyle6;
            this.SOLUTION.FillWeight = 50F;
            this.SOLUTION.HeaderText = "      SOLUTION";
            this.SOLUTION.MinimumWidth = 7;
            this.SOLUTION.Name = "SOLUTION";
            this.SOLUTION.ReadOnly = true;
            this.SOLUTION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FINE
            // 
            this.FINE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FINE.DefaultCellStyle = dataGridViewCellStyle7;
            this.FINE.FillWeight = 20F;
            this.FINE.HeaderText = "    FINE";
            this.FINE.MinimumWidth = 7;
            this.FINE.Name = "FINE";
            this.FINE.ReadOnly = true;
            this.FINE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FINE.Width = 180;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATE.FillWeight = 40F;
            this.DATE.HeaderText = "         CREATED DATE";
            this.DATE.MinimumWidth = 7;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DATE.Width = 270;
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 972);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.dataGV_Report);
            this.Controls.Add(this.btt_addReport);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IncidentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncidentReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btt_addReport;
        public Guna.UI2.WinForms.Guna2DataGridView dataGV_Report;
        private Guna.UI2.WinForms.Guna2TextBox txb_Search;
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REPORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER_FORM;
        private System.Windows.Forms.DataGridViewTextBoxColumn REASON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}