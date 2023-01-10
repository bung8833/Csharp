using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan.EStore.SqlDataLayer.ProductRepository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.ESstore.WinApp
{
	public partial class FormProducts : Form, IGridContainer
	{
		private readonly int? categoryId; // readonly表示只能在同類別的建構函數中改值
		private readonly string prodName;
        //private ProductRepository repo;
        //private List<ProductEntity> _products;

        public FormProducts(int? categoryId, string prodName)
		{
			InitializeComponent();
			this.Load += FormProducts_Load;

			this.categoryId = categoryId;
			this.prodName = prodName;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{

            Display();

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateProduct();
            frm.Owner = this;
            frm.ShowDialog();
        }

        public void Display()
        {
            var products = new ProductRepository().Search(categoryId, prodName).ToList();
			this.dataGridView1.DataSource = products;
        }
    }
}
