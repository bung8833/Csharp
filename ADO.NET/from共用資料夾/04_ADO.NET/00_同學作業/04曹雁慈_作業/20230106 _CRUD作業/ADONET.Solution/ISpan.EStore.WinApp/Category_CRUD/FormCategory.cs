using ISpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.EStore.WinApp.Category_CRUD
{
	public partial class FormCategory : Form
	{
		private CategoryRepository repo;
		private List<Category> _category;
		public string SName => textBoxName.Text;
		public string SDisplayOrder => textBoxDisplayOrder.Text;
		
		public FormCategory()
		{
			InitializeComponent();
			repo = new CategoryRepository();
			this.Load += FormCategory_Load;
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_category = repo.Search(SName, SDisplayOrder).ToList();
			dataGridView1.DataSource = _category;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{

		}
	}


}
