using ISpan.EStore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();

		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			// todo 驗證帳密是否正確


			// 開啟主畫面
			var frm = new FormMain(false);
			frm.Owner = this; // 稍後關閉時,要再度呈現 FormLogin之用
			frm.Show();

			this.Hide();
		}
	}
}
