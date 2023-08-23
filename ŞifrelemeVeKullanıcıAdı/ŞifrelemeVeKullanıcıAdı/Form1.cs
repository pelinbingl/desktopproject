using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ŞifrelemeVeKullanıcıAdı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxAlgoritma.Items.Add("toBase64");
            comboBoxAlgoritma.Items.Add("Sezar");
            comboBoxAlgoritma.Items.Add("DES");

        }

        private void comboBoxAlgoritma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBoxAlgoritma.SelectedItem.ToString();
            string sifre = textBoxSifre.Text;

            if (selectedOption == "toBase64")
            {
                byte[] metinBytes = Encoding.UTF8.GetBytes(sifre);
                string sifrelenmisMetin = Convert.ToBase64String(metinBytes);
                textBoxSifre.Text = sifrelenmisMetin;
                string ad = textBoxKullanıcıAdı.Text;
                FormYükleniyor formYükleniyor = new FormYükleniyor();
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
                    System.Threading.Thread.Sleep(10000);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });
            }
            else if (selectedOption == "Sezar")
            {
                int anahtar = 2;
                string sifrelimetin = SezarSifreleme(sifre, anahtar);
                textBoxSifre.Text = sifrelimetin;
                FormYükleniyor formYükleniyor = new FormYükleniyor();
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
                    System.Threading.Thread.Sleep(10000);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });
            }
            else if (selectedOption == "DES")
            {
                string anahtar = "MYSECRETKEY";
                string sifreliMetin = DESSifrele(sifre, anahtar);
                textBoxSifre.Text = sifreliMetin;
                FormYükleniyor formYükleniyor = new FormYükleniyor();
                formYükleniyor.Show();
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100000; i++)
                    {
                        formYükleniyor.UpdateProgress(i, formYükleniyor.GetProgressBar1());
                        System.Threading.Thread.Sleep(100); // İlerleme yavaşça ilerlesin
                    }

                    // "Şifre kaydediliyor" mesajını göster
                    formYükleniyor.ShowMessage("Şifre kaydediliyor...");

                    // 10 saniye bekleyerek ilerleme çubuğu formunda kal
                    System.Threading.Thread.Sleep(10000);

                    // Ana formu göster ve ilerleme çubuğu formunu kapat
                    this.Invoke(new Action(() =>
                    {
                        formYükleniyor.Close();
                        this.Show();
                    }));
                });
            }

        }
        private string SezarSifreleme(string metin, int anahtar)
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
        private string DESSifrele(string metin, string anahtar)
        {
            using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
            {
                desAlg.Key = Encoding.UTF8.GetBytes(anahtar);
                desAlg.IV = Encoding.UTF8.GetBytes(anahtar.Substring(0, 8));

                desAlg.Mode = CipherMode.ECB;
                desAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = desAlg.CreateEncryptor();

                byte[] metinBytes = Encoding.UTF8.GetBytes(metin);
                byte[] sifreliMetinBytes = encryptor.TransformFinalBlock(metinBytes, 0, metinBytes.Length);

                return Convert.ToBase64String(sifreliMetinBytes);

            }
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bingl\\OneDrive\\Masaüstü\\Staj\\ŞifrelemeVeKullanıcıAdı\\ŞifrelemeVeKullanıcıAdı\\Database1.mdf;Integrated Security=True";
            string username = textBoxKullanıcıAdı.Text;
            string password = textBoxSifre.Text;
            string platform = textBoxPlatform.Text;
            string algoritma = comboBoxAlgoritma.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL komutu oluştur
                    string query = "INSERT INTO KullaniciBilgileri(KullaniciAdi,Sifre, Platform,Algoritma) VALUES (@KullaniciAdi, @Sifre, @Platform,@Algoritma)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@KullaniciAdi", username);
                        command.Parameters.AddWithValue("@Sifre", password);
                        command.Parameters.AddWithValue("@Platform", platform);
                        command.Parameters.AddWithValue("@Algoritma", algoritma);

                        // Sorguyu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veriler başarıyla kaydedildi.");
                            DialogResult dialogResult = MessageBox.Show("Kullanıcı Adınız:" + username, "Şifreniz:" + password, MessageBoxButtons.YesNo);
                            DialogResult dialogResult2 = MessageBox.Show("Uygulamaya dönmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                            if (dialogResult2 == DialogResult.Yes)
                            {
                                Form1 form = new Form1();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veriler kaydedilemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamaya dönmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
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
    }
}


