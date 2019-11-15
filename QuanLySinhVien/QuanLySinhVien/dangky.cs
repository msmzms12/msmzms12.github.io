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
using System.Data.SqlClient;


namespace QuanLySinhVien
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void dangky_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Connect.LayBang("select * from TkUser");
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String a = getMD5(textBox2.Text.Trim());
                String b = getMD5(textBox3.Text.Trim());

                if (a == b)
                {
                    
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Bạn Chưa Nhập Tên Đăng Nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }
                    else if (textBox2.Text == "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();
                    }
                    else
                    {
                       
                            String sql = "insert into TkUser values('" + textBox1.Text + "','" + a + "')";
                            Connect.ThemXuaXoa(sql);
                            DialogResult rs;
                            rs = MessageBox.Show("Đăng Ký Thành Công Bạn Có Muốn Đăng Nhập Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            if (rs == DialogResult.OK)
                            {
                                dangnhap dn = new dangnhap();
                                dn.Show();
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                       // }
                    }

                }
                else
                {
                    MessageBox.Show("Mật Khẩu Nhập Lại Không Khớp Vui Lòng Kiểm Tra Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thao Tác Không Thực Hiện Được Vui Lòng Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
