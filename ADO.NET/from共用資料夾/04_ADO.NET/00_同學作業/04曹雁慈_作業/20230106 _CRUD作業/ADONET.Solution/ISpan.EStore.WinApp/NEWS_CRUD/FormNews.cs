using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan.EStore.WinApp.NEWS_CRUD.FormNews;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.EStore.WinApp.NEWS_CRUD
{

	public partial class FormNews : Form, IGridContainer
	{
		private NewsRepository repo;
		private List<News> _news;
		public string SId => textBoxId.Text;
		public string STitle => textBoxTitle.Text;
		public string SDescription => textBoxDescription.Text;
		public FormNews()
		{
			InitializeComponent();
			repo = new NewsRepository();
			this.Load += FormNews_Load;

		}

		private void FormNews_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_news = repo.Search(SId, STitle, SDescription).ToList();
			dataGridView1.DataSource = _news;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateNews();
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int newsId = _news[e.RowIndex].Id;
			var frm = new FormEditNews(newsId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
