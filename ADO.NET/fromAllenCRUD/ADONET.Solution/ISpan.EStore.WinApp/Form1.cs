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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (isInt == false)
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
			if (isInt == false)
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

        //private void buttonGetConnection_Click(object sender, EventArgs e)
        //{
        //    SqlDb.ApplicationName = "conn test";
        //    SqlDb.Pooling = this.checkBoxPooling.Checked; // true  or false
        //    SqlConnection conn = SqlDb.GetConnection("default");
        //    conn.Open();

        //    var command = new SqlCommand("SELECT * FROM Categories", conn);
        //    var reader = command.ExecuteReader();
        //    reader.Close();

        //    conn.Close();
        //    conn.Dispose();

        //}
    }
}
