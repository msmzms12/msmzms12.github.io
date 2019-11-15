using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin
{
    public partial class ThongTinMonHoc : Form
    {
        public ThongTinMonHoc()
        {
            InitializeComponent();
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

        private void ThongTinMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from MonHoc");
            dataGridView1.Columns[0].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[1].HeaderText = "Tên Môn Học";
            dataGridView1.Columns[2].HeaderText = "Số Tiết";
            dataGridView1.Columns[3].HeaderText = "Mã Giáo Viên";
            comboBox1.DataSource = Connect.LayBang("select magv from GiaoVien");
            comboBox1.DisplayMember = "magv";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTin.MonHoc.RPV_MonHoc rpv_mh = new MonHoc.RPV_MonHoc();
            rpv_mh.ShowDialog();
        }
    }
}
