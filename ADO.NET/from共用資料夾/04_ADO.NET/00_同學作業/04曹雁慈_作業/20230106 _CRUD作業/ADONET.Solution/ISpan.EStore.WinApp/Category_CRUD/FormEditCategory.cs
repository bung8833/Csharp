using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.WinApp
{
    public partial class FormEditCategory : Form
    {
        private readonly int categoryId;

        public FormEditCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;

            this.Load += FormEditCategory_Load;     
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            Category category = new CategoryRepository().GetCategory(categoryId);

            if (category == null)
            {
                MessageBox.Show("record not found.");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                textboxName.Text = category.Name;
                textboxDisplayOrder.Text = category.DisplayOrder.ToString();
            }
        }
		private void buttonSave_Click(object sender, EventArgs e)
		{

		}
	}
}
