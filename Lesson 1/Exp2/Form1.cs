using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _152120211106_Exp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsAlphaNumeric(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Red;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void btnSub_MouseEnter(object sender, EventArgs e)
        {
            btnSub.ForeColor = Color.Red;
        }

        private void btnSub_MouseLeave(object sender, EventArgs e)
        {
            btnSub.ForeColor = Color.Black;
        }

        private void btnMulti_MouseEnter(object sender, EventArgs e)
        {
            btnMulti.ForeColor = Color.Red;
        }

        private void btnDiv_MouseEnter(object sender, EventArgs e)
        {
            btnDiv.ForeColor = Color.Red;
        }

        private void btnMulti_MouseLeave(object sender, EventArgs e)
        {
            btnMulti.ForeColor = Color.Black;
        }

        private void btnDiv_MouseLeave(object sender, EventArgs e)
        {
            btnDiv.ForeColor = Color.Black;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphaNumeric(txt1.Text))
            {
                MessageBox.Show("Number must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Clear();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphaNumeric(txt2.Text))
            {
                MessageBox.Show("Number must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt2.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string input1 = txt1.Text;
            string input2 = txt2.Text;

            int number1,number2;
            int.TryParse(input1, out number1);
            int.TryParse(input2, out number2);

            if ((number1 + number2) < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text += number1 + number2;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text += number1 + number2;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string input1 = txt1.Text;
            string input2 = txt2.Text;

            int number1, number2;
            int.TryParse(input1, out number1);
            int.TryParse(input2, out number2);

            if ((number1 - number2) < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text += number1 - number2;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text += number1 - number2;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string input1 = txt1.Text;
            string input2 = txt2.Text;

            int number1, number2;
            int.TryParse(input1, out number1);
            int.TryParse(input2, out number2);

            if((number1 * number2) < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text += number1 * number2;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text += number1 * number2;
            }
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string input1 = txt1.Text;
            string input2 = txt2.Text;

            int number1, number2;
            int.TryParse(input1, out number1);
            int.TryParse(input2, out number2);

            if ((number1 / number2) < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text += number1 / number2;
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text += number1 / number2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            lblResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
    }
}
