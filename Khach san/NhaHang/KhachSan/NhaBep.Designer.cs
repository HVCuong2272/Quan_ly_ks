
namespace NhaHang.NhaHang
{
    partial class NhaBep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaBep));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonReady = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.textBoxIDFood = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonThucHien = new System.Windows.Forms.RadioButton();
            this.radioButtonChua = new System.Windows.Forms.RadioButton();
            this.textBoxIDTB = new System.Windows.Forms.TextBox();
            this.textBoxIDF = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(831, 376);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(863, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 207);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.radioButtonReady);
            this.groupBox1.Controls.Add(this.radioButtonNO);
            this.groupBox1.Location = new System.Drawing.Point(863, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 61);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonReady
            // 
            this.radioButtonReady.AutoSize = true;
            this.radioButtonReady.Checked = true;
            this.radioButtonReady.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonReady.Location = new System.Drawing.Point(40, 19);
            this.radioButtonReady.Name = "radioButtonReady";
            this.radioButtonReady.Size = new System.Drawing.Size(100, 36);
            this.radioButtonReady.TabIndex = 100;
            this.radioButtonReady.TabStop = true;
            this.radioButtonReady.Text = "Ready";
            this.radioButtonReady.UseVisualStyleBackColor = true;
            this.radioButtonReady.CheckedChanged += new System.EventHandler(this.radioButtonReady_CheckedChanged);
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNO.Location = new System.Drawing.Point(241, 19);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(68, 36);
            this.radioButtonNO.TabIndex = 101;
            this.radioButtonNO.Text = "No";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            this.radioButtonNO.CheckedChanged += new System.EventHandler(this.radioButtonNO_CheckedChanged);
            // 
            // textBoxIDFood
            // 
            this.textBoxIDFood.Location = new System.Drawing.Point(1210, 658);
            this.textBoxIDFood.Multiline = true;
            this.textBoxIDFood.Name = "textBoxIDFood";
            this.textBoxIDFood.Size = new System.Drawing.Size(10, 10);
            this.textBoxIDFood.TabIndex = 101;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.radioButtonThucHien);
            this.groupBox2.Controls.Add(this.radioButtonChua);
            this.groupBox2.Location = new System.Drawing.Point(863, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 61);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonThucHien
            // 
            this.radioButtonThucHien.AutoSize = true;
            this.radioButtonThucHien.Checked = true;
            this.radioButtonThucHien.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonThucHien.Location = new System.Drawing.Point(40, 19);
            this.radioButtonThucHien.Name = "radioButtonThucHien";
            this.radioButtonThucHien.Size = new System.Drawing.Size(181, 36);
            this.radioButtonThucHien.TabIndex = 100;
            this.radioButtonThucHien.TabStop = true;
            this.radioButtonThucHien.Text = "Da Thuc Hien";
            this.radioButtonThucHien.UseVisualStyleBackColor = true;
            this.radioButtonThucHien.CheckedChanged += new System.EventHandler(this.radioButtonThucHien_CheckedChanged);
            // 
            // radioButtonChua
            // 
            this.radioButtonChua.AutoSize = true;
            this.radioButtonChua.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChua.Location = new System.Drawing.Point(241, 19);
            this.radioButtonChua.Name = "radioButtonChua";
            this.radioButtonChua.Size = new System.Drawing.Size(91, 36);
            this.radioButtonChua.TabIndex = 101;
            this.radioButtonChua.Text = "Chua";
            this.radioButtonChua.UseVisualStyleBackColor = true;
            this.radioButtonChua.CheckedChanged += new System.EventHandler(this.radioButtonChua_CheckedChanged);
            // 
            // textBoxIDTB
            // 
            this.textBoxIDTB.Location = new System.Drawing.Point(1210, 658);
            this.textBoxIDTB.Multiline = true;
            this.textBoxIDTB.Name = "textBoxIDTB";
            this.textBoxIDTB.Size = new System.Drawing.Size(10, 10);
            this.textBoxIDTB.TabIndex = 103;
            // 
            // textBoxIDF
            // 
            this.textBoxIDF.Location = new System.Drawing.Point(1210, 658);
            this.textBoxIDF.Multiline = true;
            this.textBoxIDF.Name = "textBoxIDF";
            this.textBoxIDF.Size = new System.Drawing.Size(10, 10);
            this.textBoxIDF.TabIndex = 104;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 494);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(831, 163);
            this.dataGridView3.TabIndex = 105;
            // 
            // NhaBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 680);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBoxIDF);
            this.Controls.Add(this.textBoxIDTB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxIDFood);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhaBep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nha  Bep";
            this.Load += new System.EventHandler(this.NhaBep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonReady;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.TextBox textBoxIDFood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonThucHien;
        private System.Windows.Forms.RadioButton radioButtonChua;
        private System.Windows.Forms.TextBox textBoxIDTB;
        private System.Windows.Forms.TextBox textBoxIDF;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}