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
using NhaHang.NhaHang;
namespace NhaHang.NhaHang
{
    public partial class QuanLyMon : Form
    {
        public QuanLyMon()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        QLMon Qlmon = new QLMon();
        private void labelFName_Click(object sender, EventArgs e)
        {

        }

  
        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyMon_Load(object sender, EventArgs e)
        {
            
            comboBoxDanhMuc.Items.Add("Khai Vi"); comboBoxDanhMuc.Items.Add("Mon Chinh"); comboBoxDanhMuc.Items.Add("Trang Mieng");

           
            fillGrid(new SqlCommand("SELECT * FROM Food"));
            labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;


        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DataSource = Qlmon.getFoods2(command);

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 50;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;

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

            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Ready")
            {
                radioButtonReady.Checked = true;

            }
            else
            {
                radioButtonNO.Checked = true;
            }

            textBoxDescription.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

            try
            {
                int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
                string Food_Name = textBoxTenMon.Text;
                string Danh_Muc = comboBoxDanhMuc.Text;
                int Gia = Convert.ToInt32(textBoxGia.Text);
                string TinhTrang = "Ready";
                if (radioButtonReady.Checked)
                {
                    TinhTrang = "Ready";
                }
                else TinhTrang = "NO";

                MemoryStream Picture = new MemoryStream();

                pictureBoxPIC.Image.Save(Picture, pictureBoxPIC.Image.RawFormat);
                string Mo_Ta = textBoxDescription.Text;
                {


                    if (Qlmon.insertFood(ID_Food, Food_Name, Danh_Muc, Gia, Picture, TinhTrang, Mo_Ta))
                    {
                        MessageBox.Show("New Food Added", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = Qlmon.getFood();

                        labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
                if (MessageBox.Show("Are You Sure You to Delete This Food", "Delete Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Qlmon.deleteFood(ID_Food))
                    {
                        MessageBox.Show("Food Deleted", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;


                        dataGridView1.DataSource = Qlmon.getFood();

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
            catch
            {
                MessageBox.Show("vui long nhập thông tin  -------", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {

                int ID_Food = Convert.ToInt32(textBoxIDFood.Text);
            string Food_Name = textBoxTenMon.Text;
            string Danh_Muc = comboBoxDanhMuc.Text;
            int Gia = Convert.ToInt32(textBoxGia.Text);

            string Mo_Ta = textBoxDescription.Text; 
            string TinhTrang = "Ready";
            if (radioButtonReady.Checked)
            {
                TinhTrang = "Ready";
            }
            else TinhTrang = "NO";

            MemoryStream Picture = new MemoryStream();

            pictureBoxPIC.Image.Save(Picture, pictureBoxPIC.Image.RawFormat);
         





            if (Qlmon.updateFood(ID_Food, Food_Name, Danh_Muc, Gia, Picture, TinhTrang, Mo_Ta))
            {
                MessageBox.Show("Food Information Updated", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;


                dataGridView1.DataSource = Qlmon.getFood();
            }
            else
            {
                MessageBox.Show("Error", "TEdit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch
            {
                MessageBox.Show("vui long nhập thông tin   -------", "Add Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxFindMon_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Food WHERE CONCAT(ID_Food, Food_Name) LIKE '%" + textBoxTim.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = Qlmon.getFoods(command);
            labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;
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

        private void buttonALLBAN_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Food"));
            labelTotal.Text = "Tổng Số Món :     " + dataGridView1.Rows.Count;
            comboBoxDanhMuc.Text = "";
            textBoxIDFood.Text = "";
            textBoxTenMon.Text = "";
            comboBoxDanhMuc.Text = "";
            textBoxDescription.Text = "";
            textBoxGia.Text = ""; pictureBoxPIC.Image = null;
        }
    }
}
