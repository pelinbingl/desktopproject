using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameLoadingProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false; // Başlat düğmesini devre dışı bırak
            progressLoading.Value = 0; // İlerleme çubuğunu sıfırla
            timer.Start(); // Timer'ı başlat
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressLoading.Value += 1; // İlerlemeyi bir birim artır

            if (progressLoading.Value ==100 )
            {
                timer.Stop(); // Timer'ı durdur
                progressLoading.Text = "Yükleme tamamlandı"; // Etiketi güncelle
                btnStart.Enabled = true; // Başlat düğmesini etkinleştir
                MessageBox.Show("Oyun yükleme tamamlandı!"); // İşlem tamamlandı mesajı
            }
            else
            {
                UpdateText();
                progressLoading.Text = $"Yükleniyor... %{progressLoading.Value}"; // Etiketi güncelle
            }
        }
        private void UpdateText()
        {
            int percentage = (progressLoading.Value - progressLoading.Minimum) * 100 / (progressLoading.Maximum - progressLoading.Minimum);
            txtPercentage.Text = $"Yükleniyor......";
            lblPercentage.Text = $"%{percentage}";
        }
    }
}
