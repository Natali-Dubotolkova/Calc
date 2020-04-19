using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Practice6
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public char c;
        public double proportion = 380 / 260;
        public Form1()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            KeyPreview = true;
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D1) || (e.KeyValue == (char)Keys.NumPad1)) button1_Click(button1, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D2) || (e.KeyValue == (char)Keys.NumPad2)) button2_Click(button2, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D3) || (e.KeyValue == (char)Keys.NumPad3)) button3_Click(button3, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D4) || (e.KeyValue == (char)Keys.NumPad4)) button4_Click(button4, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D5) || (e.KeyValue == (char)Keys.NumPad5)) button5_Click(button5, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D6) || (e.KeyValue == (char)Keys.NumPad6)) button6_Click(button6, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D7) || (e.KeyValue == (char)Keys.NumPad7)) button7_Click(button7, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D8) || (e.KeyValue == (char)Keys.NumPad8)) button8_Click(button8, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D9) || (e.KeyValue == (char)Keys.NumPad9)) button9_Click(button9, null); };
            KeyDown += (s, e) => { if ((e.KeyValue == (char)Keys.D0) || (e.KeyValue == (char)Keys.NumPad0)) button15_Click(button15, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Add) button10_Click(button10, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Subtract) button11_Click(button11, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Multiply) button12_Click(button12, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Divide) button13_Click(button13, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Decimal) button14_Click(button14, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.OemPeriod) button14_Click(button14, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Back) button16_Click(button16, null); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.A) button17_Click(button17, null); };
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "1";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "1";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "2";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "2";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "3";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "3";
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "4";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "4";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "5";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "5";
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "6";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "6";
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "7";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "7";
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "8";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "8";
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "9";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "9";
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox_Result.Text += "0";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox_Result.Text);
            c = '+';
            textBox_Result.Text += " + "; 
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox_Result.Text);
            c = '-';
            textBox_Result.Text += " - ";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox_Result.Text);
            c = '*';
            textBox_Result.Text += " * ";

        }
        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox_Result.Text);
            c = '/';
            textBox_Result.Text += " / ";
        }
        private void button17_Click(object sender, EventArgs e)
        {
        
            b = Convert.ToDouble(textBox_Result.Text.Split(' ')[2]);
            

            switch (c)
            {
                case '+':
                    textBox_Result.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    textBox_Result.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    textBox_Result.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    if (b == 0) 
                    {
                        textBox_Result.Text = "Cannot divide by zero";
                    }
                    else textBox_Result.Text = Convert.ToString(a / b);
                    break;

            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "";
            a = 0;
            b = 0;
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox_Result.Text += ",";
        }
        private void textBox_Result_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
