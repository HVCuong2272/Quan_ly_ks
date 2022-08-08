using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.KhachSan;

namespace NhaHang.NhaHang
{
    public partial class QLBanTrong : Form
    {
        public QLBanTrong()
        {
            InitializeComponent();
        }
        NhaHangClass nhahnang = new NhaHangClass();
        private void QLBanTrong_Load(object sender, EventArgs e)
        {
            change();
            dataGridView1.DataSource = nhahnang.getphong0();
        }


        public void change()
        {
            if (nhahnang.checkBan(picture1.Tag.ToString()))
            {
                P1.BackColor = Color.Cyan;
                picture1.Hide();

            }
            else { P1.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture2.Tag.ToString()))
            {
                P2.BackColor = Color.Cyan; picture2.Hide();


            }
            else { P2.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture3.Tag.ToString()))
            {
                P3.BackColor = Color.Cyan; picture3.Hide();


            }
            else { P3.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture4.Tag.ToString()))
            {
                P4.BackColor = Color.Cyan; picture4.Hide();

            }
            else { P4.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture5.Tag.ToString()))
            {
                P5.BackColor = Color.Cyan; picture5.Hide();
            }
            else { P5.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture6.Tag.ToString()))
            {
                P6.BackColor = Color.Cyan; picture6.Hide();
            }
            else { P6.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture7.Tag.ToString()))
            {
                P7.BackColor = Color.Cyan; picture7.Hide();
            }
            else { P7.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture8.Tag.ToString()))
            {
                P8.BackColor = Color.Cyan; picture8.Hide();
            }
            else { P8.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture9.Tag.ToString()))
            {
                P9.BackColor = Color.Cyan; picture9.Hide();
            }
            else { P9.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture10.Tag.ToString()))
            {
                P10.BackColor = Color.Cyan; picture10.Hide();
            }
            else { P10.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture11.Tag.ToString()))
            {
                P11.BackColor = Color.Cyan; picture11.Hide();
            }
            else { P11.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture12.Tag.ToString()))
            {
                P12.BackColor = Color.Cyan; picture12.Hide();
            }
            else { P12.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture13.Tag.ToString()))
            {
                P13.BackColor = Color.Cyan; picture13.Hide();
            }
            else { P13.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture14.Tag.ToString()))
            {
                P14.BackColor = Color.Cyan; picture14.Hide();
            }
            else { P14.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture15.Tag.ToString()))
            {
                P15.BackColor = Color.Cyan; picture15.Hide();
            }
            else { P15.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture16.Tag.ToString()))
            {
                P16.BackColor = Color.Cyan; picture16.Hide();
            }
            else { P16.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture17.Tag.ToString()))
            {
                P17.BackColor = Color.Cyan; picture17.Hide();
            }
            else { P17.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture18.Tag.ToString()))
            {
                P18.BackColor = Color.Cyan; picture18.Hide();
            }
            else { P18.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture19.Tag.ToString()))
            {
                P19.BackColor = Color.Cyan; picture19.Hide();
            }
            else { P19.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture20.Tag.ToString()))
            {
                P20.BackColor = Color.Cyan; picture20.Hide();
            }
            else { P20.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture21.Tag.ToString()))
            {
                P21.BackColor = Color.Cyan; picture21.Hide();
            }
            else { P21.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture22.Tag.ToString()))
            {
                P22.BackColor = Color.Cyan; picture22.Hide();
            }
            else { P22.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture23.Tag.ToString()))
            {
                P23.BackColor = Color.Cyan; picture23.Hide();
            }
            else { P23.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture24.Tag.ToString()))
            {
                P24.BackColor = Color.Cyan; picture24.Hide();
            }
            else { P24.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(picture25.Tag.ToString()))
            {
                P25.BackColor = Color.Cyan; picture25.Hide();
            }
            else { P25.BackColor = Color.Cornsilk; }

            if (nhahnang.checkBan(pictureVIP1.Tag.ToString()))
            {
                PV1.BackColor = Color.Violet; pictureVIP1.Hide();
            }
            else { PV1.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP2.Tag.ToString()))
            {
                PV2.BackColor = Color.Violet; pictureVIP2.Hide();
            }
            else { PV2.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP3.Tag.ToString()))
            {
                PV3.BackColor = Color.Violet; pictureVIP3.Hide();
            }
            else { PV3.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP4.Tag.ToString()))
            {
                PV4.BackColor = Color.Violet; pictureVIP4.Hide();
            }
            else { PV4.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP6.Tag.ToString()))
            {
                PV6.BackColor = Color.Violet; pictureVIP6.Hide();
            }
            else { PV6.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP7.Tag.ToString()))
            {
                PV7.BackColor = Color.Violet; pictureVIP7.Hide();
            }
            else { PV7.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP8.Tag.ToString()))
            {
                PV8.BackColor = Color.Violet; pictureVIP8.Hide();
            }
            else { PV8.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP9.Tag.ToString()))
            {
                PV9.BackColor = Color.Violet; pictureVIP9.Hide();
            }
            else { PV9.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP10.Tag.ToString()))
            {
                PV10.BackColor = Color.Violet; pictureVIP10.Hide();
            }
            else { PV10.BackColor = Color.Cornsilk; }
            if (nhahnang.checkBan(pictureVIP5.Tag.ToString()))
            {
                PV5.BackColor = Color.Violet; pictureVIP5.Hide();
            }
            else { PV5.BackColor = Color.Cornsilk; };

           

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }


        public void doi()
        {
            KHDatphong datMon = new KHDatphong();
            luu.soban = textBoxTruyen.Text;
            KHDatphong dat = new KHDatphong();
            Hide();
            dat.Show();

        }
        private void picture1_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture1.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
           




        }

        public class luu
        {
            static public string soban;
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture2.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture3_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture3.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture4.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture5.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture6_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture6.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture7_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture7.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture8_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture8.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture9_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture9.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture10_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture10.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture11_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture11.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture12_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture12.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture13_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture13.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture14_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture4.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture15_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture15.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture16_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture16.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture17_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture17.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture18_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture18.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture19_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture19.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture20_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture20.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture21_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture21.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture22_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture23.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture23_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture23.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture24_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture24.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void picture25_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = picture25.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP1_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP1.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP2_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP2.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP3_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP3.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP4_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP4.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP5_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP5.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP6_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP6.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP7_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP7.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP8_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP8.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP9_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP9.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();
        }

        private void pictureVIP10_Click(object sender, EventArgs e)
        {
            textBoxTruyen.Text = pictureVIP10.Tag.ToString();
            DatMon datMon = new DatMon();
            //datMon.Show(this);
            doi();

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void buttonDatBan_Click(object sender, EventArgs e)
        {
            QuanLyBan quanLy = new QuanLyBan();
            quanLy.Show(this);
            Hide();
        }
    }
}
