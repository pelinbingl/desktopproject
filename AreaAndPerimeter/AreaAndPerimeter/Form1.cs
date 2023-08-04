using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde varsayılan seçenekleri ayarla
            radioDaire.Checked = true;
            radioAlan.Checked = true;
            labelKenar1.Text = "Yarıçap:";
            labelKenar2.Text = "Pi:";
            txtKenar2.Text = Math.PI.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (radioDaire.Checked)
            {
                // Daire hesaplaması
                double yaricap = Convert.ToDouble(txtKenar1.Text);
                double pi = Convert.ToDouble(txtKenar2.Text);
                double alan = pi * yaricap * yaricap;
                double cevre = 2 * pi * yaricap;

                txtSonuc.Text = radioAlan.Checked ? alan.ToString() : cevre.ToString();
            }
            else if (radioKare.Checked)
            {
                // Kare hesaplaması
                double kenar = Convert.ToDouble(txtKenar1.Text);
                double alan = kenar * kenar;
                double cevre = 4 * kenar;

                txtSonuc.Text = radioAlan.Checked ? alan.ToString() : cevre.ToString();
            }
            else if (radioDikdortgen.Checked)
            {
                // Dikdörtgen hesaplaması
                double kenar1 = Convert.ToDouble(txtKenar1.Text);
                double kenar2 = Convert.ToDouble(txtKenar2.Text);
                double alan = kenar1 * kenar2;
                double cevre = 2 * (kenar1 + kenar2);

                txtSonuc.Text = radioAlan.Checked ? alan.ToString() : cevre.ToString();
            }
        }

        private void radioDaire_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDaire.Checked)
            {
                labelKenar1.Text = "Yarıçap:";
                labelKenar2.Text = "Pi:";
                txtKenar2.Text = Math.PI.ToString();
            }
        }

        private void radioKare_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKare.Checked)
            {
                labelKenar1.Text = "Kenar:";
                labelKenar2.Text = "";
                txtKenar2.Text = "";
            }
        }

        private void radioDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDikdortgen.Checked)
            {
                labelKenar1.Text = "Uzun Kenar:";
                labelKenar2.Text = "Kısa Kenar:";
            }
        }

        private void txtKenar1_TextChanged(object sender, EventArgs e)
        {
            // Eğer kenar değeri değişirse sonucu temizle
            txtSonuc.Text = "";
        }

        private void txtKenar2_TextChanged(object sender, EventArgs e)
        {
            // Eğer kenar değeri değişirse sonucu temizle
            txtSonuc.Text = "";
        }

        private void radioAlan_CheckedChanged(object sender, EventArgs e)
        {
            // Alan/Çevre seçeneği değiştirildiğinde sonucu temizle
            txtSonuc.Text = "";
        }
    }
}   

}

