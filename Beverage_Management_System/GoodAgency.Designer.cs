
namespace Beverage_Management_System
{
    partial class GoodAgency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Goods = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.bt_Delete.Location = new System.Drawing.Point(469, 114);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.ShadowDecoration.Parent = this.bt_Delete;
            this.bt_Delete.Size = new System.Drawing.Size(151, 62);
            this.bt_Delete.TabIndex = 94;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // dataGridView_Goods
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridView_Goods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Goods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Goods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Goods.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Goods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Goods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Goods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Goods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Goods.ColumnHeadersHeight = 40;
            this.dataGridView_Goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.PRICE,
            this.UNIT,
            this.QUANTITY});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Goods.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_Goods.EnableHeadersVisualStyles = false;
            this.dataGridView_Goods.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Goods.Location = new System.Drawing.Point(36, 184);
            this.dataGridView_Goods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Goods.Name = "dataGridView_Goods";
            this.dataGridView_Goods.RowHeadersVisible = false;
            this.dataGridView_Goods.RowHeadersWidth = 60;
            this.dataGridView_Goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Goods.Size = new System.Drawing.Size(741, 509);
            this.dataGridView_Goods.TabIndex = 93;
            this.dataGridView_Goods.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Goods.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Goods.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Goods.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Goods.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Goods.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Goods.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Goods.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridView_Goods.ThemeStyle.ReadOnly = false;
            this.dataGridView_Goods.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_Goods.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_Goods.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Goods.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGridView_Goods.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_Goods.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.dataGridView_Goods.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Goods.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Goods_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID.FillWeight = 14.34659F;
            this.ID.HeaderText = "   ID";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NAME.DefaultCellStyle = dataGridViewCellStyle12;
            this.NAME.FillWeight = 60F;
            this.NAME.HeaderText = "              GOODS";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 230;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PRICE.DefaultCellStyle = dataGridViewCellStyle13;
            this.PRICE.FillWeight = 21.19206F;
            this.PRICE.HeaderText = "          PRICE";
            this.PRICE.MinimumWidth = 7;
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 180;
            // 
            // UNIT
            // 
            this.UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.UNIT.DefaultCellStyle = dataGridViewCellStyle14;
            this.UNIT.FillWeight = 15.89404F;
            this.UNIT.HeaderText = "  UNIT";
            this.UNIT.MinimumWidth = 7;
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            this.UNIT.Width = 90;
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QUANTITY.DefaultCellStyle = dataGridViewCellStyle15;
            this.QUANTITY.FillWeight = 21.19206F;
            this.QUANTITY.HeaderText = "   QUANTITY";
            this.QUANTITY.MinimumWidth = 7;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 160;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2TextBox1.BorderRadius = 25;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::Beverage_Management_System.Properties.Resources.search1;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(15, 15);
            this.guna2TextBox1.Location = new System.Drawing.Point(36, 114);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search ID or Goods Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(260, 60);
            this.guna2TextBox1.TabIndex = 92;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Beverage_Management_System.Properties.Resources.plus;
            this.guna2Button1.Location = new System.Drawing.Point(627, 114);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(151, 62);
            this.guna2Button1.TabIndex = 95;
            this.guna2Button1.Text = "Add goods";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.guna2ImageButton2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-8, -8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 81);
            this.panel2.TabIndex = 110;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton2.Location = new System.Drawing.Point(765, 20);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.ShadowDecoration.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(44, 56);
            this.guna2ImageButton2.TabIndex = 108;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(330, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 39);
            this.label12.TabIndex = 94;
            this.label12.Text = "GOODS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GoodAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(814, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.dataGridView_Goods);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GoodAgency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodAgency";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button bt_Delete;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridView_Goods;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
    }
}