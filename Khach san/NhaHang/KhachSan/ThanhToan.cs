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
using NhaHang.NhaHang;
using System.Globalization;


namespace NhaHang.NhaHang
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        TinhTien TinhTien = new TinhTien();
        NhaHangClass NhaHang = new NhaHangClass();

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            //comboBoxIdTable.Items.Add("1"); comboBoxIdTable.Items.Add("2"); comboBoxIdTable.Items.Add("3"); comboBoxIdTable.Items.Add("4"); comboBoxIdTable.Items.Add("5");
            //comboBoxIdTable.Items.Add("6"); comboBoxIdTable.Items.Add("7"); comboBoxIdTable.Items.Add("8"); comboBoxIdTable.Items.Add("9"); comboBoxIdTable.Items.Add("10");
            //comboBoxIdTable.Items.Add("11"); comboBoxIdTable.Items.Add("12"); comboBoxIdTable.Items.Add("13"); comboBoxIdTable.Items.Add("14"); comboBoxIdTable.Items.Add("15");
            //comboBoxIdTable.Items.Add("16"); comboBoxIdTable.Items.Add("17"); comboBoxIdTable.Items.Add("18"); comboBoxIdTable.Items.Add("19"); comboBoxIdTable.Items.Add("20");
            //comboBoxIdTable.Items.Add("21"); comboBoxIdTable.Items.Add("22"); comboBoxIdTable.Items.Add("23"); comboBoxIdTable.Items.Add("24"); comboBoxIdTable.Items.Add("25");
            //comboBoxIdTable.Items.Add("VIP1"); comboBoxIdTable.Items.Add("VIP2"); comboBoxIdTable.Items.Add("VIP3"); comboBoxIdTable.Items.Add("VIP4"); comboBoxIdTable.Items.Add("VIP5");
            //comboBoxIdTable.Items.Add("VIP6"); comboBoxIdTable.Items.Add("VIP7"); comboBoxIdTable.Items.Add("VIP8"); comboBoxIdTable.Items.Add("VIP9"); comboBoxIdTable.Items.Add("VIP10");



            loadTable();
            fill(new SqlCommand("SELECT DatMon.ID_Table as So_Phong, Ban.Name_Custumer, DatMon.ID_Food, DatMon.Food_Name , DatMon.Danh_Muc, DatMon.Gia, DatMon.So_Luong, DatMon.Picture, DatMon.Thanh_Toan FROM DatMon INNER JOIN Ban ON DatMon.ID_Table=Ban.ID_Table"));
            //dataGridView1.DataSource = NhaHang.getOrder();

            Gia();

            //Tinh();




        }
        private void Gia()
        {
            int sc = dataGridView1.Rows.Count;
            float thanhtien = 0;

            {
                for (int i = 0; i < sc; i++)
                {

                    thanhtien += float.Parse(dataGridView1.Rows[i].Cells["Gia"].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells["So_Luong"].Value.ToString());
                    textBoxTong.Text = thanhtien.ToString();

                }
            }
        }

        private void Tinh()
        {
            int thanhtien = 0;

            if (textBoxTienDua.Text == "" || textBoxGiamGia.Text == "")
            {

            }
            else
            {
                thanhtien += Int32.Parse(textBoxTienDua.Text.ToString()) - (Int32.Parse(textBoxTong.Text.ToString()) - Int32.Parse(textBoxGiamGia.Text.ToString()));
                textBoxTienThoi.Text = thanhtien.ToString();
            }


        }


        private void comboBoxIdTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_Table = comboBoxIdTable.Text;
            dataGridView1.DataSource = TinhTien.getTable2(ID_Table);

            Gia();

            //comboBoxIdTable.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textboxTenKhach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();





        }
        public void fill(SqlCommand command)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 50; dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = TinhTien.getFoods(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        public void loadTable()
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            SqlCommand Table = new SqlCommand("SELECT ID_Table FROM Ban ", mydb.getConnection);
            SqlDataAdapter ap = new SqlDataAdapter(Table);
            DataTable ds = new DataTable();
            ap.Fill(ds);
            comboBoxIdTable.DataSource = ds;
            comboBoxIdTable.DisplayMember = "ID_Table";
            comboBoxIdTable.ValueMember = "ID_Table";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboBoxIdTable.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textboxTenKhach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Gia(); Tinh();
            textBoxGiamGia.Text = "";

            textBoxTienDua.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTienDua_TextChanged(object sender, EventArgs e)
        {


            Tinh();
        }

        private void textBoxTienThoi_TextChanged(object sender, EventArgs e)
        {

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

        private void textBoxTienDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }



        private void textBoxThanh_Toan_TextChanged(object sender, EventArgs e)
        {

        }

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
                        if (TinhTien.updateFood(ID_Table)) ;
                        fill(new SqlCommand("SELECT DatMon.ID_Table, Ban.Name_Custumer, DatMon.ID_Food, DatMon.Food_Name , DatMon.Danh_Muc, DatMon.Gia, DatMon.So_Luong, DatMon.Picture, DatMon.Thanh_Toan FROM DatMon INNER JOIN Ban ON DatMon.ID_Table=Ban.ID_Table"));

                    }

                }
                else
                {
                    MessageBox.Show("Hãy Trả Đủ Tiền Để Thanh Toán : ", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }









        }

        private void textBoxTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxTenKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
