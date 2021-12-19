
namespace Beverage_Management_System
{
    partial class AlertDialog
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
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_message = new System.Windows.Forms.Label();
            this.btt_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btt_ok = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(393, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::Beverage_Management_System.Properties.Resources.close;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(39, 45);
            this.guna2ImageButton1.TabIndex = 110;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Title.Font = new System.Drawing.Font("Times New Roman", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(132, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(189, 41);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Send Message";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Location = new System.Drawing.Point(-10, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 53);
            this.panel1.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb_message
            // 
            this.lb_message.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_message.Font = new System.Drawing.Font("Times New Roman", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.lb_message.Location = new System.Drawing.Point(24, 74);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(393, 65);
            this.lb_message.TabIndex = 111;
            this.lb_message.Text = "Do you want to remove this order?";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btt_cancel
            // 
            this.btt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_cancel.BorderColor = System.Drawing.Color.Transparent;
            this.btt_cancel.BorderRadius = 25;
            this.btt_cancel.BorderThickness = 1;
            this.btt_cancel.CheckedState.Parent = this.btt_cancel;
            this.btt_cancel.CustomImages.Parent = this.btt_cancel;
            this.btt_cancel.DisabledState.Parent = this.btt_cancel;
            this.btt_cancel.FillColor = System.Drawing.Color.Brown;
            this.btt_cancel.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_cancel.ForeColor = System.Drawing.Color.White;
            this.btt_cancel.HoverState.Parent = this.btt_cancel;
            this.btt_cancel.Location = new System.Drawing.Point(69, 142);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.ShadowDecoration.Parent = this.btt_cancel;
            this.btt_cancel.Size = new System.Drawing.Size(134, 50);
            this.btt_cancel.TabIndex = 112;
            this.btt_cancel.Text = "Cancel";
            this.btt_cancel.Click += new System.EventHandler(this.btt_cancel_Click);
            // 
            // btt_ok
            // 
            this.btt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_ok.BorderColor = System.Drawing.Color.Transparent;
            this.btt_ok.BorderRadius = 25;
            this.btt_ok.BorderThickness = 1;
            this.btt_ok.CheckedState.Parent = this.btt_ok;
            this.btt_ok.CustomImages.Parent = this.btt_ok;
            this.btt_ok.DisabledState.Parent = this.btt_ok;
            this.btt_ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.btt_ok.Font = new System.Drawing.Font("Times New Roman", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ok.ForeColor = System.Drawing.Color.White;
            this.btt_ok.HoverState.Parent = this.btt_ok;
            this.btt_ok.Location = new System.Drawing.Point(238, 142);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.ShadowDecoration.Parent = this.btt_ok;
            this.btt_ok.Size = new System.Drawing.Size(134, 50);
            this.btt_ok.TabIndex = 112;
            this.btt_ok.Text = "Ok";
            this.btt_ok.Click += new System.EventHandler(this.btt_ok_Click);
            // 
            // AlertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 210);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_message;
        public Guna.UI2.WinForms.Guna2Button btt_cancel;
        public Guna.UI2.WinForms.Guna2Button btt_ok;
    }
}