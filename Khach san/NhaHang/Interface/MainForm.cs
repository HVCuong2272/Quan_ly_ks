using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.NhaHang;
using NhaHang.NhanSu;
using NhaHang.KhachSan;



namespace NhaHang.Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quảnLýMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMon quanLyMon = new QuanLyMon();
            quanLyMon.Show(this);
        }

        private void đặtMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatMon datMon = new DatMon();
            datMon.Show(this);
        }

        private void quảnLýBànTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan();
            quanLyBan.Show(this);
        }

        private void danhSáchMónNấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaBep nhaBep = new NhaBep();
            nhaBep.Show(this);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DatMon datMon = new DatMon();
            datMon.Show(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu quanLyNhanSu = new QuanLyNhanSu();
            quanLyNhanSu.Show(this);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NhaBep nhaBep = new NhaBep();
            nhaBep.Show(this);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show(this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            QuanLyMon quanLyMon = new QuanLyMon();
            quanLyMon.Show(this);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu quanLyNhanSu = new QuanLyNhanSu();
            quanLyNhanSu.Show(this);
        }

        private void đăngKýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyKhachHang dangKyKhachHang = new DangKyKhachHang();
            dangKyKhachHang.Show(this);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.Show(this);
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nguyênLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.Show(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLyBan = new QuanLyBan();
            quanLyBan.Show(this);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýCaLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLCaLam qLCaLam = new QLCaLam();
            qLCaLam.Show(this);
        }

        private void checkOutGiờLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccout addAccout = new AddAccout();
            addAccout.Show(this);
        }

        private void thâyĐổiCaLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiCa thayDoiCa = new ThayDoiCa();
            thayDoiCa.Show(this);
        }

        private void nhậnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDoanhThu tKDoanhThu = new TKDoanhThu();
            tKDoanhThu.Show(this);
        }

        private void thôngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKLuong tKLuong = new TKLuong();
            tKLuong.Show(this);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhongThanhToan traPhongThanhToan = new TraPhongThanhToan();
            traPhongThanhToan.Show(this);
        }

        private void đồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show(this);
        }

        private void quảnLýThongTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinPhong thongTinPhong = new ThongTinPhong();
            thongTinPhong.Show(this);
        }

        private void thôngKêMónHOTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiamGia giamGia = new GiamGia();
            giamGia.Show(this);

        }
    }
}
