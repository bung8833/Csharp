using ispan.Estore.SqlData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispqn.Estore.WinApp
{
	public partial class FormCreateCategory : Form
	{
		public FormCreateCategory()
		{
			InitializeComponent();
		}
		private int? DisplayOrder => int.TryParse(txtDisplayOrder.Text, out int DisplayOrder) ? DisplayOrder : (int?)null;

		private Category GetModel()
			=> new Category
			{
				Name= txtName.Text,
				DisplayOrder = this.DisplayOrder,
			};

		private void buttonsave_Click(object sender, EventArgs e)
		{
			try
			{
				new CategoryRepository().Create(GetModel());
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗喔!!!" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
