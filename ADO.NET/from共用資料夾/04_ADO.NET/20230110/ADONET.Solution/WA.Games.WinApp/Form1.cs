using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA.Games.WinApp
{
	public partial class Form1 : Form
	{
		GachaMachine machine;

		public Form1()
		{
			InitializeComponent();

			machine = new GachaMachine(50);
			this.Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			SetEnv();
		}

		private void buttonPutMoney_Click(object sender, EventArgs e)
		{
			int.TryParse(textBoxMoney.Text, out int money);
			machine.CurrentState.PutMoney(money);

			SetEnv();
		}

		private void SetEnv()
		{
			buttonRefund.Enabled = (machine.Money > 0);
			buttonShip.Enabled=(machine.CurrentState.GetType() == typeof(ReadyToShip));
		}

		private void buttonRefund_Click(object sender, EventArgs e)
		{
			machine.CurrentState.RefundMoney();

			SetEnv();
		}

		private void buttonShip_Click(object sender, EventArgs e)
		{
			machine.CurrentState.TakeOutProduct();

			SetEnv();
		}
	}
}
