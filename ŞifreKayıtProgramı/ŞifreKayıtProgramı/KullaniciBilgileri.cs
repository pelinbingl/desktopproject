using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞifreKayıtProgramı
{
    class KullaniciBilgileri
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Platform { get; set; }
        public string Algoritma { get; set; }
        public string AlgoritmaliSifre { get; set; }
        public string Email { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\bingl\\OneDrive\\Masaüstü\\projeler\\.Net Forms(C#)\\ŞifreKayıtProgramı\\ŞifreKayıtProgramı\\Database1.mdf\";Integrated Security=True");

        public void Connect()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public List<KullaniciBilgileri> GetAll()
        {
            Connect();
            SqlCommand command = new SqlCommand("SELECT * FROM KullaniciBilgileri", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            List<KullaniciBilgileri> kullaniciBilgileris = new List<KullaniciBilgileri>();

            while (reader.Read())
            {
                KullaniciBilgileri kullanici = new KullaniciBilgileri
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Platform = reader["Platform"].ToString(),
                    Algoritma = reader["Algoritma"].ToString(),
                    AlgoritmaliSifre = reader["AlgoritmalıSifre"].ToString(),
                    Email = reader["Email"].ToString()
                };

                kullaniciBilgileris.Add(kullanici);
            }

            reader.Close();
            baglanti.Close();

            return kullaniciBilgileris;
        }
        public void Kaydet(KullaniciBilgileri kullanici)
        {
            Connect();
            SqlCommand command = new SqlCommand("INSERT INTO KullaniciBilgileri VALUES(@KullaniciAdi,@Sifre,@platform,@Algoritma,@AlgoritmalıSifre,@Email)", baglanti);
            command.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
            command.Parameters.AddWithValue("@Platform", kullanici.Platform);
            command.Parameters.AddWithValue("@Algoritma", kullanici.Algoritma);
            command.Parameters.AddWithValue("@AlgoritmalıSifre", kullanici.AlgoritmaliSifre);
            command.Parameters.AddWithValue("@Email", kullanici.Email);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Guncelle(KullaniciBilgileri kullanici)
        {
            Connect();
            SqlCommand command = new SqlCommand("UPDATE KullaniciBilgileri SET KullaniciAdi=@KullaniciAdi, Sifre=@Sifre, Platform=@Platform, Algoritma=@Algoritma,AlgoritmalıSifre=@AlgoritmalıSifre WHERE Id=@Id", baglanti);
            command.Parameters.AddWithValue("@Id", kullanici.Id);
            command.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
            command.Parameters.AddWithValue("@Platform", kullanici.Platform);
            command.Parameters.AddWithValue("@Algoritma", kullanici.Algoritma);
            command.Parameters.AddWithValue("@AlgoritmalıSifre", kullanici.AlgoritmaliSifre);
            command.Parameters.AddWithValue("@Email", kullanici.Email);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Sil(KullaniciBilgileri kullanici)
        {
            Connect();
            SqlCommand command = new SqlCommand("DELETE FROM KullaniciBilgileri WHERE Id=@Id", baglanti);
            command.Parameters.AddWithValue("@Id", kullanici.Id);

            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public List<KullaniciBilgileri> Ara(string platform)
        {

            Connect();
            SqlCommand command = new SqlCommand("SELECT * FROM KullaniciBilgileri WHERE Platform LIKE @Platform", baglanti);
            command.Parameters.AddWithValue("@Platform", "%" + @Platform + "%");

            SqlDataReader reader = command.ExecuteReader();
            List<KullaniciBilgileri> bulunanKullanicilar = new List<KullaniciBilgileri>();

            while (reader.Read())
            {
                KullaniciBilgileri kullanicii = new KullaniciBilgileri()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Platform = reader["Platform"].ToString(),
                    Algoritma = reader["Algoritma"].ToString(),
                    AlgoritmaliSifre = reader["AlgoritmalıSifre"].ToString(),
                    Email = reader["Email"].ToString(),
                };

                bulunanKullanicilar.Add(kullanicii);
            }

            reader.Close();
            baglanti.Close();

            return bulunanKullanicilar;

        }
    }
}