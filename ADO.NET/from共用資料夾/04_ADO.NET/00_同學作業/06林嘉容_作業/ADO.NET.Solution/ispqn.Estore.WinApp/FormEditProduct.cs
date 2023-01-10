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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ispqn.Estore.WinApp
{
	public partial class FormEditProduct : Form
	{
		private readonly int productId;
		public FormEditProduct(int productId)
		{
			InitializeComponent();
			this.productId = productId;

			this.Load += FormEditProduct_Load;
		}

		private void FormEditProduct_Load(object sender, EventArgs e)
		{
			var product = new ProductRepository2().GetProduct(productId);
			BindForm(product);
		}

		private void BindForm(ProductEntity product)
		{
			comboBoxId.Text=product.CategoryId.HasValue?
				product.CategoryId.ToString():string.Empty;
			txtName.Text = product.Name;
			txtDescription.Text = product.Description;
			txtPrice.Text=product.Price.HasValue?
				product.Price.ToString():string.Empty;
			comboBoxstatus.Text=product.Status.ToString();
			txtImage.Text = product.ProductImage;
			txtStock.Text=product.Stock.HasValue?
				product.Stock.ToString():string.Empty;
		
		}
		private int CategoryId => int.Parse(comboBoxId.Text);
		private int? Price => int.TryParse(txtPrice.Text, out int price) ? price : (int?)null;
		private bool? Status => bool.Parse(comboBoxstatus.Text);
		private int? Stock => int.TryParse(txtStock.Text, out int stock) ? stock : (int?)null;
		private ProductEntity GetModel()
			=> new ProductEntity
			{
				Id = this.productId,
				CategoryId = this.CategoryId,
				Name = txtName.Text,
				Description = txtDescription.Text,
				Price = this.Price,
				Status = this.Status,
				ProductImage = txtImage.Text,
				Stock = this.Stock,
			};
		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
		private void buttonupdate_Click(object sender, EventArgs e)
		{
			new ProductRepository2().Update(GetModel());
			NotifyOwner();
		}

		private void buttondelete_Click(object sender, EventArgs e)
		{
			new ProductRepository2().Delete(this.productId);
			NotifyOwner();
		}
	}
	
}
