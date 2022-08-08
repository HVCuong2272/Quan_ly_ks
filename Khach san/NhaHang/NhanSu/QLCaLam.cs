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
    public partial class QLCaLam : Form
    {
        public QLCaLam()
        {
            InitializeComponent();
        }
        StaffClass staff = new StaffClass();

        private void QLCaLam_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staff.getCa();

            

            textBox1.Text = Log_In_Form.luu.User;
            textBox2.Text = Log_In_Form.luu.Pass;
            

            //if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "1")
            //{
            //    Ca1.Checked = true;

            //}
            //else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "2")
            //{
            //    Ca2.Checked = true;
            //}
            //else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "3")
            //{
            //    Ca3.Checked = true;
            //}


//dem so ca
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

            // dem so ca 2
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
            //





            //test
            //int CaLam = 0;
            //int so1 = Int32.Parse(textBox_1.Text);
            //int so2 = Int32.Parse(textBox_2.Text);
            //int so3 = Int32.Parse(textBox_3.Text);



            //if (so1 <= so2 && so1 <= so3)
            //{
            //    Ca1.Checked = true;
            //}
            //else if (so2 < so1 && so2 < so3)
            //{
            //    Ca2.Checked = true;
            //}
            //else
            //{
            //    Ca3.Checked = true;
            //}




            ////ca 2

            //int so12 = Int32.Parse(textBox12.Text);
            //int so22 = Int32.Parse(textBox22.Text);
            //int so32 = Int32.Parse(textBox32.Text);
            //dataGridView2.DataSource = staff.getCa1(textBox1.Text, textBox2.Text);
            //int CaTruoc = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());

            //if (CaTruoc == 1)
            //{
            //    if (so22 <= so32)
            //    {
            //        radioButton5.Checked = true;
            //    }
            //    else
            //    {
            //        radioButton6.Checked = true;

            //    }
            //}
            //else
            //if (CaTruoc == 2)
            //{
            //    if (so12 <= so32)
            //    {
            //        radioButton4.Checked = true;
            //    }
            //    else
            //    {
            //        radioButton6.Checked = true;

            //    }
            //}
            //else
            //if (CaTruoc == 3)
            //{
            //    if (so12 <= so22)
            //    {
            //        radioButton4.Checked = true;
            //    }
            //    else
            //    {
            //        radioButton5.Checked = true;
            //    }
            //}

            //dataGridView2.DataSource = staff.getCa1(textBox1.Text, textBox2.Text);

            //int CaTruoc = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());
            dataGridView1.DataSource = staff.getCa();
        }

        private void Ca1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void labelC_IN_Click(object sender, EventArgs e)
        {
            //// ca 1
            DateTime now = DateTime.Now;
            int CaLam = 0;
            int so1 = Int32.Parse(textBox_1.Text);
            int so2 = Int32.Parse(textBox_2.Text);
            int so3 = Int32.Parse(textBox_3.Text);



            if (so1 <= so2 && so1 <= so3)
            {
                CaLam = Int32.Parse(Ca1.Tag.ToString());
            }
            else if (so2 < so1 && so2 < so3)
            {
                CaLam = Int32.Parse(Ca2.Tag.ToString());
            }
            else
            {
                CaLam = Int32.Parse(Ca3.Tag.ToString());
            }

































            staff.insertCalam(CaLam, now, textBox1.Text, textBox2.Text);

            dataGridView1.DataSource = staff.getCa();
            // ca 2

            int CaLam2 = 0;
            int so12 = Int32.Parse(textBox12.Text);
            int so22 = Int32.Parse(textBox22.Text);
            int so32 = Int32.Parse(textBox32.Text);
            dataGridView2.DataSource = staff.getCa1(textBox1.Text, textBox2.Text);
            int CaTruoc = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());

            if (CaTruoc == 1)
            {
                if (so22 <= so32)
                {
                    CaLam2 = Int32.Parse(Ca2.Tag.ToString());
                }
                else
                {
                    CaLam2 = Int32.Parse(Ca3.Tag.ToString());
                }
            }
            else
            if (CaTruoc == 2)
            {
                if (so12 <= so32)
                {
                    CaLam2 = Int32.Parse(Ca1.Tag.ToString());
                }
                else
                {
                    CaLam2 = Int32.Parse(Ca3.Tag.ToString());
                }
            }
            else
            if (CaTruoc == 3)
            {
                if (so12 <= so22)
                {
                    CaLam2 = Int32.Parse(Ca1.Tag.ToString());
                }
                else
                {
                    CaLam2 = Int32.Parse(Ca2.Tag.ToString());
                }
            }
            staff.insertCalam2(CaLam2, textBox1.Text, textBox2.Text);
            
            dataGridView1.DataSource = staff.getCa();

            //if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "1")
            //{
            //    Ca1.Checked = true;

                //}
                //else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "2")
                //{
                //    Ca2.Checked = true;
                //}
                //else if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "3")
                //{
                //    Ca3.Checked = true;
                //}







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


            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                radioButton4.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "2")
            {
                radioButton5.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "3")
            {
                radioButton6.Checked = true;
            }

        }

        private void labelC_OUT_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            staff.UpdateC_Out(now, textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = staff.getCa();
        }
    }
}
