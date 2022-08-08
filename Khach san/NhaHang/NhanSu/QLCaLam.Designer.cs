
namespace NhaHang.NhanSu
{
    partial class QLCaLam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLCaLam));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTen = new System.Windows.Forms.Label();
            this.Ca3 = new System.Windows.Forms.RadioButton();
            this.Ca2 = new System.Windows.Forms.RadioButton();
            this.Ca1 = new System.Windows.Forms.RadioButton();
            this.labelC_OUT = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelC_IN = new System.Windows.Forms.Label();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.BackColor = System.Drawing.Color.Transparent;
            this.labelTen.Font = new System.Drawing.Font("Pristina", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Blue;
            this.labelTen.Location = new System.Drawing.Point(601, 30);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(350, 52);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Quản Lý Ca Làm Việc";
            // 
            // Ca3
            // 
            this.Ca3.AutoSize = true;
            this.Ca3.BackColor = System.Drawing.Color.Transparent;
            this.Ca3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ca3.ForeColor = System.Drawing.Color.Black;
            this.Ca3.Location = new System.Drawing.Point(377, 21);
            this.Ca3.Name = "Ca3";
            this.Ca3.Size = new System.Drawing.Size(148, 28);
            this.Ca3.TabIndex = 130;
            this.Ca3.Tag = "3";
            this.Ca3.Text = "Ca 3(6-10 giờ)";
            this.Ca3.UseVisualStyleBackColor = false;
            // 
            // Ca2
            // 
            this.Ca2.AutoSize = true;
            this.Ca2.BackColor = System.Drawing.Color.Transparent;
            this.Ca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ca2.ForeColor = System.Drawing.Color.Black;
            this.Ca2.Location = new System.Drawing.Point(192, 21);
            this.Ca2.Name = "Ca2";
            this.Ca2.Size = new System.Drawing.Size(153, 28);
            this.Ca2.TabIndex = 129;
            this.Ca2.Tag = "2";
            this.Ca2.Text = "Ca 2( 11-2 giờ)";
            this.Ca2.UseVisualStyleBackColor = false;
            // 
            // Ca1
            // 
            this.Ca1.AutoSize = true;
            this.Ca1.BackColor = System.Drawing.Color.Transparent;
            this.Ca1.Checked = true;
            this.Ca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ca1.ForeColor = System.Drawing.Color.Black;
            this.Ca1.Location = new System.Drawing.Point(22, 21);
            this.Ca1.Name = "Ca1";
            this.Ca1.Size = new System.Drawing.Size(148, 28);
            this.Ca1.TabIndex = 128;
            this.Ca1.TabStop = true;
            this.Ca1.Tag = "1";
            this.Ca1.Text = "Ca 1(7-11 giờ)";
            this.Ca1.UseVisualStyleBackColor = false;
            this.Ca1.CheckedChanged += new System.EventHandler(this.Ca1_CheckedChanged);
            // 
            // labelC_OUT
            // 
            this.labelC_OUT.AutoSize = true;
            this.labelC_OUT.BackColor = System.Drawing.Color.Navy;
            this.labelC_OUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelC_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC_OUT.ForeColor = System.Drawing.Color.Transparent;
            this.labelC_OUT.Location = new System.Drawing.Point(900, 277);
            this.labelC_OUT.Name = "labelC_OUT";
            this.labelC_OUT.Size = new System.Drawing.Size(173, 38);
            this.labelC_OUT.TabIndex = 131;
            this.labelC_OUT.Text = "Check Out";
            this.labelC_OUT.Click += new System.EventHandler(this.labelC_OUT_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1114, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker1.TabIndex = 132;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(1114, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker2.TabIndex = 133;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1372, 708);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 10);
            this.textBox1.TabIndex = 134;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1372, 708);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 10);
            this.textBox2.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.Ca1);
            this.groupBox1.Controls.Add(this.Ca2);
            this.groupBox1.Controls.Add(this.Ca3);
            this.groupBox1.Location = new System.Drawing.Point(496, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 68);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            // 
            // labelC_IN
            // 
            this.labelC_IN.AutoSize = true;
            this.labelC_IN.BackColor = System.Drawing.Color.Navy;
            this.labelC_IN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelC_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC_IN.ForeColor = System.Drawing.Color.Transparent;
            this.labelC_IN.Location = new System.Drawing.Point(489, 277);
            this.labelC_IN.Name = "labelC_IN";
            this.labelC_IN.Size = new System.Drawing.Size(146, 38);
            this.labelC_IN.TabIndex = 137;
            this.labelC_IN.Text = "Check In";
            this.labelC_IN.Click += new System.EventHandler(this.labelC_IN_Click);
            // 
            // textBox_3
            // 
            this.textBox_3.Location = new System.Drawing.Point(1367, 708);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.Size = new System.Drawing.Size(10, 10);
            this.textBox_3.TabIndex = 140;
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(1372, 704);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(10, 11);
            this.textBox_1.TabIndex = 138;
            // 
            // textBox_2
            // 
            this.textBox_2.Location = new System.Drawing.Point(1367, 708);
            this.textBox_2.Multiline = true;
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(10, 10);
            this.textBox_2.TabIndex = 139;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1367, 704);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(10, 10);
            this.textBox12.TabIndex = 141;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(1367, 708);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(10, 10);
            this.textBox22.TabIndex = 142;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(1372, 704);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(10, 10);
            this.textBox32.TabIndex = 143;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1372, 704);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(10, 10);
            this.dataGridView2.TabIndex = 144;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tomato;
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(496, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(592, 68);
            this.groupBox3.TabIndex = 148;
            this.groupBox3.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(22, 21);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(148, 28);
            this.radioButton4.TabIndex = 128;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "1";
            this.radioButton4.Text = "Ca 1(7-11 giờ)";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.Black;
            this.radioButton5.Location = new System.Drawing.Point(192, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(148, 28);
            this.radioButton5.TabIndex = 129;
            this.radioButton5.Tag = "2";
            this.radioButton5.Text = "Ca 2(11-2 giờ)";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(377, 21);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(148, 28);
            this.radioButton6.TabIndex = 130;
            this.radioButton6.Tag = "3";
            this.radioButton6.Text = "Ca 3(6-10 giờ)";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // QLCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1404, 780);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox_3);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.labelC_IN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelC_OUT);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLCaLam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Ca làm";
            this.Load += new System.EventHandler(this.QLCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.RadioButton Ca3;
        private System.Windows.Forms.RadioButton Ca2;
        private System.Windows.Forms.RadioButton Ca1;
        private System.Windows.Forms.Label labelC_OUT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelC_IN;
        private System.Windows.Forms.TextBox textBox_3;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}