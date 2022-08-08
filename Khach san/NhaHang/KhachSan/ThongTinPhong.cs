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

namespace NhaHang.KhachSan
{
    public partial class ThongTinPhong : Form
    {
        public ThongTinPhong()
        {
            InitializeComponent();
        }
        NhaHangClass NhaHangClass = new NhaHangClass();
        private void ThongTinPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhaHangClass.getphong();

            comboBoxGD1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            comboBoxSGC1.Text = dataGridView1.Rows[2].Cells[0].Value.ToString();
            comboBoxSGV1.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            if(dataGridView1.Rows[0].Cells[2].Value.ToString()== "CO        ")
            {
                radioButtonDHD1.Checked = true;
            }
            else
            {
                radioButtonDHD2.Checked = true;
            }
            if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "CO        ")
            {
                radioButtonTVD1.Checked = true;
            }
            else
            {
                radioButtonTVD2.Checked = true;
            }
            if (dataGridView1.Rows[0].Cells[3].Value.ToString() == "FREE      ")
            {
                radioButtonCFD1.Checked = true;
            }
            else
            {
                radioButtonCFD2.Checked = true;
            }
            if (dataGridView1.Rows[0].Cells[4].Value.ToString() == "FREE      ")
            {
                radioButtonHBD1.Checked = true;
            }
            else
            {
                radioButtonHBD2.Checked = true;
            }
            if (dataGridView1.Rows[0].Cells[5].Value.ToString() == "FREE      ")
            {
                radioButtonBSD1.Checked = true;
            }
            else
            {
                radioButtonBSD2.Checked = true;
            }








            
            if (dataGridView1.Rows[2].Cells[2].Value.ToString() == "CO        ")
            {
                radioButtonDHC1.Checked = true;
            }
            else
            {
                radioButtonDHC2.Checked = true;
            }
            if (dataGridView1.Rows[2].Cells[1].Value.ToString() == "CO        ")
            {
                radioButtonTVC1.Checked = true;
            }
            else
            {
                radioButtonTVC2.Checked = true;
            }
            if (dataGridView1.Rows[2].Cells[3].Value.ToString() == "FREE      ")
            {
                radioButtonCFC1.Checked = true;
            }
            else
            {
                radioButtonCFC2.Checked = true;
            }
            if (dataGridView1.Rows[2].Cells[4].Value.ToString() == "FREE      ")
            {
                radioButtonHBC1.Checked = true;
            }
            else
            {
                radioButtonHBC2.Checked = true;
            }
            if (dataGridView1.Rows[2].Cells[5].Value.ToString() == "FREE      ")
            {
                radioButtonBSC1.Checked = true;
            }
            else
            {
                radioButtonBSC2.Checked = true;
            }




            if (dataGridView1.Rows[1].Cells[2].Value.ToString() == "CO        ")
            {
                radioButtonDHV1.Checked = true;
            }
            else
            {
                radioButtonDHV2.Checked = true;
            }
            if (dataGridView1.Rows[1].Cells[1].Value.ToString() == "CO        ")
            {
                radioButtonTVV1.Checked = true;
            }
            else
            {
                radioButtonTVV2.Checked = true;
            }
            if (dataGridView1.Rows[1].Cells[3].Value.ToString() == "FREE      ")
            {
                radioButtonCFV1.Checked = true;
            }
            else
            {
                radioButtonCFV2.Checked = true;
            }
            if (dataGridView1.Rows[1].Cells[4].Value.ToString() == "FREE      ")
            {
                radioButtonHBV1.Checked = true;
            }
            else
            {
                radioButtonHBV2.Checked = true;
            }
            if (dataGridView1.Rows[1].Cells[5].Value.ToString() == "FREE      ")
            {
                radioButtonBSV1.Checked = true;
            }
            else
            {
                radioButtonBSV2.Checked = true;
            }















        }

        private void buttonPhongDon_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel13.Hide();
            panel3.Hide();

        }

        private void buttonPhongCap_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel13.Show();
            panel3.Hide();
        }

        private void buttonPhongVIP_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel13.Hide();
            panel3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sogiong;
            string dieuhoa;
            string tivi;
            string cafe;
            string hoboi;
            string buasang;

            sogiong = comboBoxGD1.Text;
            if (radioButtonDHD1.Checked)
            {
                dieuhoa = "CO";

            }
            else
            {
                dieuhoa = "KHONG";
            }
            if(radioButtonTVD1.Checked)
            {
                tivi = "CO";

            }else
            {
                tivi = "KHONG";
            }
            if (radioButtonCFD1.Checked)
            {
                cafe = "FREE";

            }
            else
            {
                cafe = "NO FREE";
            }
            if (radioButtonHBD1.Checked)
            {
                hoboi = "FREE";

            }
            else
            {
                hoboi = "NO FREE";
            }
            if (radioButtonBSD1.Checked)
            {
                buasang = "FREE";

            }
            else
            {
                buasang = "NO FREE";
            }

            if (NhaHangClass.updatePDON(sogiong, dieuhoa, tivi, cafe, hoboi, buasang))
            {
                MessageBox.Show("Updated", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sogiong;
            string dieuhoa;
            string tivi;
            string cafe;
            string hoboi;
            string buasang;

            sogiong = comboBoxSGC1.Text;
            if (radioButtonDHC1.Checked)
            {
                dieuhoa = "CO";

            }
            else
            {
                dieuhoa = "KHONG";
            }
            if (radioButtonTVC1.Checked)
            {
                tivi = "CO";

            }
            else
            {
                tivi = "KHONG";
            }
            if (radioButtonCFC1.Checked)
            {
                cafe = "FREE";

            }
            else
            {
                cafe = "NO FREE";
            }
            if (radioButtonHBC1.Checked)
            {
                hoboi = "FREE";

            }
            else
            {
                hoboi = "NO FREE";
            }
            if (radioButtonBSC1.Checked)
            {
                buasang = "FREE";

            }
            else
            {
                buasang = "NO FREE";
            }

            if (NhaHangClass.updatePVIP(sogiong, dieuhoa, tivi, cafe, hoboi, buasang))
            {
                MessageBox.Show("Updated", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sogiong;
            string dieuhoa;
            string tivi;
            string cafe;
            string hoboi;
            string buasang;

            sogiong = comboBoxSGV1.Text;
            if (radioButtonDHV1.Checked)
            {
                dieuhoa = "CO";

            }
            else
            {
                dieuhoa = "KHONG";
            }
            if (radioButtonDHV1.Checked)
            {
                tivi = "CO";

            }
            else
            {
                tivi = "KHONG";
            }
            if (radioButtonCFV1.Checked)
            {
                cafe = "FREE";

            }
            else
            {
                cafe = "NO FREE";
            }
            if (radioButtonHBV1.Checked)
            {
                hoboi = "FREE";

            }
            else
            {
                hoboi = "NO FREE";
            }
            if (radioButtonBSV1.Checked)
            {
                buasang = "FREE";

            }
            else
            {
                buasang = "NO FREE";
            }

            if (NhaHangClass.updatePCAP(sogiong, dieuhoa, tivi, cafe, hoboi, buasang))
            {
                MessageBox.Show("Updated", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update INFOR ROOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
