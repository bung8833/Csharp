using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan.EStore.SqlDataLayer.ProductRepository;

namespace ISpan.ESstore.WinApp
{
    public partial class FormCreateProduct : Form
    {
        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private ProductEntity GetModel()
        => new ProductEntity
        {
            CategoryId = int.Parse(textBoxCategoryId.Text),
            Name = textBoxName.Text,
            Description = textBoxDescription.Text,
            Price = int.Parse(textBoxPrice.Text),
            Status = int.Parse(textBoxStatus.Text),
            ProductImage = textBoxProductImage.Text
        };

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                new ProductRepository().Create(GetModel());
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗\r\n" + ex.Message);

            }


            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();

            this.DialogResult = DialogResult.OK;
        }
    }
}
