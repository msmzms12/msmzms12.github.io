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
    public partial class ThongTinGiaoVien : Form
    {
        public ThongTinGiaoVien()
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

        private void ThongTinGiaoVien_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim().Equals("Nam"))
            {
                radioButton1.Checked = true;
               
            }
            else
            {
                
                radioButton2.Checked = true;
            }
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTin.GiaoVien.RPV_GiaoVien rpv_gv = new GiaoVien.RPV_GiaoVien();
            rpv_gv.ShowDialog();
        }
    }
}
