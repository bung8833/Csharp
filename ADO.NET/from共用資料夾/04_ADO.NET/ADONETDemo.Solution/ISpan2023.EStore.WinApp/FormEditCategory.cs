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
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryId;

		public FormEditCategory(int categoryId)
		{
			_categoryId = categoryId;
			
			InitializeComponent();

			this.Load += FormEditCategory_Load;
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "get single record";

			var category = new CategoryRepository().GetCategory(this._categoryId);
			if (category == null)
			{
				MessageBox.Show("Record not found.");
				this.DialogResult= DialogResult.Cancel; // 會關閉表單
				return;
			}

			// bind data
			textBoxName.Text = category.Name;
			textBoxDisplayOrder.Text = category.DisplayOrder.ToString();
		}
	}
}
