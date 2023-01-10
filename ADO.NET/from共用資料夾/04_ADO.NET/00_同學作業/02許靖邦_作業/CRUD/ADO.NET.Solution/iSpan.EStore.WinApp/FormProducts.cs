using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iSpan.EStore.SqlDataLayer;

namespace iSpan.EStore.WinApp
{
    public partial class FormProducts : Form
    {
        private readonly int? categoryId;
        private readonly string productName;

        public FormProducts(int? categoryId, string productName)
        {
            InitializeComponent();
            this.Load += FormProducts_Load;

            this.categoryId = categoryId;
            this.productName = productName;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // ToList 是將惰性求值的結果傳給this
            var products = new ProductRepository().Search(categoryId, productName).ToList();
            this.dataGridView1.DataSource = products;
        }
    }
}
