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
    public partial class FormCreateNews : Form
    {
        public FormCreateNews()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool titleIsNull = string.IsNullOrEmpty(textBox_Title.Text);
            bool descriptionIsNull = string.IsNullOrEmpty(textBox_Description.Text);

            if (descriptionIsNull)
            {
                MessageBox.Show($"請輸入內容");
                return;
            }

            if (titleIsNull)
            {
                MessageBox.Show($"請輸入標題");
                return;
            }

            News news = new News()
            {
                Title = textBox_Title.Text,
                Description = textBox_Description.Text,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now
            };

            int newId = new NewsRepository().Create(news);
            MessageBox.Show($"紀錄已新增, id = {newId}");
        }
    }
}
