using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double variable, variable2, result;
        string sign;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out variable2))
                variable2 = double.Parse(textBox1.Text);
            else
                variable2 = 0;
                textBox1.Text = "";
            
            switch (sign)
            {

                case "+":
                    textBox1.Text = (variable + variable2).ToString();                    
                    break;

                case "-":
                    textBox1.Text = (variable - variable2).ToString();
                    break;

                case "/":
                    if (variable2==0)
                    {
                        textBox1.Text = "Nie dzielimy przez zero!";
                    }
                    else
                    {
                        textBox1.Text = ((double)variable / variable2).ToString();
                    }
                    break;

                case "*":
                    textBox1.Text = (variable * variable2).ToString();
                    break;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out result))
                variable = double.Parse(textBox1.Text);
            else
                variable = 0;

            sign = "+";
            textBox1.Text = "";  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out result))
                variable = double.Parse(textBox1.Text);
            else
                variable = 0;

            sign = "-";
            textBox1.Text = "";            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out result))
                variable = double.Parse(textBox1.Text);
            else
                variable = 0;

            sign = "*";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out result))
                variable = double.Parse(textBox1.Text);
            else
                variable = 0;

            sign = "/";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int textLength = textBox1.Text.Length;
            if (textLength > 0)
                textBox1.Text = textBox1.Text.Substring(0, textLength - 1);
        }
    }
}
