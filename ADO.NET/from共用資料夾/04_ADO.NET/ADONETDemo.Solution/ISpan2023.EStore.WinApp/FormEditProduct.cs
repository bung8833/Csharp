using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormEditProduct : Form
	{
		private readonly int _pk;

		public FormEditProduct(int pk)
		{
			_pk = pk;
			InitializeComponent();

			this.Load +=FormEditProduct_Load;
		}

		private void FormEditProduct_Load(object sender, EventArgs e)
		{
			BindCategories();

			var entity = new ProductRepository().GetProduct(this._pk);
			if (entity == null)
			{
				MessageBox.Show("record not found");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			BindData(entity);
		}
		private void BindCategories()
		{
			var items = new CategoryRepository().Search().Prepend(new Category()).ToList();

			comboBoxCategoryId.DisplayMember = "Name";
			comboBoxCategoryId.ValueMember = "Id";
			comboBoxCategoryId.DataSource = items;
		}

		private void BindData(ProductEntity entity)
		{
			Func<string, object, bool> funcSetter = (value, item) => ((Category)item).Id.ToString() == value;
			comboBoxCategoryId.SetValue(entity.CategoryId.ToString(), funcSetter);
			textBoxName.Text = entity.Name;
			textBoxDescription.Text =entity.Description;
			textBoxPrice.Text = entity.Price.ToString();
			BindStatus(entity.Status);
			textBoxStock.Text = entity.Stock.ToString();
			textBoxImage.Text = entity.ProductImage;

		}

		private void BindStatus(bool value)
		{
			if (value)
			{
				radioButtonStatus1.Checked = true;
			}
			else
			{
				radioButtonStatus0.Checked = true;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var entity = new ProductEntity()
			{
				Id = this._pk,
				CategoryId = this.CategoryId,
				Name = textBoxName.Text,
				Description = textBoxDescription.Text,
				Price = this.Price,
				Status = this.Status,
				Stock = this.Stock,
				ProductImage = textBoxImage.Text
			};

			var rowsAffected = new ProductRepository().Update(entity);

			NotifyOwner();
		}

		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			container.Display();

			this.DialogResult = DialogResult.OK;
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

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您確定要刪除記錄?", "刪除記錄",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.No) return;

			new ProductRepository().Delete(this._pk);

			NotifyOwner();
		}
	}
}
