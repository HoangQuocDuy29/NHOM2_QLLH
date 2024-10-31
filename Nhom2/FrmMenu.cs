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
            InitializeComponent();
        }

        private void btnqlsv_Click(object sender, EventArgs e)
        {
            FrmQLSV frmQLSV = new FrmQLSV();
            frmQLSV.Show();
            this.Hide();
            // 31/10
        }

        private void btngdsv_Click(object sender, EventArgs e)
        {
            FrmGDSV frmGDSV = new FrmGDSV();
            frmGDSV.Show();
            this.Hide();
        }

        private void btnqlmh_Click(object sender, EventArgs e)
        {
            FrmQLMH frmQLMH = new FrmQLMH();
            frmQLMH.Show();
            this.Hide();
        }

        private void btntlh_Click(object sender, EventArgs e)
        {
            FrmTLH frmTLH = new FrmTLH();
            frmTLH.Show();
            this.Hide();
        }

        private void btnqld_Click(object sender, EventArgs e)
        {
            FrmQLD frmQLD = new FrmQLD();
            frmQLD.Show();
            this.Hide();
        }

        private void btnbcd_Click(object sender, EventArgs e)
        {
            FrmBCD frmBCD = new FrmBCD();
            frmBCD.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Tạo instance của Form Đăng Nhập
            Form1 loginForm = new Form1();

            // Hiển thị Form Đăng Nhập
            loginForm.Show();

            // Đóng Form hiện tại (FrmMenu)
            this.Close();
        }
    }
}
