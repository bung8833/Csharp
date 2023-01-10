using iSpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetConnString_Click(object sender, EventArgs e)
        {
            SqlDB.Application = "WinDemo1";
            SqlDB.ConnectTimeout = 35;
            SqlDB.Pooling = false;

            string connStr = SqlDB.GetConnectionString("default");
            
            MessageBox.Show(connStr);
        }

        private void btnGetConnection_Click(object sender, EventArgs e)
        {
            SqlDB.Application = "conn test";
            SqlDB.ConnectTimeout = 15;
            SqlDB.Pooling = chkPooling.Checked;

            using (SqlConnection conn = SqlDB.GetConnection("default"))
            {
                using(var command = new SqlCommand("select * from Categories", conn))
                {
                    conn.Open();

                    var reader = command.ExecuteReader();
                    reader.Close();
                }
            }
        }

        private void btnReadOneCategory_Click(object sender, EventArgs e)
        {
            bool IsInt = int.TryParse(txtID.Text, out int i);
            if (!IsInt)
            {
                MessageBox.Show("請輸入正確的ID");
                return;
            }

            var frm = new FrmReadOneCategory(i);
            frm.ShowDialog();
        }

        private void btnExcuteScalar_Click(object sender, EventArgs e)
        {
            bool IsInt = int.TryParse(txtID.Text, out int i);
            if (!IsInt)
            {
                MessageBox.Show("請輸入正確的ID");
                return;
            }

            int countOfProductsByCategory = new CategoryRepository().GetProductCount(i);
            MessageBox.Show(countOfProductsByCategory.ToString());
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(txtID.Text, out int value);
            int? categoryId = isInt ? value : (int?)null;
            string productName = txtProductName.Text;

            var frm = new FrmProducts(categoryId,productName);
            frm.ShowDialog();
        }

        private void btnCreateNews_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateNews();
            frm.ShowDialog();
        }

        private void btnEditNews_Click(object sender, EventArgs e)
        {
            bool IsInt = int.TryParse(txtNewsId.Text, out int newsId);
            if (!IsInt)
            {
                MessageBox.Show("請輸入正確的ID");
                return;
            }

            var frm = new FrmEditNews(newsId);
            frm.ShowDialog();
        }

        private void btnDeleteNews_Click(object sender, EventArgs e)
        {
            bool IsInt = int.TryParse(txtNewsId.Text, out int newsId);
            if (!IsInt)
            {
                MessageBox.Show("請輸入正確的ID");
                return;
            }

            int rowAffected = new NewsRepository().Delete(newsId);
            if (rowAffected == 1) MessageBox.Show("記錄已刪除");
            else MessageBox.Show("無記錄被刪除，或記錄不存在");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            var frm = new FrmNews();
            frm.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategories();
            frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductEditor();
            frm.ShowDialog();
        }
    }
}
