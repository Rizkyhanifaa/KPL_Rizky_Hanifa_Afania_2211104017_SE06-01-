using System;
using System.Windows.Forms;

namespace modul12_2211104017
{
    public partial class Form1 : Form
    {
        private readonly PangkatCalculator _calculator;

        public Form1()
        {
            InitializeComponent();
            _calculator = new PangkatCalculator(); // Menggunakan PangkatCalculator
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                int result = _calculator.CariNilaiPangkat(a, b);

                switch (result)
                {
                    case -1:
                        labelHasil.Text = "Hasil: " + result;
                        break;
                    case -2:
                        labelHasil.Text = "Hasil: " + result;
                        break;
                    case -3:
                        labelHasil.Text = "Hasil: " + result;
                        break;
                    default:
                        labelHasil.Text = "Hasil: " + result;
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input tidak valid. Masukkan angka saja.");
            }
        }
    }
}
