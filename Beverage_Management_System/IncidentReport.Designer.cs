
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.btt_addReport = new Guna.UI2.WinForms.Guna2Button();
            this.dataGV_Report = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_ORDER_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ORDER_FORM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(456, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 31);
            this.label12.TabIndex = 28;
            this.label12.Text = "INCIDENT REPORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btt_addReport
            // 
            this.btt_addReport.BorderColor = System.Drawing.Color.Transparent;
            this.btt_addReport.BorderRadius = 5;
            this.btt_addReport.BorderThickness = 1;
            this.btt_addReport.CheckedState.Parent = this.btt_addReport;
            this.btt_addReport.CustomImages.Parent = this.btt_addReport;
            this.btt_addReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_addReport.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_addReport.ForeColor = System.Drawing.Color.White;
            this.btt_addReport.HoverState.Parent = this.btt_addReport;
            this.btt_addReport.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.btt_addReport.Location = new System.Drawing.Point(67, 75);
            this.btt_addReport.Name = "btt_addReport";
            this.btt_addReport.ShadowDecoration.Parent = this.btt_addReport;
            this.btt_addReport.Size = new System.Drawing.Size(257, 50);
            this.btt_addReport.TabIndex = 124;
            this.btt_addReport.Text = "Add a new report";
            this.btt_addReport.Click += new System.EventHandler(this.btt_addReport_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_Report.ColumnHeadersHeight = 70;
            this.dataGV_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ORDER_BILL,
            this.ID_ORDER_FORM,
            this.REASON,
            this.SOLUTION,
            this.FINE,
            this.DATE});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Report.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGV_Report.EnableHeadersVisualStyles = false;
            this.dataGV_Report.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGV_Report.Location = new System.Drawing.Point(67, 149);
            this.dataGV_Report.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_Report.Name = "dataGV_Report";
            this.dataGV_Report.ReadOnly = true;
            this.dataGV_Report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Report.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGV_Report.RowHeadersVisible = false;
            this.dataGV_Report.RowHeadersWidth = 70;
            this.dataGV_Report.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Report.Size = new System.Drawing.Size(1143, 624);
            this.dataGV_Report.TabIndex = 125;
            this.dataGV_Report.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGV_Report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dataGV_Report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dataGV_Report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Height = 70;
            this.dataGV_Report.ThemeStyle.ReadOnly = true;
            this.dataGV_Report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGV_Report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV_Report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV_Report.ThemeStyle.RowsStyle.Height = 22;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGV_Report.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Report_CellContentDoubleClick);
            // 
            // ID_ORDER_BILL
            // 
            this.ID_ORDER_BILL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_ORDER_BILL.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID_ORDER_BILL.FillWeight = 5F;
            this.ID_ORDER_BILL.Frozen = true;
            this.ID_ORDER_BILL.HeaderText = "ID";
            this.ID_ORDER_BILL.MinimumWidth = 8;
            this.ID_ORDER_BILL.Name = "ID_ORDER_BILL";
            this.ID_ORDER_BILL.ReadOnly = true;
            this.ID_ORDER_BILL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_ORDER_BILL.Width = 50;
            // 
            // ID_ORDER_FORM
            // 
            this.ID_ORDER_FORM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_ORDER_FORM.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID_ORDER_FORM.FillWeight = 7F;
            this.ID_ORDER_FORM.Frozen = true;
            this.ID_ORDER_FORM.HeaderText = "ORDER FORM";
            this.ID_ORDER_FORM.MinimumWidth = 7;
            this.ID_ORDER_FORM.Name = "ID_ORDER_FORM";
            this.ID_ORDER_FORM.ReadOnly = true;
            this.ID_ORDER_FORM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_ORDER_FORM.Width = 120;
            // 
            // REASON
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REASON.DefaultCellStyle = dataGridViewCellStyle5;
            this.REASON.FillWeight = 50F;
            this.REASON.HeaderText = "REASON";
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
            this.SOLUTION.HeaderText = "SOLUTION";
            this.SOLUTION.MinimumWidth = 7;
            this.SOLUTION.Name = "SOLUTION";
            this.SOLUTION.ReadOnly = true;
            this.SOLUTION.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FINE
            // 
            this.FINE.FillWeight = 20F;
            this.FINE.HeaderText = "FINE";
            this.FINE.MinimumWidth = 7;
            this.FINE.Name = "FINE";
            this.FINE.ReadOnly = true;
            this.FINE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DATE
            // 
            this.DATE.FillWeight = 40F;
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 7;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 839);
            this.Controls.Add(this.dataGV_Report);
            this.Controls.Add(this.btt_addReport);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncidentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncidentReport";
            this.Load += new System.EventHandler(this.IncidentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button btt_addReport;
        public Guna.UI2.WinForms.Guna2DataGridView dataGV_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER_BILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER_FORM;
        private System.Windows.Forms.DataGridViewTextBoxColumn REASON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}