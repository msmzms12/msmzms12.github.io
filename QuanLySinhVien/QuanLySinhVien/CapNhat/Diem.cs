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

namespace QuanLySinhVien
{
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Diem");
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connect.LayBang("select * from Diem");
            dataGridView1.Columns[0].HeaderText = "Mã ID";
            dataGridView1.Columns[1].HeaderText = "Mã Sinh Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Môn Học";
            dataGridView1.Columns[3].HeaderText = "Điểm";
            comboBox1.DataSource = Connect.LayBang("select masv from SinhVien");
            comboBox1.DisplayMember = "masv";
            comboBox2.DataSource = Connect.LayBang("select mamh from MonHoc");
            comboBox2.DisplayMember = "mamh";
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập ID!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Điểm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
            else
            {
                try
                {
                    String sql = "insert into Diem values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = Connect.taoketnoi();
            ketnoi.Open();
            string st = "select count(*) from Diem where id='" + textBox1.Text + "'";
            int i = 0;
            SqlCommand cmd = new SqlCommand(st, ketnoi);
            i = (int)cmd.ExecuteScalar();
            if (i == 0)
            {
                MessageBox.Show("ID không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox4.Text = "";
            }
            else
            {
                try
                {
                    String sql = "update Diem set masv='" + comboBox1.Text + "',mamh ='" + comboBox2.Text + "',diem ='" + textBox4.Text + "' where id = '" + textBox1.Text + "'";
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
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                
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
                string st = "select count(*) from Diem where id='" + textBox1.Text + "'";
                int i = 0;
                SqlCommand cmd = new SqlCommand(st, ketnoi);
                i = (int)cmd.ExecuteScalar();
                if (i == 0)
                {
                    MessageBox.Show("ID không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox4.Text = "";
                }

                else
                {
                    try
                    {
                        String sql = "delete from diem where id = '" + textBox1.Text + "'";
                        Connect.ThemXuaXoa(sql);
                        textBox1.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        textBox4.Text = "";
                        load();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tài khoản này ko có trong hệ thống !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            

            float n;
            if (float.TryParse(textBox4.Text, out n))
            {
                Int32 a = Int32.Parse(textBox4.Text.Trim());
                if (0 <= a && a <= 10)
                {
                    label6.Text = "";
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Điểm phải nhập từ 0 - 10";
                }
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Vui lòng nhập đúng định dạng";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
