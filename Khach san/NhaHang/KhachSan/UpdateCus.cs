using NhaHang.Interface;
using NhaHang.NhanSu;
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
    public partial class UpdateCus : Form
    {
        public UpdateCus()
        {
            InitializeComponent();
        }
        CustomerClass customer = new CustomerClass();
        private void buttonADD_Click(object sender, EventArgs e)
        {
            //try
            //{



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
                    if (customer.updateCustomer2(id, name, phone, email, cccd, address, quoctich, user, pass))
                    {
                        MessageBox.Show(" Customer Updated", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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





            //}
            //catch
            //{
            //    MessageBox.Show("ID already exists", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
        private void UpdateCus_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("VietNames");
            comboBox.Items.Add("Korea");
            comboBox.Items.Add("UK");
            comboBox.Items.Add("USA");
            comboBox.Items.Add("Japan");
            comboBox.Items.Add("Compodia");
            comboBox.Items.Add("China");
            comboBox.Items.Add("Italy");
            textBoxUser.Text = Log_In_Form.luu.User;
            textBoxPass.Text = Log_In_Form.luu.Pass;
            dataGridView1.DataSource = customer.getTable2(textBoxUser.Text, textBoxPass.Text);

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCCCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
        }
    }
}
