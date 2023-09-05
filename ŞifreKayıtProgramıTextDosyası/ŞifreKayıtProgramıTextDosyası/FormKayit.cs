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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ŞifreKayıtProgramıTextDosyası
{
    public partial class FormKayit : Form
    {
        KullaniciBilgileri kullanici = new KullaniciBilgileri();
        string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ŞifreKayıtProgramıTextDosyası\\ŞifreKayitlari.txt";
        int id = 1;

        public FormKayit()
        {
            InitializeComponent();
        }

        //TODO: dosya yolunu ekrandan alacak şekilde yap dinamik!
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
            btnSil.Visible = false;
            if (dataGridViewVeriler.Rows.Count > 0)
            {
                label1.Visible = false;
                textBoxAra.Visible = false;
            }
            comboBoxAlgoritma.Items.Add("toBase64");
            comboBoxAlgoritma.Items.Add("Sezar");
            kullanici.GetAllFromTextDosyasi(dosyaYolu);
            textBoxSifre.UseSystemPasswordChar = true;

            if (File.Exists(dosyaYolu))
            {
                // Dosya varsa en son kaydın Id değerini alarak yeni bir Id hesapla
                var lines = File.ReadAllLines(dosyaYolu);
                if (lines.Length > 1)
                {
                    var sonSatir = lines[lines.Length - 1];
                    var sonId = Convert.ToInt32(sonSatir.Split('|')[0]);
                    kullanici.Id = sonId + 1;
                }
                else
                {
                    kullanici.Id = 1;
                }
            }
            else
            {
                kullanici.CreateFile(dosyaYolu);
                kullanici.Id = 1;
            }
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dataGridViewVeriler.DataSource = kullanici.GetAllFromTextDosyasi(dosyaYolu);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Güncelle")
            {
                label1.Visible = true;
                textBoxAra.Visible = true;
                try
                {
                    var id = dataGridViewVeriler.CurrentRow.Cells[0].Value;

                    KullaniciBilgileri yeniKullanici = new KullaniciBilgileri
                    {

                        Id = Convert.ToInt32(id),  //Seçtiğin kaydın idsini setle
                        KullaniciAdi = textBoxKullanıcıAdı.Text,
                        Sifre = textBoxSifre.Text,
                        Platform = textBoxPlatform.Text,
                        Algoritma = comboBoxAlgoritma.Text,
                        AlgoritmaliSifre = textBoxAlgSifre.Text,
                        Email = textBoxEmail.Text
                    };

                    kullanici.GuncelleTextDosyasindan(dosyaYolu, kullanici.Id, yeniKullanici);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                label1.Visible = true;
                textBoxAra.Visible = true;

                try
                {
                    KullaniciBilgileri yeniKullanici = new KullaniciBilgileri
                    {
                        Id = id,
                        KullaniciAdi = textBoxKullanıcıAdı.Text,
                        Sifre = textBoxSifre.Text,
                        Platform = textBoxPlatform.Text,
                        Algoritma = comboBoxAlgoritma.Text,
                        AlgoritmaliSifre = textBoxAlgSifre.Text,
                        Email = textBoxEmail.Text
                    };

                    id++;

                    kullanici.KaydetVeriyiTextDosyasina(dosyaYolu, yeniKullanici);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            RefreshDataGridView();
            Temizle();
            kullanici.GetAllFromTextDosyasi(dosyaYolu);
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBoxAra.Visible = true;
            string secim = comboBoxAlgoritma.SelectedItem as string;

            string sifre = textBoxSifre.Text;
            if (secim == "toBase64")
            {
                byte[] metinBytes = Encoding.UTF8.GetBytes(sifre);
                string sifrelenmisMetin = Convert.ToBase64String(metinBytes);
                textBoxAlgSifre.Text = sifrelenmisMetin;
                ShowLoadingForm();
            }
            else if (secim == "Sezar")
            {
                int anahtar = 2;
                string sifrelimetin = SezarSifreleme(sifre, anahtar);
                textBoxAlgSifre.Text = sifrelimetin;
                ShowLoadingForm();
            }
            else if (secim == null)
            {
                MessageBox.Show("Seçim Yapınız");
            }
            RefreshDataGridView();
        }
        private void ShowLoadingForm()
        {
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
        private void Temizle()
        {
            textBoxKullanıcıAdı.Text = textBoxSifre.Text = textBoxPlatform.Text = textBoxEmail.Text = comboBoxAlgoritma.Text = textBoxAlgSifre.Text = " ";
            btnSil.Enabled = false;
            btnKaydet.Text = "Kaydet";
            dataGridViewVeriler.ClearSelection();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBoxAra.Visible = true;

            kullanici.SilTextDosyasindan(dosyaYolu, dataGridViewVeriler.CurrentCell.RowIndex);
            kullanici.GetAllFromTextDosyasi(dosyaYolu);
            Temizle();
            MessageBox.Show("Kayıt Silindi!");
            RefreshDataGridView();
            btnSil.Visible = false;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBoxAra.Visible = true;
            string hedefPlatform = textBoxAra.Text; // Arama yapılacak platformu alın
            if (!string.IsNullOrWhiteSpace(hedefPlatform))
            {
                List<KullaniciBilgileri> bulunanKullanicilar = kullanici.AraTextDosyasindan(dosyaYolu, hedefPlatform);
                if (bulunanKullanicilar != null)
                {
                    dataGridViewVeriler.DataSource = bulunanKullanicilar;
                }
                else
                {
                    MessageBox.Show("Aranılan platform listede yok");
                }
            }
            else
            {
                MessageBox.Show("Arama metni boş olamaz.");
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamadan Çıkmak İster Misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void dataGridViewVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Visible = true;
            textBoxAra.Visible = true;

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
                btnSil.Visible = true;
                btnSil.Enabled = true;
            }
        }
    }
}