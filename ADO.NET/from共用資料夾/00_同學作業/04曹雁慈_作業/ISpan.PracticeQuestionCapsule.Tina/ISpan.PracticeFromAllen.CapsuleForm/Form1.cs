using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapsuleClass;

namespace ISpan.PracticeFromAllan.CapsuleForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 扭蛋機
		/// </summary>
		

		int wallet = 0; //目前扭蛋機裡的金額
		int coin = 0; //投幣金額

		bool isNumber; //txtBoxCoin中是否為數字

		string result = string.Empty; //輸出的字串

		private void buttonCoin_Click(object sender, EventArgs e)
		{
			isNumber = int.TryParse(textBoxCoin.Text, out coin);
			if (isNumber) 
			{
				wallet = Capsule.ClacCoin(wallet, coin);
				resultstring();
				buttonEnable();
			}

		}

		private void buttonRefund_Click(object sender, EventArgs e)
		{
			if (Capsule.CanRefund(wallet))
			{
				wallet = 0;
				MessageBox.Show("已完成退幣作業");
				resultstring();
				buttonEnable();
			};
		}

		private void buttonShip_Click(object sender, EventArgs e)
		{
			if (Capsule.CanShip(wallet))
			{
				wallet = 0;
				MessageBox.Show("已完成出貨作業");
				resultstring();
				buttonEnable();
			};
		}

		private void resultstring()
		{
			switch (Capsule.CapsuleState(wallet))
			{
				case 0:
					result = $"standbyState 機器沒在工作，等待下一個客人操作。";
					break;
				case 1:
					result = $"insufficientAmountState 有投幣，但金額還不夠足夠。";
					break;
				case 2:
					result = $"readyToShip 投入足夠金額，等待客人指令就出貨。";
					break;
				default:
					break;
			}
			result += $"\r\nMoney:{wallet}元";
			this.textBoxMessage.Text = result;
		}

		private void buttonEnable()
		{
			this.buttonRefund.Enabled = Capsule.CanRefund(wallet);
			this.buttonShip.Enabled = Capsule.CanShip(wallet);
		}

	}
}