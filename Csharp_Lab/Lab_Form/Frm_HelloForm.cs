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
    public partial class Frm_HelloForm : Form
    {
        public Frm_HelloForm()
        {
            InitializeComponent();
        }

        private void Frm_HelloForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string Name = txtBox_name.Text;
            MessageBox.Show("Hello " + Name);
        }

        private void txtBox_name_Enter(object sender, EventArgs e)
        {

        }
    }
}
