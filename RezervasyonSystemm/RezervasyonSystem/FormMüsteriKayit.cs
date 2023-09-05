using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Button = System.Windows.Forms.Button;
using Microsoft.Ajax.Utilities;

namespace RezervasyonSystem
{
    public partial class FormMüsteriKayit : Form
    {
        Kayit kayit = new Kayit();
        decimal totalFee = 0;
        decimal nightlyRate = 600;
        private void dateTimePickerCikis_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime checkInDate = dateTimePickerGiris.Value;
            DateTime checkOutDate = dateTimePickerCikis.Value;

            int totalDays = (int)(checkOutDate - checkInDate).TotalDays;
            totalFee = totalDays * nightlyRate;
            textBoxUcret.Text = $"{totalFee}";
        }
        public FormMüsteriKayit()
        {
            InitializeComponent();
        }
  
        private void FormMüsteriKayit_Load(object sender, EventArgs e)
        {
            buttonKayıtet.Text = "KAYDET";
            odaolustur();
            kayit.GetAll();
        }
        private void odaolustur()
        {
            int oda = 0;
            int mesafe = 0;
            int x = -30;
            for (int i = 1; i < 5; i++)
            {
                oda = oda + 100;
                mesafe = mesafe + 65;
                for (int j = 1; j < 5; j++)
                {
                    Button button = new Button
                    {
                        Text = (oda + j).ToString(),
                        Location = new System.Drawing.Point(j * 65 + x, mesafe),
                        Height = 55,
                        Width = 55,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    using (SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\bingl\\OneDrive\\Masaüstü\\projeler\\.Net Forms(C#)\\RezervasyonSystem\\RezervasyonSystem\\Database1.mdf\";Integrated Security=True"))
                    {
                        baglanti.Open();
                        string sorgu = "SELECT [GirişTarihi],[ÇıkışTarihi] FROM MusteriKayit WHERE [OdaNo] = @Deger";
                        using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                        {
                            command.Parameters.AddWithValue("@Deger", oda + j);
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                DateTime today = DateTime.Now;
                                DateTime girişTarihi = Convert.ToDateTime(reader["GirişTarihi"]);
                                DateTime çıkışTarihi = Convert.ToDateTime(reader["ÇıkışTarihi"]);
                                girişTarihi = girişTarihi.Date.AddHours(12);
                                çıkışTarihi = çıkışTarihi.Date.AddHours(12);

                                if ((today >= girişTarihi && today <= çıkışTarihi))
                                {
                                    button.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                button.BackColor = Color.RoyalBlue;
                            }
                            button.Click += Button_Click;
                            groupBoxRooms.Controls.Add(button);
                            reader.Close();
                        }
                    }
                }
            }
        }
        int selectedCustomerId;
        //butona tıkladığında odabilgilerini getir
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int clickedRoomNumber = int.Parse(clickedButton.Text);
            textBoxodano.Text = clickedRoomNumber.ToString();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\bingl\\OneDrive\\Masaüstü\\projeler\\.Net Forms(C#)\\RezervasyonSystem\\RezervasyonSystem\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM MusteriKayit WHERE [OdaNo] = @roomNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomNumber", clickedRoomNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxAd.Text = reader["Name"].ToString();
                            textBoxSoyad.Text = reader["Surname"].ToString();
                            comboBoxCinsiyet.SelectedItem = reader["Cinsiyet"].ToString();
                            textBoxTelefon.Text = reader["Telefon"].ToString();
                            textBoxMail.Text = reader["Mail"].ToString();
                            textBoxTc.Text = reader["TcKimlik"].ToString();
                            textBoxUcret.Text = reader["Ucret"].ToString();
                            dateTimePickerGiris.Value = Convert.ToDateTime(reader["GirişTarihi"]);
                            dateTimePickerCikis.Value = Convert.ToDateTime(reader["ÇıkışTarihi"]);
                            int selectedCustomerId = Convert.ToInt32(reader["Id"]);
                            buttonKayıtet.Text = "GÜNCELLE";
                        }
                    }
                }
                connection.Close();
            }
        }
        private void buttonGeri_Click(object sender, EventArgs e)
        {
            FormAnasayfa formAnasayfa = new FormAnasayfa();
            formAnasayfa.Show();
            this.Close();
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            FormMüsteriKayit formMüsteri = new FormMüsteriKayit();
            formMüsteri.Show();
            this.Hide();
        }

        

        //Oda bilgisi doluysa odayı günceller boşsa odaya birini kaydeder
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if(buttonKayıtet.Text=="GÜNCELLE")
            {
                //kayit.Id = selectedCustomerId;
                //kayit.Id = Convert.ToInt32(dataGridViewKayitlar.CurrentRow.Cells[0].Value);
                kayit.Name = textBoxAd.Text;
                kayit.Surname = textBoxSoyad.Text;
                kayit.Cinsiyet = comboBoxCinsiyet.Text;
                kayit.Telefon = textBoxTelefon.Text;
                kayit.Mail = textBoxMail.Text;
                kayit.TcKimlik = textBoxTc.Text;
                kayit.OdaNo = textBoxodano.Text;
                kayit.GirişTarihi = DateTime.Parse(dateTimePickerGiris.Text); // Varsayılan tarih formatına dönüştürme
                kayit.ÇıkışTarihi = DateTime.Parse(dateTimePickerCikis.Text);
                kayit.Guncelleodano(kayit);
                //Güncelleme methoduna doldurduğun objeyi ve seçtiğin kaydın idsini yolla

                //Methodun içinde yazdığın sorguda id'si şu olan kaydın artık adı soyadı vs. bu şeklinde güncelle


                kayit.GetAll();
            }
            else
            {
                kayit.Name = textBoxAd.Text;
                kayit.Surname = textBoxSoyad.Text;
                kayit.Cinsiyet = comboBoxCinsiyet.Text;
                kayit.Telefon = textBoxTelefon.Text;
                kayit.Mail = textBoxMail.Text;
                kayit.TcKimlik = textBoxTc.Text;
                kayit.OdaNo = textBoxodano.Text;
                /**/
                // kayit.Ucret = Convert.ToInt32(textBoxUcret.Text);
                kayit.GirişTarihi = DateTime.Parse(dateTimePickerGiris.Text); // Varsayılan tarih formatına dönüştürme
                kayit.ÇıkışTarihi = DateTime.Parse(dateTimePickerCikis.Text); // Varsayılan tarih formatına dönüştürme
                DateTime bugününtarihi = DateTime.Now.Date;
                if (kayit.GirişTarihi != kayit.ÇıkışTarihi && kayit.GirişTarihi < kayit.ÇıkışTarihi && kayit.GirişTarihi >= bugününtarihi)
                {
                    if (kayit.GirişTarihi.Date != kayit.ÇıkışTarihi.Date)
                    {
                        kayit.Ucret = Convert.ToInt32(textBoxUcret.Text);
                        kayit.Kaydet(kayit);
                        kayit.GetAll();
                        MessageBox.Show("Kayıt Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Giriş tarihi ve çıkış tarihi aynı gün olamaz!");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz giriş veya çıkış tarihi!");
                }

            }
        }

        private void FormMüsteriKayit_Click(object sender, EventArgs e)
        {
            buttonKayıtet.Text = "KAYDET";
        }
    }
}
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bingl\OneDrive\Masaüstü\Staj\RezervasyonSystem\RezervasyonSystem\Database1.mdf;Integrated Security=True
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bingl\OneDrive\Masaüstü\Staj\RezervasyonSystem\RezervasyonSystem\Database1.mdf;Integrated Security=True
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bingl\OneDrive\Masaüstü\Staj\RezervasyonSystem\RezervasyonSystem\Database1.mdf;Integrated Security=True