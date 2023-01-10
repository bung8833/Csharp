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
	public partial class FormCreateProduct : Form
	{
		public FormCreateProduct()
		{
			InitializeComponent();
		}
		private int? CategoryId => int.Parse(comboBoxId.Text);
		private int? Price=>int.Parse(txtPrice.Text);
		private bool? Status=>bool.Parse(comboBoxstatus.Text);
		private int? Stock => int.TryParse(txtStock.Text, out int stock) ? stock : (int?)null;

		private ProductEntity GetModel()
			=> new ProductEntity
			{
				CategoryId = this.CategoryId,
				Name = txtName.Text,
				Description = txtDescription.Text,
				Price = this.Price,
				Status = this.Status,
				ProductImage=txtImage.Text,
				Stock = this.Stock,
			};
		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				new ProductRepository2().Create(GetModel());
			}
			catch(Exception ex)
			{
				MessageBox.Show("新增失敗喔!!!" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
