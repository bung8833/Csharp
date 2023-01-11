using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class HW_Calculator : Form
    {
        public HW_Calculator()
        {
            InitializeComponent();
        }


        private void DisplayAnswer(Button btn)
        {
            
            labelDivisionLine.Text = "====================";

            // Parse Num1 and Num2
            decimal num1 = 0;
            decimal num2 = 1;

            bool isDecimal = decimal.TryParse(textBoxNum1.Text, out num1)
                          && decimal.TryParse(textBoxNum2.Text, out num2);

            if (!isDecimal)
            {
                textBoxNum1.Clear();
                textBoxNum2.Clear();
                textBoxAnswer.Text = "請輸入數值";
                return;
            }


            // Calculate answer
            if (btn == buttonPlus)
            {
                textBoxAnswer.Text = Math.Round((num1 + num2), 4, 
                                                 MidpointRounding.AwayFromZero).ToString();
            }
            else if (btn == buttonMinus)
            {
                textBoxAnswer.Text = Math.Round((num1 - num2), 4,
                                                 MidpointRounding.AwayFromZero).ToString();
            }
            else if (btn == buttonMultiply)
            {
                textBoxAnswer.Text = Math.Round((num1 * num2), 4,
                                                 MidpointRounding.AwayFromZero).ToString();
            }
            else if (btn == buttonDivide)
            {
                if (num2 == 0)
                {
                    textBoxAnswer.Text = "Division by zero";
                    labelDivisionLine.Text = "Division by zero Division by zero";
                    return;
                }

                textBoxAnswer.Text = Math.Round((num1 / num2), 4,
                                                 MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                return;
            }
        }



        private void buttonPlus_Click(object sender, EventArgs e)
        {
            DisplayAnswer((Button)sender);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            DisplayAnswer((Button)sender);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            DisplayAnswer((Button)sender);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            DisplayAnswer((Button)sender);
        }
    }
}
