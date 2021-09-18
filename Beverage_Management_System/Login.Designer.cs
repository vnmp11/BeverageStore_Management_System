
namespace Beverage_Management_System

{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_Login = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.btt_unvisible2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_visible2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btt_close = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 652);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.bt_Login);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_Password);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_Username);
            this.panel3.Controls.Add(this.btt_unvisible2);
            this.panel3.Controls.Add(this.btt_visible2);
            this.panel3.Location = new System.Drawing.Point(482, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 446);
            this.panel3.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label11.Location = new System.Drawing.Point(170, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 36);
            this.label11.TabIndex = 24;
            this.label11.Text = "LOGIN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BorderColor = System.Drawing.Color.Transparent;
            this.bt_Login.BorderRadius = 25;
            this.bt_Login.BorderThickness = 1;
            this.bt_Login.CheckedState.Parent = this.bt_Login;
            this.bt_Login.CustomImages.Parent = this.bt_Login;
            this.bt_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.bt_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.HoverState.Parent = this.bt_Login;
            this.bt_Login.Location = new System.Drawing.Point(176, 337);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.PressedColor = System.Drawing.Color.DarkGray;
            this.bt_Login.ShadowDecoration.Parent = this.bt_Login;
            this.bt_Login.Size = new System.Drawing.Size(120, 50);
            this.bt_Login.TabIndex = 22;
            this.bt_Login.Text = "LOGIN";
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label10.Location = new System.Drawing.Point(28, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Password.BorderRadius = 5;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.Parent = this.txt_Password;
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.FocusedState.Parent = this.txt_Password;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.HoverState.Parent = this.txt_Password;
            this.txt_Password.Location = new System.Drawing.Point(32, 249);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.SelectedText = "";
            this.txt_Password.ShadowDecoration.Parent = this.txt_Password;
            this.txt_Password.Size = new System.Drawing.Size(365, 44);
            this.txt_Password.TabIndex = 20;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(28, 216);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 33);
            this.label13.TabIndex = 19;
            this.label13.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Username.BorderRadius = 5;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.Parent = this.txt_Username;
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.FocusedState.Parent = this.txt_Username;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.HoverState.Parent = this.txt_Username;
            this.txt_Username.Location = new System.Drawing.Point(32, 156);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderText = "";
            this.txt_Username.SelectedText = "";
            this.txt_Username.ShadowDecoration.Parent = this.txt_Username;
            this.txt_Username.Size = new System.Drawing.Size(365, 44);
            this.txt_Username.TabIndex = 17;
            // 
            // btt_unvisible2
            // 
            this.btt_unvisible2.CheckedState.Parent = this.btt_unvisible2;
            this.btt_unvisible2.HoverState.Image = global::Beverage_Management_System.Properties.Resources.visibility__2_;
            this.btt_unvisible2.HoverState.Parent = this.btt_unvisible2;
            this.btt_unvisible2.Image = global::Beverage_Management_System.Properties.Resources.visibility__2_;
            this.btt_unvisible2.Location = new System.Drawing.Point(404, 258);
            this.btt_unvisible2.Name = "btt_unvisible2";
            this.btt_unvisible2.PressedState.Parent = this.btt_unvisible2;
            this.btt_unvisible2.Size = new System.Drawing.Size(32, 23);
            this.btt_unvisible2.TabIndex = 27;
            this.btt_unvisible2.Click += new System.EventHandler(this.btt_unvisible2_Click);
            // 
            // btt_visible2
            // 
            this.btt_visible2.CheckedState.Parent = this.btt_visible2;
            this.btt_visible2.HoverState.Image = global::Beverage_Management_System.Properties.Resources.view;
            this.btt_visible2.HoverState.Parent = this.btt_visible2;
            this.btt_visible2.Image = global::Beverage_Management_System.Properties.Resources.view;
            this.btt_visible2.Location = new System.Drawing.Point(404, 258);
            this.btt_visible2.Name = "btt_visible2";
            this.btt_visible2.PressedState.Parent = this.btt_visible2;
            this.btt_visible2.Size = new System.Drawing.Size(32, 23);
            this.btt_visible2.TabIndex = 26;
            this.btt_visible2.Click += new System.EventHandler(this.btt_visible2_Click);
            // 
            // btt_close
            // 
            this.btt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_close.CheckedState.Parent = this.btt_close;
            this.btt_close.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btt_close.HoverState.Parent = this.btt_close;
            this.btt_close.Image = global::Beverage_Management_System.Properties.Resources.letter_x;
            this.btt_close.Location = new System.Drawing.Point(927, 12);
            this.btt_close.Name = "btt_close";
            this.btt_close.PressedState.Parent = this.btt_close;
            this.btt_close.Size = new System.Drawing.Size(39, 45);
            this.btt_close.TabIndex = 25;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 500);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button bt_Login;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ImageButton btt_visible2;
        private Guna.UI2.WinForms.Guna2ImageButton btt_unvisible2;
        private Guna.UI2.WinForms.Guna2ImageButton btt_close;
    }
    
}

