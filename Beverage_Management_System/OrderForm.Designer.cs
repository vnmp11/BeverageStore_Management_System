
namespace Beverage_Management_System
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.dtGridView_OrderForm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fLayoutPl_Detail = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_id_order = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btt_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btt_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAITER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_OrderForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(52, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(330, 52);
            this.label12.TabIndex = 96;
            this.label12.Text = "ORDER FORM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtGridView_OrderForm
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridView_OrderForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView_OrderForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView_OrderForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridView_OrderForm.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView_OrderForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_OrderForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridView_OrderForm.ColumnHeadersHeight = 60;
            this.dtGridView_OrderForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.WAITER,
            this.TOTAL_PRICE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView_OrderForm.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridView_OrderForm.EnableHeadersVisualStyles = false;
            this.dtGridView_OrderForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridView_OrderForm.Location = new System.Drawing.Point(61, 204);
            this.dtGridView_OrderForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtGridView_OrderForm.Name = "dtGridView_OrderForm";
            this.dtGridView_OrderForm.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_OrderForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtGridView_OrderForm.RowHeadersVisible = false;
            this.dtGridView_OrderForm.RowHeadersWidth = 60;
            this.dtGridView_OrderForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView_OrderForm.Size = new System.Drawing.Size(620, 560);
            this.dtGridView_OrderForm.TabIndex = 97;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.Height = 60;
            this.dtGridView_OrderForm.ThemeStyle.ReadOnly = true;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dtGridView_OrderForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_OrderForm_CellDoubleClick);
            // 
            // fLayoutPl_Detail
            // 
            this.fLayoutPl_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLayoutPl_Detail.AutoScroll = true;
            this.fLayoutPl_Detail.BackColor = System.Drawing.Color.White;
            this.fLayoutPl_Detail.Location = new System.Drawing.Point(719, 264);
            this.fLayoutPl_Detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLayoutPl_Detail.Name = "fLayoutPl_Detail";
            this.fLayoutPl_Detail.Size = new System.Drawing.Size(610, 500);
            this.fLayoutPl_Detail.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.lb_id_order);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(720, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 62);
            this.panel1.TabIndex = 100;
            // 
            // lb_id_order
            // 
            this.lb_id_order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_id_order.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_order.ForeColor = System.Drawing.Color.White;
            this.lb_id_order.Location = new System.Drawing.Point(374, 19);
            this.lb_id_order.Name = "lb_id_order";
            this.lb_id_order.Size = new System.Drawing.Size(40, 39);
            this.lb_id_order.TabIndex = 96;
            this.lb_id_order.Text = "1";
            this.lb_id_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 39);
            this.label1.TabIndex = 96;
            this.label1.Text = "DETAIL ORDER #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // btt_remove
            // 
            this.btt_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_remove.BorderColor = System.Drawing.Color.Transparent;
            this.btt_remove.BorderRadius = 25;
            this.btt_remove.BorderThickness = 1;
            this.btt_remove.CheckedState.Parent = this.btt_remove;
            this.btt_remove.CustomImages.Parent = this.btt_remove;
            this.btt_remove.DisabledState.Parent = this.btt_remove;
            this.btt_remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_remove.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_remove.ForeColor = System.Drawing.Color.White;
            this.btt_remove.HoverState.Parent = this.btt_remove;
            this.btt_remove.Image = global::Beverage_Management_System.Properties.Resources.delete1;
            this.btt_remove.Location = new System.Drawing.Point(865, 819);
            this.btt_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_remove.Name = "btt_remove";
            this.btt_remove.ShadowDecoration.Parent = this.btt_remove;
            this.btt_remove.Size = new System.Drawing.Size(202, 64);
            this.btt_remove.TabIndex = 101;
            this.btt_remove.Text = "DELETE";
            this.btt_remove.Click += new System.EventHandler(this.btt_remove_Click);
            // 
            // btt_confirm
            // 
            this.btt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_confirm.BorderColor = System.Drawing.Color.Transparent;
            this.btt_confirm.BorderRadius = 25;
            this.btt_confirm.BorderThickness = 1;
            this.btt_confirm.CheckedState.Parent = this.btt_confirm;
            this.btt_confirm.CustomImages.Parent = this.btt_confirm;
            this.btt_confirm.DisabledState.Parent = this.btt_confirm;
            this.btt_confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_confirm.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_confirm.ForeColor = System.Drawing.Color.White;
            this.btt_confirm.HoverState.Parent = this.btt_confirm;
            this.btt_confirm.Image = global::Beverage_Management_System.Properties.Resources.confirm;
            this.btt_confirm.Location = new System.Drawing.Point(1080, 819);
            this.btt_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_confirm.Name = "btt_confirm";
            this.btt_confirm.ShadowDecoration.Parent = this.btt_confirm;
            this.btt_confirm.Size = new System.Drawing.Size(201, 64);
            this.btt_confirm.TabIndex = 101;
            this.btt_confirm.Text = "CONFIRM";
            this.btt_confirm.Click += new System.EventHandler(this.btt_confirm_Click);
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
            this.txt_Search.Location = new System.Drawing.Point(61, 119);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search ID or Waiter\'s Full Name";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(319, 62);
            this.txt_Search.TabIndex = 102;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // ID1
            // 
            this.ID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID1.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID1.FillWeight = 30F;
            this.ID1.HeaderText = "  ID";
            this.ID1.MinimumWidth = 7;
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Width = 80;
            // 
            // WAITER
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.WAITER.DefaultCellStyle = dataGridViewCellStyle4;
            this.WAITER.FillWeight = 35F;
            this.WAITER.HeaderText = "     WAITER";
            this.WAITER.MinimumWidth = 7;
            this.WAITER.Name = "WAITER";
            this.WAITER.ReadOnly = true;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TOTAL_PRICE.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOTAL_PRICE.FillWeight = 39.44861F;
            this.TOTAL_PRICE.HeaderText = "     TOTAL PRICE";
            this.TOTAL_PRICE.MinimumWidth = 7;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            this.TOTAL_PRICE.Width = 239;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1356, 972);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btt_remove);
            this.Controls.Add(this.btt_confirm);
            this.Controls.Add(this.fLayoutPl_Detail);
            this.Controls.Add(this.dtGridView_OrderForm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_OrderForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2DataGridView dtGridView_OrderForm;
        private System.Windows.Forms.FlowLayoutPanel fLayoutPl_Detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_id_order;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btt_confirm;
        private Guna.UI2.WinForms.Guna2Button btt_remove;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAITER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
    }
}