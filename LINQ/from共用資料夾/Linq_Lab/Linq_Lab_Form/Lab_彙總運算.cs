using Linq_Lab_Form.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Lab_Form
{
	public partial class Lab_彙總運算 : Form
	{
		public Lab_彙總運算()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			ProductsTableAdapter taPro = new ProductsTableAdapter();
			taPro.Fill(dsNorthwind.Products);

			var qPro = from pro in dsNorthwind.Products
					   group pro by pro.CategoryID into g
					   where g.Count() > 5
					   orderby g.Count()
					   select new
					   {
						   Category = g.Key,
						   ProductCount = g.Count(),
						   MaxUnitPrice = g.Max(p=>p.UnitPrice),
						   MinUnitPrice = g.Min(p=>p.UnitPrice),
						   SumUnitPrice= g.Sum(p=>p.UnitPrice),
						   AvgUnitPrice = g.Average(p=>p.UnitPrice)
					   };

			dgvShow.DataSource = qPro.ToList();

		}
	}
}
