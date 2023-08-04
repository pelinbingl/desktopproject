using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            progressPercent.Value = 0;
            UpdateText();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            progressPercent.Value = Math.Max(progressPercent.Value - 10, progressPercent.Minimum);
            UpdateText();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            progressPercent.Value = Math.Min(progressPercent.Value + 10, progressPercent.Maximum);
            UpdateText();
        }
        private void UpdateText()
        {
            int percentage = (progressPercent.Value - progressPercent.Minimum) * 100 / (progressPercent.Maximum - progressPercent.Minimum);
            txtPercent.Text = $"%{percentage}";
            lblPercent.Text = $"%{percentage}";
        }


    }
}
