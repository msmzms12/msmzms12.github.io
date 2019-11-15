using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin.Lop
{
    public partial class RPV_Lop : Form
    {
        public RPV_Lop()
        {
            InitializeComponent();
        }

        private void RPV_Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanlysinhvienDataSet.Lop);

            this.reportViewer1.RefreshReport();
        }
    }
}
