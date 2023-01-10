using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab_Homework
{
    public partial class HW_Loan : Form
    {
        public HW_Loan()
        {
            InitializeComponent();
        }

        // 每月還款
        double monthlyPmt = 0;

        // double financed
        double financed = 0;

        // int years
        int years = 0;

        // int months
        int months = 0;

        // yearlyRatePercent
        double yearlyRatePercent = 0;

        // double monthlyRate
        double monthlyRate = 0;

        private bool Pmt()
        {
            bool isF = double.TryParse(txtBox_financed.Text, out financed);

            bool isY = int.TryParse(txtBox_years.Text, out years);
            months = years * 12;

            // decimal yearlyRate
            bool isYR = double.TryParse(txtBox_rate.Text, out yearlyRatePercent);
            monthlyRate = (yearlyRatePercent/100) / 12;

            if (!isF || !isY || !isYR 
                || financed < 0 || years <= 0 || yearlyRatePercent < 0)
            {
                MessageBox.Show("請輸入正確數值");
                return false;
            }

            double mP = -Financial.Pmt(monthlyRate, months, financed);
            monthlyPmt = Math.Ceiling(mP);

            return true;
        }



        private void btn_PMT_Click(object sender, EventArgs e)
        {
            if (Pmt())
            {
                //MessageBox.Show(
                //    monthlyRate.ToString() + "\n"
                //    + months.ToString() + "\n"
                //    + financed.ToString()
                //    );
                
                string Result = $"月付：{monthlyPmt:C0}元";
                MessageBox.Show(Result);
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            if (Pmt())
            {
                string Result = $"總付款：{monthlyPmt*months:C0}元";
                MessageBox.Show(Result);
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (!Pmt()) return;

            LoanReport loanReport = new LoanReport();
            loanReport.lbl_showFinanced.Text    = financed.ToString();
            loanReport.lbl_showYears.Text       = years.ToString();
            loanReport.lbl_showRate.Text        = yearlyRatePercent.ToString();
            loanReport.lbl_showMonthlyPmt.Text  = monthlyPmt.ToString();
            loanReport.lbl_showTotalPmt.Text    = (monthlyPmt * months).ToString();

            loanReport.Show();
        }
    }
}
