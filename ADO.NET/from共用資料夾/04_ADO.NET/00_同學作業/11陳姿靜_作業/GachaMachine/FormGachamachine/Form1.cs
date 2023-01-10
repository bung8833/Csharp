using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGachamachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "State:StandByState 機器沒在工作,等待下一個客人操作" + "\r\n" + "Money:" + dallar;
        }

        int dallar = 0;
        string result;
        int cost = 50;
        
        public int InputMoney
        {
            get
            {
                bool isInt = int.TryParse(tb_dollar.Text, out int value);
                return isInt ? value : 0;
			}
        }
        private void But_Dollar_Click(object sender, EventArgs e)
        {
            // tb_dollar.Text = tb_dollar.Text;

            dallar += InputMoney;

            textBox1.Text = DisplayStatus();

        }

        private void But_RefundMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已完成退幣作業", "", MessageBoxButtons.OK);
            dallar = 0;
            tb_dollar.Text = String.Empty;

            textBox1.Text = DisplayStatus();

        }

        private void But_Ship_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已出貨", "", MessageBoxButtons.OK);
            dallar -= cost;
            textBox1.Text = DisplayStatus();

        }
        public string DisplayStatus()
        {
            if (dallar < cost && dallar>0)
            {
                but_RefundMoney.Enabled = true;
                but_ship.Enabled = false;
                result = "State:InsufficientAmountState有投幣,但金額還不足夠" + "\r\n" + "Money:" + dallar;
            }
            else if (dallar == 0)
            {
                but_RefundMoney.Enabled = false;
                but_ship.Enabled = false;
                result = "State:StandByState 機器沒在工作,等待下一個客人操作" + "\r\n" + "Money:" + dallar;
            }
			else if (dallar < 0)
			{
                throw new Exception("不可能~~~~~");
			}
			else
            {
                but_RefundMoney.Enabled = true;
                but_ship.Enabled = true;

                result = "State:ReadyToship投入足夠金額,等待客人指令就出貨" + "\r\n" + "Money:" + dallar;
            }
            return result;
        }
    }
}
