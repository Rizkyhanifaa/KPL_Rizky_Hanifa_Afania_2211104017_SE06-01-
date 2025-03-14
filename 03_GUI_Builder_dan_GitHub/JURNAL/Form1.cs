using System;
using System.Windows.Forms;

namespace jurnal_modul3
{
    public partial class Form1 : Form
    {
        private string input = "";
        private int firstNumber = 0;
        private int secondNumber = 0;
        private bool isSecondNumber = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;

            if (isSecondNumber)
            {
                lblOutput.Text = firstNumber + " + " + input; 
            }
            else
            {
                lblOutput.Text = input; 
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out firstNumber))
                {
                    isSecondNumber = true;
                    input = ""; 
                    lblOutput.Text = firstNumber + " + "; 
                }
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (isSecondNumber && !string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out secondNumber))
                {
                    int result = firstNumber + secondNumber;
                    lblOutput.Text = firstNumber + " + " + secondNumber + " = " + result;
                    input = result.ToString(); 
                    isSecondNumber = false; 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}

