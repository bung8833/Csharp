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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        int count = 0;

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            count += N.Next(10000);
            //count += Convert.ToInt32(N);

            if (count % 3 == 0)
            {
                lbl_Count.Text = "Count: " + count;
            }
            else if(count % 3 == 1)
            {
                lbl_Count.Text = "Cats: " + count;
            }
            else
            {
                lbl_Count.Text = "Dogs: " + count;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            int c = 0;
            int d = 0;
            int c1 = c++;
            int d1 = ++d;

            

            string result = "c: 0, c++: " + Convert.ToString(c1) 
                          + "\nd: 0, ++d: " + Convert.ToString(d1);

            MessageBox.Show(result);
        }
    }
}
