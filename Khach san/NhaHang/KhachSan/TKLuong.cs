using NhaHang.NhanSu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NhaHang.NhaHang
{
    public partial class TKLuong : Form
    {
        public TKLuong()
        {
            InitializeComponent();
        }
        StaffClass staff = new StaffClass();
        private void TKLuong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staff.getCa2();

            chart1.DataSource = staff.getCa2();
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Tiền";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Nhân Viên";
            chart1.Titles.Add("Biểu Đồ Lương Nhân Viên ");
            chart1.Series["Luong"].XValueMember = "lname";
            chart1.Series["Luong"].YValueMembers = "Luong";



        }
    }
}
