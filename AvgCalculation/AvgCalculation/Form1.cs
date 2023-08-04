using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvgCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (radioLiseOrtaokul.Checked)
            {
                double birinciDersNotu, ikinciDersNotu;

                if (!double.TryParse(txtSınav1.Text, out birinciDersNotu) ||
                    !double.TryParse(txtSınav2.Text, out ikinciDersNotu))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                    return;
                }

                double ortalama = (birinciDersNotu + ikinciDersNotu) / 2;
                string gectiKaldi = ortalama >= 50 ? "Geçti" : "Kaldı";

                MessageBox.Show($"Lise için Ortalama: {ortalama:F2}\nDurum: {gectiKaldi}\n");
            }
            else if (radioUniversite.Checked)
            {
                double birinciSinav, ikinciSinav;

                if (!double.TryParse(txtSınav1.Text, out birinciSinav) ||
                    !double.TryParse(txtSınav2.Text, out ikinciSinav))
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                    return;
                }

                double ortalama = (birinciSinav * 0.4) + (ikinciSinav * 0.6);
                string gectiKaldi = ortalama >= 50 ? "Geçti" : "Kaldı";
                string harfNotu;

                if (ortalama >= 85) { harfNotu = "A"; }
                else if (ortalama >= 70) { harfNotu = "B"; }
                else if (ortalama >= 50) { harfNotu = "C"; }
                else if (ortalama >= 45) { harfNotu = "D"; }
                else { harfNotu = "E"; }
                MessageBox.Show($"Üniversite için Ortalama: {ortalama:F2}\nDurum: {gectiKaldi}\nHarf Notu: {harfNotu}");
            }
            else
            {
                MessageBox.Show("Lütfen bir okul seçin.");
            }
        }
    }
}
