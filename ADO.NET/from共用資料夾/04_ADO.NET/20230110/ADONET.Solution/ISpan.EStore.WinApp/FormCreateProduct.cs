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
	public partial class FormCrreateProduct : Form
	{
		public FormCrreateProduct()
		{
			InitializeComponent();

			this.Load +=FormCrreateProduct_Load;
		}

		private void FormCrreateProduct_Load(object sender, EventArgs e)
		{
			BindCategories();

		}

		private void BindCategories()
		{
			var items = new CategoryRepository().Search().Prepend(new Category()).ToList();

			comboBoxCategoryId.DisplayMember = "Name";
			comboBoxCategoryId.ValueMember = "Id";
			comboBoxCategoryId.DataSource = items;
		}

		private int CategoryId => ((Category)this.comboBoxCategoryId.SelectedItem).Id;

		private int Price => Convert.ToInt32(textBoxPrice.Text);

		private int Stock => Convert.ToInt32(textBoxStock.Text);

		private bool Status
		{
			get
			{
				if (radioButtonStatus1.Checked) return true;
				if (radioButtonStatus0.Checked) return false;
				throw new Exception("Status 必填");
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var entity = new ProductEntity()
			{
				CategoryId = this.CategoryId,
				Name = textBoxName.Text,
				Description = textBoxDescription.Text,
				Price = this.Price,
				Status = this.Status,
				Stock = this.Stock,
				ProductImage = textBoxImage.Text
			};

			var rowsAffected = new ProductRepository().Create(entity);

			IGridContainer container = this.Owner as IGridContainer;
			container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
