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

namespace NhaHang
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMon quanLyMon = new QuanLyMon();
            quanLyMon.Show(this);
        }

        private void quảnLýĐặtMónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaBep nhaBep = new NhaBep();
            nhaBep.Show(this);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DatMon datMon = new DatMon();
            datMon.Show(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NhaBep nhaBep = new NhaBep();
            nhaBep.Show(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show(this);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show(this);
        }

        private void đăngKýKháchHàngThườngXuyênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
