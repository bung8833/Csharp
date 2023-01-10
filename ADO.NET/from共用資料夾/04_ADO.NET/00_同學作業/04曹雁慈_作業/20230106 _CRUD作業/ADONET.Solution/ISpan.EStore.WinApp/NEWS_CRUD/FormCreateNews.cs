using ISpan.EStore.SqlDataLayer;
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
	public partial class FormCreateNews : Form
	{
		public FormCreateNews()
		{
			InitializeComponent();
		}

	//	private News GetModel()
 //=> new News
 //{
	// Title = textBoxTitle.Text,
	// Description = textBoxDescription.Text,
	// CreatedTime = DateTime.Now,
	// ModifiedTime = DateTime.Now
 //};
		private void buttonSave_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Title = textBoxTitle.Text,
				Description = textBoxDescription.Text,
				CreatedTime = DateTime.Now,
				ModifiedTime = DateTime.Now
			};


			int newId = new NewsRepository().Create(news);
			MessageBox.Show($"記錄已新增, id={newId}");

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			this.DialogResult = DialogResult.OK;
		}


	}
}
