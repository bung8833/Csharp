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
			if (news == null)
			{
				MessageBox.Show("Record not found.");
				this.DialogResult = DialogResult.Cancel; // 會關閉表單
				return;
			}

			// bind data
			textBoxTitle.Text = news.Title;
			textBoxDescription.Text = news.Description;
			labelModifiedTime.Text = news.ModifiedTime.ToString("yyyy/MM/dd HH:mm:ss");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Id = this.newsId,
				Title = textBoxTitle.Text,
				Description = textBoxDescription.Text,
				ModifiedTime = DateTime.Now
			};

			int rowsAffected = new NewsRepository().Update(news);

			// 如果傳回筆數是1,表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("記錄已更新");
			}
			else
			{
				MessageBox.Show("記錄沒有被異動,可能記錄已經被刪除");
			}

			FormEditNews_Load(this, EventArgs.Empty);
		}
	}
}
