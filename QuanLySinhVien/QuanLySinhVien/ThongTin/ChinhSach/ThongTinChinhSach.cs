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
    public partial class ThongTinChinhSach : Form
    {
        public ThongTinChinhSach()
        {
            InitializeComponent();
        }

        private void ThongTinChinhSach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from ChinhSach");
            dataGridView1.Columns[0].HeaderText = "Mã Chính Sách";
            dataGridView1.Columns[1].HeaderText = "Tên Chính Sách";
            dataGridView1.Columns[2].HeaderText = "Chế Độ";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =
                   dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text =
                dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTin.ChinhSach.RPV_ChinhSach rpv_cs = new ChinhSach.RPV_ChinhSach();
            rpv_cs.ShowDialog();
        }
    }
}
