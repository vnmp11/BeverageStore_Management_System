﻿
namespace Beverage_Management_System
{
    partial class ManageReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGV_Report = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label12.Location = new System.Drawing.Point(486, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "MANAGE REPORT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_Search
            // 
            this.txb_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
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
            this.txb_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txb_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Search.HoverState.Parent = this.txb_Search;
            this.txb_Search.IconLeft = global::Beverage_Management_System.Properties.Resources.search__1_;
            this.txb_Search.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.txb_Search.Location = new System.Drawing.Point(39, 80);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.PasswordChar = '\0';
            this.txb_Search.PlaceholderText = "";
            this.txb_Search.SelectedText = "";
            this.txb_Search.ShadowDecoration.Parent = this.txb_Search;
            this.txb_Search.Size = new System.Drawing.Size(270, 50);
            this.txb_Search.TabIndex = 33;
            this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
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
            this.dataGV_Report.ColumnHeadersHeight = 60;
            this.dataGV_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGV_Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_ORDER_FORM,
            this.REASON,
            this.SOLUTION,
            this.FINE,
            this.DATE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGV_Report.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV_Report.EnableHeadersVisualStyles = false;
            this.dataGV_Report.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGV_Report.Location = new System.Drawing.Point(39, 155);
            this.dataGV_Report.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_Report.Name = "dataGV_Report";
            this.dataGV_Report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGV_Report.RowHeadersVisible = false;
            this.dataGV_Report.RowHeadersWidth = 70;
            this.dataGV_Report.RowTemplate.Height = 35;
            this.dataGV_Report.RowTemplate.ReadOnly = true;
            this.dataGV_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Report.Size = new System.Drawing.Size(1159, 528);
            this.dataGV_Report.TabIndex = 127;
            this.dataGV_Report.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGV_Report.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGV_Report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dataGV_Report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dataGV_Report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGV_Report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGV_Report.ThemeStyle.HeaderStyle.Height = 60;
            this.dataGV_Report.ThemeStyle.ReadOnly = false;
            this.dataGV_Report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGV_Report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dataGV_Report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGV_Report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dataGV_Report.ThemeStyle.RowsStyle.Height = 35;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGV_Report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dataGV_Report.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Report_CellContentDoubleClick_1);
            // 
            // ID
            // 
            this.ID.FillWeight = 11.0432F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_ORDER_FORM
            // 
            this.ID_ORDER_FORM.FillWeight = 30F;
            this.ID_ORDER_FORM.HeaderText = "ID ORDER FORM";
            this.ID_ORDER_FORM.MinimumWidth = 7;
            this.ID_ORDER_FORM.Name = "ID_ORDER_FORM";
            this.ID_ORDER_FORM.ReadOnly = true;
            // 
            // REASON
            // 
            this.REASON.FillWeight = 26.45159F;
            this.REASON.HeaderText = "REASON";
            this.REASON.MinimumWidth = 7;
            this.REASON.Name = "REASON";
            this.REASON.ReadOnly = true;
            // 
            // SOLUTION
            // 
            this.SOLUTION.FillWeight = 46.19893F;
            this.SOLUTION.HeaderText = "SOLUTION";
            this.SOLUTION.MinimumWidth = 7;
            this.SOLUTION.Name = "SOLUTION";
            this.SOLUTION.ReadOnly = true;
            // 
            // FINE
            // 
            this.FINE.FillWeight = 24.85566F;
            this.FINE.HeaderText = "FINE";
            this.FINE.MinimumWidth = 7;
            this.FINE.Name = "FINE";
            this.FINE.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.FillWeight = 27.17766F;
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 7;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // ManageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 839);
            this.Controls.Add(this.dataGV_Report);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "1271, 839";
            this.Load += new System.EventHandler(this.ManageReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txb_Search;
        public Guna.UI2.WinForms.Guna2DataGridView dataGV_Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ORDER_FORM;
        private System.Windows.Forms.DataGridViewTextBoxColumn REASON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}