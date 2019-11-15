using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin.Sinhvien
{
    public partial class RPV_SinhVien : Form
    {
        public RPV_SinhVien()
        {
            InitializeComponent();
        }

        private void RPV_Diem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanlysinhvienDataSet.SinhVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
