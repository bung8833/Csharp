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
    public partial class FrmCreateNews : Form
    {
        public FrmCreateNews()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var news = new News
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now
            };
            int newsId = new NewsRepository().Create(news);
            MessageBox.Show($"記錄已新增，Id={newsId}");

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
        }
    }
}
