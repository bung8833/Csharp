using iSpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class FrmProducts : Form
    {
        private readonly int? categoryId;
        private readonly string productName;

        public FrmProducts(int? categoryId, string productName)
        {
            InitializeComponent();
            this.Load += FrmProducts_Load;

            this.categoryId = categoryId;
            this.productName = productName;
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            var products = new ProductRepository().Search(categoryId,productName).ToList();

            this.dataGridView1.DataSource = products;
        }
    }
}
