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

namespace QuanLySinhVien.CapNhat
{
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Lop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Lớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Lớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else
            {
                try
                {
                    String sql = "insert into Lop values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "')";
                    Connect.ThemXuaXoa(sql);
                    MessageBox.Show("Thêm mới chính sách thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Lop");
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Mã Khoa";
            comboBox1.DataSource = Connect.LayBang("select makhoa from Khoa");
            comboBox1.DisplayMember = "makhoa";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();
            string st = "select count(*) from Lop where malop='" + textBox1.Text + "'";
            int i = 0;
            SqlCommand cmd = new SqlCommand(st, ketnoi);
            i = (int)cmd.ExecuteScalar();
            if (i == 0)
            {
                MessageBox.Show("Mã lớp không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                try
                {
                    String sql = "update Lop set tenlop=N'" + textBox2.Text + "',makhoa =N'" + comboBox1.Text + "' where malop =N'" + textBox1.Text + "'";
                    Connect.ThemXuaXoa(sql);
                    load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn thực sự muốn xóa chính sách này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {

                SqlConnection ketnoi = Connect.taoketnoi();
                ketnoi.Open();
                string st = "select count(*) from Lop where malop='" + textBox1.Text + "'";
                int i = 0;
                SqlCommand cmd = new SqlCommand(st, ketnoi);
                i = (int)cmd.ExecuteScalar();
                if (i == 0)
                {
                    MessageBox.Show("Mã lớp không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else {

                    try
                    {
                        String sql = "delete from Lop where malop = '" + textBox1.Text + "'";
                        Connect.ThemXuaXoa(sql);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        load();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =
                   dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text =
                dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
