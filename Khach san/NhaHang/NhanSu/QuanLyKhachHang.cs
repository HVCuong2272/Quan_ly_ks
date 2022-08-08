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
using NhaHang.NhanSu;

namespace NhaHang.NhanSu
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        CustomerClass customer = new CustomerClass();
        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {



                if (verif())
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    string name = textBoxName.Text;
                    int phone = Convert.ToInt32(textBoxPhone.Text);
                    string email = textBoxEmail.Text;
                    string address = textBoxAddress.Text;
                string cccd = textBoxCCCD.Text;
                string quoctich = comboBox.Text;
                    string user = textBoxUser.Text;
                    string pass = textBoxPass.Text;
                    if (customer.insertCustomer(id, name, phone, email, cccd, address, quoctich, user, pass))
                    {
                        MessageBox.Show("New Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = customer.getTable(); labelTotal.Text = "Tổng Số khách :  " + dataGridView1.Rows.Count;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }





            }
            catch
            {
                MessageBox.Show("ID already exists", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("VietNames");
            comboBox.Items.Add("Korea");
            comboBox.Items.Add("UK");
            comboBox.Items.Add("USA");
            comboBox.Items.Add("Japan");
            comboBox.Items.Add("Compodia");
            comboBox.Items.Add("China");
            comboBox.Items.Add("Italy");
            dataGridView1.DataSource = customer.getTable(); labelTotal.Text = "Tổng Số khách :  " + dataGridView1.Rows.Count;
        }
        bool verif()
        {
            if ((textBoxCCCD.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxID.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCCCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxUser.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxPass.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            try
            {



                if (verif())
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    string name = textBoxName.Text;
                    int phone = Convert.ToInt32(textBoxPhone.Text);
                    string email = textBoxEmail.Text;
                    string address = textBoxAddress.Text;
                string cccd = textBoxCCCD.Text;
                string quoctich = comboBox.Text;
                    if (customer.updateCustomer(id, name, phone, email, cccd, address, quoctich))
                    {
                        MessageBox.Show(" Customer Updated", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = customer.getTable(); labelTotal.Text = "Tổng Số khách :  " + dataGridView1.Rows.Count;
                }
                    else
                    {
                        MessageBox.Show("Error", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }





            }
            catch
            {
                MessageBox.Show("ID already exists", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxID.Text);
            if (MessageBox.Show("Are You Sure You to Delete This Customer", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (customer.deleteCustomer(Id))
                {
                    MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dataGridView1.DataSource = customer.getTable();
                    textBoxID.Text = "";
                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                    textBoxAddress.Text = "";
                    comboBox.Text = "";
                    textBoxCCCD.Text = "";

                    labelTotal.Text = "Tổng Số khách :  " + dataGridView1.Rows.Count;



                }
                else
                {
                    MessageBox.Show("Customer Not Deleted", "delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer Not Deleted", "delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Customer WHERE CONCAT(Id, Name) LIKE '%" + textBoxFind.Text + "%'";
            SqlCommand command = new SqlCommand(query);
            dataGridView1.DataSource = customer.getCus(command);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
