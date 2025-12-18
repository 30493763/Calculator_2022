using System.Drawing.Text;

namespace Calculator_2022
{

    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnExponen = new System.Windows.Forms.Button();
            this.btnSqaureRoot = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnAbsolute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDisplay.Font = new System.Drawing.Font("Digital-7 Italic", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDisplay.Location = new System.Drawing.Point(5, 0);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(480, 89);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "123.56";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Menu;
            this.btnOne.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(21, 94);
            this.btnOne.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 60);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTwo.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(107, 94);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 60);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.Menu;
            this.btnThree.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(193, 95);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 60);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFour.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(21, 166);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 60);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFive.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(107, 166);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 60);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSix.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(193, 167);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 60);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSeven.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(21, 233);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 60);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEight.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(107, 233);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 60);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.Menu;
            this.btnNine.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(193, 234);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 60);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Menu;
            this.btnZero.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(107, 295);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(80, 60);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDot.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(193, 296);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(80, 60);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlus.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Location = new System.Drawing.Point(385, 95);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(80, 40);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEqual.Font = new System.Drawing.Font("Digital-7 Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEqual.Location = new System.Drawing.Point(299, 279);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(166, 77);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Menu;
            this.btnClear.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 60);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinus.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Location = new System.Drawing.Point(385, 141);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(80, 40);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMultiply.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMultiply.Location = new System.Drawing.Point(385, 187);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 40);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDivision.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDivision.Location = new System.Drawing.Point(385, 233);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(80, 40);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnExponen
            // 
            this.btnExponen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExponen.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponen.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExponen.Location = new System.Drawing.Point(297, 95);
            this.btnExponen.Name = "btnExponen";
            this.btnExponen.Size = new System.Drawing.Size(80, 40);
            this.btnExponen.TabIndex = 18;
            this.btnExponen.Text = "^";
            this.btnExponen.UseVisualStyleBackColor = false;
            this.btnExponen.Click += new System.EventHandler(this.btnExponen_Click);
            // 
            // btnSqaureRoot
            // 
            this.btnSqaureRoot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSqaureRoot.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqaureRoot.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSqaureRoot.Location = new System.Drawing.Point(299, 141);
            this.btnSqaureRoot.Name = "btnSqaureRoot";
            this.btnSqaureRoot.Size = new System.Drawing.Size(80, 40);
            this.btnSqaureRoot.TabIndex = 19;
            this.btnSqaureRoot.Text = "√";
            this.btnSqaureRoot.UseVisualStyleBackColor = false;
            this.btnSqaureRoot.Click += new System.EventHandler(this.btnSqaureRoot_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModulo.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModulo.Location = new System.Drawing.Point(299, 187);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(80, 40);
            this.btnModulo.TabIndex = 20;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnAbsolute
            // 
            this.btnAbsolute.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAbsolute.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsolute.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAbsolute.Location = new System.Drawing.Point(299, 234);
            this.btnAbsolute.Name = "btnAbsolute";
            this.btnAbsolute.Size = new System.Drawing.Size(80, 39);
            this.btnAbsolute.TabIndex = 21;
            this.btnAbsolute.Text = "ABS";
            this.btnAbsolute.UseVisualStyleBackColor = false;
            this.btnAbsolute.Click += new System.EventHandler(this.btnAbsolute_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnAbsolute);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnSqaureRoot);
            this.Controls.Add(this.btnExponen);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtDisplay);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;

        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnExponen;
        private System.Windows.Forms.Button btnSqaureRoot;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnAbsolute;
    }
}

