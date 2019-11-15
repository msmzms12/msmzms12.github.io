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
    public partial class SinhVien : Form
    {
        String gt;
        public SinhVien()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.DataSource = Connect.LayBang("select * from SinhVien");
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Sinh Viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Sinh Viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (radioButton2.Checked == false && radioButton1.Checked == false)
            {
                MessageBox.Show("Bạn Chưa Nhập Giới Tính!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox8.Focus();
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Focus();
            }
            else
            {
                try
                {
                    if (radioButton1.Checked)
                    {
                        gt = "Nam";
                    }
                    else
                    {
                        gt = "Nữ";
                    }
                    String sql = "insert into SinhVien values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + gt + "','" + dateTimePicker1.Value + "',N'" + textBox8.Text + "',N'" + textBox7.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')";
                    Connect.ThemXuaXoa(sql);
                    MessageBox.Show("Thêm mới thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from SinhVien");
            dataGridView1.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Giới Tính";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "SĐT";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[6].HeaderText = "Mã Cs";
            dataGridView1.Columns[7].HeaderText = "Mã Lớp";



            comboBox2.DataSource = Connect.LayBang("select macs from ChinhSach");
            comboBox2.DisplayMember = "macs";


            comboBox3.DataSource = Connect.LayBang("select malop from Lop");
            comboBox3.DisplayMember = "malop";


            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();
            string st = "select count(*) from SinhVien where masv='" + textBox1.Text + "'";
            int i = 0;
            SqlCommand cmd = new SqlCommand(st, ketnoi);
            i = (int)cmd.ExecuteScalar();
            if (i == 0)
            {
                MessageBox.Show("Mã sinh viên không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }
            else
            {
                try
                {

                    if (radioButton1.Checked)
                    {
                        gt = "Nam";
                    }
                    else
                    {
                        gt = "Nữ";
                    }
                    String sql = "update SinhVien set tensv=N'" + textBox2.Text + "',gioitinh =N'" + gt + "',ngaysinh ='" + dateTimePicker1.Value + "',sdt =N'" + textBox8.Text + "',diachi =N'" + textBox7.Text + "',macs =N'" + comboBox2.Text + "',malop =N'" + comboBox3.Text + "' where masv =N'" + textBox1.Text + "'";
                    Connect.ThemXuaXoa(sql);
                    MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thao tác không thực hiên được!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim().Equals("Nam"))
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn thực sự muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                SqlConnection ketnoi = Connect.taoketnoi();
                ketnoi.Open();
                string st = "select count(*) from SinhVien where masv='" + textBox1.Text + "'";
                int i = 0;
                SqlCommand cmd = new SqlCommand(st, ketnoi);
                i = (int)cmd.ExecuteScalar();
                if (i == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    try
                    {
                        String sql = "delete from SinhVien where masv = '" + textBox1.Text + "'";
                        Connect.ThemXuaXoa(sql);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        dateTimePicker1.Text = "";
                        textBox8.Text = "";
                        textBox7.Text = "";
                        comboBox2.Text = "";
                        comboBox3.Text = "";
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
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
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

        private void label7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChinhSach cs = new ChinhSach();
            cs.Show();
        }

        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Lop l = new Lop();
            l.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(textBox8.Text, out n))
            {
                label10.Text = "";
            }
            else
            {
                label10.ForeColor = Color.Red;
                label10.Text = "Vui lòng nhập đúng định dạng";
            }
        }
    }
}
