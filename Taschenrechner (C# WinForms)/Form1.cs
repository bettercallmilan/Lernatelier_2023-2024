using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taschenrechner2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button17.TabStop = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 7
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 8
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 9
            textBox1.Text += button3.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // /
            textBox1.Text += button15.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6
            textBox1.Text += button6.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // *
            textBox1.Text += button14.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // 1
            textBox1.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 2
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 3
            textBox1.Text += button10.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // -
            textBox1.Text += button13.Text;
        }

        private void Berechnen()
        {
            // =
            string input = textBox1.Text;
            char[] operators = { '+', '-', '*', '/' };
            double ergebnis = 0;

            foreach (char op in operators)
            {
                string[] zahlStrings = input.Split(op);

                if (zahlStrings.Length == 2 && double.TryParse(zahlStrings[0], out double zahl1) && double.TryParse(zahlStrings[1], out double zahl2))
                {
                    switch (op)
                    {
                        case '+':
                            ergebnis = zahl1 + zahl2;
                            break;
                        case '-':
                            ergebnis = zahl1 - zahl2;
                            break;
                        case '*':
                            ergebnis = zahl1 * zahl2;
                            break;
                        case '/':
                            if (zahl2 != 0)
                            {
                                ergebnis = zahl1 / zahl2;
                            }
                            else
                            {
                                Console.WriteLine("Division durch Null ist nicht möglich.");
                            }
                            break;
                    }

                    textBox1.Text = ergebnis.ToString();
                    break;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Berechnen();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 0
            textBox1.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // .
            textBox1.Text += button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // +
            textBox1.Text += button9.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Berechnen();
                e.Handled = true;
            } 
            else if (e.KeyChar == (char)Keys.X)
            {
                textBox1.Text = "";
            }
        }
    }
}
