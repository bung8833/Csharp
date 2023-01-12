using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Lab_Form
{
	public partial class Lab_匿名函式 : Form
	{
		public Lab_匿名函式()
		{
			InitializeComponent();
		}

		delegate double Payment(double Amount);

		private void button1_Click(object sender, EventArgs e)
		{
			Payment Pay;

			if (cmbDiscount.Text == "50%off")
			{
				Pay = delegate (double Amount ) { return Amount * 0.5; };
			}
			else
			{
				//Pay = delegate (double Amount) { return Amount * 0.8; };
				//Pay = (double Amount) => { return Amount * 0.8; };   // Lambda A
				//Pay = (double Amount) => Amount * 0.8;  // Lambda B
				Pay = Amount => Amount * 0.8;  // Lambda C
			}

			double amount = double.Parse(txtAmount.Text);

			double price = Pay(amount);

			MessageBox.Show("折扣後金額: " + price);
		}

		double Discount50off(double Amount)
		{
			return Amount * 0.5;
		}

		double Discount20off(double Amount)
		{
			return Amount * 0.8;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Button btn = new Button();
			//btn.Text = "Test Button";
			//btn.Name = "btnTest";
			//btn.Width = 100;
			//btn.Height = 50;

			//flpButtons.Controls.Add(btn);

			flpButtons.Controls.Clear();

			int num = int.Parse( txtButtonsNumber.Text);

			for(int i = 1; i <= num; i++)
			{
				Button btn = new Button();
				btn.Text = i.ToString();
				btn.Name = $"btn{i}";
				btn.Width = 100;
				btn.Height = 50;

				bool flag = i % 2 == 0;
				btn.BackColor = flag ? Color.Tan : Color.OldLace;
				btn.ForeColor = flag ? Color.Maroon : Color.CadetBlue;

				btn.Click += delegate(object Sender , EventArgs E)
				{
					MessageBox.Show(btn.Text);
				};

				flpButtons.Controls.Add(btn);
			}
		}

		
	}
}
