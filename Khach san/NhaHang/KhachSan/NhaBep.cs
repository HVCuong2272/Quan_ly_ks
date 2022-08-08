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
    public partial class NhaBep : Form
    {
        public NhaBep()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        QLMon QLMon = new QLMon();
        NhaBepClass NhaBepClass = new NhaBepClass();

        private void NhaBep_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = NhaBepClass.getOrder();
            dataGridView1.DataSource = NhaBepClass.getFood(); dataGridView3.DataSource = NhaBepClass.getTable();

            dataGridView3.Columns["KL_1Phan"].DefaultCellStyle.Format = "N2";

            dataGridView3.Columns["Số_Phần"].DefaultCellStyle.Format = "N0";
            fill();
        }
        public void fill()
        {
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 50;
            //picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 50;
            picCol2 = (DataGridViewImageColumn)dataGridView2.Columns[5];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

           
        }

        private void radioButtonReady_CheckedChanged(object sender, EventArgs e)
        {

            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            string TinhTrang = "Ready";
            if (radioButtonReady.Checked)
            {
                TinhTrang = "Ready";
            }
            else TinhTrang = "NO";
            NhaBepClass.updateFood(ID_Food, TinhTrang); dataGridView1.DataSource = NhaBepClass.getFood();

        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            string TinhTrang = "Ready";
            if (radioButtonReady.Checked)
            {
                TinhTrang = "Ready";
            }
            else TinhTrang = "NO";
            NhaBepClass.updateFood(ID_Food, TinhTrang);
            dataGridView1.DataSource = NhaBepClass.getFood();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxIDFood.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Ready")
            {
                radioButtonReady.Checked = true;

            }
            else
            {
                radioButtonNO.Checked = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonThucHien_CheckedChanged(object sender, EventArgs e)
        {

            //if(radioButtonChua.Checked)
            //{
                int ID_Food = Convert.ToInt32(textBoxIDF.Text);
                string ID_Table = textBoxIDTB.Text;
                string Thuc_Hien = "Da Thuc Hien";
                if (radioButtonThucHien.Checked)
                {
                    Thuc_Hien = "Da Thuc Hien";
                }
                else Thuc_Hien = "Chua";
                if (MessageBox.Show("Xác Nhận ", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhaBepClass.updateThuc_Hien(ID_Food, ID_Table, Thuc_Hien); dataGridView2.DataSource = NhaBepClass.getOrder();

                }
            //}    



           

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBoxIDTB.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxIDF.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView2.CurrentRow.Cells[6].Value.ToString() == "Da Thuc Hien")
            {
                radioButtonThucHien.Checked = true;

            }
            else
            {
                radioButtonChua.Checked = true;
            }
        }

        private void radioButtonChua_CheckedChanged(object sender, EventArgs e)
        {

                int ID_Food = Convert.ToInt32(textBoxIDF.Text);
                string ID_Table = textBoxIDTB.Text;
                string Thuc_Hien = "Da Thuc Hien";
                if (radioButtonThucHien.Checked)
                {
                    Thuc_Hien = "Da Thuc Hien";
                }
                else Thuc_Hien = "Chua";
                if (MessageBox.Show("Xác Nhận ", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhaBepClass.updateThuc_Hien(ID_Food, ID_Table, Thuc_Hien); dataGridView2.DataSource = NhaBepClass.getOrder();

                }
            
        }
    }
}
