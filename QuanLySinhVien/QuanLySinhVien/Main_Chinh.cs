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
    public partial class Main_Chinh : Form
    {
        public Main_Chinh()
        {
            InitializeComponent();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminControl ac = new AdminControl();
            ac.Show();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.45;
        }

        

        private void paintToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void quảnLýTàiKhoảnUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl uc = new UserControl();
            uc.Show();
           
        }

        private void quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TruongkhoaControl tkc = new TruongkhoaControl();
            tkc.Show();
        }

        private void quảnLýTàiKhoảnGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherControl tc = new TeacherControl();
            tc.Show();

        }

        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChinhSach cs = new ChinhSach();
            cs.Show();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinDiem ttd = new ThongTin.ThongTinDiem();
            ttd.Show();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinChinhSach ttcs = new ThongTin.ThongTinChinhSach();
            ttcs.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
        }

        private void khoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CapNhat.Khoa k = new CapNhat.Khoa();
            k.Show();
        }

        private void giáoViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CapNhat.GiaoVien gv = new CapNhat.GiaoVien();
            gv.Show();
        }

        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CapNhat.Lop l = new CapNhat.Lop();
            l.Show();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CapNhat.SinhVien sv = new CapNhat.SinhVien();
            sv.Show();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CapNhat.MonHoc mh = new CapNhat.MonHoc();
            mh.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinMonHoc ttmh = new ThongTin.ThongTinMonHoc();
            ttmh.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinSinhVien ttsv= new ThongTin.ThongTinSinhVien();
            ttsv.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinLop ttl = new ThongTin.ThongTinLop();
            ttl.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin.ThongTinGiaoVien ttgv = new ThongTin.ThongTinGiaoVien();
            ttgv.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ThongTin.ThongTinKhoa ttk = new ThongTin.ThongTinKhoa();
            ttk.Show();
        }

        private void đăngKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cậpNhậtPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhât!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second+"\n"+DateTime.Now.Day+ "-" + DateTime.Now.Month+ "-" + DateTime.Now.Year;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;


            if (label2.Left <= this.Width)
            {
                label2.Left = label2.Left + 5;
            }
            else
            {
                label2.Left = -label2.Width;
            }


        }

        private void Main_Chinh_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
        }

        private void khóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Visible = false;
            đăngNhậpToolStripMenuItem.Visible = true;
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
            thôngTinToolStripMenuItem.Visible = false;
            tìmKiếmToolStripMenuItem.Visible = false;
            điểmToolStripMenuItem.Visible = false;
            quảnLýToolStripMenuItem.Visible = false;
            hiểnThịToolStripMenuItem.Visible = false;
            tiệnÍchToolStripMenuItem.Visible = false;
            hỗTrợToolStripMenuItem.Visible = false;
            thoátToolStripMenuItem.Visible = false;
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
            
        }

        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản Admin";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Quản Lý Tài Khoản Trưởng Khoa";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Quản Lý Tài Khoản Giáo Viên";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "Quản Lý Tài Khoản User";
            khóaToolStripMenuItem.Text = "Khóa";
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật khẩu";
            đăngKhẩuToolStripMenuItem.Text = "Đăng xuất";

            thôngTinToolStripMenuItem.Text = "Thông Tin";
            khoaToolStripMenuItem.Text = "Khoa";
            giáoViênToolStripMenuItem.Text = "Giáo Viên";
            lớpToolStripMenuItem.Text = "Lớp";
            sinhViênToolStripMenuItem.Text = "Sinh Viên";
            mônHọcToolStripMenuItem.Text = "Môn Học";
            chínhSáchToolStripMenuItem.Text = "Chính Sách";
            điểmToolStripMenuItem1.Text = "Điểm";

            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            khoaToolStripMenuItem1.Text = "Khoa";
            giáoViênToolStripMenuItem1.Text = "Giáo Viên";
            lớpToolStripMenuItem1.Text = "Lớp";
            sinhViênToolStripMenuItem1.Text = "Sinh Viên";
            mônHọcToolStripMenuItem1.Text = "Môn Học";
            chínhSáchToolStripMenuItem1.Text = "Chính Sách";

            điểmToolStripMenuItem.Text = "Điểm";

            quảnLýToolStripMenuItem.Text = "Quản Lý";
            khoaToolStripMenuItem2.Text = "Khoa";
            giáoViênToolStripMenuItem2.Text = "Giáo Viên";
            lớpToolStripMenuItem2.Text = "Lớp";
            sinhViênToolStripMenuItem2.Text = "Sinh Viên";
            mônHọcToolStripMenuItem2.Text = "Môn Học";
            chínhSáchToolStripMenuItem2.Text = "Chính Sách";

            hiểnThịToolStripMenuItem.Text = "Hiện Thị";
            kiểuXemToolStripMenuItem.Text = "Kiểu Xem";
            trongSuốtToolStripMenuItem.Text = "Trong Suốt";
            ngônNgữToolStripMenuItem.Text = "Ngôn Ngữ";
            tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
            tiếngAnhToolStripMenuItem.Text = "Tiếng Anh";
            tiệnÍchToolStripMenuItem.Text = "Tiện Ích";
            máyTínhToolStripMenuItem.Text = "Máy Tính";

            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            liênHệToolStripMenuItem.Text = "Liên Hệ";
            thôngTinToolStripMenuItem1.Text = "Thông Tin";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Cập Nhập Phần Mềm";
            thoátToolStripMenuItem.Text = "Thoát";
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mặcĐịnhToolStripMenuItem.Text = "Defaut";
            hệThốngToolStripMenuItem.Text = "System";
            đăngNhậpToolStripMenuItem.Text = "Login";
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Admin Account Management";
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Text = "Dean Of An Account Management";
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Text = "Teacher Account Management";
            quảnLýTàiKhoảnUserToolStripMenuItem.Text = "User Account Management";
            khóaToolStripMenuItem.Text = "Lock";
            đổiMậtKhẩuToolStripMenuItem.Text = "Change password";
            đăngKhẩuToolStripMenuItem.Text = "Log out";

            thôngTinToolStripMenuItem.Text = "Information";
            khoaToolStripMenuItem.Text = "Marl";
            giáoViênToolStripMenuItem.Text = "Teacher";
            lớpToolStripMenuItem.Text = "CLass";
            sinhViênToolStripMenuItem.Text = "Students";
            mônHọcToolStripMenuItem.Text = "Policy";
            chínhSáchToolStripMenuItem.Text = "Falculty";
            điểmToolStripMenuItem1.Text = "Mark";

            tìmKiếmToolStripMenuItem.Text = "Search";
            khoaToolStripMenuItem1.Text = "Falculty";
            giáoViênToolStripMenuItem1.Text = "Teacher";
            lớpToolStripMenuItem1.Text = "Class";
            sinhViênToolStripMenuItem1.Text = "Students";
            mônHọcToolStripMenuItem1.Text = "Subject";
            chínhSáchToolStripMenuItem1.Text = "Policy";

            điểmToolStripMenuItem.Text = "Mark";

            quảnLýToolStripMenuItem.Text = "Manager";
            khoaToolStripMenuItem2.Text = "Falculty";
            giáoViênToolStripMenuItem2.Text = "Teacher";
            lớpToolStripMenuItem2.Text = "Class";
            sinhViênToolStripMenuItem2.Text = "Students";
            mônHọcToolStripMenuItem2.Text = "Subject";
            chínhSáchToolStripMenuItem2.Text = "Policy";

            hiểnThịToolStripMenuItem.Text = "Display";
            kiểuXemToolStripMenuItem.Text = "View";
            trongSuốtToolStripMenuItem.Text = "Crystal-Clear";
            ngônNgữToolStripMenuItem.Text = "Language";
            tiếngViệtToolStripMenuItem.Text = "VietNamese";
            tiếngAnhToolStripMenuItem.Text = "English";
            tiệnÍchToolStripMenuItem.Text = "Utilities";
            máyTínhToolStripMenuItem.Text = "Calculator";

            hỗTrợToolStripMenuItem.Text = "Support";
            liênHệToolStripMenuItem.Text = "Contact";
            thôngTinToolStripMenuItem1.Text = "Information";
            cậpNhậtPhầnMềmToolStripMenuItem.Text = "Software Update";
            thoátToolStripMenuItem.Text = "Exit";
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void điểmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhat.DoiMatKhau dmk = new CapNhat.DoiMatKhau();
            dmk.Show();
        }

        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemGiaoVien tkgv = new TimKiem.TimKiemGiaoVien();
            tkgv.Show();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemSinhVien tksv = new TimKiem.TimKiemSinhVien();
            tksv.Show();
        }

        private void khoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemKhoa tkk = new TimKiem.TimKiemKhoa();
            tkk.Show();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemMonHoc tkmh = new TimKiem.TimKiemMonHoc();
            tkmh.Show();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemLop tkl = new TimKiem.TimKiemLop();
            tkl.Show();
        }

        private void chínhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiem.TimKiemChinhSach tkcs = new TimKiem.TimKiemChinhSach();
            tkcs.Show();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QuanLySinhVien.chm");
            
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiệnÍchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Visible = false;
            đăngNhậpToolStripMenuItem.Visible = true;
            quảnLýTàiKhoảnGiáoViênToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnTrưởngKhoaToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnUserToolStripMenuItem.Visible = false;
            quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
            thôngTinToolStripMenuItem.Visible = false;
            tìmKiếmToolStripMenuItem.Visible = false;
            điểmToolStripMenuItem.Visible = false;
            quảnLýToolStripMenuItem.Visible = false;
            hiểnThịToolStripMenuItem.Visible = false;
            tiệnÍchToolStripMenuItem.Visible = false;
            hỗTrợToolStripMenuItem.Visible = false;
            thoátToolStripMenuItem.Visible = false;
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông Báo(Nhóm 3 - nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
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

        private void nhiệmVụNhómToolStripMenuItem_Click(object sender, EventArgs e)
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
            tt += "1. Phạm Văn Tài (C):Yêu cầu nâng cao 3,4,5,8.";
            tt += "\n";
            tt += "2. Phạm Thị Hương Lan:Test, yêu cầu nâng cao 1-2,Báo cáo.";
            tt += "\n";
            tt += "3. Vũ Thị Dần:Yêu cầu nâng cao 7, thiết kế giao diện.";
            tt += "\n";
            tt += "\n";
            tt += "Email: nhom3tin10a2hn@gmail.com\n";
            tt += "\n";
            MessageBox.Show((tt), "Thông Tin(nhom3tin10a2hn@gmail.com)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
