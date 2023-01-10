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

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class FormCategoryEdit : Form
    {
        private readonly int categoryId;

        public FormCategoryEdit(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            this.Load += FormCategoryEdit_Load;
        }

        private void FormCategoryEdit_Load(object sender, EventArgs e)
        {
            Category category = new CategoryRepository_old().GetCategory(categoryId);
            if (category == null)
            {
                MessageBox.Show("result not found!");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            else
            {
                textBoxName.Text = category.Name;
                textBoxDisplayOrder.Text = category.DisplayOrder.ToString();
            }

            //using (var conn = SqlDB.GetConnection())
            //{
            //    conn.Open();
            //    string sql = $"select * from Categories where Id = {categoryId}";
            //    using (var command = new SqlCommand(sql, conn))
            //    {
            //        var reader = command.ExecuteReader();

            //        if (reader.Read())
            //        {
            //            textBoxName.Text = reader["Name"].ToString();
            //            textBoxDisplayOrder.Text = reader["DisplayOrder"].ToString();

            //        }
            //        else
            //        {
            //            MessageBox.Show("result not found!");
            //            this.DialogResult = DialogResult.Cancel;
            //            return;
            //        }
            //    }
            //}
        }

        private void FormCategoryEdit_Load_1(object sender, EventArgs e)
        {

        }
    }
}
