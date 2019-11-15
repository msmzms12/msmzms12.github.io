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
    public partial class ThongTinDiem : Form
    {
        public ThongTinDiem()
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

        private void ThongTinDiem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Diem");
            dataGridView1.Columns[0].HeaderText = "Mã ID";
            dataGridView1.Columns[1].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[3].HeaderText = "Điểm";
            comboBox1.DataSource = Connect.LayBang("select masv from SinhVien");
            comboBox1.DisplayMember = "masv";
            comboBox2.DataSource = Connect.LayBang("select mamh from MonHoc");
            comboBox2.DisplayMember = "mamh";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTin.Diem.RPV_Diem rpv_d = new Diem.RPV_Diem();
            rpv_d.ShowDialog();
        }
    }
}
