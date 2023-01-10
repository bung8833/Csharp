using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormDataTable : Form
	{
		public FormDataTable()
		{
			InitializeComponent();

			this.Load +=FormDataTable_Load;
		}

		private DataTable dt;
		private void FormDataTable_Load(object sender, EventArgs e)
		{
			// 純手工建立 DataTable
			dt = new DataTable();

			#region 建立欄位

			dt.Columns.Add("Id", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("DateOfBirth", typeof(DateTime));

			#endregion

			#region 建立記錄

			for (int i = 0; i < 5; i++)
			{
				DataRow newRow = dt.NewRow();
				newRow["ID"] = i;
				newRow["Name"] = $"Name {i}";
				newRow["DateOfBirth"] = DateTime.Today.AddYears(-20 + i);

				dt.Rows.Add(newRow);
			}

			#endregion

			// 繫結到控制項
			this.dataGridView1.DataSource = dt;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			(DateTime? begin, DateTime? end) criteria = GetCriteria();

			var view = new DataView(dt);
			string filter = string.Empty;

			if (criteria.begin.HasValue == true)
			{
				filter += $" and DateOfBirth>='{criteria.begin:yyyy/MM/dd}'";
			}

			if (criteria.end.HasValue == true)
			{
				filter += $" and DateOfBirth <='{criteria.end:yyyy/MM/dd}'";
			}

			if (filter != string.Empty)
			{
				filter = filter.Substring(5);
			}
			view.RowFilter = filter;

			// 繫結到控制項
			this.dataGridView1.DataSource = view;
		}

		private (DateTime? begin, DateTime? end) GetCriteria()
		{
			DateTime? dtBegin = DateTime.TryParse(textBoxBegin.Text, out DateTime begin) ? begin : (DateTime?)null;
			DateTime? dtEnd = DateTime.TryParse(textBoxEnd.Text, out DateTime end) ? end : (DateTime?)null;

			// 若都有值且大小相反就對調
			return (dtBegin.HasValue && dtEnd.HasValue && dtBegin.Value > dtEnd.Value)
				? (dtEnd, dtBegin)
				: (dtBegin, dtEnd);

		}
	}
}
