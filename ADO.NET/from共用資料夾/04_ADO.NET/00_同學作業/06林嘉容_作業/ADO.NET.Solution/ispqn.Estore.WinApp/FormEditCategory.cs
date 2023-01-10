using ispan.Estore.SqlData;
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

namespace ispqn.Estore.WinApp
{
    public partial class FormEditCategory : Form
    {
        private readonly int categroyId;

        public FormEditCategory(int categroyId)
        {
            InitializeComponent();
            this.categroyId = categroyId;

            this.Load += FormEditCategory_Load;
        }
		

		private void FormEditCategory_Load(object sender, EventArgs e)
        {
			Category category = new CategoryRepository().GetCategory(categroyId);
			#region Form1

			if (category == null)
            {
                MessageBox.Show("record not found.");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                txtName.Text =category.Name;
                txtDisplayOrder.Text = category.DisplayOrder.ToString();
            }
			//using (var conn = SQLDb.GetConnection())
			//{
			//    string sql = $"select * from Categories where id ={categroyId}";
			//    using (var commad =new SqlCommand(sql, conn))
			//    {
			//        conn.Open();
			//        var reader = commad.ExecuteReader();
			//        if (reader.Read())
			//        {
			//            txtName.Text = reader["Name"].ToString();
			//            txtDisplayOrder.Text = reader["DisplayOrder"].ToString();  
			//        }
			//        else
			//        {
			//            MessageBox.Show("record not found.");
			//            this.DialogResult = DialogResult.Cancel;
			//            return;
			//        }
			//    }
			//}
			#endregion

			BindForm(category);
		}

		private void BindForm(Category category)
		{
			txtName.Text = category.Name;
			txtDisplayOrder.Text = category.DisplayOrder.HasValue? category.DisplayOrder.ToString():string.Empty;
		}
		private int? DisplayOrder => int.TryParse(txtDisplayOrder.Text, out int DisplayOrder) ? DisplayOrder : (int?)null;
		private Category GetModel()
			=> new Category
			{
				Id = this.categroyId, //很重要
				Name = txtName.Text,
				DisplayOrder = this.DisplayOrder,
			};
		private void NotifyOwner()
		{
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
		private void buttonupdate_Click(object sender, EventArgs e)
		{
			new CategoryRepository().Update(GetModel());
			
			NotifyOwner();
		}

		private void buttondelete_Click(object sender, EventArgs e)
		{
			new CategoryRepository().Delete(categroyId);

			NotifyOwner();
		}
	}
}
