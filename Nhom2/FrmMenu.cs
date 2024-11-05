using Nhom2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            //
            InitializeComponent();
            UC_QLSV qlsv = new UC_QLSV();
            addUserControl(qlsv);
            ptexit.Click += new EventHandler(pictureBox2_Click);
            // Đăng ký sự kiện MouseEnter và MouseLeave cho PictureBox
            ptexit.MouseEnter += new EventHandler(PictureBox_MouseEnter);
            ptexit.MouseLeave += new EventHandler(PictureBox_MouseLeave);
        }
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            ptexit.Cursor = Cursors.Hand; // Thay đổi con trỏ thành hình bàn tay khi di chuột vào
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            ptexit.Cursor = Cursors.Default; // Trả con trỏ về mặc định khi rời chuột khỏi PictureBox
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //
        private void guna2qlsv_Click(object sender, EventArgs e)
        {
            UC_QLSV qlsv = new UC_QLSV();
            addUserControl(qlsv );
        }

        private void guna2qlmh_Click(object sender, EventArgs e)
        {
            UC_QLMH qlmh = new UC_QLMH();
            addUserControl(qlmh);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát toàn bộ chương trình
        }

        private void Nhom2_Click(object sender, EventArgs e)
        {

        }

        private void guna2bcd_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
