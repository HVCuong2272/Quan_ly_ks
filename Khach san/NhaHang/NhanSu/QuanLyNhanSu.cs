using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.NhanSu;

namespace NhaHang.NhanSu
{
    public partial class QuanLyNhanSu : Form
    {
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tiep Tan");
            comboBox1.Items.Add("Dau Bep");
            comboBox1.Items.Add("Quan Ly");
            comboBox1.Items.Add("Phuc Vu");
            fillGrid(new SqlCommand("SELECT Id,fname,lname,bdate,gender,phone,address,picture,ChucVu FROM Staff"));

        }
        StaffClass StaffClass = new StaffClass();
        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = Convert.ToInt32(textBoxID.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string adrs = TextBoxAddress.Text;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                else gender = "Male";
                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                string ChucVu = comboBox1.Text;
                // sv tu 10-100, co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (StaffClass.insertStaff(id, fname, lname, bdate, gender, phone, adrs, pic, ChucVu))
                    {
                        MessageBox.Show("New Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT Id,fname,lname,bdate,gender,phone,address,picture,ChucVu FROM Staff"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ID already exists", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.DataSource = StaffClass.getStaff(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
            labelTotal.Text = "Số Lượng Nhân Viên:" + dataGridView1.Rows.Count;


        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "")
                || (TextBoxLname.Text.Trim() == "")
                || (TextBoxAddress.Text.Trim() == "")
                || (TextBoxPhone.Text.Trim() == "")
                || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonDownLoad_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "picture" + textBoxID.Text;

            if (PictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("NO Image In The PictureBox");

            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image.Save(svf.FileName + (". " + ImageFormat.Png.ToString()));
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;

                }
                else
                {
                    RadioButtonMale.Checked = true;
                }

                TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
                comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }

            catch
            {

            }

        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            //try
            //{

                int id = Convert.ToInt32(textBoxID.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string phone = TextBoxPhone.Text;
                string adrs = TextBoxAddress.Text;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                else gender = "Male";
                MemoryStream pic = new MemoryStream();
                int born_year = DateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                string ChucVu = comboBox1.Text;
                // sv tu 10-100, co the thay doi
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (StaffClass.updateStaff(id, fname, lname, bdate, gender, phone, adrs, pic, ChucVu))
                    {
                        MessageBox.Show("Staff Updated", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT Id,fname,lname,bdate,gender,phone,address,picture,ChucVu FROM Staff"));
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("ID already exists", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Are You Sure You to Delete This Staff", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (StaffClass.deleteStaff(studentID))
                    {
                        MessageBox.Show("Staff Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        TextBoxFname.Text = "";
                        TextBoxLname.Text = "";
                        TextBoxAddress.Text = "";
                        TextBoxPhone.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                        comboBox1.Text = "";
                        fillGrid(new SqlCommand("SELECT Id,fname,lname,bdate,gender,phone,address,picture,ChucVu FROM Staff"));
                    }
                    //else
                    //{
                    //    MessageBox.Show("Student Not Deleted", "delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Student Not Staff", "delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Please Enter Avalid ID", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
