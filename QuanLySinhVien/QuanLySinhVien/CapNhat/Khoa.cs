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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Khoa");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khoa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Khoa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                try
                {
                    String sql = "insert into Khoa values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    Connect.ThemXuaXoa(sql);
                    load();
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Khoa");
            dataGridView1.Columns[0].HeaderText = "Mã Khoa";
            dataGridView1.Columns[1].HeaderText = "Tên Khoa";
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
            string st = "select count(*) from Khoa where makhoa='" + textBox1.Text + "'";
            int i = 0;
            SqlCommand cmd = new SqlCommand(st, ketnoi);
            i = (int)cmd.ExecuteScalar();
            if (i == 0)
            {
                MessageBox.Show("Mã khoa không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                try
                {
                    String sql = "update Khoa set tenkhoa='" + textBox2.Text + "' where makhoa = '" + textBox1.Text + "'";
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
            rs = MessageBox.Show("Bạn thực sự muốn tài khoản này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                SqlConnection ketnoi = Connect.taoketnoi();
                ketnoi.Open();
                string st = "select count(*) from Khoa where makhoa='" + textBox1.Text + "'";
                int i = 0;
                SqlCommand cmd = new SqlCommand(st, ketnoi);
                i = (int)cmd.ExecuteScalar();
                if (i == 0)
                {
                    MessageBox.Show("Mã khoa không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    try
                    {
                        String sql = "delete from Khoa where makhoa = '" + textBox1.Text + "'";
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
            textBox1.Focus();
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
    }
}
