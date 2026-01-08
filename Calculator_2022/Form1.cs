using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// aurthor: ching ho, li
// email: 30493763@cityofglacol.ac.uk
// date of last update: 28 dec 2025
// time of last update: 7:39 pm
// version: 1.2.1
// description: A simple calculator application using windows form
// git hub link: https://github.com/30493763/Calculator_2022.git
// git branch: main

namespace Calculator_2022
{
    public partial class Form1 : Form
    {
        //***********************************************************************************************************************************
        //        GLOBAL VARIABLES
        //***********************************************************************************************************************************

        const int MAX_LENGTH_OF_STRING = 9; // maximum length of string in display

        double total1 = 0; // first operand
        double total2 = 0; // second operand / result

        //flags for operation buttons
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool exponentButtonClicked = false;
        bool moduloButtonClicked = false;

        bool negate = false; // status of negate button, false = not negated, true = negated

        //***********************************************************************************************************************************

        public Form1()
        {
            InitializeComponent();
        }

        //***********************************************************************************************************************************
        //         CLICK EVENTS for all number buttons and operators
        //***********************************************************************************************************************************

        private void NumberButton_Click(object sender, EventArgs e) // for number buttons 0-9
        {
            string buttonText = returnButtonText(sender); // Get the text value from buttons

            if (ifDisplayIsOperatorOrZero())
                txtDisplay.Text = buttonText;
            else
            {
                if (txtDisplay.Text.Length > MAX_LENGTH_OF_STRING) // limit the length of string in display
                {
                    MessageBox.Show("Maximum number of digits reached!");
                    return;
                }
                txtDisplay.Text = txtDisplay.Text + buttonText;
            }
        } // end of NumberButton_Click event

        private void DecimalButton_Click(object sender, EventArgs e) // for decimal point button
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text = txtDisplay.Text + ".";
        }//end of DecimalButton_Click event

        private void NegateButton_Click(object sender, EventArgs e) // for negate button
        {
            if (!negate)
            {
                txtNegate.Text = "-";
                negate = true;
            }
            else
                resetNegate();
        }//end of NegateButton_Click event

        private void ClsButton_Click(object sender, EventArgs e) // for clear button
        {
            txtDisplay.Text = "0";
            total1 = 0;
            total2 = 0;
            resetAllOperationStatusToFalse();
            resetNegate();
        }//end of ClsButton_Click event

        private void BasicOperator_Click(object sender, EventArgs e) // for basic operator buttons + - × /
        {
            string buttonText = returnButtonText(sender); // Get the text value from buttons
            getOperandValueAndClearDisplay();
            resetNegate();
            updateOperationStatus(char.Parse(buttonText));
            txtDisplay.Text = buttonText;
        }//end of BasicOperator_Click event

        private void ExponentModuluButton_Click(object sender, EventArgs e)
        {
            string buttonText = returnButtonText(sender); // Get the text value from buttons
            getOperandValueAndClearDisplay();
            updateOperationStatus(char.Parse(buttonText));
            txtDisplay.Text = buttonText;
        }// end of ExponentModuluButton_Click event

        private void SquareRootButton_Click(object sender, EventArgs e) // for square root button
        {
            string result = returnTotalWithLimitedLengthOfString(Math.Sqrt(double.Parse(txtDisplay.Text)).ToString());
            txtDisplay.Text = result;

        }//end of SquareRootButton_Click event

        private void AbsoluteButton_Click(object sender, EventArgs e) // for absolute value button
        {
            if (getValueFromDisplay() < 0)
            {
                txtDisplay.Text = (getValueFromDisplay() * -1).ToString();
                resetNegate();
            }
        }//end of AbsoluteButton_Click event

