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
using ISpan2023.EStore.SqlDataLayer;
using ISpan2023.EStore.SqlDataLayer.Extensions;

namespace ISpan2023.EStore.WinApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonGetConnStr_Click(object sender, EventArgs e)
		{
			string key = "default";

			SqlDb.ApplicationName = "connTest";
			SqlDb.ConnectionTimeout = 99;

			string connStr = SqlDb.GetConnectionString(key);
			labelConnStr.Text = connStr;
		}

		private void buttonGetConn_Click(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "connTest";
			SqlDb.ConnectionTimeout = 99;
			SqlDb.Pooling = checkBoxPooling.Checked;

			SqlConnection conn = SqlDb.GetConnection(); // key of connection string = 'default'
			conn.Open();

			var command = new SqlCommand("SELECT Id FROM News", conn);

			var reader = command.ExecuteReader();
			reader.Close();

			// 要記得寫close
			conn.Close();

		}

		private void buttonUsingConn_Click(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "demo: using conn";
			SqlDb.Pooling = false;
			using (SqlConnection conn = SqlDb.GetConnection())
			{
				conn.StatisticsEnabled = true;
				conn.Open();

				// 不必寫close
			}
		}

		private void buttonEditCategory_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBoxCategoryId.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入Category Id, 再試一次");
				return;
			}

			var frm = new FormEditCategory(categoryId);
			frm.ShowDialog();

		}

		private void buttonGetProducts_Click(object sender, EventArgs e)
		{
			var frm = new FormProducts();
			frm.ShowDialog();
		}

		private void buttonAddNews_Click(object sender, EventArgs e)
		{
			var frm = new FormAddNews();
			frm.ShowDialog();
		}

		private void buttonEditNews_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 News Id, 再試一次");
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

		private void buttonMissRequiredValue_Click(object sender, EventArgs e)
		{
			string sql = "INSERT INTO Categories(Name, DisplayOrder)VALUES(@Name, @DisplayOrder)";
			var parameters = SqlParameterBuilder.Create()
				.AddNVarchar("Name", 30, null)
				.AddInt("DisplayOrder", (int?)null)
				.Build();


			try
			{
				// 這行會發生錯誤
				int newId = SqlDb.Create(() => SqlDb.GetConnection(), sql, parameters);
			}
			catch (SqlException sqlEx)
			{
				string message = sqlEx.Message; // 簡易寫法

				// class介於[0,10]是information,不必顯示
				//message = sqlEx.Errors.Cast<SqlError>().Where(err => err.Class > 10).Select(err => err.Message)
				//	.Aggregate((acc, next) => acc + "\r\n" + next);
				//MessageBox.Show(message);

				MessageBox.Show(sqlEx.GetErrorMessage());
			}


		}

		private void buttonConnectFail_Click(object sender, EventArgs e)
		{
			SqlDb.UserId = "dummy";
			try
			{
				var conn = SqlDb.GetConnection();
				conn.Open(); // 這行會錯
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show(sqlEx.GetErrorMessage());
			}
		}

		private void buttonFKFail_Click(object sender, EventArgs e)
		{
			string sql = @"INSERT INTO Products
(CategoryId,Name, Description,Price, Status,ProductImage,Stock)
VALUES
(-1,'','',0, 1,'',1)";

			try
			{
				SqlDb.Create(() => SqlDb.GetConnection(), sql);
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show(sqlEx.GetErrorMessage());
			}
		}

		private void buttonCreateDataTable_Click(object sender, EventArgs e)
		{
			var frm = new FormDataTable();
			frm.ShowDialog();
		}

		private void buttonBatchUpdateCategory_Click(object sender, EventArgs e)
		{
			var frm = new FormBatchUpdateCategory();
			frm.ShowDialog();
		}

		private void buttonMaintainProducts_Click(object sender, EventArgs e)
		{
			var frm = new FormProducts();
			frm.ShowDialog();
		}
	}
}
