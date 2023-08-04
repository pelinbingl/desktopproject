using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combobxOperatorSymbol.Items.AddRange(new object[] {"+", "-","*", "/"});
        }
        private void combobxOperatorSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = combobxOperatorSymbol.SelectedItem.ToString();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber1.Text, out double num1) && double.TryParse(txtNumber2.Text, out double num2) && combobxOperatorSymbol.SelectedItem != null)
            {
                string operatorSymbol = combobxOperatorSymbol.SelectedItem.ToString();
                double sonuc = 0;
                switch (operatorSymbol)
                {
                    case "+":
                        sonuc = num1 + num2;
                        break;
                    case "-":
                        sonuc = num1 - num2;
                        break;
                    case "*":
                        sonuc = num1 * num2;
                        break;
                    case "/":
                        // Bölme işlemi yaparken 0'a bölünmeyi kontrol edin
                        if (num2 != 0)
                            sonuc = num1 / num2;
                        else
                            MessageBox.Show("Bir sayıyı 0'a bölemezsiniz!");
                        break;
                }
                txtResult.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Geçersiz girişler! Lütfen sayıları ve işlem sembolünü doğru bir şekilde girin.");
            }

        }

       
    }
}
