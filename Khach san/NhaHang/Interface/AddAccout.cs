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
namespace NhaHang.Interface
{
    public partial class AddAccout : Form
    {
        public AddAccout()
        {
            InitializeComponent();
        }
        StaffClass staffClass = new StaffClass();
        private void bt_Add_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string pass = textBoxP.Text;
            int Id = Int32.Parse(textBoxID.Text);


           

            if (textBoxUser.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (textBoxP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else if (textBoxP.Text != textBoxPA.Text)
            {
                MessageBox.Show("Hai mật khẩu không khớp!");
            }

            try
            {
                if (staffClass.insertAccount(username, pass,Id))
                {
                    MessageBox.Show("New Accout Insert", "Add Accout ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = staffClass.getAccount();
                    textBoxUser.Text = "";
                    textBoxP.Text = "";
                    textBoxPA.Text = "";




                }
                else
                {
                    MessageBox.Show("Accout Not Insert", "Add Accout ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Usename đã tồn tại !!!", "LỖi  Accout ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddAccout_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staffClass.getAccount();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
