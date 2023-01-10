using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //todo 驗證帳密是否正確

            // 開啟主畫面
            var frm = new FormMain(false);
            frm.Owner = this; // 稍後FormMain關閉時 能再讓Owner顯示出來
            frm.Show();

            this.Hide();
        }
    }
}
