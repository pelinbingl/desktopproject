using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞifreKayıtProgramıTextDosyası
{
    internal class KullaniciBilgileri
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Platform { get; set; }
        public string Algoritma { get; set; }
        public string AlgoritmaliSifre { get; set; }
        public string Email { get; set; }

        public List<KullaniciBilgileri> GetAllFromTextDosyasi(string dosyaYolu)
        {
            List<KullaniciBilgileri> kullaniciBilgileriListesi = new List<KullaniciBilgileri>();

            if (File.Exists(dosyaYolu))
            {
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    var lines = File.ReadAllLines(dosyaYolu);
                    for (var i = 1; i < lines.Length; i++)
                    {
                        var line = lines[i].Split('|');

                        if (line.Length == 7)
                        {
                            kullaniciBilgileriListesi.Add(new KullaniciBilgileri
                            {
                                Id = int.Parse(line[0]),
                                KullaniciAdi = line[1],
                                Sifre = line[2],
                                Platform = line[3],
                                Algoritma = line[4],
                                AlgoritmaliSifre = line[5],
                                Email = line[6]
                            });
                        }
                    }
                }
            }
            return kullaniciBilgileriListesi;
        }
        public void KaydetVeriyiTextDosyasina(string dosyaYolu, KullaniciBilgileri kullaniciBilgileri)
        {
            try
            {
                List<string> satirlar = new List<string>();

                int yeniId = 1;

                if (File.Exists(dosyaYolu))
                {
                    using (StreamReader reader = new StreamReader(dosyaYolu))
                    {
                        var lines = File.ReadAllLines(dosyaYolu);
                        if (lines.Length > 1)
                        {
                            var sonSatir = lines[lines.Length - 1];
                            var sonId = Convert.ToInt32(sonSatir.Split('|')[0]);
                            yeniId = sonId + 1;
                        }
                    }
                }

                kullaniciBilgileri.Id = yeniId;

                using (StreamWriter writer = new StreamWriter(dosyaYolu, true, Encoding.UTF8))
                {
                    string yeniKayit = $"{kullaniciBilgileri.Id}|{kullaniciBilgileri.KullaniciAdi}|{kullaniciBilgileri.Sifre}|{kullaniciBilgileri.Platform}|{kullaniciBilgileri.Algoritma}|{kullaniciBilgileri.AlgoritmaliSifre}|{kullaniciBilgileri.Email}";
                    writer.WriteLine(yeniKayit);
                }
                MessageBox.Show("Veriler dosyaya kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CreateFile(string dosyaYolu)
        {
            using (StreamWriter headerWriter = File.CreateText(dosyaYolu))
            {
                string sütunIsimleri = "Id|KullaniciAdi|Sifre|Platform|Algoritma|AlgoritmaliSifre|Email";
                headerWriter.WriteLine(sütunIsimleri);
            }
        }
        public void GuncelleTextDosyasindan(string dosyaYolu, int hedefMaxValue, KullaniciBilgileri yeniBilgiler)
        {
            List<string> satirlar = new List<string>();

            if (File.Exists(dosyaYolu))
            {
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    var lines = File.ReadAllLines(dosyaYolu);
                    for (var i = 0; i < lines.Length; i++)
                    {
                        var line = lines[i].Split('|');

                        if (line.Length == 7 && line[0] == yeniBilgiler.Id.ToString())
                        {
                            line[1] = yeniBilgiler.KullaniciAdi.ToString();
                            line[2] = yeniBilgiler.Sifre.ToString();
                            line[3] = yeniBilgiler.Platform.ToString();
                            line[4] = yeniBilgiler.Algoritma.ToString();
                            line[5] = yeniBilgiler.AlgoritmaliSifre.ToString();
                            line[6] = yeniBilgiler.Email.ToString();
                        }

                        string updatedLine = string.Join("|", line);
                        satirlar.Add(updatedLine);
                    }
                }

                using (StreamWriter writer = new StreamWriter(dosyaYolu, false, Encoding.UTF8))
                {
                    foreach (string satir in satirlar)
                    {
                        writer.WriteLine(satir);
                    }
                }
            }

            MessageBox.Show("Veri güncellendi ve text dosyasına kaydedildi.");
        }
        public void SilTextDosyasindan(string dosyaYolu, int rowIndex)
        {

            var linesList = File.ReadAllLines(dosyaYolu).ToList();

            linesList.RemoveAt(rowIndex + 1);

            File.WriteAllLines(dosyaYolu, linesList.ToArray());

        }
        public List<KullaniciBilgileri> AraTextDosyasindan(string dosyaYolu, string hedefPlatform)
        {
            List<KullaniciBilgileri> bulunanKullanicilar = new List<KullaniciBilgileri>();

            if (File.Exists(dosyaYolu))
            {
                using (StreamReader reader = new StreamReader(dosyaYolu))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 7)
                        {
                            string platform = parts[3];
                            if (platform == hedefPlatform)
                            {
                                bulunanKullanicilar.Add(new KullaniciBilgileri
                                {
                                    Id = int.Parse(parts[0]),
                                    KullaniciAdi = parts[1],
                                    Sifre = parts[2],
                                    Platform = platform,
                                    Algoritma = parts[4],
                                    AlgoritmaliSifre = parts[5],
                                    Email = parts[6]
                                });
                            }
                        }
                    }
                }
            }
            return bulunanKullanicilar;
        }
    }
}