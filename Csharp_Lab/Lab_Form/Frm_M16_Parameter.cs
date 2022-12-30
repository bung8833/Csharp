using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M16_Parameter : Form
    {
        public Frm_M16_Parameter()
        {
            InitializeComponent();
        }

        private void btn_ByValue_Click(object sender, EventArgs e)
        {
            decimal dec = 1;
            MessageBox.Show(dec.ToString());
            ByValueParameter(dec);
            MessageBox.Show(dec.ToString());
        }

        void ByValueParameter(decimal Value)
        {
            Value = 10000;
        }

        private void btn_ByRef_Click(object sender, EventArgs e)
        {
            decimal dec = 1;
            MessageBox.Show(dec.ToString());
            ByRefParameter(ref dec);
            MessageBox.Show(dec.ToString());
        }
        
        void ByRefParameter(ref decimal Value)
        {
            Value = 10000;
        }

        private void btn_ByRef2_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Name = "Richman";
            member.Age = 7;
            MessageBox.Show(member.Name + " " + member.Age.ToString());

            ByRefParameter2(member);
            MessageBox.Show(member.Name + " " + member.Age.ToString());
        }

        void ByRefParameter2(Member member)
        {
            member.Name = "Richard";
            member.Age = 20;
        }

        private void btn_ByOut_Click(object sender, EventArgs e)
        {
            int value = 0;
            MessageBox.Show(value.ToString());

            ByOut(out value); // 用變數value接收return
            MessageBox.Show(value.ToString());
        }

        void ByOut(out int Value) // out 可return多個值
        {
            Value = 20;
        }

        private void btn_MyParams_Click(object sender, EventArgs e)
        {
            string ResultChinese = ByParams("國文", 100, 90, 80, 70, 60);
            MessageBox.Show(ResultChinese);

            string ResultMath = ByParams("數學", 100, 0);
            MessageBox.Show(ResultMath);
        }

        string ByParams(string Subject, params int[] Scores)
        {
            int Total = 0;
            for (int i = 0; i < Scores.Length; i++)
            {
                Total += Scores[i];
            }
            int Average = Total / Scores.Length;

            return Subject + "的總成績是" + Total.ToString() + "分，"
                   + "\n平均是" + Average.ToString() + "分。";
        }
    }
}
