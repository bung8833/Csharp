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
using iSpan.EStore.SqlDataLayer;

namespace iSpan.EStore.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_GetConnectionString_Click(object sender, EventArgs e)
        {
            SqlDb.ApplicationName = "MyConnectionTest";
            //SqlDb.ConnectionTimeout = 90;
            SqlDb.Pooling = false;

            string connStr = SqlDb.GetConnectionString("default");

            MessageBox.Show(connStr);
        }

        private void btn_GetConnection_Click(object sender, EventArgs e)
        {
            // 看螢幕截圖
            SqlDb.ApplicationName = "conn test"; // 到profiler看連線情形
            SqlDb.Pooling = this.checkBox_Pooling.Checked; // true or false

            // using 避免code有錯 走不到close()
            using (SqlConnection conn = SqlDb.GetConnection("default"))
            {
                using (var command = new SqlCommand("SELECT * FROM Categories", conn))
                {
                    conn.Open();

                    var reader = command.ExecuteReader();
                    reader.Close();
                }
            }
        }

        private void button_EditCategory_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBox_id.Text, out int categoryId);
            if (!isInt)
            {
                MessageBox.Show("請輸入正確的 Category Id");
                return;
            }

            var editCategory = new FormEditCategory(categoryId);
            editCategory.ShowDialog();
        }

        

        //private void btn_GetConnection_Click(object sender, EventArgs e)
        //{
        //    SqlDb.ApplicationName = "conn test"; // 到profiler看連線情形
        //    SqlDb.Pooling = this.checkBox_Pooling.Checked; // true or false
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
