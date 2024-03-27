using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120211124_Lab_Exp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] GenerateLucasSeries(int numberOfTerms)
        {
            int[] lucasSeries = new int[numberOfTerms];
            lucasSeries[0] = 2;
            lucasSeries[1] = 1;

            for (int i = 2; i < numberOfTerms; i++)
            {
                lucasSeries[i] = lucasSeries[i - 1] + lucasSeries[i - 2];
            }

            return lucasSeries;
        }
        private double CalculateAverage(int[] numbers)
        {
            double sum = 0;
            for (int num = 0; num < numbers.Length; num++)
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

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            
    
            int number = 0;            
            int.TryParse(txtBoxArraySize.Text, out number);
            if(number <= 45)
            {
                if (number == 0)
                {
                    MessageBox.Show("InValid Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxArraySize.Clear();                    
                }
                else if (number == 1)
                {
                    int[] lucasSeries = { 2 };
                    txtBoxLucasNumbers.Clear();
                    foreach (int term in lucasSeries)
                    {
                        txtBoxLucasNumbers.AppendText(term.ToString() + Environment.NewLine);
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
                    int[] lucasSeries = GenerateLucasSeries(number);
                    txtBoxLucasNumbers.Clear();
                    foreach (int term in lucasSeries)
                    {
                        txtBoxLucasNumbers.AppendText(term.ToString() + Environment.NewLine);
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
                txtBoxLucasNumbers.Clear();
            }    
        }

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.LightGray;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
        }

        private void txtBoxArraySize_TextChanged_1(object sender, EventArgs e)
        {
            if (!IsNumeric(txtBoxArraySize.Text))
            {
                MessageBox.Show("Please Enter Only a Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxArraySize.Clear();                
            }
        }

        private void checkBoxAverage_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAverage.Checked)
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
