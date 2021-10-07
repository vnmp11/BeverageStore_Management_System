
namespace Beverage_Management_System
{
    partial class ListImportForm
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
            this.DtaGridView_Warehouse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BARTENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Warehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(397, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 39);
            this.label12.TabIndex = 97;
            this.label12.Text = "IMPORT FORM";
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
            this.ID,
            this.ID_BARTENDER,
            this.DATE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtaGridView_Warehouse.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtaGridView_Warehouse.EnableHeadersVisualStyles = false;
            this.DtaGridView_Warehouse.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Warehouse.Location = new System.Drawing.Point(111, 76);
            this.DtaGridView_Warehouse.Name = "DtaGridView_Warehouse";
            this.DtaGridView_Warehouse.RowHeadersVisible = false;
            this.DtaGridView_Warehouse.RowHeadersWidth = 62;
            this.DtaGridView_Warehouse.RowTemplate.Height = 28;
            this.DtaGridView_Warehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaGridView_Warehouse.Size = new System.Drawing.Size(846, 591);
            this.DtaGridView_Warehouse.TabIndex = 98;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Warehouse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtaGridView_Warehouse.ThemeStyle.HeaderStyle.Height = 32;
            this.DtaGridView_Warehouse.ThemeStyle.ReadOnly = false;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.Height = 28;
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtaGridView_Warehouse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID_IMPORTFORM";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
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
            // ListImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 984);
            this.Controls.Add(this.DtaGridView_Warehouse);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListImportForm";
            this.Text = "ListImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Warehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView DtaGridView_Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BARTENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}