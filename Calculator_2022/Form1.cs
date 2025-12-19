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

        bool negate = false;

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
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnOne.Text;
            //else
            //    txtDisplay.Text = btnOne.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnOne.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnOne.Text;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
            //else
            //    txtDisplay.Text = btnTwo.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnTwo.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnThree.Text;
            //else
            //    txtDisplay.Text = btnThree.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnThree.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnThree.Text;

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnFour.Text;
            //else
            //    txtDisplay.Text = btnFour.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnFour.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnFour.Text;

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnFive.Text;
            //else
            //    txtDisplay.Text = btnFive.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnFive.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnFive.Text;

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnSix.Text;
            //else
            //    txtDisplay.Text = btnSix.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnSix.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnSix.Text;

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
            //else
            //    txtDisplay.Text = btnSeven.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnSeven.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnSeven.Text;

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnEight.Text;
            //else
            //    txtDisplay.Text = btnEight.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnEight.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnEight.Text;

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "-" || !displayIsOperatorOrZero())
            //    txtDisplay.Text = txtDisplay.Text + btnNine.Text;
            //else
            //    txtDisplay.Text = btnNine.Text;
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnNine.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnNine.Text;

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (displayIsOperatorOrZero())
                txtDisplay.Text = btnZero.Text;
            else
                txtDisplay.Text = txtDisplay.Text + btnZero.Text;

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (displayIsOperatorOrZero())
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
            resetAllOperationStatusToFalse();
            resetNegate();  
            txtDisplay.Text = "0";
        }

        //***********************************************
        //   Event for the Plus button
        //************************************************
        private void btnPlus_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            resetNegate();
            updateOperationStatus('+');
            txtDisplay.Text = "+";
        }

        //***********************************************
        //   Event for the Minus button   
        //************************************************
        private void btnMinus_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            resetNegate();
            updateOperationStatus('-');
            txtDisplay.Text = "-";

        }

        //***********************************************
        //   Event for the Multiply button
        //************************************************
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            resetNegate();
            updateOperationStatus('*');
            txtDisplay.Text = "*";
        }

        //***********************************************
        //   Event for the Divide button
        //************************************************
        private void btnDivision_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            resetNegate();
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
            txtDisplay.Text = "^";

        }// end of btnExponen_Click event

        //***********************************************
        //   Event for the Modulo button
        //************************************************
        private void btnModulo_Click(object sender, EventArgs e)
        {
            getOperandValueAndClearDisplay();
            updateOperationStatus('%');
            txtDisplay.Text = "%";
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
            txtDisplay.Text = (getValueFromDisplay()*-1).ToString();
            resetNegate();  

        }// end of btnAbsolute_Click event

        //***********************************************
        //   Event for the Equal button - calculates the total value
        //************************************************
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked)
            {
                //total2 = total1 + double.Parse(txtDisplay.Text);
                total2 = total1 + getValueFromDisplay();

            }
            else if (minusButtonClicked)
            {
                //total2 = total1 - double.Parse(txtDisplay.Text);
                total2 = total1 - getValueFromDisplay();

            }
            else if (multiplyButtonClicked)
            {
                //total2 = total1 * double.Parse(txtDisplay.Text);
                total2 = total1 * getValueFromDisplay();

            }
            else if (divideButtonClicked)
            {
                //total2 = total1/double.Parse(txtDisplay.Text);
                total2 = total1 / getValueFromDisplay();

            }
            else if (exponentButtonClicked)
            {
                //total2 = power(total1, double.Parse(txtDisplay.Text));
                total2 = power(total1, getValueFromDisplay() );

            }
            else if (moduloButtonClicked)
            {
                //total2 = total1 % double.Parse(txtDisplay.Text);
                total2 = total1 % getValueFromDisplay();
            }


            if (total2 >=0)
            {
                txtDisplay.Text = total2.ToString();//display the total value
                resetNegate();
            }
            if (total2 < 0)
            {
                txtDisplay.Text = (total2*-1).ToString();//display the total value

                txtNegate.Text = "-";
                negate = true;
            }

            total1 = 0;//start from the beginning
            //resetNegate();
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
            if (displayIsOperatorOrZero())
                return;

            if (negate)
                total1 = total1 + (double.Parse(txtNegate.Text + txtDisplay.Text));
            else
                total1 = total1 + double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
            resetNegate();
        }

        private double getValueFromDisplay()
        {
            double value = 0;
            if (negate)
                value = double.Parse(txtNegate.Text + txtDisplay.Text);
            else
                value = double.Parse(txtDisplay.Text);
            return value;
        }

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

        private void resetNegate()
        {
            txtNegate.Text = "";
            negate = false;
        }// end of resetNegate method

        private bool displayIsOperatorOrZero() {
            {
                if (txtDisplay.Text == "+" || txtDisplay.Text == "-" || txtDisplay.Text == "*" || txtDisplay.Text == "/" || txtDisplay.Text == "^" || txtDisplay.Text == "%" || txtDisplay.Text == "0")
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

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (negate)
            {
                txtNegate.Text = "";
                negate = false;
            }
            else
            {
                txtNegate.Text = "-";
                negate = true;
            }
        }// end of btnNegate_Click event

    }
}
