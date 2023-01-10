using iSpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
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
                MessageBox.Show("Record not found");
                this.DialogResult = DialogResult.Cancel; // 會關閉表單
                return;
            }

            // bind data
            textBox_Title.Text = news.Title;
            textBox_Description.Text = news.Description;
            label_ModifiedTime.Text = news.ModifiedTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            News news = new News()
            {
                Id = this.newsId,
                Title = textBox_Title.Text,
                Description = textBox_Description.Text,
                ModifiedTime = DateTime.Now
            };

            int rowsAffected = new NewsRepository().Update(news);

            if (rowsAffected > 0)
            {
                MessageBox.Show($"{rowsAffected}筆紀錄已更新");
            }
            else
            {
                MessageBox.Show("紀錄沒有被異動，可能紀錄已被刪除");
            }

            FormEditNews_Load(this, EventArgs.Empty);
        }
    }
}
