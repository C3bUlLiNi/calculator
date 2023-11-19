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
    public partial class Kalkulator : Form
    {
        double number1 = 0;
        double number2 = 0;
        double result = 0;
        string op = "";
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if(input.Text == "0")
            {
                input.Text = "0";
            }
            else
            {
                input.Text = input.Text + "0";
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "1";
            }
            else
            {
                input.Text = input.Text + "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "2";
            }
            else
            {
                input.Text = input.Text + "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "3";
            }
            else
            {
                input.Text = input.Text + "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "4";
            }
            else
            {
                input.Text = input.Text + "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "5";
            }
            else
            {
                input.Text = input.Text + "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "6";
            }
            else
            {
                input.Text = input.Text + "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "7";
            }
            else
            {
                input.Text = input.Text + "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "8";
            }
            else
            {
                input.Text = input.Text + "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = "9";
            }
            else
            {
                input.Text = input.Text + "9";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(input.Text.Contains("-"))
                {
                    input.Text = (input.Text).Trim('-');
                }
           else
            {
                input.Text = "-" + input.Text;
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if(input.Text.Contains(','))
                {
                    input.Text = input.Text + "";
                }
            else
            {
                input.Text = input.Text + ",";
            }
        }

    

        private void minusButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            op = "-";
            input.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            op = "*";
            input.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            op = "/";
            input.Text = "";
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            result = Math.Sqrt(number1);
            input.Text = result.ToString();
            equationLabel.Text = result + " = pierwiastek kwadratowy liczby " + number1;
        }

        private void powButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            result = Math.Pow(number1,2);
            input.Text = result.ToString();
            equationLabel.Text = result + " = kwadrat liczby " + number1;
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            number1 = number1 / 100;
            input.Text = number1.ToString();
            equationLabel.Text = "procent z liczby " + number1*100;
        }

        private void strongButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            double strong = 1;
            for(double i = number1; i > 0; i--)
            {
                strong = strong * i;
            }
            input.Text = strong.ToString();
            equationLabel.Text = strong + " = silnia z " + number1;
        }

        private void absButton_Click(object sender, EventArgs e)
        {
            number1 = Math.Abs(double.Parse(input.Text));
            input.Text = number1.ToString();
            equationLabel.Text = "wartość bezwzględna liczby " + -number1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            input.Text = "";
            number1 = 0;
            number2 = 0;
            result = 0;
            op = "";
            equationLabel.Text = "";
        }

        private void clearEverythingButton_Click(object sender, EventArgs e)
        {
            input.Text = "";
            number1 = 0;
            op = "";
            equationLabel.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (op)
                {
                    case "+":
                        number2 = double.Parse(input.Text);
                        result = number1 + number2;
                        input.Text = result.ToString();
                        if (op != "")
                        {
                            equationLabel.Text = (result + " = " + number1 + " " + op + " " + number2).ToString();
                        }
                        break;
                    case "-":
                        number2 = double.Parse(input.Text);
                        result = number1 - number2;
                        input.Text = result.ToString();
                        if (op != "")
                        {
                            equationLabel.Text = (result + " = " + number1 + " " + op + " " + number2).ToString();
                        }
                        break;
                    case "*":
                        number2 = double.Parse(input.Text);
                        result = number1 * number2;
                        input.Text = result.ToString();
                        if (op != "")
                        {
                            equationLabel.Text = (result + " = " + number1 + " " + op + " " + number2).ToString();
                        }
                        break;
                    case "/":
                        number2 = double.Parse(input.Text);
                        result = number1 / number2;
                        input.Text = result.ToString();
                        if (op != "")
                        {
                            equationLabel.Text = (result + " = " + number1 + " " + op + " " + number2).ToString();
                        }
                        break;
                    default:
                        MessageBox.Show("Brak operatora!");
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(input.Text);
            op = "+";
            input.Text = "";
        }

        private void equationLabel_Click(object sender, EventArgs e)
        {
            

        }
    }
}
