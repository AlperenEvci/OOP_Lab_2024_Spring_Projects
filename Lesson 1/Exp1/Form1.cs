using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120211124_Lab_Exp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsAlphabetic(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(textBox1.Text) || textBox2.Text.Length == 10)
            {
                MessageBox.Show("First and last names should consist of only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsAlphabetic(textBox2.Text) || textBox2.Text.Length == 10)
            {
                MessageBox.Show("First and last names should consist of only letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
            }
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                lbl3.Text = textBox1.Text + " " + textBox2.Text;
            }
            else
            {
                MessageBox.Show("UserName or Surname is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }

        bool flag1 = true;
        private void btn2_Click(object sender, EventArgs e)
        {
            lbl3.Text = "";
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (flag1)
                {
                    lbl3.Text = textBox2.Text + " " + textBox1.Text;
                    flag1 = false;
                }
                else
                {
                    lbl3.Text = textBox1.Text + " " + textBox2.Text;
                    flag1 = true;
                }
            }
            else
            {
                MessageBox.Show("UserName or Surname is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        bool flag2 = true;

        private void btn3_Click(object sender, EventArgs e)
        {            

            if (flag2)
            {
                lbl3.ForeColor = Color.Red;
                flag2 = false;
            }
            else
            {
                lbl3.ForeColor = Color.Black;
                flag2 = true;
            }
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbl3.Font = new Font("Verdana", 15, FontStyle.Bold); ;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;
        }
    }
}
