using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double num1;
        string oper;
        int i;
        string[] num = new string[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_num(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double num2;
            if (i == 1)
            {
                num2 = Convert.ToDouble(num[0]) + Convert.ToDouble(num[1]) / Math.Pow(10, Convert.ToDouble(num[1].Length));
            }
            else
            {
                num2 = Convert.ToDouble(textBox1.Text);
            }
            switch (oper)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 += num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 -= num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 *= num2);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(num1 /= num2);
                    break;
            }
            oper = null;
            i = 0;
        }

        private void btn_Oper(object sender, EventArgs e)
        {
            if (i == 1)
            {
                num1 = Convert.ToDouble(num[0]) + Convert.ToDouble(num[1]) / Math.Pow(10, Convert.ToDouble(num[1].Length));
            }
            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
            }
            oper = ((Button)sender).Text;
            i = 0;
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
