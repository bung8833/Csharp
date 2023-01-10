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
    public partial class FrmNewCategory : Form
    {
        public FrmNewCategory()
        {
            InitializeComponent();
        }

        private Category GetModel()
            => new Category
            {
                Name = txtName.Text,
                DisplayOrder = this.DisplayOrder
            };

        private int DisplayOrder
            => int.TryParse(txtDisplayOrder.Text, out int h) ?
            h
            : 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new CategoryRepository().Create(GetModel());
            }
            catch (Exception ex) { MessageBox.Show("新增失敗\n" + ex.Message); }
            this.DialogResult = DialogResult.OK;

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
        }
    }
}
