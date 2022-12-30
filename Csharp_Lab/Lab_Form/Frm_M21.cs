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
    public partial class Frm_M21 : Form
    {
        public Frm_M21()
        {
            InitializeComponent();
        }

        bool flag = false;

        private void btn_Reverse_Click(object sender, EventArgs e)
        {
            Color color1 = Color.BlueViolet;
            Color color2 = Color.GreenYellow;

            //if (flag)
            //{
            //    btn_Reverse.BackColor = color1;
            //}
            //else
            //{
            //    btn_Reverse.BackColor = color2;
            //}

            btn_Reverse.BackColor = flag ? color1 : color2;

            flag = !flag;
        }

        private void btn_Case_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show
                ("xxoo$$&&", "提問", MessageBoxButtons.YesNoCancel);

            switch (Result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Y");
                    break;

                case DialogResult.No:
                    MessageBox.Show("N");
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("Nothing here.");
                    break;

                default:
                    MessageBox.Show("Default");
                    break;
            }
        }

        private void btn_foreach_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //if (item == btn_foreach)
                //{
                //    continue;
                //}

                //if (item.GetType() != typeof(Button))
                //{
                //    continue;
                //}

                if (! (item is Button) )
                {
                    continue;
                }
                item.BackColor = Color.Black;
                item.ForeColor = Color.LightYellow;
                //item.Location = new Point(100, 100);
                //item.Left -= 10;
                //item.Top -= 10;
                //item.Container container
            }
        }

        //private void Item_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
