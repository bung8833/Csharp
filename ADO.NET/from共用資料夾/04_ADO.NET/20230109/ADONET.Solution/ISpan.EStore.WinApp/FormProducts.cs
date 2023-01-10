using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
	public partial class FormProducts : Form, IGridContainer
	{
		private List<ProductDto> _products;

		public FormProducts(int? categoryId, string productName)
		{
			InitializeComponent();

			this.Load += FormProducts_Load;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			BindCategories();
			Display();
		}

		public void Display()
		{
			int selectedValue = ((Category)comboBoxCategory.SelectedItem).Id;
			int? categoryId = selectedValue==0 ? (int?)null : selectedValue;

			string prodName = textBoxName.Text;

			_products = new ProductRepository().Search(categoryId, prodName).ToList();
			this.dataGridView1.DataSource = _products;
		}

		private void BindCategories()
		{
			var items = new CategoryRepository().Search().Prepend(new Category()).ToList();

			comboBoxCategory.DisplayMember = "Name";
			comboBoxCategory.ValueMember = "Id";
			comboBoxCategory.DataSource = items;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			var frm = new FormCrreateProduct();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int pk = _products[e.RowIndex].Id;
			var frm = new FormEditProduct(pk);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
