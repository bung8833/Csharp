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
    public partial class FrmEditNews : Form
    {
        private readonly int newsId;
        public FrmEditNews(int newsId)
        {
            InitializeComponent();
            this.newsId = newsId;

            this.Load += FrmEditNews_Load;
        }

        private void FrmEditNews_Load(object sender, EventArgs e)
        {
            var news = new NewsRepository().GetNews(this.newsId);
            if (news == null)
            {
                MessageBox.Show("Record Not Found");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            txtTitle.Text = news.Title;
            txtDescription.Text = news.Description;
            txtModifiedTime.Text = news.ModifiedTime.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var news = new News
            {
                Id = this.newsId,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                ModifiedTime = DateTime.Now
            };

            int rowAffected = new NewsRepository().Update(news);

            if (rowAffected > 0) MessageBox.Show("記錄已更新");
            else MessageBox.Show("記錄未更新，或記錄已被刪除");

            FrmEditNews_Load(this, EventArgs.Empty);
            CallDisplay();
        }

        private void btnDeleteNews_Click(object sender, EventArgs e)
        {
            new NewsRepository().Delete(this.newsId);
            CallDisplay();
        }

        private void CallDisplay()
        {
            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();

            this.DialogResult = DialogResult.OK;
        }
    }
}
