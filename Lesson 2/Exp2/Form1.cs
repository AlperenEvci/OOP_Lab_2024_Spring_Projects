using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab_Week2_Exp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private int[] GenerateFibonacciSeries(int numberOfTerms)
        {
            int[] fibonacciSeries = new int[numberOfTerms];
            fibonacciSeries[0] = 1;
            fibonacciSeries[1] = 1;

            for (int i = 2; i < numberOfTerms; i++)
            {
                fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            }

            return fibonacciSeries;
        }
        private double CalculateAverage(int[] numbers)
        {
            double sum = 0;
            for (int num = 0; num<numbers.Length;num++)
            {
                sum += numbers[num];
            }
            return sum / numbers.Length;
        }

        private bool IsNumeric(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(txtBoxArraySize.Text))
            {
                MessageBox.Show("Please Enter Only a Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxArraySize.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = 0;
            int.TryParse(txtBoxArraySize.Text, out number);
            if (number <= 45)
            {
                if (number == 0)
                {
                    MessageBox.Show("InValid Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxArraySize.Clear();
                }
                else if (number == 1)
                {
                    int[] lucasSeries = { 2 };
                    txtBoxFibonacciNumbers.Clear();
                    foreach (int term in lucasSeries)
                    {
                        txtBoxFibonacciNumbers.AppendText(term.ToString() + Environment.NewLine);
                    }

                    if (checkBoxAverage.Checked)
                    {
                        double average = CalculateAverage(lucasSeries);
                        lblAverage.Text = "AVERAGE: " + average.ToString("0.00");
                    }
                    else
                    {
                        lblAverage.Text = string.Empty;
                    }
                }
                else
                {
                    int[] lucasSeries = GenerateFibonacciSeries(number);
                    txtBoxFibonacciNumbers.Clear();
                    foreach (int term in lucasSeries)
                    {
                        txtBoxFibonacciNumbers.AppendText(term.ToString() + Environment.NewLine);
                    }

                    if (checkBoxAverage.Checked)
                    {
                        double average = CalculateAverage(lucasSeries);
                        lblAverage.Text = "AVERAGE: " + average.ToString("0.00");
                    }
                    else
                    {
                        lblAverage.Text = string.Empty;

                    }
                }
            }
            else
            {
                MessageBox.Show("Too Large Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxArraySize.Clear();
                txtBoxFibonacciNumbers.Clear();
            }

        }

        private void checkBoxAverage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAverage.Checked)
            {
                btnCalculate.Text = "Generate - Calculate";
            }
            else
            {
                btnCalculate.Text = "Generate";
            }
        }
    }
}
