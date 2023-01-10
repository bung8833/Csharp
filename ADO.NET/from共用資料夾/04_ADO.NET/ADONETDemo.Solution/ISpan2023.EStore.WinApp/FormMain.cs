using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormMain : Form
	{
		private readonly bool isMdi;
		public FormMain(bool isMdi)
		{
			InitializeComponent();

			this.isMdi = isMdi;

			if (isMdi) this.IsMdiContainer = true;
		}

		/// <summary>
		/// 判斷已開啟的表單裡,有沒有指定名稱的表單
		/// </summary>
		/// <param name="formName"></param>
		/// <returns></returns>
		private bool IsClosed(string formName)
		{
			return !Application.OpenForms.Cast<Form>().Any(f => f.Name == formName);
		}

		private static FormProducts _frmProducts;
		private void 維護商品ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_frmProducts == null || IsClosed("FormProducts"))
			{
				_frmProducts = new FormProducts();
				if (isMdi) _frmProducts.MdiParent = this;
			}
			var frm = _frmProducts;

			// var frm = new FormProducts();
			// if (isMdi) frm.MdiParent = this;
			frm.Show();
			frm.Activate();
		}

		private void 維護商品分類CToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormEditCategory(1);
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private void 維護NewsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormUsers();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Form1();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}
	}
}
