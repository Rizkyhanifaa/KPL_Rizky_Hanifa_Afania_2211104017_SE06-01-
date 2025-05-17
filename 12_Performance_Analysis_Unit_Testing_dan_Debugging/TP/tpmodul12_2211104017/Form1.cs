using System;
using System.Windows.Forms;

namespace tpmodul12_2211104017
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(textBoxInput.Text, out input))
            {
                labelOutput.Text = BilanganHelper.CariTandaBilangan(input);
            }
            else
            {
                labelOutput.Text = "Input tidak valid";
            }
        }
    }
}
