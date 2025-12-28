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
// time of last update: 2:00 am
// version: 1.0.0
// description: A simple calculator application using windows form
// git hub link: https://github.com/30493763/Calculator_2022.git
// git branch: rewrite



namespace Calculator_2022
{
    public partial class Form1 : Form
    {
        //***********************************************************************************************************************************
        //        GLOBAL VARIABLES
        //***********************************************************************************************************************************
        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool exponentButtonClicked = false;
        bool moduloButtonClicked = false;
        bool absoluteButtonClicked = false;

        bool negate = false;

        //***********************************************************************************************************************************

        public Form1()
        {
            InitializeComponent();
        }


        //***********************************************************************************************************************************
        //         CLICK EVENTS
        //***********************************************************************************************************************************


        //**************************************************
        //       Events for each number button
        //**************************************************

        //***********************************************************************************************************************************
        //         METHODS
        //***********************************************************************************************************************************

        private void NumberButton_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button so we can access its properties
            Button clickedButton = (Button)sender;

            // Get the text (0-9) from the button
            string buttonText = clickedButton.Text;

            // Example: Show the number or append it to a TextBox
            //txtDisplay.Text += buttonText;
            if ( int.TryParse(buttonText, out int number) && (number >=0 && number <=9) )
            {
                // thats a number button clicked
                if (ifDisplayIsOperatorOrZero())
                {
                    txtDisplay.Text = buttonText; // replace display
                }
                else
                {
                    txtDisplay.Text += buttonText; // concatenate to display
                }
            }
            else if (buttonText == ".")
            {
                txtDisplay.Text += buttonText; // concatenate to display
            }

        }

        //***********************************************
        //   Method for returns text of button clicked 
        //************************************************
        private string returnButtonText(object sender)
        {
            //Cast the sender to a Button so we can access its properties
            Button clickedButton = (Button)sender;
            return clickedButton.Text;
        }// end of returnButtonText method

        //***********************************************
        //   Method for returns base^exponent using System.Math
        //************************************************
        private double power(double baseNumber, double exponent)
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

        //***********************************************
        //   Method:resetNegate()
        //   clear txtNegate to white space
        //   reset negate to false
        //************************************************
        private void resetNegate()
        {
            txtNegate.Text = "";
            negate = false;
        }// end of resetNegate method

        //***********************************************
        //   Method:ifDisplayIsOperatorOrZero()
        //   if the current display is an operator or zero (return true), the number buttons will replace it
        //   otherwise (return false) , the number concatenates to the display
        //   return : bool
        //************************************************
        private bool ifDisplayIsOperatorOrZero()
        {
            {
                if (txtDisplay.Text == "+" || txtDisplay.Text == "-" || txtDisplay.Text == "*" || txtDisplay.Text == "/" || txtDisplay.Text == "^" || txtDisplay.Text == "%" || txtDisplay.Text == "0")
                    return true;
                else
                {
                    return false;
                }
            }
        } // end of ifDisplayIsOperatorOrZero method

        //***********************************************
        //   Method:getOperandValueAndClearDisplay
        //   get operatpr value
        //   clear display for next operand
        //   reset negate status
        //************************************************
        private void getOperandValueAndClearDisplay()
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

        private double getValueFromDisplay()
        {
            double value = 0;
            if (negate)
                value = double.Parse(txtNegate.Text + txtDisplay.Text);
            else
                value = double.Parse(txtDisplay.Text);
            return value;
        } // end of getValueFromDisplay method

        private void resetAllOperationStatusToFalse()
        {
                plusButtonClicked = false;
                minusButtonClicked= false; 
                multiplyButtonClicked= false; 
                divideButtonClicked= false; 
                exponentButtonClicked= false; 
                moduloButtonClicked= false;
                absoluteButtonClicked = false;
        } // end of private method resetAllOperationStatusToFalse

        private void updateOperationStatus(char operation)
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
                case '*':
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
                case 'A':
                    absoluteButtonClicked = true;
                    break;
                default:
                    break;
            }
        }// end of private method updateOperationStatus

    }
}
