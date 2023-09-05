using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RezervasyonSystem
{
     class Kayit
     {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string TcKimlik { get; set; }
        public string OdaNo { get; set; }
        public int Ucret { get; set; }
        public DateTime  GirişTarihi { get; set; }
        public DateTime ÇıkışTarihi { get; set; }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\bingl\\OneDrive\\Masaüstü\\projeler\\.Net Forms(C#)\\RezervasyonSystem\\RezervasyonSystem\\Database1.mdf\";Integrated Security=True");
        public void Connect()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public List<Kayit> GetAll()
        {
            Connect();
            SqlCommand command = new SqlCommand("SELECT * FROM MusteriKayit", baglanti);
            SqlDataReader reader = command.ExecuteReader();
            List<Kayit> kullaniciBilgileris = new List<Kayit>();

            while (reader.Read())
            {
                Kayit musteri = new Kayit
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name= reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Mail = reader["Mail"].ToString(),
                    TcKimlik = reader["TcKimlik"].ToString(),
                    OdaNo = reader["OdaNo"].ToString(),
                    Ucret = Convert.ToInt32(reader["Ucret"]),
                    GirişTarihi = Convert.ToDateTime(reader["GirişTarihi"]),
                    ÇıkışTarihi = Convert.ToDateTime(reader["ÇıkışTarihi"])
                };

                kullaniciBilgileris.Add(musteri);
            }

            reader.Close();
            baglanti.Close();

            return kullaniciBilgileris;
        }
        public void Kaydet(Kayit kullanici)
        {
            Connect();
            kullanici.GirişTarihi = kullanici.GirişTarihi.Date.AddHours(12);
            kullanici.ÇıkışTarihi = kullanici.ÇıkışTarihi.Date.AddHours(12);
            SqlCommand command = new SqlCommand("INSERT INTO MusteriKayit VALUES(@Name,@Surname,@Cinsiyet,@Telefon,@Mail,@TcKimlik,@OdaNo,@Ucret,@GirişTarihi,@ÇıkışTarihi)", baglanti);
            command.Parameters.AddWithValue("@Name", kullanici.Name);
            command.Parameters.AddWithValue("@Surname", kullanici.Surname);
            command.Parameters.AddWithValue("@Cinsiyet", kullanici.Cinsiyet);
            command.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
            command.Parameters.AddWithValue("@Mail", kullanici.Mail);
            command.Parameters.AddWithValue("@TcKimlik", kullanici.TcKimlik);
            command.Parameters.AddWithValue("@OdaNo", kullanici.OdaNo);
            command.Parameters.AddWithValue("@Ucret", kullanici.Ucret);
            command.Parameters.AddWithValue("@GirişTarihi", kullanici.GirişTarihi);
            command.Parameters.AddWithValue("ÇıkışTarihi", kullanici.ÇıkışTarihi);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Guncelleodano(Kayit kullanici)
        {
            Connect();

            SqlCommand command = new SqlCommand("UPDATE MusteriKayit SET Name=@Name, Surname=@Surname,Cinsiyet =@Cinsiyet, Telefon=@Telefon,Mail=@Mail,TcKimlik=@TcKimlik,OdaNo=@OdaNo,Ucret=@Ucret,GirişTarihi=@GirişTarihi,ÇıkışTarihi=@ÇıkışTarihi  WHERE OdaNo = @OdaNo", baglanti);
            command.Parameters.AddWithValue("@Name", kullanici.Name);
            command.Parameters.AddWithValue("@Surname", kullanici.Surname);
            command.Parameters.AddWithValue("@Cinsiyet", kullanici.Cinsiyet);
            command.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
            command.Parameters.AddWithValue("@Mail", kullanici.Mail);
            command.Parameters.AddWithValue("@TcKimlik", kullanici.TcKimlik);
            command.Parameters.AddWithValue("@OdaNo", kullanici.OdaNo);
            command.Parameters.AddWithValue("@Ucret", kullanici.Ucret);
            command.Parameters.AddWithValue("@GirişTarihi", kullanici.GirişTarihi);
            command.Parameters.AddWithValue("ÇıkışTarihi", kullanici.ÇıkışTarihi);

            // Güncelleme işlemini gerçekleştir
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Müşteri bilgileri güncellendi.");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız oldu.");
            }
        }
        public void Guncelle(Kayit kullanici)
        {
            Connect();
            SqlCommand command = new SqlCommand("UPDATE MusteriKayit SET Name=@Name, Surname=@Surname,Cinsiyet =@Cinsiyet, Telefon=@Telefon,Mail=@Mail,TcKimlik=@TcKimlik,OdaNo=@OdaNo,Ucret=@Ucret,GirisTarihi=@GirisTarihi,ÇıkışTarihi=@ÇıkışTarihi  WHERE Id=@Id", baglanti);
            command.Parameters.AddWithValue("@Id", kullanici.Id);
            command.Parameters.AddWithValue("@Name", kullanici.Name);
            command.Parameters.AddWithValue("@Surname", kullanici.Surname);
            command.Parameters.AddWithValue("@Cinsiyet", kullanici.Cinsiyet);
            command.Parameters.AddWithValue("@Telefon", kullanici.Telefon);
            command.Parameters.AddWithValue("@Mail", kullanici.Mail);
            command.Parameters.AddWithValue("@TcKimlik", kullanici.TcKimlik);
            command.Parameters.AddWithValue("@OdaNo", kullanici.OdaNo);
            command.Parameters.AddWithValue("@Ucret", kullanici.Ucret);
            command.Parameters.AddWithValue("@GirişTarihi", kullanici.GirişTarihi);
            command.Parameters.AddWithValue("@ÇıkışTarihi", kullanici.ÇıkışTarihi);
           /**/ command.ExecuteNonQuery();

            baglanti.Close();
        }
        public void Sil(Kayit kullanici)
        {
            Connect();
            SqlCommand command = new SqlCommand("DELETE FROM MusteriKayit WHERE Id=@Id", baglanti);
            command.Parameters.AddWithValue("@Id", kullanici.Id);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
        public List<Kayit> Ara(string ad)
        {

            Connect();
            SqlCommand command = new SqlCommand("SELECT * FROM Musterikayit WHERE Name LIKE @Name", baglanti);
            command.Parameters.AddWithValue("@Name","%"+ad+"%");

            SqlDataReader reader = command.ExecuteReader();
            List<Kayit> bulunanmusteri = new List<Kayit>();

            while (reader.Read())
            {
                Kayit kullanicii = new Kayit()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    Telefon = reader["Telefon"].ToString(),
                    Mail = reader["Mail"].ToString(),
                    TcKimlik = reader["TcKimlik"].ToString(),
                    OdaNo = reader["OdaNo"].ToString(),
                    Ucret = Convert.ToInt32(reader["Ucret"]),
                    GirişTarihi = Convert.ToDateTime(reader["GiriŞTarihi"]),
                    ÇıkışTarihi = Convert.ToDateTime(reader["ÇıkışTarihi"])
                };

                bulunanmusteri.Add(kullanicii);
            }

            reader.Close();
            baglanti.Close();

            return bulunanmusteri;

        }
    }
}
