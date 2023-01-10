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
    public partial class FrmCategories : Form,IGridContainer
    {
        private CategoryRepository repo;
        public string sName => txtName.Text;
        public int? sDisplayOrder 
            => int.TryParse(txtDisplayOrder.Text, out int text) ? text : (int?)null;
        private List<Category> _category;

        public FrmCategories()
        {
            InitializeComponent();
            repo = new CategoryRepository();
            this.Load += FrmCategories_Load;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _category = repo.Search(sName, sDisplayOrder).ToList();
            dataGridViewCategories.DataSource = _category;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FrmNewCategory();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int categoryId = _category[e.RowIndex].Id;
            var frm = new FrmEditCategory(categoryId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
