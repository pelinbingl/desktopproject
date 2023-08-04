using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number;
        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.Enabled = true;
            Random rastgele = new Random();
            number= rastgele.Next(101);
            MessageBox.Show("I kept a number in my mind.");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(txtGuess.Text);
            if (guess < number) { MessageBox.Show("UP"); }
            else if (guess > number) { MessageBox.Show("DOWN"); }
            else if (guess == number) { MessageBox.Show("CONGRATULATIONS"); }
            txtGuess.Clear();
        }
    }
}
