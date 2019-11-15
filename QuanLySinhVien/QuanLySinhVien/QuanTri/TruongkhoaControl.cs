using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace QuanLySinhVien
{
    public partial class TruongkhoaControl : Form
    {
        public TruongkhoaControl()
        {
            InitializeComponent();
        }

        public string getMD5(String text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] re = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < re.Length; i++)
            {
                str.Append(re[i].ToString("x2"));
            }
            return str.ToString();
        }
        public void load()
        {
            dataGridView1.DataSource = Connect.LayBang("select tk,convert(varchar(32),hashbytes('md5',mk),2) from TkTruongKhoa");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Đăng Nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }

            else
            {
                try
                {
                    String sql = "insert into TkTruongKhoa values('" + textBox1.Text + "','" + getMD5(textBox2.Text.Trim()) + "')";
                    Connect.ThemXuaXoa(sql);
                    MessageBox.Show("Thêm mới trưởng khoa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void TruongkhoaControl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select tk,convert(varchar(32),hashbytes('md5',mk),2) from TkTruongKhoa");
            dataGridView1.Columns[0].HeaderText = "Tên Đăng Nhập";
            dataGridView1.Columns[1].HeaderText = "Mật Khẩu";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =
                   dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text =
                dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "update TkTruongKhoa set mk='" + getMD5(textBox2.Text.Trim()) + "' where tk = '" + textBox1.Text + "'";
                Connect.ThemXuaXoa(sql);
                load();
                MessageBox.Show("Sửa thông tin trưởng khoa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception )
            {
                MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn thực sự muốn tài khoản này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                try
                {
                    String sql = "delete from TkTruongKhoa where tk = '" + textBox1.Text + "'";
                    Connect.ThemXuaXoa(sql);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    load();
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
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
