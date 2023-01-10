using ispan.Estore.SqlData;
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
using static ispqn.Estore.WinApp.Form1;

namespace ispqn.Estore.WinApp
{
	
public partial class Form1 : Form
	{
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getconnectionstring_Click(object sender, EventArgs e)
        {
            SQLDb.ApplicationName = "Test";
            SQLDb.ConnectTimeout = 66;
            SQLDb.Pooling = false;
            string connStr = SQLDb.GetConnectionString("default");
            MessageBox.Show(connStr);
        }

        private void btn_getconnection_Click(object sender, EventArgs e)
        {
            //SQLDb.ApplicationName = "conn test";
            //SQLDb.Pooling = this.checkBox_pooling.Checked;
            //SqlConnection conn =SQLDb.GetConnection("default");
            //conn.Open();

            //var commad = new SqlCommand("select * from Categories" , conn);
            //var reader = commad.ExecuteReader();
            //reader.Close();

            //conn.Close();
            //conn.Dispose();

            //用using以免忘記close
            SQLDb.ApplicationName = "conn test";
            SQLDb.Pooling = this.checkBox_pooling.Checked;

            using( SqlConnection conn = SQLDb.GetConnection("default"))
            {
                using (var commad = new SqlCommand("select * from Categories", conn))
                {
                    conn.Open();

                    var reader = commad.ExecuteReader();
                    reader.Close();
                }
            }
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {

            bool isInt = int.TryParse(text_categoryid.Text, out int categroyId);
            if(isInt == false)
            {
                MessageBox.Show("請輸入正確 categroy Id");
                return;
            }
            var frm = new FormEditCategory(categroyId);
            frm.ShowDialog();
        }


        private void btn_ExectueScalar_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(text_categoryid.Text, out int categroyId);
            if(isInt == false)
            {
				MessageBox.Show("請輸入正確 categroy Id");
				return;
			}
            int countOfProductsByCategory = new CategoryRepository().GetProductCount(categroyId);
            MessageBox.Show(countOfProductsByCategory.ToString());
        }
		
		private void btn_GetProducts_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(text_categoryid.Text, out int value);
			int? categoryId = isInt ? value : (int?)null;
			string prodName = text_productName.Text;
			var frm = new FormProducts(categoryId, prodName);
			frm.dataGridView2.Visible=false;
			frm.ShowDialog();
		}

        private void btn_createnews_Click(object sender, EventArgs e)
        {
            var form = new FormCreateNews();
            form.ShowDialog();
        }

        private void btn_editnews_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textNewsid.Text,out int newsId);
            if(isInt == false)
            {
                MessageBox.Show("請輸入正確News ID");
                return;
            }
            var frm = new FormEditNews(newsId);
            frm.ShowDialog();
        }

        private void btn_delelte_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textNewsid.Text,out int newsId);
            if (!isInt)
            {
                MessageBox.Show("請輸入News Id,再試一次");
                return;
            }
			int rowsAffected = new NewsRepository().Delete(newsId);

            if (rowsAffected > 0)
            {
                MessageBox.Show("紀錄已刪除");
            }
            else
            {
                MessageBox.Show("沒有紀錄被刪除,可能此紀錄已不存在");
            }

		}

        private void buttonUser_Click(object sender, EventArgs e)
        {
            var frm = new FormUser();
            frm.ShowDialog();
        }
		private  void buttonProduct_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(text_categoryid.Text, out int value);
			int? categoryId = isInt ? value : (int?)null;
			string prodName = text_productName.Text;

			var frm = new FormProducts(categoryId, prodName);
            frm.dataGridView1.Visible = false;
			frm.ShowDialog();
		}
       
		private void buttonNews_Click(object sender, EventArgs e)
		{
            var frm = new FormNews();
            frm.ShowDialog();
		}

		private void buttonCategory_Click(object sender, EventArgs e)
		{
            var frm = new FormCategory();
            frm.ShowDialog();
		}
	}
}
