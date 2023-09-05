using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreKayıtProgramı
{
    public partial class FormKayit : Form
    {
        KullaniciBilgileri kullanici = new KullaniciBilgileri();
        public FormKayit()
        {
            InitializeComponent();
        }
        public string SezarSifreleme(string metin, int anahtar)
        {
            StringBuilder sifreliMetin = new StringBuilder();

            foreach (char karakter in metin)
            {
                if (char.IsLetter(karakter))
                {
                    char baslangic = char.IsUpper(karakter) ? 'A' : 'a';
                    sifreliMetin.Append((char)((((karakter - baslangic) + anahtar) % 29) + baslangic));
                }
                else
                {
                    sifreliMetin.Append(karakter);
                }
            }
            return sifreliMetin.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSil.Visible = false;
            comboBoxAlgoritma.Items.Add("toBase64");
            comboBoxAlgoritma.Items.Add("Sezar");
            kullanici.GetAll();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dataGridViewVeriler.DataSource = kullanici.GetAll();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Güncelle")
            {
                int rowindex = dataGridViewVeriler.CurrentRow.Index;
                MessageBox.Show(rowindex.ToString());
            /*  kullanici.Id = Convert.ToInt32(dataGridViewVeriler.CurrentRow.Cells[0].Value);
                kullanici.KullaniciAdi = textBoxKullanıcıAdı.Text;
                kullanici.Sifre = textBoxSifre.Text;
                kullanici.Platform = textBoxPlatform.Text;
                kullanici.Algoritma = comboBoxAlgoritma.Text;
                kullanici.AlgoritmaliSifre = textBoxAlgSifre.Text;
                kullanici.Email = textBoxEmail.Text;
                kullanici.Guncelle(kullanici);
                kullanici.GetAll();
                MessageBox.Show("Kayıt Güncellendi!");
                RefreshDataGridView();
            */
            }
            else
            {
                kullanici.KullaniciAdi = textBoxKullanıcıAdı.Text;
                kullanici.Sifre = textBoxSifre.Text;
                kullanici.Platform = textBoxPlatform.Text;
                kullanici.Algoritma = comboBoxAlgoritma.Text;
                kullanici.AlgoritmaliSifre = textBoxAlgSifre.Text;
                kullanici.Email = textBoxEmail.Text;
                kullanici.Kaydet(kullanici);
                kullanici.GetAll();
                MessageBox.Show("Kayıt Eklendi!");
                RefreshDataGridView();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            kullanici.Id = Convert.ToInt32(dataGridViewVeriler.CurrentRow.Cells[0].Value);
            kullanici.Sil(kullanici);
            kullanici.GetAll();
            Temizle();
            MessageBox.Show("Kayıt Silindi!");
            RefreshDataGridView();
            buttonSil.Visible = false;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBoxKullanıcıAdı.Text = textBoxSifre.Text = textBoxPlatform.Text = textBoxEmail.Text = comboBoxAlgoritma.Text = textBoxAlgSifre.Text = " ";
            buttonSil.Enabled = false;
            btnKaydet.Text = "Kaydet";
            dataGridViewVeriler.ClearSelection();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string secim = comboBoxAlgoritma.SelectedItem as string;

            string sifre = textBoxSifre.Text;
            if (secim == "toBase64")
            {
                byte[] metinBytes = Encoding.UTF8.GetBytes(sifre);
                string sifrelenmisMetin = Convert.ToBase64String(metinBytes);
                textBoxAlgSifre.Text = sifrelenmisMetin;
                string ad = textBoxKullanıcıAdı.Text;
                FormProgressBar formYükleniyor = new FormProgressBar();
                formYükleniyor.Show();
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        formYükleniyor.UpdateProgress(i, formYükleniyor.GetProgressBar1());
                        System.Threading.Thread.Sleep(100); // İlerleme yavaşça ilerlesin
                    }

                    // "Şifre kaydediliyor" mesajını göster
                    formYükleniyor.ShowMessage("Şifre kaydediliyor...");

                    // 10 saniye bekleyerek ilerleme çubuğu formunda kal
                    System.Threading.Thread.Sleep(10);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });
            }
            else if (secim == "Sezar")
            {
                int anahtar = 2;
                string sifrelimetin = SezarSifreleme(sifre, anahtar);
                textBoxAlgSifre.Text = sifrelimetin;
                FormProgressBar formYükleniyor = new FormProgressBar();
                formYükleniyor.Show();
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        formYükleniyor.UpdateProgress(i, formYükleniyor.GetProgressBar1());
                        System.Threading.Thread.Sleep(100); // İlerleme yavaşça ilerlesin
                    }

                    // "Şifre kaydediliyor" mesajını göster
                    formYükleniyor.ShowMessage("Şifre kaydediliyor...");

                    // 10 saniye bekleyerek ilerleme çubuğu formunda kal
                    System.Threading.Thread.Sleep(10);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });

            }
            else if (secim == " ")
            {
                textBoxAlgSifre.Text = null;
                FormProgressBar formYükleniyor = new FormProgressBar();
                formYükleniyor.Show();
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        formYükleniyor.UpdateProgress(i, formYükleniyor.GetProgressBar1());
                        System.Threading.Thread.Sleep(100); // İlerleme yavaşça ilerlesin
                    }

                    // "Şifre kaydediliyor" mesajını göster
                    formYükleniyor.ShowMessage("Şifre kaydediliyor...");

                    // 10 saniye bekleyerek ilerleme çubuğu formunda kal
                    System.Threading.Thread.Sleep(10);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });
            }
            RefreshDataGridView();

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            dataGridViewVeriler.ClearSelection();
            string arananPlatform = textBoxPlatform.Text; // Varsayalım bu TextBox ile kullanıcının platform aradığını girdiği alandır

            List<KullaniciBilgileri> bulunanKullanicilar = kullanici.Ara(arananPlatform);

            dataGridViewVeriler.DataSource = bulunanKullanicilar;
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak İster Misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBoxSifre_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSifre.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = false; // Parola karakterini göster
            }
            else
            {
                textBoxSifre.UseSystemPasswordChar = true; // Parola karakterini gizle
            }
        }

        private void dataGridViewVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVeriler.ClearSelection();
            btnKaydet.Text = "Güncelle";
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0) // Satır seçildiğinden emin ol
            {
                DataGridViewRow selectedRow = dataGridViewVeriler.Rows[e.RowIndex];
                string kullaniciAdi = selectedRow.Cells["KullaniciAdi"].Value.ToString();
                string sifre = selectedRow.Cells["Sifre"].Value.ToString();
                string platform = selectedRow.Cells["Platform"].Value.ToString();
                string algoritma = selectedRow.Cells["Algoritma"].Value.ToString();
                string algSifre = selectedRow.Cells["AlgoritmaliSifre"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                textBoxKullanıcıAdı.Text = kullaniciAdi;
                textBoxSifre.Text = sifre;
                textBoxAlgSifre.Text = algSifre;
                textBoxPlatform.Text = platform;
                comboBoxAlgoritma.SelectedItem = algoritma;
                textBoxEmail.Text = email;
                buttonSil.Visible = true;
            }
        }
    }
}