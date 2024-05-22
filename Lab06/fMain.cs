using System;
using System.Windows.Forms;

namespace Lab06
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!"; 
                tbX1X2.Text = "Не введено даних!"; return;
            }

            try
            {
                double x1 = double.Parse(tbX1.Text); double x2 = double.Parse(tbX2.Text);

                double y = x1 * x2;
                double average = (x1 + x2) / 2;

                tbY.Text = y.ToString("0.######");
                tbX1X2.Text = average.ToString("0.####");
            }
            catch (FormatException)
            {
                tbY.Text = "Некоректні дані!";
                tbX1X2.Text = "Некоректні дані!";
            }           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbX1X2.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
