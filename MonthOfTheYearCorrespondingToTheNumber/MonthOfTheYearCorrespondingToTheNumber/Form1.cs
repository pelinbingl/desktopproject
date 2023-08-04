using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthOfTheYearCorrespondingToTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string monthNumberText = txtNumber.Text;
            if (!string.IsNullOrWhiteSpace(monthNumberText) && int.TryParse(monthNumberText, out int monthNumber))
            {
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    string MonthName = months[monthNumber - 1];
                    txtMonth.Text = $" {MonthName}";
                }
                else
                {
                    MessageBox.Show("Enter a valid month number (1-12).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
