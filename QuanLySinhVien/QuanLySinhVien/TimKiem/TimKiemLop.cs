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
    public partial class TimKiemLop : Form
    {
        public TimKiemLop()
        {
            InitializeComponent();
        }

        private void TimKiemLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Lop");
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Mã Khoa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

            else
            {
                if (comboBox1.SelectedItem.ToString() == "Mã Lớp")
                {

                    dataGridView1.DataSource = Connect.LayBang("select * from Lop where malop like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";

                }
                else if (comboBox1.SelectedItem.ToString() == "Tên Lớp")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from Lop where tenlop like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "Mã Khoa")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from Lop where makhoa like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn Trường Tìm Kiếm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Lop");
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
    }
}
