using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class FormEditNews : Form
    {
        public int NewsId { get; }

        public FormEditNews(int newsId)
        {
            InitializeComponent();
            this.Load += FormEditNews_Load;
            this.NewsId = newsId;
        }

        private void FormEditNews_Load(object sender, EventArgs e)
        {
            var news = NewsRepository_old.GetNews(1);
            if (news == null)
            {
                MessageBox.Show("result not found!");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                textBoxTitle.Text = news.Title;
                textBoxDescription.Text = news.Description;
                labelUpdateTime.Text = news.UpdatedTime.ToString();
            }
            //var news = new News
            //{
            //    title = textBoxTitle.Text,
            //    description = textBoxDescription.Text,
            //    createdTime = DateTime.Now,
            //    updatedTime = DateTime.Now
            //};
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var news = new News
            {
                Id = NewsId,
                Title = textBoxTitle.Text,
                Description = textBoxDescription.Text,
                UpdatedTime = DateTime.Now,
            };
            int rowAffected = new NewsRepository_old().Update(news);

            if (rowAffected > 0) {
                MessageBox.Show("紀錄已更新");
            }
            else 
            {
                MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
            }

            FormEditNews_Load(this, EventArgs.Empty);
        }

        private void FormEditNews_Load_1(object sender, EventArgs e)
        {

        }
    }
}
