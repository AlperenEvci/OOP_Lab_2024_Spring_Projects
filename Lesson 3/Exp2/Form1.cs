using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Week3_Exp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;            
        }
        
        public static void Encipher(char[] input, int key, out bool success, Label succesLabel, out string encryptedMessage)
        {
            encryptedMessage = string.Empty;
            if (input.Length < 2)
            {
                success = false;
                succesLabel.Text = "FAILED";                
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                Cipher(ref ch, key);
                encryptedMessage += ch;
            }
            success = true;
            succesLabel.Text = "SUCCESS";
            
        }

        public static void Cipher(ref char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            ch = (char)((ch + key - d) % 26 + d);
        }
        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (radioButton2.Checked)
            {
                char[] input = textBox1.Text.ToCharArray();
                bool success;
                string encryptedMessage;

                if(!int.TryParse(textBox2.Text, out number))
                {
                    number = 1;
                }                

                Encipher(input, number, out success, label3, out encryptedMessage);
                if (success)
                {
                    label3.BackColor = Color.Green;
                    label4.Text = "CIPHER:  " + encryptedMessage;
                }
                else
                {
                    label3.BackColor = Color.Red;
                    label4.Text = "";
                }
            }
            else
            {
                char[] input = textBox1.Text.ToCharArray();
                bool success;
                string encryptedMessage;                
                Encipher(input, 2, out success, label3, out encryptedMessage);
                if (success)
                {
                    label3.BackColor = Color.Green;
                    label4.Text = "CIPHER:  " + encryptedMessage;
                }
                else
                {
                    label3.BackColor = Color.Red;
                    label4.Text = "";
                }
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide";
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                checkBox1.Text = "Show";
            }
        }
    }
}
