using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class InputYourGuess : Form
    {
        private int numberOfGuess;

        public void SelectInput()
        {
            textBoxGuessInput.Focus();
            textBoxGuessInput.SelectAll();
        }

        public InputYourGuess()
        {
            InitializeComponent();

            SelectInput();
        }

        private void ReceiveGuess()
        {
            SelectInput();

            bool isInt = int.TryParse(textBoxGuessInput.Text, out numberOfGuess);

            if (!isInt)
            {
                MessageBox.Show("請輸入整數數字");
                return;
            }

            
            HW_GuessTheNumber owner = (HW_GuessTheNumber)this.Owner;

            // numberOfGuess in wrong range
            if (numberOfGuess > owner.UpperBound
             || numberOfGuess < owner.LowerBound )
            {
                MessageBox.Show($"請輸入{owner.LowerBound}~{owner.UpperBound}之間的數字");
                return;
            }

            owner.DisplayHint(numberOfGuess);
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ReceiveGuess();
        }
        
        private void textBoxGuessInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReceiveGuess();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
