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

        private void ShowFormInContainer(Form frm, 
                                         bool clearContainer=true)
        {
            frm.TopLevel = false;

            if (clearContainer)panelRight.Controls.Clear();
            panelRight.Controls.Add(frm);
            frm.Show();
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            HW_Hello hello = new HW_Hello();

            ShowFormInContainer(hello);
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            HW_Loan loan = new HW_Loan();

            ShowFormInContainer(loan);
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            HW_POS pos = new HW_POS();

            ShowFormInContainer(pos);
        }

        private void btn_TicTacToe_Click(object sender, EventArgs e)
        {
            HW_TicTacToe ticTacToe = new HW_TicTacToe();

            ShowFormInContainer(ticTacToe);
        }
    }
}
