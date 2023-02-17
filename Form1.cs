using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables used
        /// </summary>
        private double number1, result;
        private int operation = 0;

        public bool sign = false;
        public bool separ = false;
        public bool divideByZero = false;
        public bool negSqrt = false;

        public double min;
        public double max;

        /// <summary>
        /// initializing
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
        }

        /// <summary>
        /// All buttons of numbers in calculator (0..9)
        /// </summary>
        
        // num1
        private void num1_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "1";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "1";
            }
        }

        // num2
        private void num2_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "2";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "2";
            }
        }

        // num3
        private void num3_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "3";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "3";
            }
        }

        // num4
        private void num4_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "4";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "4";
            }
        }

        // num5
        private void num5_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "5";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "5";
            }
        }

        // num6
        private void num6_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "6";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "6";
            }
        }

        // num7
        private void num7_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "7";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "7";
            }
        }

        // num8
        private void num8_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "8";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "8";
            }
        }

        // num9
        private void num9_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text == "")
            {
                OutputWindow.Text = "9";
            }
            else
            {
                OutputWindow.Text = OutputWindow.Text + "9";
            }
        }

        // num0
        private void num0_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = OutputWindow.Text + "0";
        }

        /// <summary>
        /// Separator of integer and fractional part (",")
        /// </summary>
        private void separator_Click(object sender, EventArgs e)
        {
            if (separ == false && OutputWindow.Text != "")
            {
                OutputWindow.Text = OutputWindow.Text + ",";
                separ = true;

                if (secondoutput.Text == "Result:")
                {
                    secondoutput.Text = "Input your values:";
                }
            }
        }

        /// <summary>
        /// Arithmetic operations ("+, -, *, /")
        /// </summary>

        // addition
        private void plus_Click(object sender, EventArgs e)
        {
            if(sign == false && OutputWindow.Text != "")
            {
                number1 = double.Parse(OutputWindow.Text);
                OutputWindow.Clear();
                operation = 1;
                secondoutput.Text = number1.ToString() + "+";
                sign = true;
                separ = false;
            }
        }

        // subtraction
        private void minus_Click(object sender, EventArgs e)
        {
            if (sign == false && OutputWindow.Text != "")
            {
                number1 = double.Parse(OutputWindow.Text);
                OutputWindow.Clear();
                operation = 2;
                secondoutput.Text = number1.ToString() + "-";
                sign = true;
                separ = false;
            }
        }

        // multiplication
        private void mult_Click(object sender, EventArgs e)
        {
            if (sign == false && OutputWindow.Text != "")
            {
                number1 = double.Parse(OutputWindow.Text);
                OutputWindow.Clear();
                operation = 3;
                secondoutput.Text = number1.ToString() + "×";
                sign = true;
                separ = false;
            }
        }

        // division
        private void div_Click(object sender, EventArgs e)
        {
            if (sign == false && OutputWindow.Text != "")
            {
                number1 = double.Parse(OutputWindow.Text);
                OutputWindow.Clear();
                operation = 4;
                secondoutput.Text = number1.ToString() + "÷";
                sign = true;
                separ = false;
            }
        }

        /// <summary>
        /// Button that clear all input
        /// </summary>
        private void clearall_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
            secondoutput.Text = "Input your values:";
            sign = false;
            separ = false;
        }

        /// <summary>
        /// Button that output the result of arithmetic operation
        /// </summary>
        private void equal_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text != "")
            {
                switch (operation)
                {
                    case 1:
                        result = Math.Round(number1 + double.Parse(OutputWindow.Text), 4);
                        OutputWindow.Text = result.ToString();
                        break;
                    case 2:
                        result = Math.Round(number1 - double.Parse(OutputWindow.Text), 4);
                        OutputWindow.Text = result.ToString();
                        break;
                    case 3:
                        result = Math.Round(number1 * double.Parse(OutputWindow.Text), 4);
                        OutputWindow.Text = result.ToString();
                        break;
                    case 4:
                        if (double.Parse(OutputWindow.Text) != 0)
                        {
                            result = Math.Round(number1 / double.Parse(OutputWindow.Text), 4);
                            OutputWindow.Text = result.ToString();
                        }
                        else
                        {
                            OutputWindow.Text = "Divide by zero!";
                            divideByZero = true;
                        }
                        break;
                    default:
                        break;
                }
                secondoutput.Text = "Result:";
                sign = false;
            }
        }

        /// <summary>
        /// Bodies of textboxes
        /// </summary>
        
        // main textbox
        private void OutputWindow_TextChanged(object sender, EventArgs e)
        {

        }

        // additional textbox
        private void secondoutput_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Custom operations ("sqrt(x), sin(x), 1/x")
        /// </summary>

        // sqrt(x)
        private void sqrtx_Click(object sender, EventArgs e)
        {
            

            if (OutputWindow.Text != "")
            {
                double first = double.Parse(OutputWindow.Text);

                if(first >= 0)
                {
                    result = Math.Sqrt(double.Parse(OutputWindow.Text));
                    OutputWindow.Text = result.ToString();
                    if (result % 1 != 0)
                    {
                        separ = true;
                    }
                    secondoutput.Text = "Result:";
                }
                else
                {
                    OutputWindow.Text = "Negative value!";
                    negSqrt = true;
                }
            }
        }

        // sin(x)
        private void sinx_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text != "")
            {
                result = Math.Sin(double.Parse(OutputWindow.Text));
                OutputWindow.Text = result.ToString();
                if (result % 1 != 0)
                {
                    separ = true;
                }
                secondoutput.Text = "Result:";
            }
        }

        // 1/x
        private void reverse_Click(object sender, EventArgs e)
        {
            if (OutputWindow.Text != "")
            {
                result = 1 / double.Parse(OutputWindow.Text);
                OutputWindow.Text = result.ToString();
                if(result % 1 != 0)
                {
                    separ = true;
                }
                secondoutput.Text = "Result:";
            }
        }

        /// <summary>
        /// Range of numbers to input
        /// </summary>

        // minimal number
        private void mininput_TextChanged(object sender, EventArgs e)
        {
            min = double.Parse(mininput.Text);
        }

        // maximal number
        private void maxinput_TextChanged(object sender, EventArgs e)
        {
            max = double.Parse(maxinput.Text);
        }

        /// <summary>
        /// Button that clear only last value
        /// </summary>
        private void clearone_Click(object sender, EventArgs e)
        {
            string first = OutputWindow.Text;
            string second = secondoutput.Text;

            if(OutputWindow.Text != "")
            {
                OutputWindow.Text = OutputWindow.Text.Remove(OutputWindow.Text.Length - 1, 1);

                if(secondoutput.Text == "Result:")
                {
                    secondoutput.Text = "Input your values:";
                }

                if (first[first.Length - 1] == '+' || first[first.Length - 1] == '-' ||
                    first[first.Length - 1] == '×' || first[first.Length - 1] == '÷')
                {
                    sign = false;
                }

                if(first[first.Length - 1] == ',')
                {
                    separ = false;
                }

                if(divideByZero == true)
                {
                    OutputWindow.Text = "";
                }

                if(negSqrt == true)
                {
                    OutputWindow.Text = "";
                }
            }
        }
    }
}
