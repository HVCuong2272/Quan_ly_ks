using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.NhanSu
{
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }
        StaffClass staff = new StaffClass();
        public void Luong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staff.getCa2();
       


            int end = Convert.ToInt32(dataGridView1.Rows.Count);
            int Id = 0;
            for (int i = 0; i < end; i++)
            {
                if(dataGridView1.Rows[i].Cells[0].Value.ToString()=="" || dataGridView1.Rows[i].Cells[7].Value.ToString()=="" || dataGridView1.Rows[i].Cells[8].Value.ToString() =="")
                {

                }   else
                {
                    Id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    DateTime startTime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[7].Value);
                    textBox1.Text = startTime.ToString("HH");


                    DateTime endtime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[8].Value);
                    textBox2.Text = endtime.ToString("HH");

                    TimeSpan duration = startTime - endtime;
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text));
                    //int a = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text);
                    if (Convert.ToInt32(textBox3.Text) < 0)
                    {
                        textBox3.Text = "0";
                    }


                    staff.updateGio(Convert.ToInt32(textBox3.Text), Id);

                    // tính Luong
                    int sc = dataGridView1.Rows.Count;

                    float luong = 0;
                    int sogio = Convert.ToInt32(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString());
                    if (sogio == 8)
                    {
                        luong += (float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) * float.Parse(textBoxLuong.Text)); staff.updateLuong(luong, Id);
                    }
                    else if (sogio == 0)
                    {
                        luong = 0;
                        staff.updateLuong(luong, Id);
                    }
                    else if (sogio > 8)
                    {
                        luong += ((Convert.ToInt32(textBoxLuong.Text)) * 8) + ((float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) - 8) * float.Parse(textBoxPhat.Text));
                        staff.updateLuong(luong, Id);
                    }
                    else if (sogio < 8)
                    {
                        luong += (float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) * float.Parse(textBoxLuong.Text)) - ((8 - float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString())) * float.Parse(textBoxPhat.Text));
                        staff.updateLuong(luong, Id);
                    }

                    float tong = 0;
                    for (int l = 0; l < end; l++)
                    {
                       // tong = tong + float.Parse(dataGridView1.Rows[l].Cells["Luong"].Value.ToString());
                    }

                    textBoxTong.Text = Convert.ToString(tong);
                }    





                











            }
            dataGridView1.DataSource = staff.getCa2();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {


            if ( dataGridView1.CurrentRow.Cells[7].Value.ToString() == "" || dataGridView1.CurrentRow.Cells[8].Value.ToString() == "")
            {

            }
            else
            {
                dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[7].Value;
                dateTimePicker2.Value = (DateTime)dataGridView1.CurrentRow.Cells[8].Value;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            int end = Convert.ToInt32(dataGridView1.Rows.Count);
            int Id = 0;
            for (int i = 0; i < end; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "" || dataGridView1.Rows[i].Cells[7].Value.ToString() == "" || dataGridView1.Rows[i].Cells[8].Value.ToString() == "")
                {

                }
                else
                {
                    Id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    DateTime startTime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[7].Value);
                    textBox1.Text = startTime.ToString("HH");


                    DateTime endtime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[8].Value);
                    textBox2.Text = endtime.ToString("HH");

                    TimeSpan duration = startTime - endtime;
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text));
                    //int a = Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox1.Text);
                    if (Convert.ToInt32(textBox3.Text) < 0)
                    {
                        textBox3.Text = "0";
                    }


                    staff.updateGio(Convert.ToInt32(textBox3.Text), Id);

                    // tính Luong
                    int sc = dataGridView1.Rows.Count;

                    float luong = 0;
                    int sogio = Convert.ToInt32(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString());
                    if (sogio == 8)
                    {
                        luong += (float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) * float.Parse(textBoxLuong.Text)); staff.updateLuong(luong, Id);
                    }
                    else if (sogio == 0)
                    {
                        luong = 0;
                        staff.updateLuong(luong, Id);
                    }
                    else if (sogio > 8)
                    {
                        luong += ((Convert.ToInt32(textBoxLuong.Text)) * 8) + ((float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) - 8) * float.Parse(textBoxPhat.Text));
                        staff.updateLuong(luong, Id);
                    }
                    else if (sogio < 8)
                    {
                        luong += (float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString()) * float.Parse(textBoxLuong.Text)) - ((8 - float.Parse(dataGridView1.Rows[i].Cells["So_Gio"].Value.ToString())) * float.Parse(textBoxPhat.Text));
                        staff.updateLuong(luong, Id);
                    }
                }


            }
            dataGridView1.DataSource = staff.getCa2();
            float tong = 0;
            for (int l = 0; l < end; l++)
            {
                tong = tong + float.Parse(dataGridView1.Rows[l].Cells["Luong"].Value.ToString());
            }

            textBoxTong.Text = Convert.ToString(tong);
        }
    }
}
