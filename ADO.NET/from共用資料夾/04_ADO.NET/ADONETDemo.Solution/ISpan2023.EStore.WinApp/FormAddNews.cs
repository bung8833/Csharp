using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan2023.EStore.SqlDataLayer;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormAddNews : Form
	{
		public FormAddNews()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Title = textBoxTitle.Text,
				Description = textBoxDescription.Text
			};

			int id = new NewsRepository().Create_2(news);
			MessageBox.Show($"記錄已新增, id={id}");
		}
	}
}
