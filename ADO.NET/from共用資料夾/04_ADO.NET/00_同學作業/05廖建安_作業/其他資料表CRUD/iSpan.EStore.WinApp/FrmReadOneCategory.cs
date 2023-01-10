using iSpan.EStore.SqlDataLayer;
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

namespace iSpan.EStore.WinApp
{
    public partial class FrmReadOneCategory : Form
    {
        private readonly int categoryId;

        public FrmReadOneCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;

            this.Load += FrmEditCategory_Load;
        }

        private void FrmEditCategory_Load(object sender, EventArgs e)
        {
            Category category = new CategoryRepository().GetCategory(categoryId);

            if (category == null)
            {
                MessageBox.Show("Record Not Found");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                txtName.Text = category.Name;
                txtDisplayOrder.Text = category.DisplayOrder.ToString();
            }

            //using (var conn = SqlDB.GetConnection())
            //{
            //    string sql = $"SELECT * FROM Categories WHERE Id={categoryId}";
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        conn.Open();
            //        var reader = command.ExecuteReader();

            //        if (category == null)
            //        {
            //            MessageBox.Show("Record Not Found");
            //            this.DialogResult = DialogResult.Cancel;
            //            return;
            //        }
            //        else
            //        {
            //            txtName.Text = reader["Name"].ToString();
            //            txtDisplayOrder.Text = reader["DisplayOrder"].ToString();
            //        }
            //    }
            //}
        }
    }
}
