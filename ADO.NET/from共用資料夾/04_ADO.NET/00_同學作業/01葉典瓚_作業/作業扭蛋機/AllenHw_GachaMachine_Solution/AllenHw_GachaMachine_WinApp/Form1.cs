using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllenHw_GachaMachine_dll;

namespace AllenHw_GachaMachine_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public BusinessRule MyBusiness;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MyBusiness = new BusinessRule();
            DisplayState();
        }

        private void buttonRefundMoney_Click(object sender, EventArgs e)
        {
            int refundMoney = MyBusiness.RefundMoney();
            string stateString = DisplayState();
            textBoxState.Text = $"退幣{refundMoney}成功\r\n" +
                $"MachineState: {Machine.MachineState}, {stateString}\r\n" +
                $"MachineMoney: {Machine.CustomerMoney}";
        }

        private void buttonToShip_Click(object sender, EventArgs e)
        {
            int remainingMoney = MyBusiness.ShipMoney(new Product().Price);
            string stateString = DisplayState();
            textBoxState.Text = $"出貨1個成功\r\n" +
                $"MachineState: {Machine.MachineState}, {stateString}\r\n" +
                $"MachineMoney: {remainingMoney}";
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            bool Isinsert = int.TryParse(textBoxInsertMoney.Text, out int InsertMoney);
            if (Isinsert && InsertMoney >= 0)
            {
                int remainingMoney = MyBusiness.InsertMoney(InsertMoney);
                string stateString = DisplayState();
                textBoxState.Text = $"insert : {InsertMoney} sucess, \r\n" +
                    $"MachineState: {Machine.MachineState}, {stateString}\r\n" +
                    $"MachineMoney: {remainingMoney}";
            }
            else {
                textBoxState.Text = $"請輸入正整數";
            }
            
        }
        public string DisplayState() {
            var state = Machine.MachineState;
            if (state == State.Waiting)
            {
                buttonRefundMoney.Enabled = false;
                buttonToShip.Enabled = false;
                return "機器沒在工作了，等待下一個客人的操作";
            }
            else if (state == State.Refundable)
            {
                buttonRefundMoney.Enabled = true;
                buttonToShip.Enabled = false;
                return "有投幣但金額還不足";
            }
            else if (state == State.Refundable_CanBeShipped)
            {
                buttonRefundMoney.Enabled = true;
                buttonToShip.Enabled = true;
                return "投入足夠金額，等待客人指令就出貨";
            }
            return "成功弄壞機器啦~~~";

        }


    }
}
