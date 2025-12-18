using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//hello
namespace Calculator_2022
{
    public partial class Form1 : Form
    {
        //***********************************************
        //         global variables
        //**********************************************
        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool exponentButtonClicked = false;
        bool moduloButtonClicked = false;
        bool absoluteButtonClicked = false;

        //****************************************************
        public Form1()
        {
            InitializeComponent();
        }

        //**************************************************
        //       Events for each number button
        //**************************************************
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnOne.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnTwo.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnThree.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnFour.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnFive.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnSix.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnSeven.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnEight.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnNine.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnZero.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (displayIsOperator())
                txtDisplay.Text = btnDot.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        //******************************************************
        //     Event for Clear button- clears the display and all previous operations
        //**********************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total1 = 0;
            total2=0;
            updateOperationStatus(default);
        }

        //***********************************************
        //   Event for the Plus button
        //************************************************
        private void btnPlus_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('+');
            txtDisplay.Text = "+";
        }

        //***********************************************
        //   Event for the Minus button   
        //************************************************
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "-";
                return;
            };

            getOperandValueAndClearDisplay();
            updateOperationStatus('-');
            txtDisplay.Text = "-";

        }

        //***********************************************
        //   Event for the Multiply button
        //************************************************
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('*');
            txtDisplay.Text = "*";
        }

        //***********************************************
        //   Event for the Divide button
        //************************************************
        private void btnDivision_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('/');
            txtDisplay.Text = "/";
        }


        //***********************************************
        //   Event for the Exponent button
        //************************************************
        private void btnExponen_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('^');

        }// end of btnExponen_Click event

        //***********************************************
        //   Event for the Modulo button
        //************************************************
        private void btnModulo_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('%');
        }


        private void btnSqaureRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.Sqrt(double.Parse(txtDisplay.Text)).ToString();
        }// end of btnRoot_Click event

        //***********************************************
        //   Event for the Absolute button
        //************************************************
        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.Abs(double.Parse(txtDisplay.Text)).ToString();
        }// end of btnAbsolute_Click event

        //***********************************************
        //   Event for the Equal button - calculates the total value
        //************************************************
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
           else if (divideButtonClicked)
            {
                total2 = total1/double.Parse(txtDisplay.Text);
            }
            else if (exponentButtonClicked)
            {
                total2 = power(total1, double.Parse(txtDisplay.Text));
            }
            else if (moduloButtonClicked)
            {
                total2 = total1 % double.Parse(txtDisplay.Text);
            }

            txtDisplay.Text = total2.ToString();//display the total value
            total1 = 0;//start from the beginning
        }


        // Simple exponential helper - returns base^exponent using System.Math
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
        private void getOperandValueAndClearDisplay()
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void resetAllOperationStatusToFalse()
        {
            bool[] clickedStatus = new bool[7] { 
                plusButtonClicked, 
                minusButtonClicked, 
                multiplyButtonClicked, 
                divideButtonClicked, 
                exponentButtonClicked, 
                moduloButtonClicked,
                absoluteButtonClicked
            };
            for (int i = 0; i < clickedStatus.Length; i++)
                clickedStatus[i] = false;
        } // end of private method resetAllOperationStatusToFalse

        private bool displayIsOperator() {
            {
                if (txtDisplay.Text == "+" || txtDisplay.Text == "-" || txtDisplay.Text == "*" || txtDisplay.Text == "/" || txtDisplay.Text == "^" || txtDisplay.Text == "%")
                    return true;
                else
                {
                    return false;
                }
            }
        }

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
