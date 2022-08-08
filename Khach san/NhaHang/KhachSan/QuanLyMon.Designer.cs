
namespace NhaHang.NhaHang
{
    partial class QuanLyMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelIDFood = new System.Windows.Forms.Label();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.labelDanhMuc = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxIDFood = new System.Windows.Forms.TextBox();
            this.pictureBoxPIC = new System.Windows.Forms.PictureBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.comboBoxDanhMuc = new System.Windows.Forms.ComboBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonReady = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.pictureBoxFindMon = new System.Windows.Forms.PictureBox();
            this.buttonALLBAN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPIC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(613, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 334);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(710, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 26);
            this.label9.TabIndex = 64;
            this.label9.Text = "Search Food By ID:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelAddress.Location = new System.Drawing.Point(31, 363);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(105, 31);
            this.labelAddress.TabIndex = 53;
            this.labelAddress.Text = "Mô Tả:";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelGender.Location = new System.Drawing.Point(31, 298);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(169, 31);
            this.labelGender.TabIndex = 51;
            this.labelGender.Text = "Tình Trạng: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTotal.Location = new System.Drawing.Point(1158, 441);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(258, 58);
            this.labelTotal.TabIndex = 87;
            this.labelTotal.Text = "Tổng Số Món :";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelPicture.Location = new System.Drawing.Point(31, 430);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(200, 31);
            this.labelPicture.TabIndex = 54;
            this.labelPicture.Text = "Ảnh Minh Họa:";
            // 
            // labelIDFood
            // 
            this.labelIDFood.AutoSize = true;
            this.labelIDFood.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDFood.Location = new System.Drawing.Point(31, 98);
            this.labelIDFood.Name = "labelIDFood";
            this.labelIDFood.Size = new System.Drawing.Size(119, 31);
            this.labelIDFood.TabIndex = 79;
            this.labelIDFood.Text = "ID Food:";
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(31, 143);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(144, 31);
            this.labelTenMon.TabIndex = 80;
            this.labelTenMon.Text = "Ten Mon: ";
            // 
            // labelDanhMuc
            // 
            this.labelDanhMuc.AutoSize = true;
            this.labelDanhMuc.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhMuc.Location = new System.Drawing.Point(31, 191);
            this.labelDanhMuc.Name = "labelDanhMuc";
            this.labelDanhMuc.Size = new System.Drawing.Size(157, 31);
            this.labelDanhMuc.TabIndex = 81;
            this.labelDanhMuc.Text = "Danh Muc: ";
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(31, 242);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(61, 31);
            this.labelGia.TabIndex = 82;
            this.labelGia.Text = "Gia:";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.buttonUpload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUpload.Location = new System.Drawing.Point(454, 531);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(76, 30);
            this.buttonUpload.TabIndex = 96;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxIDFood
            // 
            this.textBoxIDFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxIDFood.Location = new System.Drawing.Point(238, 98);
            this.textBoxIDFood.Name = "textBoxIDFood";
            this.textBoxIDFood.Size = new System.Drawing.Size(208, 30);
            this.textBoxIDFood.TabIndex = 95;
            // 
            // pictureBoxPIC
            // 
            this.pictureBoxPIC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBoxPIC.Location = new System.Drawing.Point(238, 437);
            this.pictureBoxPIC.Name = "pictureBoxPIC";
            this.pictureBoxPIC.Size = new System.Drawing.Size(208, 124);
            this.pictureBoxPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPIC.TabIndex = 94;
            this.pictureBoxPIC.TabStop = false;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonXoa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(169, 581);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(130, 61);
            this.buttonXoa.TabIndex = 93;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSua.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(327, 583);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(119, 59);
            this.buttonSua.TabIndex = 92;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonThem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(21, 583);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(119, 60);
            this.buttonThem.TabIndex = 91;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // comboBoxDanhMuc
            // 
            this.comboBoxDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDanhMuc.FormattingEnabled = true;
            this.comboBoxDanhMuc.Location = new System.Drawing.Point(238, 198);
            this.comboBoxDanhMuc.Name = "comboBoxDanhMuc";
            this.comboBoxDanhMuc.Size = new System.Drawing.Size(208, 33);
            this.comboBoxDanhMuc.TabIndex = 90;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxGia.Location = new System.Drawing.Point(238, 249);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(208, 30);
            this.textBoxGia.TabIndex = 89;
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTenMon.Location = new System.Drawing.Point(238, 152);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(208, 30);
            this.textBoxTenMon.TabIndex = 88;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTim.Location = new System.Drawing.Point(943, 41);
            this.textBoxTim.Multiline = true;
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(357, 42);
            this.textBoxTim.TabIndex = 97;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(238, 363);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(208, 68);
            this.textBoxDescription.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonReady);
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Location = new System.Drawing.Point(238, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 68);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonReady
            // 
            this.radioButtonReady.AutoSize = true;
            this.radioButtonReady.Checked = true;
            this.radioButtonReady.Location = new System.Drawing.Point(21, 32);
            this.radioButtonReady.Name = "radioButtonReady";
            this.radioButtonReady.Size = new System.Drawing.Size(70, 21);
            this.radioButtonReady.TabIndex = 100;
            this.radioButtonReady.TabStop = true;
            this.radioButtonReady.Text = "Ready";
            this.radioButtonReady.UseVisualStyleBackColor = true;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(132, 32);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(50, 21);
            this.radioButtonNO.TabIndex = 101;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFindMon
            // 
            this.pictureBoxFindMon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFindMon.Image")));
            this.pictureBoxFindMon.Location = new System.Drawing.Point(1422, 31);
            this.pictureBoxFindMon.Name = "pictureBoxFindMon";
            this.pictureBoxFindMon.Size = new System.Drawing.Size(74, 52);
            this.pictureBoxFindMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFindMon.TabIndex = 100;
            this.pictureBoxFindMon.TabStop = false;
            this.pictureBoxFindMon.Click += new System.EventHandler(this.pictureBoxFindMon_Click);
            // 
            // buttonALLBAN
            // 
            this.buttonALLBAN.BackColor = System.Drawing.Color.Orange;
            this.buttonALLBAN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALLBAN.Location = new System.Drawing.Point(613, 441);
            this.buttonALLBAN.Name = "buttonALLBAN";
            this.buttonALLBAN.Size = new System.Drawing.Size(72, 46);
            this.buttonALLBAN.TabIndex = 101;
            this.buttonALLBAN.Text = "ALL";
            this.buttonALLBAN.UseVisualStyleBackColor = false;
            this.buttonALLBAN.Click += new System.EventHandler(this.buttonALLBAN_Click);
            // 
            // QuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1596, 686);
            this.Controls.Add(this.buttonALLBAN);
            this.Controls.Add(this.pictureBoxFindMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxIDFood);
            this.Controls.Add(this.pictureBoxPIC);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBoxDanhMuc);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.textBoxTenMon);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelDanhMuc);
            this.Controls.Add(this.labelTenMon);
            this.Controls.Add(this.labelIDFood);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Mon";
            this.Load += new System.EventHandler(this.QuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPIC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelIDFood;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.Label labelDanhMuc;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxIDFood;
        private System.Windows.Forms.PictureBox pictureBoxPIC;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ComboBox comboBoxDanhMuc;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxTenMon;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonReady;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.PictureBox pictureBoxFindMon;
        private System.Windows.Forms.Button buttonALLBAN;
    }
}