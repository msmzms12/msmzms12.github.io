using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin.MonHoc
{
    public partial class RPV_MonHoc : Form
    {
        public RPV_MonHoc()
        {
            InitializeComponent();
        }

        private void RPV_MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.quanlysinhvienDataSet.MonHoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
