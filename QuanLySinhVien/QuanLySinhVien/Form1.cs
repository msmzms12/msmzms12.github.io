using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label2.Left <= this.Width)
            {
                label2.Left = label2.Left + 5;
            }
            else
            {
                label2.Left = -label2.Width;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            String tt;
            tt = "Phầm Mềm: Quản Lý Sinh Viên\n";
            tt += "\n";
            tt += "Version 1.1 \n";
            tt += "\n";
            tt += "Học phần thực tập lập trình .NET";
            tt += "\n";
            tt += "Nhóm 3 - DHTIN10A2";
            tt += "\n\n";
            tt += "Thành Viên Nhóm";
            tt += "\n";
            tt += "1. Phạm Văn Tài (C)";
            tt += "\n";
            tt += "2. Phạm Thị Hương Lan";
            tt += "\n";
            tt += "3. Vũ Thị Dần";
            tt += "\n";
            tt += "\n";
            tt += "Email: nhom3tin10a2hn@gmail.com\n";
            tt += "\n";
            MessageBox.Show((tt), "Thông Tin(nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
