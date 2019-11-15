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
    public partial class TimKiemMonHoc : Form
    {
        public TimKiemMonHoc()
        {
            InitializeComponent();
        }

        private void TimKiemMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], tengv[Tên Giáo Viên] from MonHoc join GiaoVien on(MonHoc.magv = GiaoVien.magv)");

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
            
            else {
            if (comboBox1.SelectedItem.ToString() == "Mã Môn Học")
            {

                dataGridView1.DataSource = Connect.LayBang("select * from MonHoc where mamh like N'%" + textBox2.Text.Trim() + "%' ");
                comboBox1.Focus();
                textBox2.Text = "";

            }
            else if (comboBox1.SelectedItem.ToString() == "Tên Môn Học")
            {
                dataGridView1.DataSource = Connect.LayBang("select * from MonHoc where tenmh like N'%" + textBox2.Text.Trim() + "%' ");
                comboBox1.Focus();
                textBox2.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "Số Tiết")
            {
                dataGridView1.DataSource = Connect.LayBang("select * from MonHoc where sotiet like N'%" + textBox2.Text.Trim() + "%' ");
                comboBox1.Focus();
                textBox2.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tên Giáo Viên")
            {
                dataGridView1.DataSource = Connect.LayBang("select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], tengv[Tên Giáo Viên] from MonHoc join GiaoVien on( MonHoc.magv = GiaoVien.magv) where tengv like N'%" + textBox2.Text.Trim() + "%' ");
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
            dataGridView1.DataSource = Connect.LayBang("select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], tengv[Tên Giáo Viên] from MonHoc join GiaoVien on(MonHoc.magv = GiaoVien.magv)");

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
