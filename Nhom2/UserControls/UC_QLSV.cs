using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom2.UserControls
{
    public partial class UC_QLSV : UserControl
    {
        string connect = "Data Source=HOANG-QUOC-DUY\\SQLEXPRESS;Initial Catalog=Nhom2;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public UC_QLSV()
        {
            InitializeComponent();
            dataGridViewqlsv.CellClick += new DataGridViewCellEventHandler(dataGridViewqlsv_CellContentClick);

        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connect);
            LoadSinhVienData();
        }
        private void LoadSinhVienData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM SinhVien"; // Truy vấn để lấy tất cả dữ liệu từ bảng SinhVien
                adapter = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Dữ liệu được tải thành công!"); // Kiểm tra nếu có dữ liệu
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong bảng SinhVien!");
                }

                dataGridViewqlsv.DataSource = dt; // Hiển thị dữ liệu trong DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridViewqlsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
