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
    public partial class Frm_M17_enum : Form
    {
        public Frm_M17_enum()
        {
            InitializeComponent();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            int Role = 1;
            const int Admin = 1, User = 2;

            if (Role == Admin)
            {
                btn_Product.Enabled = true;
            }
            else
            {
                btn_Product.Enabled = false;
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Admin.");
        }

        private void btn_enum_Click(object sender, EventArgs e)
        {
            //int Role = 0;

            //if (Role == (int)UserRole.Admin)
            //{
            //    btn_Product.Enabled = true;
            //}
            //else
            //{
            //    btn_Product.Enabled= false;
            //}

            UserRole Role = UserRole.Admin;

            //if (Role == UserRole.Admin)
            //{
            //    btn_Product.Enabled = true;
            //}
            //else
            //{
            //    btn_Product.Enabled = false;
            //}
            // enum: easy to read and manage

            switch (Role) // 只有Admin or not Admin, 用if就可以
            {
                case UserRole.Admin:
                    btn_Product.Enabled = true;
                    break;

                case UserRole.User:
                    btn_Product.Enabled = false;
                    break;

                case UserRole.User1:
                    btn_Product.Enabled = false;
                    break;
                
                default:
                    btn_Product.Enabled = false;
                    break;
            }
        }
    }
}
