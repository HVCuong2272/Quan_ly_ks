using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.NhanSu;
using NhaHang.Interface;

namespace NhaHang.NhanSu
{
    public partial class ThayDoiCa : Form
    {
        public ThayDoiCa()
        {
            InitializeComponent();
        }
        StaffClass staff = new StaffClass();
        private void ThayDoiCa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staff.getCaTD();
            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox_1.Text = Convert.ToString(ca1.ToString());
            textBox_2.Text = Convert.ToString(ca2.ToString());

            textBox_3.Text = Convert.ToString(ca3.ToString());

            //ca 2
            int ca12 = 0;
            int ca22 = 0;
            int ca32 = 0;
            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "1")
                {
                    ca12 = ca12 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "2")
                {
                    ca22 = ca22 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "3")
                {
                    ca32 = ca32 + 1;
                }





            }
            textBox12.Text = Convert.ToString(ca12.ToString());
            textBox22.Text = Convert.ToString(ca22.ToString());

            textBox32.Text = Convert.ToString(ca32.ToString());





        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "1")
            {
                Ca1.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "2")
            {
                Ca2.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "3")
            {
                Ca3.Checked = true;
            }
            // ca 2

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                radioButton1.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "2")
            {
                radioButton2.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "3")
            {
                radioButton3.Checked = true;
            }





            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Ca1_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca = 1;
            if (Ca1.Checked)
            {
                ca = 1;
            }
            else if (Ca2.Checked)
            {
                ca = 2;
            }
            else if(Ca3.Checked)
            {
                ca = 3;
            }
           
                staff.updateCa(Id, ca);
            textBoxID.Text = "";
           


            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox_1.Text = Convert.ToString(ca1.ToString());
            textBox_2.Text = Convert.ToString(ca2.ToString());

            textBox_3.Text = Convert.ToString(ca3.ToString());
        }

        private void Ca2_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca = 1;
            if (Ca1.Checked)
            {
                ca = 1;
            }
            else if (Ca2.Checked)
            {
                ca = 2;
            }
            else if (Ca3.Checked)
            {
                ca = 3;
            }

            staff.updateCa(Id, ca); textBoxID.Text = "";

           



            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox_1.Text = Convert.ToString(ca1.ToString());
            textBox_2.Text = Convert.ToString(ca2.ToString());

            textBox_3.Text = Convert.ToString(ca3.ToString());
        }

        private void Ca3_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca = 1;
            if (Ca1.Checked)
            {
                ca = 1;
            }
            else if (Ca2.Checked)
            {
                ca = 2;
            }
            else if (Ca3.Checked)
            {
                ca = 3;
            }

            staff.updateCa(Id, ca); textBoxID.Text = "";

           



            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox_1.Text = Convert.ToString(ca1.ToString());
            textBox_2.Text = Convert.ToString(ca2.ToString());

            textBox_3.Text = Convert.ToString(ca3.ToString());
        }

        private void label2_Click(object sender, EventArgs e)

        {
            textBoxID.Text = "";
            dataGridView1.DataSource = staff.getCaTD();
            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox_1.Text = Convert.ToString(ca1.ToString());
            textBox_2.Text = Convert.ToString(ca2.ToString());

            textBox_3.Text = Convert.ToString(ca3.ToString());


            int ca12 = 0;
            int ca22 = 0;
            int ca32 = 0;

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "1")
                {
                    ca12 = ca12 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "2")
                {
                    ca22 = ca22 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "3")
                {
                    ca32 = ca32 + 1;
                }





            }
            textBox12.Text = Convert.ToString(ca12.ToString());
            textBox22.Text = Convert.ToString(ca22.ToString());

            textBox32.Text = Convert.ToString(ca32.ToString());




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca12 = 1;
            if (radioButton1.Checked)
            {
                ca12 = 1;
            }
            else if (radioButton2.Checked)
            {
                ca12 = 2;
            }
            else if (radioButton3.Checked)
            {
                ca12 = 3;
            }

            staff.updateCa2(Id, ca12);
            textBoxID.Text = "";



            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox12.Text = Convert.ToString(ca1.ToString());
            textBox22.Text = Convert.ToString(ca2.ToString());

            textBox32.Text = Convert.ToString(ca3.ToString());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca = 1;
            if (Ca1.Checked)
            {
                ca = 1;
            }
            else if (Ca2.Checked)
            {
                ca = 2;
            }
            else if (Ca3.Checked)
            {
                ca = 3;
            }

            staff.updateCa2(Id, ca);
            textBoxID.Text = "";



            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox12.Text = Convert.ToString(ca1.ToString());
            textBox22.Text = Convert.ToString(ca2.ToString());

            textBox32.Text = Convert.ToString(ca3.ToString());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int ca = 1;
            if (Ca1.Checked)
            {
                ca = 1;
            }
            else if (Ca2.Checked)
            {
                ca = 2;
            }
            else if (Ca3.Checked)
            {
                ca = 3;
            }

            staff.updateCa2(Id, ca);
            textBoxID.Text = "";



            int ca1 = 0;
            int ca2 = 0;
            int ca3 = 0;
            int end = Convert.ToInt32(dataGridView1.Rows.Count);

            for (int i = 0; i < end; i++)
            {


                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "1")
                {
                    ca1 = ca1 + 1;

                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "2")
                {
                    ca2 = ca2 + 1;
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "3")
                {
                    ca3 = ca3 + 1;
                }





            }
            textBox12.Text = Convert.ToString(ca1.ToString());
            textBox22.Text = Convert.ToString(ca2.ToString());

            textBox32.Text = Convert.ToString(ca3.ToString());
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
