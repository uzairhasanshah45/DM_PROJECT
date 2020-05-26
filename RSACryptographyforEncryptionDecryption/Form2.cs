using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSACryptographyforEncryptionDecryption
{
    public partial class Form2 : Form
    {
        public double n,e;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            encryptionanddecryption en = new encryptionanddecryption();
            calculations c = new calculations();
            keys k = new keys();

            /*if (richTextBox3.Text != "" && richTextBox4.Text != "")
            {
                
            }
            else
            {
                MessageBox.Show("Please enter the fields");
            }*/

            c.primeNumbers();
            c.calculatingN();
            c.totient();
            c.Key((Convert.ToDouble(comboBox1.Text)), richTextBox3.Text);
            c.checkingGCD();
            c.calculateD();

            double[] encryptedtext = c.encrpt();

            string[] decryptetext = c.dcrptn(encryptedtext);

            for (int i = 0; i < decryptetext.Length; i++)
            {
                richTextBox2.Text += decryptetext[i].ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryptionanddecryption en = new encryptionanddecryption();
            calculations c = new calculations();
            keys k = new keys();

            

            if (richTextBox3.Text != "" && comboBox1.Text != "")
            {
                c.Key((Convert.ToDouble(comboBox1.Text)),richTextBox3.Text);
                c.primeNumbers();
                n = c.calculatingN();
                c.totient();
                this.e = c.checkingGCD();
                richTextBox5.Text = this.n + "," + this.e;

                double[] encryptedtext = c.encrpt();

                for (int i = 0; i < encryptedtext.Length; i++)
                {
                    richTextBox1.Text += encryptedtext[i].ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter the fields");
            }
           
            
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = string.Empty;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("7");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
