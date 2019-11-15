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
namespace QuanLySinhVien.TimKiem
{
    public partial class TimKiemKhoa : Form
    {
        public TimKiemKhoa()
        {
            InitializeComponent();
        }

        private void TimKiemKhoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Khoa");
            dataGridView1.Columns[0].HeaderText = "Mã Khoa";
            dataGridView1.Columns[1].HeaderText = "Tên Khoa";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();

            if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }

            else
            {
                if (comboBox1.SelectedItem.ToString() == "Mã Khoa")
                {

                    dataGridView1.DataSource = Connect.LayBang("select * from Khoa where makhoa like N'%" + textBox2.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox2.Text = "";

                }
                else if (comboBox1.SelectedItem.ToString() == "Tên Khoa")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from Khoa where tenkhoa like N'%" + textBox2.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn Trường Tìm Kiếm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Khoa");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
