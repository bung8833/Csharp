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
using static iSpan.EStore.SqlDataLayer.ProductRepository;

namespace iSpan.EStore.WinApp
{
    public partial class FrmProductEditor : Form, IGridContainer
    {
        private ProductRepository repo;
        public int? sCategoryId 
            => int.TryParse(txtCategoryId.Text, out int text) ? text : (int?)null;
        public string sCategoryName => txtCategoryName.Text;
        public string sProductName => txtProductName.Text;
        private List<ProductDto> _product;

        public FrmProductEditor()
        {
            InitializeComponent();
            repo = new ProductRepository();
            this.Load += FrmProductEditor_Load;
        }

        private void FrmProductEditor_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _product = repo.Search(sCategoryId, sProductName,sCategoryName).ToList();
            dataGridViewProduct.DataSource = _product;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddProduct();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
