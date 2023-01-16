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

		private void button2_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			new ProductsTableAdapter().Fill(dsNorthwind.Products);

			var qPro = dsNorthwind.Products.OrderBy(p => p.UnitPrice).Take(7).Aggregate(
				(p, next) => p.UnitPrice > next.UnitPrice ? p : next);

			//var qPro = dsNorthwind.Products.OrderBy(p => p.UnitPrice).Take(7).Aggregate(new NorthwindDataSet.ProductsRow { ProductID = 99999 , CategoryID = 1 , ProductName = "BEST" , SupplierID= 1, QuantityPerUnit ="666" , UnitPrice = 9000 , UnitsInStock = 30 , UnitsOnOrder = 20 , ReorderLevel =20 , Discontinued = false} , );

			MessageBox.Show(qPro.ProductName + " " + qPro.UnitPrice);


			//var q = dsNorthwind.Products.OrderBy(p => p.UnitPrice).Take(7).Aggregate()

			string sentence = "the quick brown fox jumps over the lazy dog";

			string[] words = sentence.Split(' ');

			var q = words.Aggregate((now, next) => next + " " + now); 
			// quick the -> brown quick the -> fox brown quick the

			int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };  // 49

			var qNums = ints.Aggregate(0, (total, next) => total + next);


			string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

			var qLongest = fruits.Aggregate("banana", 
				(longest, next) => longest.Length < next.Length ? next : longest, 
				result => result.ToUpper());


			//MessageBox.Show(q);

			//MessageBox.Show(qNums.ToString());

			MessageBox.Show(qLongest);

		}
	}
}
