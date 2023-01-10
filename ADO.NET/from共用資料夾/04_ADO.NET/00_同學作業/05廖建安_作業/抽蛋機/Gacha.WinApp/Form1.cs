using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacha.WinApp
{
    public partial class Form1 : Form
    {
        static int initialCoin = 0;
        GachaMachine machine = new GachaMachine(initialCoin, 50); 

        public Form1()
        {
            InitializeComponent();

            MachintStatementUpdate(initialCoin);

            btnRefund.Enabled = false;
            btnShip.Enabled = false;
        }

        public void MachintStatementUpdate(int coin)
        {
            int state = machine.StatementCheck();
            if (state > 0) txtStatement.Text = 
                    $"State:ReadyToShip 投入足夠金額，等待客人指令就出貨\r\nMoney:{coin}";
            else if (state == 0) txtStatement.Text = 
                    $"State:InsufficientAmountState 有投幣，但金額還不夠\r\nMoney:{coin}";
            else txtStatement.Text= 
                    $"State:StandByState 機器未運作，等待下一個客人操作\r\nMoney:{coin}";
        }

        private void btnInsertCoin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInsertCoin.Text, out int coin) && coin > 0)
            {
                int balanceNow = machine.InsertCoin(coin);
                MachintStatementUpdate(balanceNow);

                btnRefund.Enabled = true;
                if (machine.StatementCheck() > 0) btnShip.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入正整數金額");
                txtInsertCoin.Text = string.Empty;
                txtInsertCoin.Focus(); 
            }
            
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            MachintStatementUpdate(machine.Refund());
            btnRefund.Enabled = false;
            btnShip.Enabled = false;
            MessageBox.Show("已完成退幣");
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            int balance = machine.Shipment();
            MachintStatementUpdate(balance);
            if (machine.StatementCheck() <= 0) btnShip.Enabled = false;
            MessageBox.Show("已出貨");
        }
    }

    public class GachaMachine
    {
        private int balance; //餘額
        public int price { get; private set; }  //商品價格

        public GachaMachine(int initialCoin, int initialPrice)
        {
            balance = initialCoin;
            price = initialPrice;
        }
        
        public int StatementCheck()
        {
            if (balance >= price)
                return 1; // 可出貨
            else if (balance > 0 && balance < price)
                return 0; // 餘額不足以出貨
            return -1; // 沒有錢
        }

        public int InsertCoin(int coin)
        {
            balance += coin;
            return balance;
        }

        public int Refund()
        {
            balance = 0;
            return balance;
        }

        public int Shipment()
        {
            if (balance < price) return -1;
            else
            {
                balance -= price;
                return balance;
            }
        }
    }
}
