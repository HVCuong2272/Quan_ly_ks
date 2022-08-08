
namespace NhaHang.NhaHang
{
    partial class DatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatMon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelIDBan = new System.Windows.Forms.Label();
            this.labelIDFood = new System.Windows.Forms.Label();
            this.labelTenMon = new System.Windows.Forms.Label();
            this.labelDanhMuc = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.labelTim = new System.Windows.Forms.Label();
            this.textBoxTenMon = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonREMOVE = new System.Windows.Forms.Button();
            this.comboBoxIdTable = new System.Windows.Forms.ComboBox();
            this.comboBoxDanhMuc = new System.Windows.Forms.ComboBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.pictureBoxPIC = new System.Windows.Forms.PictureBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.textBoxIDFood = new System.Windows.Forms.TextBox();
            this.buttonMonChinh = new System.Windows.Forms.Button();
            this.buttonTrangMieng = new System.Windows.Forms.Button();
            this.buttonKhaiVi = new System.Windows.Forms.Button();
            this.buttonALL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.labelTien = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.pictureBoxFindMon = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxSoLuong = new System.Windows.Forms.ComboBox();
            this.labelSL = new System.Windows.Forms.Label();
            this.pictureBoxFindBan = new System.Windows.Forms.PictureBox();
            this.textBoxTimBan = new System.Windows.Forms.TextBox();
            this.labelTimBan = new System.Windows.Forms.Label();
            this.buttonALLBAN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Location = new System.Drawing.Point(336, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelIDBan
            // 
            this.labelIDBan.AutoSize = true;
            this.labelIDBan.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDBan.Location = new System.Drawing.Point(13, 174);
            this.labelIDBan.Name = "labelIDBan";
            this.labelIDBan.Size = new System.Drawing.Size(126, 31);
            this.labelIDBan.TabIndex = 1;
            this.labelIDBan.Text = "ID Table:";
            // 
            // labelIDFood
            // 
            this.labelIDFood.AutoSize = true;
            this.labelIDFood.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDFood.Location = new System.Drawing.Point(13, 215);
            this.labelIDFood.Name = "labelIDFood";
            this.labelIDFood.Size = new System.Drawing.Size(119, 31);
            this.labelIDFood.TabIndex = 2;
            this.labelIDFood.Text = "ID Food:";
            // 
            // labelTenMon
            // 
            this.labelTenMon.AutoSize = true;
            this.labelTenMon.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMon.Location = new System.Drawing.Point(13, 260);
            this.labelTenMon.Name = "labelTenMon";
            this.labelTenMon.Size = new System.Drawing.Size(144, 31);
            this.labelTenMon.TabIndex = 3;
            this.labelTenMon.Text = "Ten Mon: ";
            // 
            // labelDanhMuc
            // 
            this.labelDanhMuc.AutoSize = true;
            this.labelDanhMuc.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhMuc.Location = new System.Drawing.Point(13, 308);
            this.labelDanhMuc.Name = "labelDanhMuc";
            this.labelDanhMuc.Size = new System.Drawing.Size(157, 31);
            this.labelDanhMuc.TabIndex = 4;
            this.labelDanhMuc.Text = "Danh Muc: ";
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(13, 359);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(61, 31);
            this.labelGia.TabIndex = 5;
            this.labelGia.Text = "Gia:";
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTim.Location = new System.Drawing.Point(425, 142);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(69, 31);
            this.labelTim.TabIndex = 6;
            this.labelTim.Text = "Tim:";
            this.labelTim.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxTenMon
            // 
            this.textBoxTenMon.Location = new System.Drawing.Point(163, 267);
            this.textBoxTenMon.Name = "textBoxTenMon";
            this.textBoxTenMon.Size = new System.Drawing.Size(151, 22);
            this.textBoxTenMon.TabIndex = 9;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(163, 359);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(151, 22);
            this.textBoxGia.TabIndex = 11;
            // 
            // textBoxTim
            // 
            this.textBoxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTim.Location = new System.Drawing.Point(500, 131);
            this.textBoxTim.Multiline = true;
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(357, 42);
            this.textBoxTim.TabIndex = 12;
            this.textBoxTim.TextChanged += new System.EventHandler(this.textBoxTim_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1067, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(665, 385);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(1329, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 48);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ordering ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(512, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 48);
            this.label8.TabIndex = 15;
            this.label8.Text = "List Food";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(959, 336);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(87, 45);
            this.buttonADD.TabIndex = 16;
            this.buttonADD.Text = ">>";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonREMOVE
            // 
            this.buttonREMOVE.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonREMOVE.Location = new System.Drawing.Point(959, 417);
            this.buttonREMOVE.Name = "buttonREMOVE";
            this.buttonREMOVE.Size = new System.Drawing.Size(87, 45);
            this.buttonREMOVE.TabIndex = 17;
            this.buttonREMOVE.Text = "<<";
            this.buttonREMOVE.UseVisualStyleBackColor = false;
            this.buttonREMOVE.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // comboBoxIdTable
            // 
            this.comboBoxIdTable.BackColor = System.Drawing.Color.YellowGreen;
            this.comboBoxIdTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxIdTable.FormattingEnabled = true;
            this.comboBoxIdTable.Location = new System.Drawing.Point(163, 166);
            this.comboBoxIdTable.Name = "comboBoxIdTable";
            this.comboBoxIdTable.Size = new System.Drawing.Size(151, 39);
            this.comboBoxIdTable.TabIndex = 21;
            this.comboBoxIdTable.Text = "0";
            // 
            // comboBoxDanhMuc
            // 
            this.comboBoxDanhMuc.FormattingEnabled = true;
            this.comboBoxDanhMuc.Location = new System.Drawing.Point(163, 315);
            this.comboBoxDanhMuc.Name = "comboBoxDanhMuc";
            this.comboBoxDanhMuc.Size = new System.Drawing.Size(151, 24);
            this.comboBoxDanhMuc.TabIndex = 23;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonXoa.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(106, 666);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(104, 47);
            this.buttonXoa.TabIndex = 75;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSua.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(221, 666);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(93, 45);
            this.buttonSua.TabIndex = 74;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonThem.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(7, 666);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(93, 46);
            this.buttonThem.TabIndex = 73;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // pictureBoxPIC
            // 
            this.pictureBoxPIC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBoxPIC.Location = new System.Drawing.Point(106, 470);
            this.pictureBoxPIC.Name = "pictureBoxPIC";
            this.pictureBoxPIC.Size = new System.Drawing.Size(208, 124);
            this.pictureBoxPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPIC.TabIndex = 76;
            this.pictureBoxPIC.TabStop = false;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(13, 470);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(77, 31);
            this.labelPicture.TabIndex = 77;
            this.labelPicture.Text = "Hinh:";
            // 
            // textBoxIDFood
            // 
            this.textBoxIDFood.Location = new System.Drawing.Point(163, 224);
            this.textBoxIDFood.Name = "textBoxIDFood";
            this.textBoxIDFood.Size = new System.Drawing.Size(151, 22);
            this.textBoxIDFood.TabIndex = 78;
            // 
            // buttonMonChinh
            // 
            this.buttonMonChinh.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonMonChinh.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonChinh.Location = new System.Drawing.Point(617, 206);
            this.buttonMonChinh.Name = "buttonMonChinh";
            this.buttonMonChinh.Size = new System.Drawing.Size(143, 47);
            this.buttonMonChinh.TabIndex = 81;
            this.buttonMonChinh.Text = "Món Chính";
            this.buttonMonChinh.UseVisualStyleBackColor = false;
            this.buttonMonChinh.Click += new System.EventHandler(this.buttonMonChinh_Click);
            // 
            // buttonTrangMieng
            // 
            this.buttonTrangMieng.BackColor = System.Drawing.Color.Chocolate;
            this.buttonTrangMieng.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrangMieng.Location = new System.Drawing.Point(766, 208);
            this.buttonTrangMieng.Name = "buttonTrangMieng";
            this.buttonTrangMieng.Size = new System.Drawing.Size(170, 45);
            this.buttonTrangMieng.TabIndex = 80;
            this.buttonTrangMieng.Text = "Tráng Miệng";
            this.buttonTrangMieng.UseVisualStyleBackColor = false;
            this.buttonTrangMieng.Click += new System.EventHandler(this.buttonTrangMieng_Click);
            // 
            // buttonKhaiVi
            // 
            this.buttonKhaiVi.BackColor = System.Drawing.Color.Orchid;
            this.buttonKhaiVi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhaiVi.Location = new System.Drawing.Point(491, 207);
            this.buttonKhaiVi.Name = "buttonKhaiVi";
            this.buttonKhaiVi.Size = new System.Drawing.Size(120, 46);
            this.buttonKhaiVi.TabIndex = 79;
            this.buttonKhaiVi.Text = "Khai Vị";
            this.buttonKhaiVi.UseVisualStyleBackColor = false;
            this.buttonKhaiVi.Click += new System.EventHandler(this.buttonKhaiVi_Click);
            // 
            // buttonALL
            // 
            this.buttonALL.BackColor = System.Drawing.Color.Orange;
            this.buttonALL.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALL.Location = new System.Drawing.Point(337, 206);
            this.buttonALL.Name = "buttonALL";
            this.buttonALL.Size = new System.Drawing.Size(142, 46);
            this.buttonALL.TabIndex = 82;
            this.buttonALL.Text = "ALL";
            this.buttonALL.UseVisualStyleBackColor = false;
            this.buttonALL.Click += new System.EventHandler(this.buttonALL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1760, 724);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 83;
            this.textBox1.Text = "Khai Vi";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Crimson;
            this.labelTotal.Location = new System.Drawing.Point(672, 670);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(154, 35);
            this.labelTotal.TabIndex = 85;
            this.labelTotal.Text = "Tổng Số Món :";
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(1177, 644);
            this.textBoxTong.Multiline = true;
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(357, 42);
            this.textBoxTong.TabIndex = 87;
            this.textBoxTong.TextChanged += new System.EventHandler(this.textBoxTong_TextChanged);
            // 
            // labelTien
            // 
            this.labelTien.AutoSize = true;
            this.labelTien.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTien.Location = new System.Drawing.Point(1072, 655);
            this.labelTien.Name = "labelTien";
            this.labelTien.Size = new System.Drawing.Size(81, 31);
            this.labelTien.TabIndex = 86;
            this.labelTien.Text = "Tổng:";
            this.labelTien.Click += new System.EventHandler(this.labelTien_Click);
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.Crimson;
            this.labelSoLuong.Location = new System.Drawing.Point(1072, 600);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(154, 35);
            this.labelSoLuong.TabIndex = 88;
            this.labelSoLuong.Text = "Tổng Số Món :";
            // 
            // pictureBoxFindMon
            // 
            this.pictureBoxFindMon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFindMon.Image")));
            this.pictureBoxFindMon.Location = new System.Drawing.Point(862, 121);
            this.pictureBoxFindMon.Name = "pictureBoxFindMon";
            this.pictureBoxFindMon.Size = new System.Drawing.Size(74, 52);
            this.pictureBoxFindMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFindMon.TabIndex = 89;
            this.pictureBoxFindMon.TabStop = false;
            this.pictureBoxFindMon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1760, 724);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 10);
            this.textBox2.TabIndex = 90;
            this.textBox2.Text = "Mon Chinh";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1760, 724);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(10, 10);
            this.textBox3.TabIndex = 91;
            this.textBox3.Text = "Trang Mieng";
            // 
            // comboBoxSoLuong
            // 
            this.comboBoxSoLuong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.comboBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSoLuong.FormattingEnabled = true;
            this.comboBoxSoLuong.Location = new System.Drawing.Point(163, 398);
            this.comboBoxSoLuong.Name = "comboBoxSoLuong";
            this.comboBoxSoLuong.Size = new System.Drawing.Size(151, 37);
            this.comboBoxSoLuong.TabIndex = 95;
            this.comboBoxSoLuong.Text = "1";
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSL.Location = new System.Drawing.Point(8, 404);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(149, 31);
            this.labelSL.TabIndex = 94;
            this.labelSL.Text = "So Luong: ";
            // 
            // pictureBoxFindBan
            // 
            this.pictureBoxFindBan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFindBan.Image")));
            this.pictureBoxFindBan.Location = new System.Drawing.Point(1665, 136);
            this.pictureBoxFindBan.Name = "pictureBoxFindBan";
            this.pictureBoxFindBan.Size = new System.Drawing.Size(74, 52);
            this.pictureBoxFindBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFindBan.TabIndex = 98;
            this.pictureBoxFindBan.TabStop = false;
            this.pictureBoxFindBan.Click += new System.EventHandler(this.pictureBoxFindBan_Click);
            // 
            // textBoxTimBan
            // 
            this.textBoxTimBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimBan.Location = new System.Drawing.Point(1302, 136);
            this.textBoxTimBan.Multiline = true;
            this.textBoxTimBan.Name = "textBoxTimBan";
            this.textBoxTimBan.Size = new System.Drawing.Size(357, 42);
            this.textBoxTimBan.TabIndex = 97;
            this.textBoxTimBan.TextChanged += new System.EventHandler(this.textBoxTimBan_TextChanged);
            // 
            // labelTimBan
            // 
            this.labelTimBan.AutoSize = true;
            this.labelTimBan.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimBan.Location = new System.Drawing.Point(1171, 142);
            this.labelTimBan.Name = "labelTimBan";
            this.labelTimBan.Size = new System.Drawing.Size(125, 31);
            this.labelTimBan.TabIndex = 96;
            this.labelTimBan.Text = "Tim Ban:";
            // 
            // buttonALLBAN
            // 
            this.buttonALLBAN.BackColor = System.Drawing.Color.Orange;
            this.buttonALLBAN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALLBAN.Location = new System.Drawing.Point(1067, 137);
            this.buttonALLBAN.Name = "buttonALLBAN";
            this.buttonALLBAN.Size = new System.Drawing.Size(72, 46);
            this.buttonALLBAN.TabIndex = 99;
            this.buttonALLBAN.Text = "ALL";
            this.buttonALLBAN.UseVisualStyleBackColor = false;
            this.buttonALLBAN.Click += new System.EventHandler(this.buttonALLBAN_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(942, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 67);
            this.button1.TabIndex = 100;
            this.button1.Text = "Change the quantity";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(337, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 101;
            this.button2.Text = "Bàn trống";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1551, 644);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 45);
            this.button3.TabIndex = 102;
            this.button3.Text = "Thanh Toán";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(465, 668);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 45);
            this.button4.TabIndex = 103;
            this.button4.Text = "UpDate mon";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1782, 735);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonALLBAN);
            this.Controls.Add(this.pictureBoxFindBan);
            this.Controls.Add(this.textBoxTimBan);
            this.Controls.Add(this.labelTimBan);
            this.Controls.Add(this.comboBoxSoLuong);
            this.Controls.Add(this.labelSL);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBoxFindMon);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.textBoxTong);
            this.Controls.Add(this.labelTien);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonALL);
            this.Controls.Add(this.buttonMonChinh);
            this.Controls.Add(this.buttonTrangMieng);
            this.Controls.Add(this.buttonKhaiVi);
            this.Controls.Add(this.textBoxIDFood);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.pictureBoxPIC);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBoxDanhMuc);
            this.Controls.Add(this.comboBoxIdTable);
            this.Controls.Add(this.buttonREMOVE);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxTim);
            this.Controls.Add(this.textBoxGia);
            this.Controls.Add(this.textBoxTenMon);
            this.Controls.Add(this.labelTim);
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelDanhMuc);
            this.Controls.Add(this.labelTenMon);
            this.Controls.Add(this.labelIDFood);
            this.Controls.Add(this.labelIDBan);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Món ....";
            this.Load += new System.EventHandler(this.DatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFindBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelIDBan;
        private System.Windows.Forms.Label labelIDFood;
        private System.Windows.Forms.Label labelTenMon;
        private System.Windows.Forms.Label labelDanhMuc;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox textBoxTenMon;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonREMOVE;
        private System.Windows.Forms.ComboBox comboBoxIdTable;
        private System.Windows.Forms.ComboBox comboBoxDanhMuc;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.PictureBox pictureBoxPIC;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.TextBox textBoxIDFood;
        private System.Windows.Forms.Button buttonMonChinh;
        private System.Windows.Forms.Button buttonTrangMieng;
        private System.Windows.Forms.Button buttonKhaiVi;
        private System.Windows.Forms.Button buttonALL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTong;
        private System.Windows.Forms.Label labelTien;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.PictureBox pictureBoxFindMon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxSoLuong;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.PictureBox pictureBoxFindBan;
        private System.Windows.Forms.TextBox textBoxTimBan;
        private System.Windows.Forms.Label labelTimBan;
        private System.Windows.Forms.Button buttonALLBAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}