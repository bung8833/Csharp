using ispan.Estore.SqlData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
	public partial class FormCategory : Form, IGridContainer
	{
		private CategoryRepository repo;
		private List<Category> categories;

		public int? SId => int.TryParse(txtId.Text, out int SId)? SId : (int?)null;
		public string SName=>txtName.Text;

		public FormCategory()
		{
			InitializeComponent();
			repo = new CategoryRepository();

			this.Load += FormCategory_Load;
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			categories=repo.Search(SId,SName).ToList();

			dataGridView1.DataSource = categories;

		}

		private void buttonsearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateCategory();
			frm.Owner= this;

			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int categoryId = categories[e.RowIndex].Id;

			var frm = new FormEditCategory(categoryId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
