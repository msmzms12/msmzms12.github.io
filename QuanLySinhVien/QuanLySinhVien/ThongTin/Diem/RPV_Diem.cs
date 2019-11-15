using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.ThongTin.Diem
{
    public partial class RPV_Diem : Form
    {
        public RPV_Diem()
        {
            InitializeComponent();
        }

        private void RPV_Diem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Diem' table. You can move, or remove it, as needed.
            this.diemTableAdapter.Fill(this.quanlysinhvienDataSet.Diem);

            this.reportViewer1.RefreshReport();
        }
    }
}
