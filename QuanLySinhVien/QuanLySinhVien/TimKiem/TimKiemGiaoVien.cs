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
    public partial class TimKiemGiaoVien : Form
    {
        public TimKiemGiaoVien()
        {
            InitializeComponent();
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien");
            dataGridView1.Columns[0].HeaderText = "Mã Giáo Viên";
            dataGridView1.Columns[1].HeaderText = "Tên GIáo Viên";
            dataGridView1.Columns[2].HeaderText = "Giới Tính";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "SĐT";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
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
                if (comboBox1.SelectedItem.ToString() == "Mã Giáo Viên")
                {

                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where magv like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";

                }
                else if (comboBox1.SelectedItem.ToString() == "Tên Giáo Viên")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where tengv like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "Địa Chỉ")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where diachi like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "Ngày Sinh")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where ngaysinh like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "Giới Tính")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where gioitinh like N'%" + textBox1.Text.Trim() + "%' ");
                    comboBox1.Focus();
                    textBox1.Text = "";
                }
                else if (comboBox1.SelectedItem.ToString() == "SĐT")
                {
                    dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien where sdt like N'%" + textBox1.Text.Trim() + "%' ");
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
            dataGridView1.DataSource = Connect.LayBang("select * from GiaoVien");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
