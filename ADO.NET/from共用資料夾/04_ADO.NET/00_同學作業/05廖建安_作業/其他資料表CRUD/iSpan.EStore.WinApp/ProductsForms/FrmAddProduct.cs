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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private ProductDetail GetModel()
            => new ProductDetail
            {
                Name = txtName.Text,
                CategoryId=this.categoryId,
                Description=txtDescription.Text,
                Price=this.price,
                Stock=this.stock,
                ProductImage=txtProductImage.Text,
                Status=chkBoxStatus.Checked
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new ProductRepository().Create(GetModel());
            }
            catch (Exception ex) { MessageBox.Show("新增失敗\n" + ex.Message); }
            this.DialogResult = DialogResult.OK;

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
        }
    }
}
