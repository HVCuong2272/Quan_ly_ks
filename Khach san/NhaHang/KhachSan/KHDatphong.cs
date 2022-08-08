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
    public partial class KHDatphong : Form
    {
        public KHDatphong()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();

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

        private void KHDatphong_Load(object sender, EventArgs e)
        {
            textBoxID.Text = QLBanTrong.luu.soban;
            comboBoxType.Items.Add("Don");
            comboBoxType.Items.Add("Cap"); comboBoxType.Items.Add("VIP");
            string ID = textBoxID.Text;

            if (ID == "1" || ID == "2" || ID == "3" || ID == "4" || ID == "5" || ID == "6" || ID == "7" || ID == "8" || ID == "9" || ID == "10")
            {
                comboBoxType.Text = "Don";
                textBoxBill.Text = "500000";
            }else
           
            if (ID == "VIP1" || ID == "VIP2" || ID == "VIP3" || ID == "VIP4" || ID == "VIP5" || ID == "VIP6" || ID == "VIP7" || ID == "VIP8" || ID == "VIP9" || ID == "VIP10")
            {

                comboBoxType.Text = "VIP";
                textBoxBill.Text = "1500000";


            }
            else
            {
                comboBoxType.Text = "Cap";
                textBoxBill.Text = "700000";


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
            }
            else
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
    }
}
