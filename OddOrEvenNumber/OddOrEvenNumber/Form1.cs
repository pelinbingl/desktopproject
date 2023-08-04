using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddOrEvenNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text, out int sayi))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
                return;
            }

            string result = (sayi % 2 == 0) ? "The Number is even " : "The Number is odd";

            txtResult.Text = $"{result}";
        }
    }
}
