using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.NhaHang
{
    public partial class QuanLyBan : Form
    {
        public QuanLyBan()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhahnang.getTable();
            comboBoxType.Items.Add("Don");
            comboBoxType.Items.Add("Cap"); comboBoxType.Items.Add("VIP");

            change();
            labelTotal.Text = "Tổng Số Bàn Đã Đặt:  " + dataGridView1.Rows.Count;
            



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBoxID.Text;
                string Type = comboBoxType.Text;


                string Name_Custumer = textBoxTKhach.Text;
                string Number_of_guests = numericUpDown1.Text;

                DateTime Time = dateTimePicker1.Value;
                string Total = textBoxBill.Text;

                string status = "Empty";
                //if (radioButtonfull.Checked)
                //{
                //    status = "full";
                //}

                if (numericUpDown1.Text != "0")
                {
                    status = "Full";
                }

                {


                    if (nhahnang.insertBan(ID, Type, Number_of_guests, Time, status, Total, Name_Custumer))
                    {
                        MessageBox.Show("New Table Added", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = nhahnang.getTable();
                        change();
                        labelTotal.Text = "Tổng Số Bàn Đã Đặt:  " + dataGridView1.Rows.Count;

                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ID Table đã Tông Tại   -------", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string Type = comboBoxType.Text;
            string ID = textBoxID.Text;

            if (Type == "Don")
            {
                if (ID == "1" || ID == "2" || ID == "3" || ID == "4" || ID == "5" || ID == "6" || ID == "7" || ID == "8" || ID == "9" || ID == "10")
                {
                    numericUpDown1.Maximum = 1;
                    numericUpDown1.Minimum = 1;
                };
            }else
            if (Type == "VIP")
            {
                if (ID != "VIP1" || ID != "VIP2" || ID != "VIP3" || ID != "VIP4" || ID != "VIP5" || ID != "VIP6" || ID != "VIP7" || ID != "VIP8" || ID != "VIP9" || ID != "VIP10")
                {

                    numericUpDown1.Maximum = 5;
                    numericUpDown1.Minimum = 1;
                }
            }


            
            
            else
            {
                numericUpDown1.Maximum = 2;
                numericUpDown1.Minimum = 1;
            }

        }

        private void picture1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture1.Tag.ToString();
            comboBoxType.Text = "Don";
            textBoxBill.Text = "500000";


            


        }

        private void picture2_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture2.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureVIP1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP1.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";

        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            string ID_Table = textBoxID.Text;
            if (MessageBox.Show("Are You Sure You to Delete This Table", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhahnang.deleteBan(ID_Table))
                {
                    MessageBox.Show("Table Deleted", "Delete Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    change();

                    dataGridView1.DataSource = nhahnang.getTable();
                    textBoxID.Text = "";
                    textBoxBill.Text = "";
                    comboBoxType.Text = "";
                    numericUpDown1.Value = 1;
                    radioButtonEmpty.Checked = true;

                    labelTotal.Text = "Tổng Số Bàn Đã Đặt:  " + dataGridView1.Rows.Count;



                }
                else
                {
                    MessageBox.Show("Table Not Deleted", "delete Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Table Not Deleted", "delete Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            change();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            numericUpDown1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;


            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Full")
            {
                radioButtonFull.Checked = true;

            }
            else
            {
                radioButtonEmpty.Checked = true;
            }

            textBoxBill.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picture3_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture3.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
            //if (nhahnang.checkBan(picture1.Tag.ToString()))
            //{
            //    picture3.BackColor = Color.LightPink;
            //}
            //else
            //{
            //    picture3.BackColor = Color.Blue;
            //}
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture4.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture5.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture6_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture6.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture7_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture7.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture8_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture8.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture9_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture9.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture10_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture10.Tag.ToString();
            comboBoxType.Text = "Don"; textBoxBill.Text = "500000";
        }

        private void picture11_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture11.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture12_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture12.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture13_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture13.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture14_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture14.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture15_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture15.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture16_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture16.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture17_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture17.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture18_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture18.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }
      

        private void picture19_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture19.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture20_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture20.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }
     

        private void picture21_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture21.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture22_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture22.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture23_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture23.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture24_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture24.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void picture25_Click(object sender, EventArgs e)
        {
            textBoxID.Text = picture25.Tag.ToString();
            comboBoxType.Text = "Cap"; textBoxBill.Text = "700000";
        }

        private void pictureVIP2_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP2.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP3_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP3.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP4_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP4.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP5_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP5.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP6_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP6.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP7_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP7.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP8_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP8.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP9_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP9.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

        private void pictureVIP10_Click(object sender, EventArgs e)
        {
            textBoxID.Text = pictureVIP10.Tag.ToString();
            comboBoxType.Text = "VIP"; textBoxBill.Text = "1500000";
        }

       
        public void change()
        {
            if (nhahnang.checkBan(picture1.Tag.ToString()))
            {
                picture1.BackColor = Color.Cyan;

            }
            else { picture1.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture2.Tag.ToString()))
            {
                picture2.BackColor = Color.Cyan;

            }
            else { picture2.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture3.Tag.ToString()))
            {
                picture3.BackColor = Color.Cyan;

            }
            else { picture3.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture4.Tag.ToString()))
            {
                picture4.BackColor = Color.Cyan;

            }
            else { picture4.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture5.Tag.ToString()))
            {
                picture5.BackColor = Color.Cyan;
            }
            else { picture5.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture6.Tag.ToString()))
            {
                picture6.BackColor = Color.Cyan;
            }
            else { picture6.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture7.Tag.ToString()))
            {
                picture7.BackColor = Color.Cyan;
            }
            else { picture7.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture8.Tag.ToString()))
            {
                picture9.BackColor = Color.Cyan;
            }
            else { picture8.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture9.Tag.ToString()))
            {
                picture9.BackColor = Color.Cyan;
            }
            else { picture9.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture10.Tag.ToString()))
            {
                picture10.BackColor = Color.Cyan;
            }
            else { picture10.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture11.Tag.ToString()))
            {
                picture11.BackColor = Color.Cyan;
            }
            else { picture11.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture12.Tag.ToString()))
            {
                picture12.BackColor = Color.Cyan;
            }
            else { picture12.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture13.Tag.ToString()))
            {
                picture13.BackColor = Color.Cyan;
            }
            else { picture13.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture14.Tag.ToString()))
            {
                picture14.BackColor = Color.Cyan;
            }
            else { picture14.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture15.Tag.ToString()))
            {
                picture15.BackColor = Color.Cyan;
            }
            else { picture15.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture16.Tag.ToString()))
            {
                picture16.BackColor = Color.Cyan;
            }
            else { picture16.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture17.Tag.ToString()))
            {
                picture17.BackColor = Color.Cyan;
            }
            else { picture17.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture18.Tag.ToString()))
            {
                picture18.BackColor = Color.Cyan;
            }
            else { picture18.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture19.Tag.ToString()))
            {
                picture19.BackColor = Color.Cyan;
            }
            else { picture19.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture20.Tag.ToString()))
            {
                picture20.BackColor = Color.Cyan;
            }
            else { picture20.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture21.Tag.ToString()))
            {
                picture21.BackColor = Color.Cyan;
            }
            else { picture21.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture22.Tag.ToString()))
            {
                picture22.BackColor = Color.Cyan;
            }
            else { picture22.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture23.Tag.ToString()))
            {
                picture23.BackColor = Color.Cyan;
            }
            else { picture23.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture24.Tag.ToString()))
            {
                picture24.BackColor = Color.Cyan;
            }
            else { picture24.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture25.Tag.ToString()))
            {
                picture25.BackColor = Color.Cyan;
            }
            else { picture25.BackColor = Color.Cornsilk; }

            if (nhahnang.checkBan(pictureVIP1.Tag.ToString()))
            {
                pictureVIP1.BackColor = Color.Violet;
            }
            else { pictureVIP1.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP2.Tag.ToString()))
            {
                pictureVIP2.BackColor = Color.Violet;
            }
            else { pictureVIP2.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP3.Tag.ToString()))
            {
                pictureVIP3.BackColor = Color.Violet;
            }
            else { pictureVIP3.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP4.Tag.ToString()))
            {
                pictureVIP4.BackColor = Color.Violet;
            }
            else { pictureVIP4.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP6.Tag.ToString()))
            {
                pictureVIP6.BackColor = Color.Violet;
            }
            else { pictureVIP6.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP7.Tag.ToString()))
            {
                pictureVIP7.BackColor = Color.Violet;
            }
            else { pictureVIP7.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP8.Tag.ToString()))
            {
                pictureVIP8.BackColor = Color.Violet;
            }
            else { pictureVIP8.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP9.Tag.ToString()))
            {
                pictureVIP9.BackColor = Color.Violet;
            }
            else { pictureVIP9.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP10.Tag.ToString()))
            {
                pictureVIP10.BackColor = Color.Violet;
            }
            else { pictureVIP10.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP5.Tag.ToString()))
            {
                pictureVIP5.BackColor = Color.Violet;
            }
            else { pictureVIP5.BackColor = Color.Cornsilk; };

            labelTotal.Text = "Tổng Số Bàn Đã Đặt:  " + dataGridView1.Rows.Count;

        }
        DataTable dataTable = new DataTable();
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Ban WHERE CONCAT(ID_Table, Type, Number_of_guests, Time, status, Price) LIKE '%" + textBoxSearch.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            fillGrid(command);

        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.DataSource = nhahnang.getBans(command);



        }
        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            string ID = textBoxID.Text;
            string Type = comboBoxType.Text;

            string Name_Custumer = textBoxTKhach.Text;


            string Number_of_guests = numericUpDown1.Text;

            DateTime Time = dateTimePicker1.Value;
            string Total = textBoxBill.Text;

            string status = "Empty";
            if (radioButtonFull.Checked)
            {
                status = "full";
            }





            if (nhahnang.updateBan(ID, Type, Number_of_guests, Time, status, Total , Name_Custumer))
            {
                MessageBox.Show("Table Information Updated", "Edit Table", MessageBoxButtons.OK, MessageBoxIcon.Information); dataGridView1.DataSource = nhahnang.getTable();
                labelTotal.Text = "Tổng Số Bàn Đã Đặt:  " + dataGridView1.Rows.Count;

                dataGridView1.DataSource = nhahnang.getTable();
            }
            else
            {
                MessageBox.Show("Error", "Table Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
            Hide();
        }
    }
}
