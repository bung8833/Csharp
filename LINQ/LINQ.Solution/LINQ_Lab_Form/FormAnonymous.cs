using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Lab_Form
{
    public partial class FormAnonymous : Form
    {
        public FormAnonymous()
        {
            InitializeComponent();
        }

        delegate double Payment(double amount);
        
        private void buttonPayment_Click(object sender, EventArgs e)
        {
            Payment Pay;

            if (comboBox1.Text == "20% off")
            {
                Pay = delegate (double amount) { return amount * 0.8; };
            }
            else if (comboBox1.Text == "50% off")
            {
                Pay = (double amount) => { return amount * 0.5; }; // Lambda A
            }
            else
            {
                Pay = (double amount) => amount; // Lambda B
            }

            double price = double.Parse(textBox1.Text);
            double discountedPrice = Pay(price);

            MessageBox.Show($"Payment: {discountedPrice}");
        }
    }
}
