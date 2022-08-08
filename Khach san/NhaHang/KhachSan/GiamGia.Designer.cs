
namespace NhaHang.KhachSan
{
    partial class GiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamGia));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelGiam = new System.Windows.Forms.Label();
            this.textBoxgiam = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.buttonREMOVE = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(293, 373);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(42, 17);
            this.labeldate.TabIndex = 88;
            this.labeldate.Text = "Date:";
            // 
            // labelGiam
            // 
            this.labelGiam.AutoSize = true;
            this.labelGiam.Location = new System.Drawing.Point(293, 341);
            this.labelGiam.Name = "labelGiam";
            this.labelGiam.Size = new System.Drawing.Size(41, 17);
            this.labelGiam.TabIndex = 87;
            this.labelGiam.Text = "Giam";
            // 
            // textBoxgiam
            // 
            this.textBoxgiam.Location = new System.Drawing.Point(390, 338);
            this.textBoxgiam.Name = "textBoxgiam";
            this.textBoxgiam.Size = new System.Drawing.Size(295, 22);
            this.textBoxgiam.TabIndex = 86;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(293, 308);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(41, 17);
            this.labelCode.TabIndex = 85;
            this.labelCode.Text = "Code";
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(390, 304);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(295, 22);
            this.textBoxcode.TabIndex = 84;
            // 
            // buttonREMOVE
            // 
            this.buttonREMOVE.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonREMOVE.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonREMOVE.Location = new System.Drawing.Point(530, 439);
            this.buttonREMOVE.Name = "buttonREMOVE";
            this.buttonREMOVE.Size = new System.Drawing.Size(173, 64);
            this.buttonREMOVE.TabIndex = 83;
            this.buttonREMOVE.Text = "Remove";
            this.buttonREMOVE.UseVisualStyleBackColor = false;
            this.buttonREMOVE.Click += new System.EventHandler(this.buttonREMOVE_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonADD.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(351, 439);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(173, 63);
            this.buttonADD.TabIndex = 81;
            this.buttonADD.Text = "Add";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 239);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // GiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 635);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelGiam);
            this.Controls.Add(this.textBoxgiam);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.buttonREMOVE);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiamGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiamGia";
            this.Load += new System.EventHandler(this.GiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelGiam;
        private System.Windows.Forms.TextBox textBoxgiam;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.Button buttonREMOVE;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}