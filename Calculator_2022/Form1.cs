using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtDisplay.Text = txtDisplay.Text+btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
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
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //***********************************************
        //   Event for the Plus button
        //************************************************
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            
            txtDisplay.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //***********************************************
        //   Event for the Minus button   
        //************************************************
        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1+double.Parse(txtDisplay.Text);
            
            txtDisplay.Clear();

            minusButtonClicked = true;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;

        }

        //***********************************************
        //   Event for the Multiply button
        //************************************************
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1+double.Parse(txtDisplay.Text);
            
            txtDisplay.Clear();

            multiplyButtonClicked = true;
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
           
        }

        //***********************************************
        //   Event for the Divide button
        //************************************************
        private void btnDivision_Click(object sender, EventArgs e)
        {
            total1 = total1+double.Parse(txtDisplay.Text);
            
            txtDisplay.Clear();//clears the display textbox

            divideButtonClicked = true;
            multiplyButtonClicked = false;
            plusButtonClicked = false;
            minusButtonClicked = false;
           
        }

        //***********************************************
        //   Event for the Equal button - calculates the total value
        //************************************************
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked==true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked==true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked==true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
           else if (divideButtonClicked==true)
            {
                total2 = total1/double.Parse(txtDisplay.Text);
            }

            txtDisplay.Text = total2.ToString();//display the total value
            total1 = 0;//start from the beginning
        }
    }
}
