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
    public partial class FrmEditCategory : Form
    {
        private readonly int categoryId;

        public FrmEditCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            this.Load += FrmEditCategory_Load;
        }

        private void FrmEditCategory_Load(object sender, EventArgs e)
        {
            ShowContent();
        }

        public void ShowContent()
        {
            var entity = new CategoryRepository().GetCategory(categoryId);

            txtName.Text = entity.Name;
            txtDisplayOrder.Text = entity.DisplayOrder.ToString();
        }

        private Category GetModel()
            => new Category
            {
                Id = categoryId,
                Name = txtName.Text,
                DisplayOrder = this.DisplayOrder,
            };

        private int DisplayOrder
            => int.Parse(txtDisplayOrder.Text);

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new CategoryRepository().Update(GetModel());
            CallDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new CategoryRepository().Delete(this.categoryId);
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
