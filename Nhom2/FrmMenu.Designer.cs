﻿namespace Nhom2
{
    partial class FrmMenu
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
        //
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ptexit = new System.Windows.Forms.PictureBox();
            this.Nhom2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2bcd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2qld = new Guna.UI2.WinForms.Guna2Button();
            this.guna2gdsv = new Guna.UI2.WinForms.Guna2Button();
            this.gunatlh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2qlmh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2qlsv = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelMenu.Controls.Add(this.ptexit);
            this.panelMenu.Controls.Add(this.Nhom2);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(-2, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(2000, 77);
            this.panelMenu.TabIndex = 8;
            // 
            // ptexit
            // 
            this.ptexit.Image = ((System.Drawing.Image)(resources.GetObject("ptexit.Image")));
            this.ptexit.Location = new System.Drawing.Point(1862, 0);
            this.ptexit.Name = "ptexit";
            this.ptexit.Size = new System.Drawing.Size(64, 44);
            this.ptexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptexit.TabIndex = 2;
            this.ptexit.TabStop = false;
            this.ptexit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Nhom2
            // 
            this.Nhom2.AutoSize = true;
            this.Nhom2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhom2.ForeColor = System.Drawing.Color.White;
            this.Nhom2.Location = new System.Drawing.Point(114, 27);
            this.Nhom2.Name = "Nhom2";
            this.Nhom2.Size = new System.Drawing.Size(86, 23);
            this.Nhom2.TabIndex = 1;
            this.Nhom2.Text = "Nhóm 2";
            this.Nhom2.Click += new System.EventHandler(this.Nhom2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2bcd);
            this.panel1.Controls.Add(this.guna2qld);
            this.panel1.Controls.Add(this.guna2gdsv);
            this.panel1.Controls.Add(this.gunatlh);
            this.panel1.Controls.Add(this.guna2qlmh);
            this.panel1.Controls.Add(this.guna2qlsv);
            this.panel1.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 77);
            this.panel1.TabIndex = 9;
            // 
            // guna2bcd
            // 
            this.guna2bcd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2bcd.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2bcd.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2bcd.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2bcd.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2bcd.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2bcd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2bcd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2bcd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2bcd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2bcd.FillColor = System.Drawing.Color.White;
            this.guna2bcd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2bcd.ForeColor = System.Drawing.Color.Black;
            this.guna2bcd.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2bcd.Location = new System.Drawing.Point(1567, 0);
            this.guna2bcd.Name = "guna2bcd";
            this.guna2bcd.Size = new System.Drawing.Size(359, 74);
            this.guna2bcd.TabIndex = 5;
            this.guna2bcd.Text = "Báo Cáo Điểm";
            this.guna2bcd.Click += new System.EventHandler(this.guna2bcd_Click);
            // 
            // guna2qld
            // 
            this.guna2qld.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2qld.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2qld.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2qld.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2qld.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qld.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2qld.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2qld.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2qld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2qld.FillColor = System.Drawing.Color.White;
            this.guna2qld.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2qld.ForeColor = System.Drawing.Color.Black;
            this.guna2qld.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2qld.Location = new System.Drawing.Point(1196, 0);
            this.guna2qld.Name = "guna2qld";
            this.guna2qld.Size = new System.Drawing.Size(374, 74);
            this.guna2qld.TabIndex = 4;
            this.guna2qld.Text = "QL Điểm";
            // 
            // guna2gdsv
            // 
            this.guna2gdsv.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2gdsv.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2gdsv.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2gdsv.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2gdsv.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2gdsv.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2gdsv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2gdsv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2gdsv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2gdsv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2gdsv.FillColor = System.Drawing.Color.White;
            this.guna2gdsv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2gdsv.ForeColor = System.Drawing.Color.Black;
            this.guna2gdsv.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2gdsv.Location = new System.Drawing.Point(801, 0);
            this.guna2gdsv.Name = "guna2gdsv";
            this.guna2gdsv.Size = new System.Drawing.Size(395, 74);
            this.guna2gdsv.TabIndex = 3;
            this.guna2gdsv.Text = "Ghi Danh";
            // 
            // gunatlh
            // 
            this.gunatlh.BorderColor = System.Drawing.Color.DarkGray;
            this.gunatlh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gunatlh.CheckedState.BorderColor = System.Drawing.Color.White;
            this.gunatlh.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.gunatlh.CheckedState.FillColor = System.Drawing.Color.White;
            this.gunatlh.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunatlh.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gunatlh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunatlh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunatlh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunatlh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunatlh.FillColor = System.Drawing.Color.White;
            this.gunatlh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunatlh.ForeColor = System.Drawing.Color.Black;
            this.gunatlh.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.gunatlh.Location = new System.Drawing.Point(509, 0);
            this.gunatlh.Name = "gunatlh";
            this.gunatlh.Size = new System.Drawing.Size(293, 74);
            this.gunatlh.TabIndex = 2;
            this.gunatlh.Text = "Tạo Lớp Học";
            // 
            // guna2qlmh
            // 
            this.guna2qlmh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2qlmh.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2qlmh.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2qlmh.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2qlmh.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlmh.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2qlmh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlmh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlmh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2qlmh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2qlmh.FillColor = System.Drawing.Color.White;
            this.guna2qlmh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2qlmh.ForeColor = System.Drawing.Color.Black;
            this.guna2qlmh.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2qlmh.Location = new System.Drawing.Point(255, 0);
            this.guna2qlmh.Name = "guna2qlmh";
            this.guna2qlmh.Size = new System.Drawing.Size(258, 74);
            this.guna2qlmh.TabIndex = 1;
            this.guna2qlmh.Text = "QL Môn Học";
            this.guna2qlmh.Click += new System.EventHandler(this.guna2qlmh_Click);
            // 
            // guna2qlsv
            // 
            this.guna2qlsv.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2qlsv.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2qlsv.CheckedState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlsv.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2qlsv.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlsv.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2qlsv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlsv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2qlsv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2qlsv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2qlsv.FillColor = System.Drawing.Color.White;
            this.guna2qlsv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2qlsv.ForeColor = System.Drawing.Color.Black;
            this.guna2qlsv.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2qlsv.Location = new System.Drawing.Point(3, 0);
            this.guna2qlsv.Name = "guna2qlsv";
            this.guna2qlsv.Size = new System.Drawing.Size(255, 74);
            this.guna2qlsv.TabIndex = 0;
            this.guna2qlsv.Text = "QL Sinh Viên";
            this.guna2qlsv.Click += new System.EventHandler(this.guna2qlsv_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 152);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(2000, 650);
            this.panelContainer.TabIndex = 10;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 603);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Nhom2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2qlsv;
        private Guna.UI2.WinForms.Guna2Button guna2bcd;
        private Guna.UI2.WinForms.Guna2Button guna2qld;
        private Guna.UI2.WinForms.Guna2Button guna2gdsv;
        private Guna.UI2.WinForms.Guna2Button gunatlh;
        private Guna.UI2.WinForms.Guna2Button guna2qlmh;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.PictureBox ptexit;
    }
}