using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation = '+';
        int counter = 0;
        double result = 0.0;

        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Calculate(string inputnew, double resultnew, out double resultn, out int countern )

        {
            operand1 = inputnew;
            double num1;
            double.TryParse(operand1, out num1);

            if (operation == '+')

            {
                resultnew = num1 + resultnew;
                textBox1.Text = resultnew.ToString();
                counter++;
            }

            else if (operation == '-')

            {
                if (counter == 0)
                {
                    resultnew = num1;
                    textBox1.Text = resultnew.ToString();
                    counter++;
                }
                else
                {
                    resultnew = resultnew - num1;
                    textBox1.Text = resultnew.ToString();
                    counter++;
                }


            }

            else if (operation == '*')
            {
                if (counter == 0)
                {
                    resultnew = num1;
                    textBox1.Text = resultnew.ToString();
                    counter++;
                }
                else
                {
                    resultnew = resultnew * num1;
                    textBox1.Text = resultnew.ToString();
                    counter++;
                }

            }

            else if (operation == '/')
            {
                if (counter == 0)
                {
                    resultnew = num1;
                    textBox1.Text = resultnew.ToString();
                    counter++;
                }
                else
                {
                    if (num1 == 0)
                    {
                        textBox1.Text = resultnew.ToString() + '/' + num1.ToString();
                        counter++;
                    }

                    else
                    {
                        resultnew = resultnew / num1;
                        textBox1.Text = resultnew.ToString();
                        counter++;

                    }


                }

            }

            resultn = resultnew;
            countern = counter;
                        

        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text = input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text = input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text = input;
        }


        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text = input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text = input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text = input;
        }


        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text = input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text = input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text = input;
        }


        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text = input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text = input;
        }

        

        

       
        private void cee_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.input = string.Empty;
            result = 0;
            counter = 0;
            operation = '+';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Calculate(input, result, out result, out counter);


            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Calculate(input, result, out result, out counter);

            operation = '-';
            input = string.Empty;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            Calculate(input, result, out result, out counter);

            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Calculate(input, result, out result, out counter);

            operation = '/';
            input = string.Empty;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            Calculate(input, result, out result, out counter);
            

            input = string.Empty;
    }
    }
}
