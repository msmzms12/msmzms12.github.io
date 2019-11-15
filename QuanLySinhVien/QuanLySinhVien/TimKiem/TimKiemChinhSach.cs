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
    public partial class TimKiemChinhSach : Form
    {
        public TimKiemChinhSach()
        {
            InitializeComponent();
        }

        private void TimKiemChinhSach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach");
            dataGridView1.Columns[0].HeaderText = "Mã Chính Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Chính Sách";
            dataGridView1.Columns[2].HeaderText = "Chế Độ";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
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
                if (comboBox1.SelectedItem.ToString() == "Mã Chính Sách")
                {

                    dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach where macs like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";

                }
                else if (comboBox1.SelectedItem.ToString() == "Tên Chính Sách")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach where tencs like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "Chế Độ")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach where chedo like N'%" + textBox1.Text.Trim() + "%' ");
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
            dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach");
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
