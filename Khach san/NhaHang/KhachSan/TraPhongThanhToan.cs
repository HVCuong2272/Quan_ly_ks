using NhaHang.NhaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.KhachSan
{
    public partial class TraPhongThanhToan : Form
    {
        public TraPhongThanhToan()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        private void TraPhongThanhToan_Load(object sender, EventArgs e)
        {
            Tinh();
            
            





            dataGridView1.DataSource = nhahnang.getTable();


            DateTime startTime = Convert.ToDateTime(dateTimePicker1.Value);
            textBox1.Text = startTime.ToString("dd");


            DateTime endtime = Convert.ToDateTime(dateTimePicker2.Value);
            textBox2.Text = endtime.ToString("dd");

            //TimeSpan duration = endtime - startTime;
            textBoxngay.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime(dateTimePicker1.Value);
            textBox1.Text = startTime.ToString("dd");


            DateTime endtime = Convert.ToDateTime(dateTimePicker2.Value);
            textBox2.Text = endtime.ToString("dd");

            //TimeSpan duration = endtime - startTime;
            textBoxngay.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            //if (textBoxGia.Text == "" || textBoxngay.Text == "")
            //{

            //}
            //else
            //{
            //    textBoxTong.Text = Convert.ToString((Int32.Parse(textBoxGia.Text.ToString()) * Int32.Parse(textBoxngay.Text.ToString())));
            //}
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime(dateTimePicker1.Value);
            textBox1.Text = startTime.ToString("dd");


            DateTime endtime = Convert.ToDateTime(dateTimePicker2.Value);
            textBox2.Text = endtime.ToString("dd");

            //TimeSpan duration = endtime - startTime;
            textBoxngay.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboBoxIdTable.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textboxTenKhach.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxGia.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Tinh();
            dateTimePicker2.Text = "";
            textBoxGiamGia.Text = "";
            textBoxTienDua.Text = "";
            textBoxTienThoi.Text = "";


        }
        private void Tinh()
        {
            int thanhtien = 0;
            if (textBoxGia.Text == "" || textBoxngay.Text == "")
            {

            }
            else
            {
                textBoxTong.Text = Convert.ToString((Int32.Parse(textBoxGia.Text.ToString()) * Int32.Parse(textBoxngay.Text.ToString())));
            }
            if (textBoxTienDua.Text == "" || textBoxGiamGia.Text == "")
            {

            }
            else
            {
                //thanhtien += Int32.Parse(textBoxTienDua.Text.ToString()) - (Int32.Parse(textBoxTong.Text.ToString()) - Int32.Parse(textBoxGiamGia.Text.ToString()));
                //textBoxTienThoi.Text = thanhtien.ToString();
            }


        }
        


        
        private void textBoxGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGiamGia.Text == "")
            {

            }
            else
            {
                if (Int32.Parse(textBoxGiamGia.Text.ToString()) >= Int32.Parse(textBoxTong.Text.ToString()))
                {
                    textBoxGiamGia.Text = textBoxTong.Text;
                    textBoxTienDua.Text = "0";
                }
            }
            Tinh();
        }

        private void textBoxTienDua_TextChanged(object sender, EventArgs e)
        {
            Tinh();

        }

        private void textBoxTong_TextChanged(object sender, EventArgs e)
        {
            Tinh();

        }
        TinhTien TinhTien = new TinhTien();
        private void buttonThanh_Toan_Click(object sender, EventArgs e)
        {
            if (textBoxTienDua.Text == "" || textBoxGiamGia.Text == "")
            {

            }
            else
            {
                if (Int32.Parse(textBoxTienDua.Text.ToString()) >= (Int32.Parse(textBoxTong.Text.ToString()) - Int32.Parse(textBoxGiamGia.Text.ToString())))
                {
                    string ID_Table = comboBoxIdTable.Text;

                    if (MessageBox.Show("Xác Nhận Thanh Toán-----", "Thanh Toán.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (TinhTien.updateFood2(ID_Table));
                        dataGridView1.DataSource = nhahnang.getTable();

                    }

                }
                else
                {
                    MessageBox.Show("Hãy Trả Đủ Tiền Để Thanh Toán : ", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBoxcode_TextChanged(object sender, EventArgs e)
        {
            string code = textBoxcode.Text;

            dataGridView2.DataSource = nhahnang.getGiamGia2(code);

           







            try
            {

                textBoxGiamGia.Text = dataGridView2.Rows[0].Cells["Giam"].Value.ToString();
            }
            catch
            {
                
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxngay_TextChanged(object sender, EventArgs e)
        {
            Tinh();
        }
    }
}
