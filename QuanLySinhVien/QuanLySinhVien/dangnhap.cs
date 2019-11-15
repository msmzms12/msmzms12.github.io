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

namespace QuanLySinhVien
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        int sai = 5;
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
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ketnoi = Connect.taoketnoi();
                ketnoi.Open();
                String tentk = textBox1.Text.Trim();
                String matkhau = getMD5(textBox2.Text.Trim());
                if (tentk == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập Tài Khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if(matkhau == "")
                {
                    MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
                else
                {
                    String tkus = "select count(*) from TkUser where tk='" + tentk + "' and mk='" + matkhau + "'";
                    SqlCommand cmd = new SqlCommand(tkus, ketnoi);
                    int a = (int)cmd.ExecuteScalar();
                    cmd.Dispose();

                    String tkad = "select count(*) from TkAdmin where tk='" + tentk + "' and mk='" + matkhau + "'";
                    SqlCommand cmt = new SqlCommand(tkad, ketnoi);
                    int j = (int)cmt.ExecuteScalar();
                    cmt.Dispose();

                    String tkgv = "select count(*) from TkGiaoVien where tk='" + tentk + "' and mk='" + matkhau + "'";
                    SqlCommand cme = new SqlCommand(tkgv, ketnoi);
                    int k = (int)cme.ExecuteScalar();
                    cme.Dispose();

                    String tktk = "select count(*) from TkTruongKhoa where tk='" + tentk + "' and mk='" + matkhau + "'";
                    SqlCommand cmr = new SqlCommand(tktk, ketnoi);
                    int o = (int)cmr.ExecuteScalar();
                    cmr.Dispose();


                    if (sai > 0)
                    {
                        if (a > 0)
                        {
                            MessageBox.Show("Bạn Đăng Nhập Vào Tài Khoản User!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main_Chinh mc = new Main_Chinh();
                            mc.Text = "Tài Khoản User(Nhóm 3 - nhom3tin10a2@gmail.com)-Xin Chào Thầy Mai Mạnh Trừng";
                            mc.label2.Text = "Xin Chào User:Phạm Văn Tài Đã Đến Với Phầm Mềm Quản Lý Sinh Viên";
                            mc.đăngNhậpToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
                            mc.quảnLýToolStripMenuItem.Visible = false;
                            mc.điểmToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
                            mc.Show();
                            this.Hide();


                        }
                        else if (j > 0)
                        {
                            MessageBox.Show("Bạn Đăng Nhập Vào Tài Khoản Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Main_Chinh md = new Main_Chinh();
                            md.Text = "Tài Khoản Admin(Nhóm 3 - nhom3tin10a2@gmail.com)-Xin Chào Thầy Mai Mạnh Trừng";
                            md.label2.Text = "Xin Chào Admin:Phạm Văn Tài Đã Đến Với Phầm Mềm Quản Lý Sinh Viên";
                            md.Show();
                            this.Hide();
                            md.đăngNhậpToolStripMenuItem.Visible = false;


                        }
                        else if (k > 0)
                        {
                            MessageBox.Show("Bạn Đăng Nhập Vào Tài Khoản Giáo Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Main_Chinh mc = new Main_Chinh();
                            mc.Text = "Tài Khoản Giáo Viên(Nhóm 3 - nhom3tin10a2@gmail.com)-Xin Chào Thầy Mai Mạnh Trừng";
                            mc.label2.Text = "Xin Chào Giáo Viên:Vũ Thị Dần Đã Đến Với Phầm Mềm Quản Lý Sinh Viên";
                            this.Hide();
                            mc.Show();
                            mc.đăngNhậpToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
                            mc.quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
                            mc.điểmToolStripMenuItem.Visible = false;
                           
                        }
                        else if (o > 0)
                        {
                            MessageBox.Show("Bạn Đăng Nhập Vào Tài Khoản Trưởng Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Main_Chinh mc = new Main_Chinh();
                            mc.Text = "Tài Khoản Trưởng Khoa(Nhóm 3 - nhom3tin10a2@gmail.com)-Xin Chào Thầy Mai Mạnh Trừng";
                            mc.label2.Text = "Xin Chào Trưởng Khoa:Phạm Thị Hương Lan Đã Đến Với Phầm Mềm Quản Lý Sinh Viên";
                            this.Hide();
                            mc.đăngNhậpToolStripMenuItem.Visible = false;
                            mc.Show();
                        }
                        else
                        {
                            sai = sai - 1;
                            MessageBox.Show("Username Hoặc Password sai ! Bạn còn " + sai + "Lần đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.textBox1.Clear();
                            this.textBox2.Clear();
                            this.textBox1.Focus();
                            //MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            //textBox1.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hết lượt truy cập mời bạn đăng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Form1 f = new Form1();
                        f.Show();

                    }

                
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra Vui Lòng Kiểm Tra Lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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

        private void dangnhap_Load(object sender, EventArgs e)
        {
            



            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
