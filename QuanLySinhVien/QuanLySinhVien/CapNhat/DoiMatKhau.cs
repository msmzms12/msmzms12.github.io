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
using System.Security.Cryptography;

namespace QuanLySinhVien.CapNhat
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Nhom 3 - nhom3tin10a2hn@gmail.com", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();
            String d = getMD5(textBox3.Text);
            String b = getMD5(textBox4.Text);

            String tentk = textBox1.Text;
            String matkhau = getMD5(textBox2.Text);

            if (tentk == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (matkhau == "")
            {

                MessageBox.Show("Bạn chưa nhập mật khẩu !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (d == "")
            {

                MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (b == "")
            {

                MessageBox.Show("Bạn chưa nhập lại mật khẩu !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else
            {
                String taikhoan = "select count (*) from TkAdmin where tk='" + textBox1.Text + "' and mk='" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(taikhoan, ketnoi);
                int i = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                String tkhoa = "select count(*) from TkTruongKhoa where tk='" + textBox1.Text + "'and mk='" + matkhau + "'";
                SqlCommand sql = new SqlCommand(tkhoa, ketnoi);
                int truongkhoa = (int)sql.ExecuteScalar();
                sql.Dispose();
                String tku = "select count(*) from TkUser where tk='" + textBox1.Text + "' and mk='" + matkhau + "'";
                SqlCommand cm = new SqlCommand(tku, ketnoi);
                int us = (int)cm.ExecuteScalar();
                cm.Dispose();
                String tkgv = "select count(*) from TkGiaoVien where tk='" + textBox1.Text + "' and mk='" + matkhau + "'";
                SqlCommand c = new SqlCommand(tkgv, ketnoi);
                int gv = (int)c.ExecuteScalar();
                c.Dispose();
                if (i > 0)
                {
                    try
                    {
                        if (d == b)
                        {
                            SqlCommand s;
                            String strsql;
                            strsql = "update TkAdmin set mk='" + d + "'where tk='" + textBox1.Text + "'";
                            s = new SqlCommand(strsql, ketnoi);
                            s.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu bạn nhập lại không khớp !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác không thực hiện được.Vui lòng kiểm tra lại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else if (gv > 0)
                {

                    try
                    {
                        if (d == b)
                        {
                            SqlCommand s1;
                            String gv1;
                            gv1 = "update TkGiaoVien set mk='" + d + "'where tk='" + textBox1.Text + "'";
                            s1 = new SqlCommand(gv1, ketnoi);
                            s1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công !", "Đổi mật khẩu  !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu bạn nhập lại không khớp !", "Đổi mật khẩu !", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác không thực hiện được.Vui lòng kiểm tra lại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else if (truongkhoa > 0)
                {

                    try
                    {
                        if (d == b)
                        {
                            SqlCommand s2;
                            String tk1;
                            tk1 = "update TkTruongKhoa set mk='" + d + "'where tk='" + textBox1.Text + "'";
                            s2 = new SqlCommand(tk1, ketnoi);
                            s2.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công !", "Đổi mật khẩu  !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu bạn nhập lại không khớp !", "Đổi mật khẩu !", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác không thực hiện được.Vui lòng kiểm tra lại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else if (us > 0)
                {

                    try
                    {
                        if (d == b)
                        {
                            SqlCommand u1;
                            String us1;
                            us1 = "update TkUser set mk='" + d + "'where tk='" + textBox1.Text + "'";
                            u1 = new SqlCommand(us1, ketnoi);
                            u1.ExecuteNonQuery();
                            MessageBox.Show("Bạn đã thay đổi mật khẩu thành công !", "Đổi mật khẩu  !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu bạn nhập lại không khớp !", "Đổi mật khẩu !", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thao tác không thực hiện được.Vui lòng kiểm tra lại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai thông tin tài khoản hoặc mật khẩu !", "Đổi mật khẩu  !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }

            if (textBox4.UseSystemPasswordChar == true)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
    }

