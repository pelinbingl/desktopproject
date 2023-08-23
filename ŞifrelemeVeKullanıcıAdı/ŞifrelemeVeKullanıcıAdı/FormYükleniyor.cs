using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifrelemeVeKullanıcıAdı
{
    public partial class FormYükleniyor : Form
    {
        public FormYükleniyor()
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
            this.progressBar1.Value++;
        }

        public void ShowMessage(string message)
        {
            progressBar1.Value = Math.Min(progressBar1.Value + 10, progressBar1.Maximum);
            label1.Text = "Şifre kayıt ediliyor.";
        }
    }
}
