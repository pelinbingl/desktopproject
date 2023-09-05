using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSystem
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMüsteriKayit formMüsteriKayit=new FormMüsteriKayit();   
            formMüsteriKayit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogIn form1 = new FormLogIn();
            form1.Show();
            this.Hide();
            
        }

        private void buttonMusteriler_Click(object sender, EventArgs e)
        {
            FormMüsteri formMüsteri = new FormMüsteri();
            formMüsteri.Show();
            this.Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
        }

        private void buttonCikis_Click_1(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı kapat
            }
            else
            {
                FormAnasayfa formAnasayfa= new FormAnasayfa(); 
                formAnasayfa.Show();
                this.Hide();
            }
        }
    }
}
