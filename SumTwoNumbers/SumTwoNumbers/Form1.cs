using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int num1) && int.TryParse(txtNumber2.Text, out int num2))
            {
                int result = num1 + num2;
                txtResult.Text = result.ToString();
                //MessageBox.Show($"{result}");
            }
            else
            {
                MessageBox.Show("Geçerli sayılar giriniz!");
            }

        }
    }
}
