using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.NhaHang
{
    public partial class TKDoanhThu : Form
    {
        public TKDoanhThu()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        QLMon QLMon = new QLMon();
        private void TKDoanhThu_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = nhahnang.getDT();
            Gia();
        }
        private void Gia()
        {
            int sc = dataGridView2.Rows.Count;
            float thanhtien = 0;

            {
                for (int i = 0; i < sc; i++)
                {
                    if(dataGridView2.Rows[i].Cells["Thanh_Toan"].Value.ToString()== "Da Thanh Toan")
                    {
                        thanhtien += float.Parse(dataGridView2.Rows[i].Cells["Gia"].Value.ToString()) * float.Parse(dataGridView2.Rows[i].Cells["So_Luong"].Value.ToString());
                        label1.Text = "Tổng Doanh Thu :     " + thanhtien.ToString("$ 00000000.00");
                    }    
                   

                }
            }
        }
    }
}
