using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.NhanSu;
using NhaHang.Interface;

namespace NhaHang.NhanSu
{
    public partial class DangKyKhachHang : Form
    {
        public DangKyKhachHang()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void DangKyKhachHang_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("VietNames");
            comboBox.Items.Add("Korea");
            comboBox.Items.Add("UK");
            comboBox.Items.Add("USA");
            comboBox.Items.Add("Japan");
            comboBox.Items.Add("Compodia");
            comboBox.Items.Add("China");
            comboBox.Items.Add("Italy");
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Log_In_Form log_In_Form = new Log_In_Form();
            log_In_Form.Show(this);
            Hide();

        }
    }
}
