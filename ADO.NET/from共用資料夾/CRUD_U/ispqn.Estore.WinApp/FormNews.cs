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
	public partial class FormNews : Form,IGridContainer
	{
		private NewsRepository repo;
		private List<News> news;

		public string STitle => txtTitle.Text;
		public FormNews()
		{
			InitializeComponent();
			repo  =new NewsRepository();

			this.Load += FormNews_Load;
		}

		private void FormNews_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			news =repo.Search(STitle).ToList();

			dataGridView1.DataSource = news;
		}

		
		private void buttonadd_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateNews();
			frm.Owner= this;
			frm.ShowDialog();
		}

		private void buttonsearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int newsId = news[e.RowIndex].ID;

			var frm = new FormEditNews(newsId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
