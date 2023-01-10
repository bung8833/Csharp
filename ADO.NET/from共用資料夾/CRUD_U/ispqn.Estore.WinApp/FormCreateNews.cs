using ispan.Estore.SqlData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
	public partial class FormCreateNews : Form
	{
		public FormCreateNews()
		{
			InitializeComponent();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Title =tex_title.Text,
				Description = tex_Description.Text,
				CreatedTime = DateTime.Now,
				ModifiedTime = DateTime.Now
			};
			try
			{
				int newId = new NewsRepository().Create(news);
				MessageBox.Show($"紀錄已新增,={newId}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗喔!!!" + ex.Message);
			}
			

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult= DialogResult.OK;
		}

		
	}
}
