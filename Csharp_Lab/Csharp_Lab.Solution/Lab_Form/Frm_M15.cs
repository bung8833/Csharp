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
    public partial class Frm_M15 : Form
    {
        public Frm_M15()
        {
            InitializeComponent();
        }

        private void btn_ValueType_Click(object sender, EventArgs e)
        {
            int B = 30;
            int C = B;
            B = 40;
            MessageBox.Show(Convert.ToString(C));
        }

        private void btn_ReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtBox_ReferenceType;
            // Reference 指派

            tb.Text = "Reference";
            //txtBox_ReferenceType.Text = "Reference";

            txtBox_ReferenceType.BackColor = SystemColors.Highlight;
            //tb.BackColor = SystemColors.Highlight;`   
        }
    }
}
