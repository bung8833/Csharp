using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
    public partial class Form1 : Form, IGridContainer
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Display()
        {
            MessageBox.Show("user 新增了");
        }

        private void buttonGetConnectionString_Click(object sender, EventArgs e)
        {
            SqlDb.ApplicationName = "myTest";
            SqlDb.ConnectTimeout = 99;
            SqlDb.Pooling = true;
            string connStr = SqlDb.GetConnectionString("default");

            MessageBox.Show(connStr);
        }

        private void buttonGetConnection_Click(object sender, EventArgs e)
        {
            SqlDb.ApplicationName = "conn test";
            SqlDb.Pooling = this.checkBoxPooling.Checked; // true  or false

            using (SqlConnection conn = SqlDb.GetConnection("default")) {
                using (var command = new SqlCommand("SELECT * FROM Categories", conn)) {
                    conn.Open();

                    var reader = command.ExecuteReader();
                    reader.Close();
                }
            }

        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textboxCategoryId.Text, out int categoryId);
            if (isInt = false)
            {
                MessageBox.Show("請輸入正確 Category Id");
                return;
            }

            var frm = new FormEditCategory(categoryId);
            frm.ShowDialog();
        }

        private void buttonExecuteScalar_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textboxCategoryId.Text, out int categoryId);
			if (isInt = false)
			{
				MessageBox.Show("請輸入正確 Category Id");
				return;
			}

			int countOfProductsByCategory = 
                new CategoryRepository().GetProductCount(categoryId);
            MessageBox.Show(countOfProductsByCategory.ToString());
        }

        private void buttonGetProducts_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textboxCategoryId.Text, out int value);
            int? categoryId = isInt ? value : (int?)null;
            string prodName = textBoxProductName.Text;

			var frm = new FormProducts(categoryId, prodName);
            frm.ShowDialog();
        }

        private void buttonCreateNews_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateNews();
            frm.ShowDialog();
        }

        private void buttonEditNews_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
			if (isInt = false)
			{
				MessageBox.Show("請輸入正確 News Id");
				return;
			}

			var frm = new FormEditNews(newsId);
			frm.ShowDialog();
		}

        private void buttonDeleteNews_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 News Id, 再試一次");
				return;
			}

			int rowsAffected = new NewsRepository().Delete(newsId);
			if (rowsAffected == 1)
			{
				MessageBox.Show("記錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有記錄被刪除, 可能此記錄不存在");
			}
		}

        private void buttonMaintainUsers_Click(object sender, EventArgs e)
        {
            var frm = new FormUsers();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateUser();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
