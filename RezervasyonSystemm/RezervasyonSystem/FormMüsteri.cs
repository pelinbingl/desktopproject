using Newtonsoft.Json.Converters;
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

namespace RezervasyonSystem
{
    public partial class FormMüsteri : Form
    {
        public FormMüsteri()
        {
            InitializeComponent();
        }
        Kayit kayit = new Kayit();
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bingl\OneDrive\Masaüstü\Staj\RezervasyonSystem\RezervasyonSystem\Database1.mdf;Integrated Security=True");
        private void RefreshDataGridView()
        {
            dataGridViewKayitlar.DataSource = kayit.GetAll();
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            dataGridViewKayitlar.ClearSelection();
            string arananAd = textBoxAranacakIsim.Text;
            List<Kayit> bulunanmusteri = kayit.Ara(arananAd);
            dataGridViewKayitlar.DataSource = bulunanmusteri;
 
        }
        private void buttonGeri_Click_1(object sender, EventArgs e)
        {
            FormAnasayfa formAnasayfa = new FormAnasayfa();
            formAnasayfa.Show();
            this.Hide();
        }

        private void dataGridViewKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewKayitlar.ClearSelection();
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0) // Satır seçildiğinden emin ol
            {
                DataGridViewRow selectedRow = dataGridViewKayitlar.Rows[e.RowIndex];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string surname = selectedRow.Cells["Surname"].Value.ToString();
                string cinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
                string telefon = selectedRow.Cells["Telefon"].Value.ToString();
                string mail = selectedRow.Cells["Mail"].Value.ToString();
                string tckimlik = selectedRow.Cells["TcKimlik"].Value.ToString();
                string odano = selectedRow.Cells["OdaNo"].Value.ToString();
                string ucret = selectedRow.Cells["Ucret"].Value.ToString();
                string giristarihi = (selectedRow.Cells["GirişTarihi"].Value).ToString();
                string çıkıştarihi = (selectedRow.Cells["ÇıkışTarihi"].Value).ToString();

                textBoxAd.Text = name;
                textBoxSoyad.Text = surname;
                comboBox1.Text = cinsiyet;
                textBoxTelefon.Text = telefon;
                textBoxMail.Text = mail;
                textBoxTc.Text = tckimlik;
                textBoxodano.Text = odano;
                textBoxUcret.Text = ucret;
                dateTimePickerGiris.Text = giristarihi;
                dateTimePickerCikis.Text = çıkıştarihi;
            }
        }

        private void FormMüsteri_Load_1(object sender, EventArgs e)
        {
            kayit.GetAll();
            RefreshDataGridView();
        }
        private void buttonTemizle_Click_1(object sender, EventArgs e)
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxTc.Clear();
            comboBox1.Text = null;
            textBoxTelefon.Clear();
            textBoxMail.Clear();
            textBoxodano.Clear();
            textBoxUcret.Clear();
            dateTimePickerCikis.Value= DateTime.Now;
            dateTimePickerGiris.Value= DateTime.Now;
            textBoxAranacakIsim.Clear();
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            kayit.Id = Convert.ToInt32(dataGridViewKayitlar.CurrentRow.Cells[0].Value);
            kayit.Sil(kayit);
            kayit.GetAll();
            MessageBox.Show("Kayıt Silindi!");
            RefreshDataGridView();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            kayit.Name = textBoxAd.Text;
            kayit.Surname = textBoxSoyad.Text;
            kayit.Cinsiyet = comboBox1.Text;
            kayit.Telefon = textBoxTelefon.Text;
            kayit.Mail = textBoxMail.Text;
            kayit.TcKimlik = textBoxTc.Text;
            kayit.OdaNo = textBoxodano.Text;
            kayit.GirişTarihi = DateTime.Parse(dateTimePickerGiris.Text); // Varsayılan tarih formatına dönüştürme
            kayit.ÇıkışTarihi = DateTime.Parse(dateTimePickerCikis.Text);
            kayit.Guncelleodano(kayit);
            RefreshDataGridView();
            //Güncelleme methoduna doldurduğun objeyi ve seçtiğin kaydın idsini yolla

            //Methodun içinde yazdığın sorguda id'si şu olan kaydın artık adı soyadı vs. bu şeklinde güncelle


            kayit.GetAll();
        }
    }
}

//SqlCommand sqlCommand = new SqlCommand("DELETE from MusteriKayit where Id=(" + id + ")", sqlConnection);
//SqlCommand komut = new SqlCommand("delete from MusteriKayit where id=(" + id + ")", baglanti);