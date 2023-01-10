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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            HW_Hello hello = new HW_Hello();
            //hello.Location = container <-- ???
            hello.ShowDialog();
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            HW_Loan loan = new HW_Loan();
            loan.ShowDialog();
        }

        private void btn_TicTacToe_Click(object sender, EventArgs e)
        {
            HW_TicTacToe ticTacToe = new HW_TicTacToe();
            ticTacToe.ShowDialog();

            //for (int i = 0; i < 10; i++)
            //{
            //    // 會從原本位置往右下跑
            //    //Point loc = new Point(0, 0);
            //    //ticTacToe.Left = 0;
            //    ticTacToe.ShowDialog();
            //}
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            HW_POS pos = new HW_POS();
            pos.ShowDialog();
        }
    }
}
