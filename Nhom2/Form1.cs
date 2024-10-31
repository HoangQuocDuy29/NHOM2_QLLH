using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using System.Windows.Forms;

namespace Nhom2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HOANG-QUOC-DUY\\SQLEXPRESS;Initial Catalog=Nhom2;Integrated Security=True;"; // Chuỗi kết nối đến SQL Server
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE UserName = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtuser.Text);
                command.Parameters.AddWithValue("@password", txtpassword.Text);

                try
                {
                    connection.Open();
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        // Đăng nhập thành công, chuyển sang form FrmMenu
                        FrmMenu menuForm = new FrmMenu();
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Đăng nhập thất bại
                        MessageBox.Show("Bạn đã nhập sai thông tin đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
