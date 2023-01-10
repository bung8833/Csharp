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

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_getConnString_Click(object sender, EventArgs e)
        {
            SqlDB.ConnectTimeout = 30;
            SqlDB.ApplicationName = "haha";
            SqlDB.Pooling = true;
            string connStr = SqlDB.GetConnectionString("default");
            MessageBox.Show(connStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_getConnection_Click(object sender, EventArgs e)
        {
            /*
            SqlDB.ApplicationName = "conn test";
            SqlDB.Pooling = this.PoolingCheckBox.Checked; 
            SqlConnection conn = SqlDB.GetConnection("default");
            conn.Open();

            var command = new SqlCommand("select * from Categories", conn); 
            var reader = command.ExecuteReader();
            reader.Close();

            conn.Close();
            conn.Dispose();
            */
            SqlDB.ApplicationName = "conn test";
            SqlDB.Pooling = this.PoolingCheckBox.Checked;
            // SQL連線會忘記斷資源
            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                var command = new SqlCommand("select * from Categories", conn);
                conn.Open();
                using (var reader = command.ExecuteReader())
                {

                }
            }

            //conn.Close();
            //conn.Dispose();
        }

        private void btnReadDataOnce_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxId.Text, out int categoryId);
            if (isInt == false) {
                MessageBox.Show("請輸入正確的Category Id");
                return;
            }
            var frm = new FormCategoryEdit(categoryId);
            frm.ShowDialog();
        }

        private void buttonExecuteScalar_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxId.Text, out int categoryId);
            if (isInt == false)
            {
                MessageBox.Show("請輸入正確的Category Id");
                return;
            }
            string tableName = "Products";
            int countOfProduct = CategoryRepository_old.GetCountOfTable(tableName, categoryId);
            MessageBox.Show(countOfProduct.ToString());
        }

        private void buttonGetProducts_Click(object sender, EventArgs e)
        {
            //var proFrm = new FormProducts();
            //proFrm.ShowDialog();
        }

        private void buttonGetProducts2_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxId.Text, out int value);
            int? categoryId = isInt ? value : (int?)null;
            string ProdName = textBoxProductName.Text;
            var frm = new FormProducts(categoryId, ProdName);
            frm.ShowDialog();

        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateNews();
            frm.ShowDialog();
        }

        private void buttonUpdateNews_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
            if (isInt == false)
            {
                MessageBox.Show("請輸入正確的News Id");
                return;
            }
            //string tableName = "News";
            //int countOfProduct = CategoryRepository.GetCountOfTable(tableName, newsId);
            //MessageBox.Show(countOfProduct.ToString());

            var frm = new FormEditNews(newsId);
            frm.ShowDialog();
        }

        private void buttonDelNews_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
            if (isInt == false)
            {
                MessageBox.Show("請輸入正確的News Id");
                return;
            }

            int rowAffected = new NewsRepository_old().Delete(newsId);

            if (rowAffected > 0)
            {
                MessageBox.Show("紀錄已更新");
            }
            else
            {
                MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
            }
        }

        private void buttonCallUserForm_Click(object sender, EventArgs e)
        {

            var frm = new FormUserManage();
            frm.ShowDialog();
        }
    }
}
