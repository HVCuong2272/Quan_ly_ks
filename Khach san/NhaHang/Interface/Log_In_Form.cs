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
using NhaHang.NhaHang;
using NhaHang.KhachSan;


namespace NhaHang.Interface
{
    public partial class Log_In_Form : Form
    {
        public Log_In_Form()
        {
            InitializeComponent();
        }
        StaffClass staffClass = new StaffClass(); 
        private void loginButton_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            
            if (radioButtonQuanLy.Checked == true)
            {
                 command = new SqlCommand("SELECT * FROM Staff WHERE Username = @User AND Password = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;
            }
            else
            {
                 command = new SqlCommand("SELECT * FROM Customer WHERE UserName = @User AND PassWord = @Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;
            }
           

            


            adapter.SelectCommand = command;
            adapter.Fill(table);

            string user = textBoxUser.Text;
            string pass = textBoxPass.Text;

            if ((table.Rows.Count > 0))
            {
                if (radioButtonQuanLy.Checked == true)
                {
                    if(staffClass.checkTQuyen(user,pass))
                    {
                        //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                        MainForm mainForm = new MainForm();
                        mainForm.Show(this);
                        Hide();


                    }    
                    else
                    {
                        MessageBox.Show("Bạn Không Có Quyền", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }    

                }
                else
                {
                    if (staffClass.checkTQuyen2(user, pass))
                    {
                        doi();
                        //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                        //DangKyKhachHang kh = new DangKyKhachHang();
                        //kh.Show(this);
                        Hide();


                    }
                    else
                    {
                        MessageBox.Show("Khách Hàng Không Có Quyền ", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }


            }
            else
            {
                MessageBox.Show("Invalid Username or Password OR ''Bạn Không có quyền truy cập''", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }
        public void doi()
        {
            UpdateCus update = new UpdateCus();
            luu.User = textBoxUser.Text;
            luu.Pass = textBoxPass.Text;
           
            Hide();
            update.Show(this);
        }
        private void Log_In_Form_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        public class luu
        {
            static public string User;
            static public string Pass;
        }
        private void labelAddAccout_Click(object sender, EventArgs e)
        {
            AddAccout addAccout = new AddAccout();
            addAccout.Show(this);
        }

        private void radioButtonNhanVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
            
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            panel1.Show();
            DangNhap.Hide();
            button1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DangKyKhachHang dangKyKhachHang = new DangKyKhachHang();
            dangKyKhachHang.Show(this);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLBanTrong qLBanTrong = new QLBanTrong();
            qLBanTrong.Show(this);
            
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
