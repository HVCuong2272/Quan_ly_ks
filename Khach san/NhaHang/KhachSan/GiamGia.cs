using NhaHang.NhaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.KhachSan
{
    public partial class GiamGia : Form
    {
        public GiamGia()
        {
            InitializeComponent();
        }
        TinhTien TinhTien = new TinhTien();
        NhaHangClass NhaHang = new NhaHangClass();
        private void GiamGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhaHang.getGiamGia();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
           

            string code = textBoxcode.Text;
            string giam = textBoxgiam.Text;

            DateTime Time = dateTimePicker1.Value;

            if (NhaHang.checkGGia(code))
            {
                {


                    if (NhaHang.insertGGia(code, giam, Time))
                    {
                        MessageBox.Show("New Event Added", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = NhaHang.getGiamGia();


                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("đã tồn tại", "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

            
        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            string code = textBoxcode.Text;


           



            {


                if (NhaHang.deleteGGia(code))
                {
                    MessageBox.Show("New Event Deleted", "Deleted Event", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = NhaHang.getGiamGia();


                }
                else
                {
                    MessageBox.Show("Error", "Deleted Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxgiam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
