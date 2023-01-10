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

namespace ISpan2023.EStore.WinApp
{
	public partial class FormBatchUpdateCategory : Form
	{
		public FormBatchUpdateCategory()
		{
			InitializeComponent();

			this.Load +=FormBatchUpdateCategory_Load;
		}

		private void FormBatchUpdateCategory_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = null;

			using (var conn = SqlDb.GetConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = "SELECT * FROM Categories";
					da = new SqlDataAdapter(cmd);
					da.Fill(dt);
				}
			}

			dataGridView1.DataSource = dt;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = (DataTable)dataGridView1.DataSource;
				DataTable result = new CategoryRepository().Update(dt);

				dataGridView1.DataSource = result;
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show(sqlEx.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("error:" + ex.Message);
			}
		}

		/// <summary>
		/// 使用 conn.BeginTransaction 批次同步記錄
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonUpdate2_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = (DataTable)dataGridView1.DataSource;
				new CategoryRepository().Update2(dt);

				FormBatchUpdateCategory_Load(this, null);
			}
			catch (SqlException sqlEx)
			{
				string msg = sqlEx.Message + "\r\n如果您有刪除了不允許刪除的記錄, 請按'重新整理'以便重新從資料庫取得目前記錄";
				MessageBox.Show(msg);
			}
			catch (Exception ex)
			{
				MessageBox.Show("error:" + ex.Message);
			}


		}

		private void buttonReload_Click(object sender, EventArgs e)
		{
			FormBatchUpdateCategory_Load(this, null);

		}
	}
}
