namespace Nhom2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnqlsv = new System.Windows.Forms.Button();
            this.btnqlmh = new System.Windows.Forms.Button();
            this.btntlh = new System.Windows.Forms.Button();
            this.btngdsv = new System.Windows.Forms.Button();
            this.btnqld = new System.Windows.Forms.Button();
            this.btnbcd = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnqlsv
            // 
            this.btnqlsv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqlsv.Location = new System.Drawing.Point(164, 134);
            this.btnqlsv.Name = "btnqlsv";
            this.btnqlsv.Size = new System.Drawing.Size(188, 47);
            this.btnqlsv.TabIndex = 0;
            this.btnqlsv.Text = "Quản Lý Sinh Viên";
            this.btnqlsv.UseVisualStyleBackColor = true;
            this.btnqlsv.Click += new System.EventHandler(this.btnqlsv_Click);
            // 
            // btnqlmh
            // 
            this.btnqlmh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqlmh.Location = new System.Drawing.Point(164, 203);
            this.btnqlmh.Name = "btnqlmh";
            this.btnqlmh.Size = new System.Drawing.Size(188, 47);
            this.btnqlmh.TabIndex = 1;
            this.btnqlmh.Text = "Quản Lý Môn Học";
            this.btnqlmh.UseVisualStyleBackColor = true;
            this.btnqlmh.Click += new System.EventHandler(this.btnqlmh_Click);
            // 
            // btntlh
            // 
            this.btntlh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntlh.Location = new System.Drawing.Point(164, 270);
            this.btntlh.Name = "btntlh";
            this.btntlh.Size = new System.Drawing.Size(188, 47);
            this.btntlh.TabIndex = 2;
            this.btntlh.Text = "Tạo Lớp Học";
            this.btntlh.UseVisualStyleBackColor = true;
            this.btntlh.Click += new System.EventHandler(this.btntlh_Click);
            // 
            // btngdsv
            // 
            this.btngdsv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngdsv.Location = new System.Drawing.Point(415, 134);
            this.btngdsv.Name = "btngdsv";
            this.btngdsv.Size = new System.Drawing.Size(188, 47);
            this.btngdsv.TabIndex = 3;
            this.btngdsv.Text = "Ghi Danh Sinh Viên";
            this.btngdsv.UseVisualStyleBackColor = true;
            this.btngdsv.Click += new System.EventHandler(this.btngdsv_Click);
            // 
            // btnqld
            // 
            this.btnqld.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqld.Location = new System.Drawing.Point(415, 203);
            this.btnqld.Name = "btnqld";
            this.btnqld.Size = new System.Drawing.Size(188, 47);
            this.btnqld.TabIndex = 4;
            this.btnqld.Text = "Quản Lý Điểm";
            this.btnqld.UseVisualStyleBackColor = true;
            this.btnqld.Click += new System.EventHandler(this.btnqld_Click);
            // 
            // btnbcd
            // 
            this.btnbcd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbcd.Location = new System.Drawing.Point(415, 270);
            this.btnbcd.Name = "btnbcd";
            this.btnbcd.Size = new System.Drawing.Size(188, 47);
            this.btnbcd.TabIndex = 5;
            this.btnbcd.Text = "Báo Cáo Điểm";
            this.btnbcd.UseVisualStyleBackColor = true;
            this.btnbcd.Click += new System.EventHandler(this.btnbcd_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(315, 360);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(138, 47);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnbcd);
            this.Controls.Add(this.btnqld);
            this.Controls.Add(this.btngdsv);
            this.Controls.Add(this.btntlh);
            this.Controls.Add(this.btnqlmh);
            this.Controls.Add(this.btnqlsv);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnqlsv;
        private System.Windows.Forms.Button btnqlmh;
        private System.Windows.Forms.Button btntlh;
        private System.Windows.Forms.Button btngdsv;
        private System.Windows.Forms.Button btnqld;
        private System.Windows.Forms.Button btnbcd;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
    }
}