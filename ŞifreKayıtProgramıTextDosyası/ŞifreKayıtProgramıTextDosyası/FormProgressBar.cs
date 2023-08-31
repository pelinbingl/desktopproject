using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreKayıtProgramıTextDosyası
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public ProgressBar GetProgressBar1()
        {
            return progressBar1;
        }

        public void UpdateProgress(int value, ProgressBar progressBar1)
        {

            if (progressBar1.Value >= 0 && progressBar1.Value < 100)
            {
                label1.Text = "Şifre Kayıt ediliyor";
                labelYuzde.Text = $"%{progressBar1.Value}";
                progressBar1.Value++;
            }
            else if (progressBar1.Value == 100)
            {
                labelYuzde.Text = $"%{progressBar1.Value}";
                label1.Text = "Şifre Kayıt Edildi.";
            }
            else if (progressBar1.Value >= 101)
            {
                this.Close(); // Formu kapat
            }
        }
        public void ShowMessage(string message)
        {
            progressBar1.Value = Math.Min(progressBar1.Value + 10, progressBar1.Maximum);
            label1.Text = "Şifre kayıt ediliyor.";
        }
        private void FormProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
