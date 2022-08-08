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
    public partial class DatMon : Form
    {
        public DatMon()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        QLMon QLMon = new QLMon();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        MY_DB mydb = new MY_DB();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DatMon_Load(object sender, EventArgs e)
        {
            comboBoxIdTable.Items.Add("1"); comboBoxIdTable.Items.Add("2"); comboBoxIdTable.Items.Add("3"); comboBoxIdTable.Items.Add("4"); comboBoxIdTable.Items.Add("5");
            comboBoxIdTable.Items.Add("6"); comboBoxIdTable.Items.Add("7"); comboBoxIdTable.Items.Add("8"); comboBoxIdTable.Items.Add("9"); comboBoxIdTable.Items.Add("10");
            comboBoxIdTable.Items.Add("11"); comboBoxIdTable.Items.Add("12"); comboBoxIdTable.Items.Add("13"); comboBoxIdTable.Items.Add("14"); comboBoxIdTable.Items.Add("15");
            comboBoxIdTable.Items.Add("16"); comboBoxIdTable.Items.Add("17"); comboBoxIdTable.Items.Add("18"); comboBoxIdTable.Items.Add("19"); comboBoxIdTable.Items.Add("20");
            comboBoxIdTable.Items.Add("21"); comboBoxIdTable.Items.Add("22"); comboBoxIdTable.Items.Add("23"); comboBoxIdTable.Items.Add("24"); comboBoxIdTable.Items.Add("25");
            comboBoxIdTable.Items.Add("VIP1"); comboBoxIdTable.Items.Add("VIP2"); comboBoxIdTable.Items.Add("VIP3"); comboBoxIdTable.Items.Add("VIP4"); comboBoxIdTable.Items.Add("VIP5");
            comboBoxIdTable.Items.Add("VIP6"); comboBoxIdTable.Items.Add("VIP7"); comboBoxIdTable.Items.Add("VIP8"); comboBoxIdTable.Items.Add("VIP9"); comboBoxIdTable.Items.Add("VIP10");
            comboBoxDanhMuc.Items.Add("Khai Vi"); comboBoxDanhMuc.Items.Add("Mon Chinh"); comboBoxDanhMuc.Items.Add("Trang Mieng");
            comboBoxSoLuong.Items.Add("1"); comboBoxSoLuong.Items.Add("2"); comboBoxSoLuong.Items.Add("3"); comboBoxSoLuong.Items.Add("4");

            labelSoLuong.Text = "Tổng Số Món :     " + dataGridView2.Rows.Count;
            dataGridView1.DataSource = nhahnang.getFood();
            dataGridView2.DataSource = nhahnang.getOrder();

            fill();
            Gia();

            comboBoxIdTable.Text = QLBanTrong.luu.soban;

       
           




        }
      private void Gia()
        {
            int sc = dataGridView2.Rows.Count;
            float thanhtien = 0;

            {
                for (int i = 0; i < sc; i++)
                {
                    thanhtien += float.Parse(dataGridView2.Rows[i].Cells["Gia"].Value.ToString())* float.Parse(dataGridView2.Rows[i].Cells["So_Luong"].Value.ToString());
                    textBoxTong.Text = thanhtien.ToString();

                }
            }
        }




        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void fill()
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 50;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 50;
            picCol2 = (DataGridViewImageColumn)dataGridView2.Columns[6];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            labelSoLuong.Text = "Tổng Số Món :     " + dataGridView2.Rows.Count;
            labelTotal.Text = "Số Món Ăn Trong Menu :" + dataGridView1.Rows.Count;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxIDFood.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenMon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxDanhMuc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxPIC.Image = Image.FromStream(picture);




        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
                string Food_Name = textBoxTenMon.Text;
                string Danh_Muc = comboBoxDanhMuc.Text;
                int Gia = Convert.ToInt32(textBoxGia.Text);

                MemoryStream Picture = new MemoryStream();

                pictureBoxPIC.Image.Save(Picture, pictureBoxPIC.Image.RawFormat);

                {


                    if (nhahnang.insertFood(ID_Food, Food_Name, Danh_Muc, Gia, Picture))
                    {
                        MessageBox.Show("New Food Added", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = nhahnang.getFood();

                        labelTotal.Text = "Số Món Ăn Trong Menu :" + dataGridView1.Rows.Count;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ID Table đã Tông Tại   -------", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxPIC.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonALL_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhahnang.getFood();
            fill();
            
            textBoxIDFood.Text = "";
            textBoxTenMon.Text = "";
            comboBoxDanhMuc.Text = "";
            textBoxGia.Text = "";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            string Food_Name = textBoxTenMon.Text;
            string Danh_Muc = comboBoxDanhMuc.Text;
            int Gia = Convert.ToInt32(textBoxGia.Text);

            MemoryStream Picture = new MemoryStream();

            pictureBoxPIC.Image.Save(Picture, pictureBoxPIC.Image.RawFormat);





            if (nhahnang.updateFood(ID_Food, Food_Name, Danh_Muc, Gia, Picture))
            {
                MessageBox.Show("Food Information Updated", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                labelTotal.Text = "Số Món Ăn Trong Menu :" + dataGridView1.Rows.Count;


                dataGridView1.DataSource = nhahnang.getFood();
            }
            else
            {
                MessageBox.Show("Error", "TEdit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            comboBoxIdTable.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxIDFood.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxTenMon.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBoxDanhMuc.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxGia.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            comboBoxSoLuong.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView2.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxPIC.Image = Image.FromStream(picture);
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try

            {
                string Thuc_Hien = "Chua";
                string Thanh_Toan = "";
                string ID_Table = comboBoxIdTable.Text;
                int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
                string Food_Name = textBoxTenMon.Text;
                string Danh_Muc = comboBoxDanhMuc.Text;
                int Gia = Convert.ToInt32(textBoxGia.Text);
                int So_Luong = Convert.ToInt32(comboBoxSoLuong.Text);

                MemoryStream Picture = new MemoryStream();
                pictureBoxPIC.Image.Save(Picture, pictureBoxPIC.Image.RawFormat);

                if (QLMon.checkTinhTrang( ID_Food))
                {
                    if (nhahnang.checkMon(ID_Table, ID_Food))
                    {
                        MessageBox.Show("Kiểm Tra Lại Món Đã Đặt , Có Thể Món Đã Dược Đặt", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (comboBoxIdTable.Text == "0")
                        {
                            MessageBox.Show("Chọn Bàn Phù Hợp", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if(nhahnang.checkBan(ID_Table))
                            {
                                if (nhahnang.insertOrder(ID_Table, ID_Food, Food_Name, Danh_Muc, Gia, So_Luong, Picture, Thanh_Toan, Thuc_Hien))
                                {
                                    MessageBox.Show("Mon Da Duoc Them Vao", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                    dataGridView2.DataSource = nhahnang.getOrder();
                                    labelSoLuong.Text = "Tổng Số Món :" + dataGridView2.Rows.Count;

                                    int sc = dataGridView2.Rows.Count;
                                    float thanhtien = 0;


                                    {
                                        for (int i = 0; i < sc; i++)
                                        {
                                            thanhtien += float.Parse(dataGridView2.Rows[i].Cells["Gia"].Value.ToString()) * float.Parse(dataGridView2.Rows[i].Cells["So_Luong"].Value.ToString());
                                            textBoxTong.Text = thanhtien.ToString();

                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Error", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bàn Chưa Có Người Đặt  ", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Món Tạm Hết ", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }





                




                




        }
            catch
            {
                MessageBox.Show("Hãy Chọn Món  -------", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void textBoxTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTien_Click(object sender, EventArgs e)
        {

        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            string ID_Table = comboBoxIdTable.Text;
            if (MessageBox.Show("Are You Sure You to Delete This Food", "Delete Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhahnang.deleteDatMon(ID_Table, ID_Food))
                {
                    MessageBox.Show("Food Deleted", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView2.DataSource = nhahnang.getOrder();
                    labelTotal.Text = "Tổng Số Món :" + dataGridView2.Rows.Count;

                    int sc = dataGridView2.Rows.Count;
                    float thanhtien = 0;

                    {
                        for (int i = 0; i < sc; i++)
                        {
                            thanhtien += float.Parse(dataGridView2.Rows[i].Cells["Gia"].Value.ToString());
                            textBoxTong.Text = thanhtien.ToString(); Gia();


                        }
                    }

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
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            if (MessageBox.Show("Are You Sure You to Delete This Food", "Delete Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhahnang.deleteFood(ID_Food))
                {
                    MessageBox.Show("Food Deleted", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    labelTotal.Text = "Số Món Ăn Trong Menu :" + dataGridView1.Rows.Count;


                    dataGridView1.DataSource = nhahnang.getFood();
                    comboBoxIdTable.Text = "0";
                    textBoxIDFood.Text = "";
                    textBoxTenMon.Text = "";
                    comboBoxDanhMuc.Text = "";
                    textBoxGia.Text = "";



                }
                else
                {
                    MessageBox.Show("Food Not Deleted", "delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Food Not Deleted", "delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonKhaiVi_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Food WHERE CONCAT(ID_Food, Danh_Muc) LIKE '%"+ textBox1.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = nhahnang.getFoods(command);




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Food WHERE CONCAT(ID_Food, Food_Name) LIKE '%" + textBoxTim.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = nhahnang.getFoods(command);
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMonChinh_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Food WHERE CONCAT(ID_Food, Danh_Muc) LIKE '%" + textBox2.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = nhahnang.getFoods(command);
        }

        private void buttonTrangMieng_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Food WHERE CONCAT(ID_Food, Danh_Muc) LIKE '%" + textBox3.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = nhahnang.getFoods(command);
        }

        private void pictureBoxFindBan_Click(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM DatMon WHERE ID_Table LIKE '%" + Int32.Parse(textBoxTimBan.Text) + "%'";
            //SqlCommand command = new SqlCommand(query);
            //dataGridView2.DataSource = nhahnang.getFoods(command);
            string ID_Table = textBoxTimBan.Text;
            dataGridView2.DataSource = nhahnang.Find(ID_Table);



            Gia();
            fill();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            int So_Luong = Convert.ToInt32(comboBoxSoLuong.Text);
            string ID_Table = comboBoxIdTable.Text;
            int ID_Food = Convert.ToInt32(textBoxIDFood.Text);




            if (nhahnang.updateSL(ID_Table, ID_Food, So_Luong))
            {
                MessageBox.Show("Đã Thây Đổi Số Lượng", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Gia();
                labelSoLuong.Text = "Tổng Số Món :     " + dataGridView2.Rows.Count;

                dataGridView2.DataSource = nhahnang.getOrder();
                
            }
            else
            {
                MessageBox.Show("Error", "TEdit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonALLBAN_Click_1(object sender, EventArgs e)
        {
            dataGridView2.DataSource = nhahnang.getOrder();
            Gia();
            fill(); textBoxTimBan.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyMon quanLyMon = new QuanLyMon();
            quanLyMon.Show(this);
        }

        private void textBoxTimBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
