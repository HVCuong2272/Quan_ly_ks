
namespace NhaHang.Interface
{
    partial class Log_In_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In_Form));
            this.labelLogIn = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.radioButtonQuanLy = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonKH = new System.Windows.Forms.RadioButton();
            this.DangNhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLogIn.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelLogIn.ForeColor = System.Drawing.Color.Brown;
            this.labelLogIn.Location = new System.Drawing.Point(85, 23);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(266, 57);
            this.labelLogIn.TabIndex = 0;
            this.labelLogIn.Text = "Đăng Nhập";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(224, 126);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(200, 47);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.Text = "User_root";
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(224, 188);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(200, 41);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.Text = "123";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelname.Location = new System.Drawing.Point(10, 127);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(195, 36);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "UserName:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelPass.ForeColor = System.Drawing.Color.Blue;
            this.labelPass.Location = new System.Drawing.Point(10, 188);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(181, 36);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "PassWord:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Turquoise;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.Tomato;
            this.loginButton.Location = new System.Drawing.Point(142, 361);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(282, 65);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // radioButtonQuanLy
            // 
            this.radioButtonQuanLy.AutoSize = true;
            this.radioButtonQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonQuanLy.Checked = true;
            this.radioButtonQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuanLy.Location = new System.Drawing.Point(224, 253);
            this.radioButtonQuanLy.Name = "radioButtonQuanLy";
            this.radioButtonQuanLy.Size = new System.Drawing.Size(122, 33);
            this.radioButtonQuanLy.TabIndex = 8;
            this.radioButtonQuanLy.TabStop = true;
            this.radioButtonQuanLy.Text = "Quản Lý";
            this.radioButtonQuanLy.UseVisualStyleBackColor = false;
            this.radioButtonQuanLy.CheckedChanged += new System.EventHandler(this.radioButtonQuanLy_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(215, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đặt Phòng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.labelLogIn);
            this.panel1.Controls.Add(this.radioButtonQuanLy);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.radioButtonKH);
            this.panel1.Location = new System.Drawing.Point(69, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 566);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(17, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "Đặt Phòng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(259, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "* Đăng ký khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonKH
            // 
            this.radioButtonKH.AutoSize = true;
            this.radioButtonKH.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKH.Location = new System.Drawing.Point(224, 292);
            this.radioButtonKH.Name = "radioButtonKH";
            this.radioButtonKH.Size = new System.Drawing.Size(164, 33);
            this.radioButtonKH.TabIndex = 9;
            this.radioButtonKH.Text = "Khách Hàng";
            this.radioButtonKH.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.DangNhap.ForeColor = System.Drawing.Color.Teal;
            this.DangNhap.Location = new System.Drawing.Point(215, 242);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(188, 51);
            this.DangNhap.TabIndex = 1;
            this.DangNhap.Text = "Đăng Nhập";
            this.DangNhap.UseVisualStyleBackColor = false;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DangNhap);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Log_In_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Đăng Nhập";
            this.Load += new System.EventHandler(this.Log_In_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton radioButtonQuanLy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.RadioButton radioButtonKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}