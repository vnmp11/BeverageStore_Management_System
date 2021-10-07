
namespace Beverage_Management_System
{
    partial class GoodsInImportForm
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
            this.DtaGridView_Goods = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_Save = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Goods)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtaGridView_Goods
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaGridView_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DtaGridView_Goods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaGridView_Goods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtaGridView_Goods.BackgroundColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGridView_Goods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_Goods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGridView_Goods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaGridView_Goods.ColumnHeadersHeight = 32;
            this.DtaGridView_Goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.QUANTITY,
            this.STATUS});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtaGridView_Goods.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtaGridView_Goods.EnableHeadersVisualStyles = false;
            this.DtaGridView_Goods.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Goods.Location = new System.Drawing.Point(76, 118);
            this.DtaGridView_Goods.Name = "DtaGridView_Goods";
            this.DtaGridView_Goods.RowHeadersVisible = false;
            this.DtaGridView_Goods.RowHeadersWidth = 62;
            this.DtaGridView_Goods.RowTemplate.Height = 28;
            this.DtaGridView_Goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtaGridView_Goods.Size = new System.Drawing.Size(817, 344);
            this.DtaGridView_Goods.TabIndex = 101;
            this.DtaGridView_Goods.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtaGridView_Goods.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Goods.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtaGridView_Goods.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtaGridView_Goods.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtaGridView_Goods.ThemeStyle.HeaderStyle.Height = 32;
            this.DtaGridView_Goods.ThemeStyle.ReadOnly = false;
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.Height = 28;
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DtaGridView_Goods.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 8;
            this.QUANTITY.Name = "QUANTITY";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 8;
            this.STATUS.Name = "STATUS";
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Save.BorderColor = System.Drawing.Color.Transparent;
            this.bt_Save.BorderRadius = 25;
            this.bt_Save.BorderThickness = 1;
            this.bt_Save.CheckedState.Parent = this.bt_Save;
            this.bt_Save.CustomImages.Parent = this.bt_Save;
            this.bt_Save.DisabledState.Parent = this.bt_Save;
            this.bt_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.ForeColor = System.Drawing.Color.White;
            this.bt_Save.HoverState.Parent = this.bt_Save;
            this.bt_Save.Image = global::Beverage_Management_System.Properties.Resources.update_arrows;
            this.bt_Save.Location = new System.Drawing.Point(734, 481);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.ShadowDecoration.Parent = this.bt_Save;
            this.bt_Save.Size = new System.Drawing.Size(159, 62);
            this.bt_Save.TabIndex = 102;
            this.bt_Save.Text = "CONFIRM";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-4, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 80);
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(894, 20);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 56);
            this.guna2ImageButton1.TabIndex = 108;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(252, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(430, 39);
            this.label12.TabIndex = 94;
            this.label12.Text = "DETAIL IMPORT GOODS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GoodsInImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(946, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.DtaGridView_Goods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsInImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsInImportForm";
            this.Load += new System.EventHandler(this.GoodsInImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGridView_Goods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DtaGridView_Goods;
        private Guna.UI2.WinForms.Guna2Button bt_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn STATUS;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}