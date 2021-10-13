
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.dtGridView_OrderForm = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PERSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLayoutPl_Detail = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_id_order = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btt_remove = new Guna.UI2.WinForms.Guna2Button();
            this.btt_confirm = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_OrderForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(461, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 31);
            this.label12.TabIndex = 96;
            this.label12.Text = "ORDER FORM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_OrderForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridView_OrderForm.ColumnHeadersHeight = 60;
            this.dtGridView_OrderForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.ID_PERSON,
            this.TOTAL_PRICE,
            this.STATUS});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridView_OrderForm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridView_OrderForm.EnableHeadersVisualStyles = false;
            this.dtGridView_OrderForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridView_OrderForm.Location = new System.Drawing.Point(54, 85);
            this.dtGridView_OrderForm.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView_OrderForm.Name = "dtGridView_OrderForm";
            this.dtGridView_OrderForm.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridView_OrderForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridView_OrderForm.RowHeadersVisible = false;
            this.dtGridView_OrderForm.RowHeadersWidth = 60;
            this.dtGridView_OrderForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView_OrderForm.Size = new System.Drawing.Size(551, 597);
            this.dtGridView_OrderForm.TabIndex = 97;
            this.dtGridView_OrderForm.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridView_OrderForm.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridView_OrderForm.ThemeStyle.HeaderStyle.Height = 60;
            this.dtGridView_OrderForm.ThemeStyle.ReadOnly = true;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dtGridView_OrderForm.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridView_OrderForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_OrderForm_CellContentClick);
            this.dtGridView_OrderForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_OrderForm_CellDoubleClick);
            // 
            // ID1
            // 
            this.ID1.FillWeight = 30F;
            this.ID1.HeaderText = "ID";
            this.ID1.MinimumWidth = 7;
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            // 
            // ID_PERSON
            // 
            this.ID_PERSON.FillWeight = 35F;
            this.ID_PERSON.HeaderText = "ID_WAITER";
            this.ID_PERSON.MinimumWidth = 7;
            this.ID_PERSON.Name = "ID_PERSON";
            this.ID_PERSON.ReadOnly = true;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.FillWeight = 39.44861F;
            this.TOTAL_PRICE.HeaderText = "TOTAL PRICE";
            this.TOTAL_PRICE.MinimumWidth = 7;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.FillWeight = 30F;
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 7;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // fLayoutPl_Detail
            // 
            this.fLayoutPl_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLayoutPl_Detail.AutoScroll = true;
            this.fLayoutPl_Detail.BackColor = System.Drawing.Color.White;
            this.fLayoutPl_Detail.Location = new System.Drawing.Point(639, 146);
            this.fLayoutPl_Detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fLayoutPl_Detail.Name = "fLayoutPl_Detail";
            this.fLayoutPl_Detail.Size = new System.Drawing.Size(521, 466);
            this.fLayoutPl_Detail.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.lb_id_order);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(639, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 57);
            this.panel1.TabIndex = 100;
            // 
            // lb_id_order
            // 
            this.lb_id_order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_id_order.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_order.ForeColor = System.Drawing.Color.White;
            this.lb_id_order.Location = new System.Drawing.Point(332, 15);
            this.lb_id_order.Name = "lb_id_order";
            this.lb_id_order.Size = new System.Drawing.Size(36, 31);
            this.lb_id_order.TabIndex = 96;
            this.lb_id_order.Text = "1";
            this.lb_id_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_id_order.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 96;
            this.label1.Text = "DETAIL ORDER #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label12_Click);
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
            this.btt_remove.BorderRadius = 5;
            this.btt_remove.BorderThickness = 1;
            this.btt_remove.CheckedState.Parent = this.btt_remove;
            this.btt_remove.CustomImages.Parent = this.btt_remove;
            this.btt_remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_remove.ForeColor = System.Drawing.Color.White;
            this.btt_remove.HoverState.Parent = this.btt_remove;
            this.btt_remove.Image = global::Beverage_Management_System.Properties.Resources.delete1;
            this.btt_remove.Location = new System.Drawing.Point(640, 639);
            this.btt_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_remove.Name = "btt_remove";
            this.btt_remove.ShadowDecoration.Parent = this.btt_remove;
            this.btt_remove.Size = new System.Drawing.Size(241, 67);
            this.btt_remove.TabIndex = 101;
            this.btt_remove.Text = "REMOVE";
            this.btt_remove.Click += new System.EventHandler(this.btt_remove_Click);
            // 
            // btt_confirm
            // 
            this.btt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_confirm.BorderColor = System.Drawing.Color.Transparent;
            this.btt_confirm.BorderRadius = 5;
            this.btt_confirm.BorderThickness = 1;
            this.btt_confirm.CheckedState.Parent = this.btt_confirm;
            this.btt_confirm.CustomImages.Parent = this.btt_confirm;
            this.btt_confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btt_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_confirm.ForeColor = System.Drawing.Color.White;
            this.btt_confirm.HoverState.Parent = this.btt_confirm;
            this.btt_confirm.Image = global::Beverage_Management_System.Properties.Resources.confirm;
            this.btt_confirm.Location = new System.Drawing.Point(898, 639);
            this.btt_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btt_confirm.Name = "btt_confirm";
            this.btt_confirm.ShadowDecoration.Parent = this.btt_confirm;
            this.btt_confirm.Size = new System.Drawing.Size(240, 67);
            this.btt_confirm.TabIndex = 101;
            this.btt_confirm.Text = "CONFIRM";
            this.btt_confirm.Click += new System.EventHandler(this.btt_confirm_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1205, 778);
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
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_OrderForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}