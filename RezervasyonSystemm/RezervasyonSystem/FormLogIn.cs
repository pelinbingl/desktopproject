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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\bingl\OneDrive\Masaüstü\projeler\.Net Forms(C#)\RezervasyonSystem\RezervasyonSystem\Database1.mdf"";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
            }
        }

        private void Login()
        {
            cs.Open();
            string sql = "select * from AdminGiris where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre ";
            SqlParameter prm1 = new SqlParameter("KullaniciAdi", textBoxKullanıcıAd.Text.Trim());
            SqlParameter prm2 = new SqlParameter("Sifre", textBoxSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, cs);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
           
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FormAnasayfa formAnasayfa = new FormAnasayfa();
                formAnasayfa.Show();
                this.Hide();
            }
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            FormAnasayfa formAnasayfa = new FormAnasayfa();
            formAnasayfa.Show();
            this.Hide();
        }

        private void textBoxSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            textBoxSifre.UseSystemPasswordChar = true;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
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
