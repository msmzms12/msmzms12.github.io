using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin.GiaoVien
{
    public partial class RPV_GiaoVien : Form
    {
        public RPV_GiaoVien()
        {
            InitializeComponent();
        }

        private void RPV_GiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.quanlysinhvienDataSet.GiaoVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