        private void BackspaceButton_Click(object sender, EventArgs e) // for backspace button
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }//end of BackspaceButton_Click event

        private void EqualsButton_Click(object sender, EventArgs e) // for equals button
        {
            if (plusButtonClicked)
                total2 = total1 + getValueFromDisplay();
            else if (minusButtonClicked)
                total2 = total1 - getValueFromDisplay();
            else if (multiplyButtonClicked)
                total2 = total1 * getValueFromDisplay();
            else if (divideButtonClicked)
                total2 = total1 / getValueFromDisplay();
            else if (exponentButtonClicked)
                total2 = power(total1, getValueFromDisplay());
            else if (moduloButtonClicked)
                total2 = total1 % getValueFromDisplay();

            if (total2 >= 0)
            {
                txtDisplay.Text = returnTotalWithLimitedLengthOfString(total2.ToString()); //display the total value, limit length of string
                resetNegate();
            }
            else
            {
                txtDisplay.Text = returnTotalWithLimitedLengthOfString((total2 * -1).ToString()); //display the total value, limit length of string
                txtNegate.Text = "-";
                negate = true;
            }
            total1 = 0;//start from the beginning
        }// end of EqualsButton_Click event

        //***********************************************************************************************************************************
        //         METHODS
        //***********************************************************************************************************************************
        private string returnButtonText(object sender) // Method for returns text of button clicked 
        {
            Button clickedButton = (Button)sender; //Cast the sender to a Button so we can access its properties
            return clickedButton.Text;
        }// end of returnButtonText method
    
        private double power(double baseNumber, double exponent) // Method for returns base^exponent using System.Math
        {
            int result = 1;
            if (baseNumber == 0 )
                return 0;
            else if (exponent == 0) 
                return 1; //Any number raised to the power of 0 equals 1 (a^0 = 1). 
            else
            {
                for (int i = 0; i < (int)exponent; i++)
                {
                    result *= (int)baseNumber;// Multiply result by base
                }
                return result;
            }
        }// end of power method

        private void resetNegate() //   clear txtNegate to white space, reset variabe negate to false
        {
            txtNegate.Text = "";
            negate = false;
        }// end of resetNegate method

        private bool ifDisplayIsOperatorOrZero() // check if the display is an operator or zero
        {
            if (txtDisplay.Text == "+" || txtDisplay.Text == "-" || txtDisplay.Text == "×" || txtDisplay.Text == "/" || txtDisplay.Text == "^" || txtDisplay.Text == "%" || txtDisplay.Text == "0")
                return true;
            else
            {
                return false;
            }
        } // end of ifDisplayIsOperatorOrZero method

        private void getOperandValueAndClearDisplay() //   1.get operatpr value, 2.clear display for next operand, 3.reset negate status
        {
            if (ifDisplayIsOperatorOrZero())
                return;

            if (negate)
                total1 = total1 + (double.Parse(txtNegate.Text + txtDisplay.Text));
            else
                total1 = total1 + double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
            resetNegate();
        }// end of getOperandValueAndClearDisplay method

        private double getValueFromDisplay() // get value from display, consider negate status
        {
            double value = 0;
            if (negate)
                value = double.Parse(txtNegate.Text + txtDisplay.Text);
            else
                value = double.Parse(txtDisplay.Text);
            return value;
        } // end of getValueFromDisplay method

        private string returnTotalWithLimitedLengthOfString(string total) // return total in less than 10 characters due to display limit of txtDisplay
        {
            string totalString;
            if (total.Length > MAX_LENGTH_OF_STRING)
                totalString = total.Substring(0, MAX_LENGTH_OF_STRING);
            else
                totalString = total;
            return totalString;
        } // end of returnTotalWithLimitedLengthOfString method

        private void resetAllOperationStatusToFalse() // reset all operation status to false
        {
                plusButtonClicked = false;
                minusButtonClicked= false; 
                multiplyButtonClicked= false; 
                divideButtonClicked= false; 
                exponentButtonClicked= false; 
                moduloButtonClicked= false;
        } // end of private method resetAllOperationStatusToFalse

        private void updateOperationStatus(char operation) // update operation status based on operation char
        {
            resetAllOperationStatusToFalse();

            switch (operation)
            {
                case '+':
                    plusButtonClicked = true;
                    break;
                case '-':
                    minusButtonClicked = true;
                    break;
                case '×':
                    multiplyButtonClicked = true;
                    break;
                case '/':
                    divideButtonClicked = true;
                    break;
                case '^':
                    exponentButtonClicked = true;
                    break;
                case '%':
                    moduloButtonClicked = true;
                    break;
                default:
                    break;
            }
        }// end of private method updateOperationStatus

    }
}
