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
	
	public partial class FormProducts : Form, IGridContainer
	{
        # region ProductRepository2
		private ProductRepository2 repo;
		private List<ProductEntity> _dto;

		public int? SId => int.TryParse(txtId.Text, out int Sid) ? Sid : (int?)null;
		public string SName => txtName.Text;
		#endregion

		private readonly int? categoryId;
		private readonly string prodName; //只有在建構函數才可以改值

		
		public FormProducts(int? categoryId,string prodName)
		{
			InitializeComponent();
			repo = new ProductRepository2();
			this.Load += FormProducts_Load;

			this.categoryId = categoryId; //這裡才能改
			this.prodName = prodName;
		}
		public void Display()
		{
			_dto = repo.Search(SId, SName).ToList();
			dataGridView2.DataSource = _dto;
		}
		private void FormProducts_Load(object sender, EventArgs e)
		{
			#region Form1的search
			var products = new ProductRepository().Search(categoryId, prodName).ToList();
			this.dataGridView1.DataSource = products;
			#endregion

			Display();
		}

		

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			this.dataGridView2.Visible= true;
			this.dataGridView1.Visible= false;
			Display();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			this.dataGridView2.Visible = true;
			this.dataGridView1.Visible = false;
			var frm = new FormCreateProduct();
			frm.Owner= this;
			frm.ShowDialog();
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int productId = _dto[e.RowIndex].Id;

			var frm = new FormEditProduct(productId);
			frm.Owner= this;
			frm.ShowDialog();
		}
	}
}
