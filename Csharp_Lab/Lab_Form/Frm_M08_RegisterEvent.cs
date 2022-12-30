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
    public partial class Frm_M08_RegisterEvent : Form
    {
        public Frm_M08_RegisterEvent()
        {
            InitializeComponent();
        }

        private void Frm_M08_RegisterEvent_Load(object sender, EventArgs e)
        {

        }

        private void Btn_RegisterEvent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                //this.btn_Register01.Click += new System.EventHandler(this.btn_Register01_Click);
                btn_Register01.Click += new EventHandler(btn_Register01_Click_Event);
                // 左側是button 繫結到 右邊的Method

                btn_Register02.Click += btn_Register02_Click_Event;
                // 新寫法
            }
            // 累加
        }

        private void btn_Register01_Click_Event(object sender, EventArgs e)
        {
            // btn_Register01 has no Click Event yet
            MessageBox.Show("Register01 is clicked.");
        }

        private void btn_Register02_Click_Event(object sender, EventArgs e)
        {
            MessageBox.Show("Register02 is clicked.");
        }

        private void btn_DeRegisterEvent_Click(object sender, EventArgs e)
        {
            btn_Register01.Click -= new EventHandler(btn_Register01_Click_Event);
            btn_Register02.Click -= btn_Register02_Click_Event;
            // 累減
        }

        private void btn_invisible_Click(object sender, EventArgs e)
        {
            btn_target.Visible = false;
        }

        private void btn_undo_invisible_Click(object sender, EventArgs e)
        {
            btn_target.Visible = true;
        }

        private void btn_foo_Click(object sender, EventArgs e)
        {
            btn_target.Text = "foo";
        }

        private void btn_undo_foo_Click(object sender, EventArgs e)
        {
            btn_target.Text = "Target";
        }

        private void btn_CallMethod_Click(object sender, EventArgs e)
        {
            btn_target.SetBounds(150, 150, 100, 100);
        }

        private void btn_CallMethod2_Click(object sender, EventArgs e)
        {
            btn_target.Text = btn_Register01.Text;
        }

        private void btn_MsgBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Loading failed, try again please", "System Message", MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.ServiceNotification);
            
            while(result != DialogResult.Abort)
            {
                if(result == DialogResult.Retry)
                {
                    result = MessageBox.Show(
                        "Try again please", "System Message", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.ServiceNotification);
                }
                
                
                if(result == DialogResult.Ignore)
                {
                    result = MessageBox.Show(
                        "Cannot ignore", "System Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.ServiceNotification);
                }


                if (result == DialogResult.OK)
                {
                    result = MessageBox.Show(
                        "Loading failed, try again please", "System Message", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.ServiceNotification);
                }
            }
            
            MessageBox.Show(
                "Program Error", "System Message", MessageBoxButtons.OK,
                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.ServiceNotification);

            Close();
        }
    }
}
