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
    public partial class FrmEditProduct : Form
    {
        private readonly int productId;

        public FrmEditProduct(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            this.Load += FrmEditProduct_Load;
        }

        private void FrmEditProduct_Load(object sender, EventArgs e)
        {
            ShowContent();
        }

        private void ShowContent()
        {
            var entity = new ProductRepository().GetProduct(productId);

            txtName.Text = entity.Name;
            txtCategoryId.Text = entity.CategoryId.ToString();
            txtDescription.Text = entity.Description;
            txtPrice.Text = entity.Price.ToString();
            txtProductImage.Text =entity.ProductImage;
            txtStock.Text = entity.Stock.ToString();
            chkBoxStatus.Checked = entity.Status;
        }

        private ProductDetail GetModel()
            => new ProductDetail
            {
                Name = txtName.Text,
                CategoryId = this.categoryId,
                Description = txtDescription.Text,
                Price = this.price,
                Stock = this.stock,
                ProductImage = txtProductImage.Text,
                Status = chkBoxStatus.Checked
            };

        private int categoryId
            => int.TryParse(txtCategoryId.Text, out int h) ?
            h
            : 0;

        private int price
            => int.TryParse(txtPrice.Text, out int h) ?
            h
            : 0;

        private int stock
            => int.TryParse(txtStock.Text, out int h) ?
            h
            : 0;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new ProductRepository().Update(GetModel());
            CallDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new ProductRepository().Delete(productId);
            CallDisplay();
        }

        private void CallDisplay()
        {
            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
            this.DialogResult = DialogResult.OK;
        }
    }
}
