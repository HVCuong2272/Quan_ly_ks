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

namespace NhaHang.NhaHang
{
    public partial class NguyenLieu : Form
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }
        NhaBepClass NhaBepClass = new NhaBepClass();

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            loadTable();
            dataGridView1.DataSource = NhaBepClass.getTable();

           
            dataGridView1.Columns["KL_1Phan"].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns["Số_Phần"].DefaultCellStyle.Format = "N0";
            Sphan();














        }
        private void Sphan()
        {
            int sc = dataGridView1.Rows.Count;
           

            {
                for (int i = 0; i < sc; i++)
                {
                    if(dataGridView1.Rows[i].Cells[3].Value.ToString() == "")
                    {
                       
                    }    else if (dataGridView1.Rows[i].Cells[5].Value.ToString()=="")
                    {

                    }
                    else
                    {
                        float sophan = 0;
                        sophan += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) / float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        Math.Round(sophan, 1);

                        NhaBepClass.updateSoPhan(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), sophan);
                    }
                    

                }
            }
        }
        public void loadTable()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            SqlCommand Table = new SqlCommand("SELECT ID_Food FROM Food ", mydb.getConnection);
            SqlDataAdapter ap = new SqlDataAdapter(Table);
            DataTable ds = new DataTable();
            ap.Fill(ds);
            comboBox1.DataSource = ds;
            

            comboBox1.DisplayMember = "ID_Food";
            //comboBox1.ValueMember = "ID_Food";

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            MY_DB mydb = new MY_DB();
            //int stt = Convert.ToInt32(textBoxIDF.Text);
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            SqlCommand Table = new SqlCommand("SELECT *  FROM Food WHERE ID_Food LIKE '%" + comboBox1.Text.Trim() + "%'", mydb.getConnection);
            SqlDataAdapter ap = new SqlDataAdapter(Table);
            DataTable ds = new DataTable();
            ap.Fill(ds);
            dataGridView2.DataSource = ds;


            

            if (ds.Rows.Count > 0)
            {
                //textBoxNameFood.Text = ds.Rows[0]["Food_Name"].ToString().Trim();



                string a = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                if (a == "")
                {

                }
                else
                {
                    textBoxFood.Text = a;

                }
            }








        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {



            try
            {








                int ID_Food = Convert.ToInt32(comboBox1.Text);
                int ID = Convert.ToInt32(textBoxID.Text);
                string Name = textBoxName.Text;
                int KL = Convert.ToInt32(textBoxKhoiLuong.Text);
                DateTime date = dateTimePicker1.Value;
                float phan = float.Parse(textBox1Phan.Text);

                {
                    if (NhaBepClass.checkNL(ID, ID_Food))
                    {

                        if (NhaBepClass.insertNL(ID, ID_Food, Name, KL, date, phan))
                        {
                            MessageBox.Show("Nguyên Liệu Đã Thêm", "Add nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = NhaBepClass.getTable();

                            Sphan();



                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kiêm Tra Lại Nguyên Liệu   ", "Add Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }







            }
            catch
            {
                MessageBox.Show("ID Nguyên Liệu đã Tông Tại   -------", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxKhoiLuong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() !="")
            {
                float a = float.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                textBox1Phan.Text = a.ToString("0.00");
            }
            else
            {
                textBox1Phan.Text = "0";
            }
           
            

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            int ID_Food = Convert.ToInt32(comboBox1.Text);
            int ID = Convert.ToInt32(textBoxID.Text);
            string Name = textBoxName.Text;
            int KL = Convert.ToInt32(textBoxKhoiLuong.Text);
            DateTime date = dateTimePicker1.Value;
            float phan = float.Parse(textBox1Phan.Text);

            {


                if (NhaBepClass.updateNL(ID, ID_Food, Name, KL, date, phan))
                {
                    MessageBox.Show("Nguyên Liệu Đã Update", "Update nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = NhaBepClass.getTable();

                    Sphan();



                }
                else
                {
                    MessageBox.Show("Error", "Update Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //}
            //    catch
            //    {
            //        MessageBox.Show("ID Nguyên Liệu đã Tông Tại   -------", "Update Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBoxID.Text);
            int ID_Food = Convert.ToInt32(comboBox1.Text);
            if (MessageBox.Show("Are You Sure You to Delete This 'Nguyên Liệu'", "Delete Nguyên Liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (NhaBepClass.deleteNL(ID, ID_Food))
                {
                    MessageBox.Show("Nguyên Liệu Deleted", "Delete Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = NhaBepClass.getTable();

                    Sphan();



                }
                else
                {
                    MessageBox.Show("Nguyên Liệu Not Deleted", "delete Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nguyên Liệu Not Deleted", "delete Nguyên Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
