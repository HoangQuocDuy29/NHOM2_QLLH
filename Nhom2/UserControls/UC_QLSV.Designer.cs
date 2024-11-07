namespace Nhom2.UserControls
{
    partial class UC_QLSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nhom2 = new System.Windows.Forms.Label();
            this.dataGridViewqlsv = new System.Windows.Forms.DataGridView();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewqlsv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nhom2
            // 
            this.Nhom2.AutoSize = true;
            this.Nhom2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhom2.ForeColor = System.Drawing.Color.Black;
            this.Nhom2.Location = new System.Drawing.Point(600, 25);
            this.Nhom2.Name = "Nhom2";
            this.Nhom2.Size = new System.Drawing.Size(320, 39);
            this.Nhom2.TabIndex = 2;
            this.Nhom2.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dataGridViewqlsv
            // 
            this.dataGridViewqlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewqlsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewqlsv.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewqlsv.Name = "dataGridViewqlsv";
            this.dataGridViewqlsv.RowHeadersWidth = 51;
            this.dataGridViewqlsv.RowTemplate.Height = 24;
            this.dataGridViewqlsv.Size = new System.Drawing.Size(2000, 335);
            this.dataGridViewqlsv.TabIndex = 3;
            this.dataGridViewqlsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewqlsv_CellContentClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewqlsv);
            this.panel1.Location = new System.Drawing.Point(0, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 338);
            this.panel1.TabIndex = 4;
            // 
            // UC_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nhom2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(20, 20);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_QLSV";
            this.Size = new System.Drawing.Size(2000, 650);
            this.Load += new System.EventHandler(this.UC_QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewqlsv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Label Nhom2;
        private System.Windows.Forms.DataGridView dataGridViewqlsv;
        private System.Windows.Forms.Panel panel1;
    }
}
