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
            InitializeComponent();
            UC_QLSV qlsv = new UC_QLSV();
            addUserControl(qlsv);
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
    }
}
