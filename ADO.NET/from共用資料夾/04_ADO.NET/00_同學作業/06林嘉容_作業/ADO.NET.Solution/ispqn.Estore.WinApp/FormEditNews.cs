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
	public partial class FormEditNews : Form
	{
		private readonly int newsId;
		public FormEditNews(int newsId)
		{
			InitializeComponent();
			this.newsId = newsId;

			this.Load += FormEditNews_Load; 
		}

		private void FormEditNews_Load(object sender, EventArgs e)
		{
			News news = new NewsRepository().GetNews(this.newsId);
			if(news == null)
			{
				MessageBox.Show("Record not Found");
				this.DialogResult = DialogResult.Cancel; //會關閉表單
				return;
			}

			//bind data
			textTitle.Text =news.Title;
			textDescription.Text =news.Description;
			labelModified.Text = news.ModifiedTime.ToString("yyyy/MM/dd HH:mm:ss");
		
		}

		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				ID = this.newsId,
				Title = textTitle.Text,
				Description = textDescription.Text,
				ModifiedTime = DateTime.Now,
			};

			int rowsAffected = new NewsRepository().Update(news);

			if(rowsAffected > 0)
			{
				MessageBox.Show("已經更新");
			}
			else
			{
				MessageBox.Show("紀錄沒有異動，可能紀錄已被刪除");

			}

			FormEditNews_Load(this, EventArgs.Empty);
			NotifyOwner();
		}

		private void buttondelete_Click(object sender, EventArgs e)
		{
			new NewsRepository().Delete(newsId);

			NotifyOwner();
		}
	}
}
