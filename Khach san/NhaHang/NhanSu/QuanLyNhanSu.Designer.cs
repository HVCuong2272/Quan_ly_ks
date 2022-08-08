
namespace NhaHang.NhanSu
{
    partial class QuanLyNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanSu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.buttonDownLoad = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBday = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonREMOVE = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelChuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonMale);
            this.groupBox1.Controls.Add(this.RadioButtonFemale);
            this.groupBox1.Location = new System.Drawing.Point(173, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 56);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Checked = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(6, 16);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(73, 24);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(100, 16);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(94, 24);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // buttonDownLoad
            // 
            this.buttonDownLoad.BackColor = System.Drawing.Color.Khaki;
            this.buttonDownLoad.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownLoad.Location = new System.Drawing.Point(173, 480);
            this.buttonDownLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownLoad.Name = "buttonDownLoad";
            this.buttonDownLoad.Size = new System.Drawing.Size(200, 29);
            this.buttonDownLoad.TabIndex = 62;
            this.buttonDownLoad.Text = "DownLoad";
            this.buttonDownLoad.UseVisualStyleBackColor = false;
            this.buttonDownLoad.Click += new System.EventHandler(this.buttonDownLoad_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.BackColor = System.Drawing.Color.Khaki;
            this.ButtonUploadImage.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadImage.Location = new System.Drawing.Point(173, 447);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(200, 29);
            this.ButtonUploadImage.TabIndex = 61;
            this.ButtonUploadImage.Text = "Upload Image";
            this.ButtonUploadImage.UseVisualStyleBackColor = false;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.Color.IndianRed;
            this.PictureBoxStudentImage.Cursor = System.Windows.Forms.Cursors.No;
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(173, 341);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(200, 102);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStudentImage.TabIndex = 60;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(173, 287);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxAddress.Multiline = true;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(200, 50);
            this.TextBoxAddress.TabIndex = 59;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(173, 252);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.TextBoxPhone.TabIndex = 58;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(173, 154);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker1.TabIndex = 57;
            this.DateTimePicker1.Value = new System.DateTime(2021, 5, 31, 12, 15, 40, 0);
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Location = new System.Drawing.Point(173, 113);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(200, 22);
            this.TextBoxLname.TabIndex = 56;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(173, 82);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(200, 22);
            this.TextBoxFname.TabIndex = 55;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(173, 44);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 22);
            this.textBoxID.TabIndex = 54;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(52, 352);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(77, 20);
            this.labelPicture.TabIndex = 53;
            this.labelPicture.Text = "Picture:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(44, 300);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 20);
            this.labelAddress.TabIndex = 52;
            this.labelAddress.Text = "Address:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(43, 252);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(70, 20);
            this.labelPhone.TabIndex = 51;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(45, 207);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(78, 20);
            this.labelGender.TabIndex = 50;
            this.labelGender.Text = "Gender:";
            // 
            // labelBday
            // 
            this.labelBday.AutoSize = true;
            this.labelBday.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBday.Location = new System.Drawing.Point(44, 154);
            this.labelBday.Name = "labelBday";
            this.labelBday.Size = new System.Drawing.Size(97, 20);
            this.labelBday.TabIndex = 49;
            this.labelBday.Text = "BirthDate:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(43, 116);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(107, 20);
            this.labelLname.TabIndex = 48;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(44, 83);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(109, 20);
            this.labelFName.TabIndex = 47;
            this.labelFName.Text = "First Name:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(62, 44);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(79, 20);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "Staff ID:";
            // 
            // buttonREMOVE
            // 
            this.buttonREMOVE.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonREMOVE.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonREMOVE.Location = new System.Drawing.Point(22, 600);
            this.buttonREMOVE.Name = "buttonREMOVE";
            this.buttonREMOVE.Size = new System.Drawing.Size(173, 64);
            this.buttonREMOVE.TabIndex = 66;
            this.buttonREMOVE.Text = "Remove";
            this.buttonREMOVE.UseVisualStyleBackColor = false;
            this.buttonREMOVE.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEDIT.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDIT.Location = new System.Drawing.Point(201, 532);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(173, 62);
            this.buttonEDIT.TabIndex = 65;
            this.buttonEDIT.Text = "Edit";
            this.buttonEDIT.UseVisualStyleBackColor = false;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonADD.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(22, 531);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(173, 63);
            this.buttonADD.TabIndex = 64;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 400);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Crimson;
            this.labelTotal.Location = new System.Drawing.Point(958, 512);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(79, 31);
            this.labelTotal.TabIndex = 68;
            this.labelTotal.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(529, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 70;
            // 
            // labelChuc
            // 
            this.labelChuc.AutoSize = true;
            this.labelChuc.Location = new System.Drawing.Point(425, 47);
            this.labelChuc.Name = "labelChuc";
            this.labelChuc.Size = new System.Drawing.Size(76, 17);
            this.labelChuc.TabIndex = 69;
            this.labelChuc.Text = "Công Việc:";
            // 
            // QuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 748);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelChuc);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonREMOVE);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDownLoad);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBday);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelID);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Lý Nhân Sự";
            this.Load += new System.EventHandler(this.QuanLyNhanSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.Button buttonDownLoad;
        private System.Windows.Forms.Button ButtonUploadImage;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBday;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonREMOVE;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelChuc;
    }
}