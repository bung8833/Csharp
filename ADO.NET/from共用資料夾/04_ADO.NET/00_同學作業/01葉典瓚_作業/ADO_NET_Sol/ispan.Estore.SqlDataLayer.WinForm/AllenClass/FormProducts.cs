using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class FormProducts : Form
    {
        private readonly int? category;
        private readonly string prodName;

        public FormProducts(int? category, string prodName)
        {
            InitializeComponent();
            this.Load += FormProducts_Load;
            this.category = category;
            this.prodName = prodName;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            // .ToList是要惰性求值的資料全部回給this function
            var products = new ProductRepository_old().Search(category, prodName).ToList();
            this.dataGridView1.DataSource = products;
        }
    }
}
