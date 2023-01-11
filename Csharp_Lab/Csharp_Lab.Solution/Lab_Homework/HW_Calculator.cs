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


        private void DisplayAnswer(decimal n1, decimal n2, Button btn)
        {
            if (btn == buttonPlus)
            {
                decimal ans = n1 + n2;

                textBoxAnswer.Text = ans.ToString();
            }
            else if (btn == buttonMinus)
            {
                decimal ans = n1 - n2;

                textBoxAnswer.Text = ans.ToString();
            }
            else if (btn == buttonMultiply)
            {
                decimal ans = n1 * n2;

                textBoxAnswer.Text = ans.ToString();
            }
            else if (btn == buttonDivide)
            {
                // undone
                decimal ans = n1 / n2;

                textBoxAnswer.Text = ans.ToString();
            }
            else
            {
                return;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            decimal n1 = 0;
            decimal n2 = 0;

            (decimal num1, decimal num2) vtup = (0, 0);

            bool isDecimal = decimal.TryParse(textBoxNum1.Text, out n1)
                          && decimal.TryParse(textBoxNum2.Text, out n2);

            if (!isDecimal)
            {
                textBoxNum1.Clear();
                textBoxNum2.Clear();
                textBoxAnswer.Text = "請輸入數值";
                return;
            }

            DisplayAnswer(n1, n2, (Button)sender);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }
    }
}
