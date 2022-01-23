using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsForms
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        string userInput = "";
        char function;
        double result = 0.0;
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            if (CalculatorDisplay.Text != "" || first != "" )
            {
                
                userInput += "0";
                CalculatorDisplay.Text += userInput;
            }
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ""; // to clear the input
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                CalculatorDisplay.Text = ""; // to clear the input
                userInput += ",";
                CalculatorDisplay.Text += userInput;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                function = '+';
                first = userInput;
                userInput = "";
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                function = '-';
                first = userInput;
                userInput = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                function = '*';
                first = userInput;
                userInput = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                function = '/';
                first = userInput;
                userInput = "";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                first = userInput;
                double result = 0;
                double firstNum = Convert.ToDouble(first);
                result = -firstNum;
                CalculatorDisplay.Text = result.ToString();
                userInput = result.ToString();
                result = 0;
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                first = userInput;
                double result = 0;
                double firstNum = Convert.ToDouble(first);

                result = firstNum / 100;
                CalculatorDisplay.Text = result.ToString();
                userInput = result.ToString();
                result = 0;
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                first = userInput;
                double result = 0;
                double firstNum = Convert.ToDouble(first);

                if (firstNum < 0)
                {
                    CalculatorDisplay.Text = "Not in this field, sorry :( ";
                }
                else
                {
                    result = Math.Sqrt(firstNum);
                    CalculatorDisplay.Text = result.ToString();
                   
                }
                userInput = result.ToString();
                result = 0;
            }
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                second = userInput;
                double firstNum, secondNum;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);

                // Plus
                if (function == '+')
                {
                    result = firstNum + secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
                // Minus
                else if (function == '-')
                {
                    result = firstNum - secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
                // Multiply
                else if (function == '*')
                {
                    result = firstNum * secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
                // Divide
                else if (function == '/')
                {
                    if (secondNum == 0)
                    {
                        CalculatorDisplay.Text = "Huh, classic (: ";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        CalculatorDisplay.Text = result.ToString();
                    }
                }

                userInput = result.ToString();
                result = 0;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0;
            CalculatorDisplay.Text = "0";
        }

        private void CalculatorDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        // MR
        private void buttonMR_Click(object sender, EventArgs e)
        {
            if (memory != 0)
            {
                userInput = memory.ToString();
                CalculatorDisplay.Text = memory.ToString();
            }
        }

        // M-
        private void buttonMPop_Click(object sender, EventArgs e)
        {
            if (userInput != "")
            {
                memory -= Convert.ToDouble(userInput);
            }
        }

        // M+
        private void buttonMM_Click(object sender, EventArgs e)
        {
  
            if (userInput != "")
            {
                memory += Convert.ToDouble(userInput);
            }
        }
    }
}
