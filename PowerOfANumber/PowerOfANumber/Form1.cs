using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerOfANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string numberText = txtNumber.Text;
            string powerText = txtPower.Text;
            if (string.IsNullOrWhiteSpace(numberText) || string.IsNullOrWhiteSpace(powerText)) //boş olup olmadığını kontrol ediyor
            {
                MessageBox.Show("Please enter a number and exponent value.");
                return;
            }

            if (!double.TryParse(numberText, out double sayi) || !int.TryParse(powerText, out int kuvvet))  //use double ifade girersek bu dönecek
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }
            /*
          
              Math.Pow(number,power)
            */

            double result = Math.Pow(sayi, kuvvet);
            txtResult.Text = $"{result}";
        }
    }
}
