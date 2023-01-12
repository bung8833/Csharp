using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Homework
{
    public partial class HW_GuessTheNumber : Form
    {
        //private int answer = 50;
        //private int lowerBound = 1;
        //private int upperBound = 100;
        // todo 自動選取文字, 子Form位置

        public int Answer { get; private set; }
        public int LowerBound { get; private set; }
        public int UpperBound { get; private set; }

        public void RenewAnswer()
        {
            // reset boundaries
            LowerBound = 1;
            UpperBound = 100;

            // 生成1~100的隨機整數
            Answer = new Random(Guid.NewGuid().GetHashCode())
                         .Next(1, 101); // [1, 101)

            // 更改label文字
            labelInstruction.Text = $"Geuss the number: " +
                                    $"from {LowerBound} to {UpperBound}";
        }


        public HW_GuessTheNumber()
        {
            InitializeComponent();

            RenewAnswer();
        }


        /// <summary>
        /// 根據使用者猜的數字，提示是否猜中答案；
        /// 若沒猜中，提示答案比猜測的數字高或低
        /// </summary>
        /// <param name="numberOfGuess"></param>
        public void DisplayHint(int numberOfGuess)
        {
            // 猜中答案的情形
            if (numberOfGuess == Answer)
            {
                MessageBox.Show($"Bingo! Answer: {Answer}\r\n按確定開始下一局遊戲");
                RenewAnswer();
                return;
            }

            // 紀錄答案所在的區間
            if (numberOfGuess > Answer)
            {
                UpperBound = numberOfGuess -1 ; // 區間不包含numberOfGuess 因為它不是正確答案
            }
            else if (numberOfGuess < Answer)
            {
                LowerBound = numberOfGuess +1 ; // 區間不包含numberOfGuess 因為它不是正確答案
            }

            // modify labelText by number of guess
            labelInstruction.Text = $"Geuss the number: " +
                                    $"from {LowerBound} to {UpperBound}";
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            InputYourGuess formInput = new InputYourGuess();
            formInput.Owner = this;
            
            formInput.StartPosition = FormStartPosition.CenterScreen ;
            formInput.ShowDialog();
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer: {Answer}\r\n按確定開始下一局遊戲");

            RenewAnswer();
        }
    }
}
