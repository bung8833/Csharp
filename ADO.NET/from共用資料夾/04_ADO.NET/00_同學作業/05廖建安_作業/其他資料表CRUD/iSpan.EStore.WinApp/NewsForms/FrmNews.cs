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
    public partial class FrmNews : Form, IGridContainer
    {
        private NewsRepository repo;
        public string sTitle => txtTitle.Text;
        public string sDescription => txtDescription.Text;
        private List<News> _news;
        public FrmNews()
        {
            InitializeComponent();
            repo = new NewsRepository();
            this.Load += FrmNews_Load;
        }

        private void FrmNews_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _news = repo.Search(sTitle,sDescription).ToList();
            dataGridViewNews.DataSource = _news;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateNews();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridViewNews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int newsId = _news[e.RowIndex].Id;
            var frm = new FrmEditNews(newsId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
