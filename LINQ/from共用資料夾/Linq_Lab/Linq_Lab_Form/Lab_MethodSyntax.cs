using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Linq_Lab_Form
{
	public partial class Lab_MethodSyntax : Form
	{
		public Lab_MethodSyntax()
		{
			InitializeComponent();
		}
		NorthwindEntities dbContext = new NorthwindEntities();
		private void button1_Click(object sender, EventArgs e)
		{
			
			//var q = dbContext.Employees
			//	.Where(emp => emp.Country == "USA")
			//	.Select(emp => new
			//	{
			//		Name = emp.FirstName + " " + emp.LastName,
			//		emp.City,
			//		emp.Country
			//	});

			var q = dbContext.Employees.Where(emp => emp.Country == "USA");

			dgvShow.DataSource = q.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var q = dbContext.Products
				.GroupBy(p => p.Categories.CategoryName)
				.Select(g => new
				{
					Category = g.Key,
					ProductCount = g.Count()
				});

			dgvShow.DataSource = q.ToList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var q = dbContext.Products.
				Join(dbContext.Categories, GetCategoryID, c => c.CategoryID,
				(p, c) => new
				{
					p.ProductName,
					p.UnitPrice,
					c.CategoryName
				});

			dgvShow.DataSource = q.ToList();
		}

		int? GetCategoryID(Products product)
		{
			return product.CategoryID;
		}


		private void button4_Click(object sender, EventArgs e)
		{
			//var q = dbContext.Products.OrderBy(p => p.UnitPrice)
			//	.Select(p=>new { 
			//	p.ProductName,
			//	p.UnitPrice,
			//	p.QuantityPerUnit
			//	});

			var q = dbContext.Products.OrderByDescending(p => p.UnitPrice)
				.Select(p => new {
					p.ProductName,
					p.UnitPrice,
					p.QuantityPerUnit
				});

			dgvShow.DataSource = q.ToList();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			var q = dbContext.Products
				.OrderBy(p => p.CategoryID)
				.ThenByDescending(p => p.UnitPrice)
				.ThenBy(p => p.QuantityPerUnit)
				.Select(p => new
				{
					p.ProductName,
					p.CategoryID,
					p.UnitPrice,
					p.QuantityPerUnit
				});

			dgvShow.DataSource = q.ToList();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			//List<CategoryProduct> lsCP = new List<CategoryProduct>();				
			//foreach(Categories c in dbContext.Categories)
			//{
			//	foreach(Products p in c.Products)
			//	{
			//		lsCP.Add(new CategoryProduct
			//		{
			//			CategoryName = c.CategoryName,
			//			ProductName = p.ProductName
			//		});
			//	}
			//}
			//dgvShow.DataSource = lsCP;		

			var q = dbContext.Categories
				.SelectMany(c => c.Products,
				(c, p) => new CategoryProduct
				{
					CategoryName = c.CategoryName,
					ProductName = p.ProductName
				});

			dgvShow.DataSource = q.ToList();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int categoryID = dbContext.Categories.First(c => c.CategoryName == cmbCategory.Text).CategoryID;

			var qProducts = dbContext.Products.Where(p => p.CategoryID == categoryID);

			dgvShow.DataSource = qProducts.ToList();

			if (qProducts.Any())
			{
				Products qFirst = qProducts.First();
				MessageBox.Show($"第一筆商品: {qFirst.ProductName}");
			}
			else
			{
				MessageBox.Show("沒有資料");
			}
			
			//Products qFirst = qProducts.FirstOrDefault();

			//if(qFirst != null)
			//{
			//	
			//}
			//else
			//{
			//	MessageBox.Show("沒有資料");
			//}

		}

		private void Lab_MethodSyntax_Load(object sender, EventArgs e)
		{
			
			foreach(Categories item in dbContext.Categories)
			{
				cmbCategory.Items.Add(item.CategoryName);				
			}
			cmbCategory.SelectedIndex = 0;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if(dbContext.Categories.All(c => c.CategoryName.Length > 1))
			{
				MessageBox.Show("種類名稱長度全部大於1個字");
			}
			else
			{
				MessageBox.Show("種類名稱長度有些小於或等於1個字");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if(dbContext.Categories.All(c=>c.Picture != null))
			{
				MessageBox.Show("所有種類都有圖片");
			}
			else
			{
				MessageBox.Show("有的種類沒有圖片");
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			//Func<int, string> ReturnBirthYear = ReturnMethod;
			//Func<int, string> ReturnBirthYear = age => $"出生年 {DateTime.Now.Year - age}";
			Func<int, string> ReturnBirthYear = (int age) =>
			{
				int birthYear = DateTime.Now.Year - age;
				string result = "出生年 " + birthYear;
				return result;
			};

			MessageBox.Show(ReturnBirthYear(20));

		}

		string ReturnMethod(int Age)
		{
			int birthYear = DateTime.Now.Year - Age;
			string result = "出生年 " + birthYear;
			return result;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			//MyFunc("USA", c => dbContext.Employees.First(emp => emp.Country == c).FirstName);

			MyFunc("USA", EmpolyeeFirstName);
		}

		string EmpolyeeFirstName (string Country)
		{
			var q = (from emp in dbContext.Employees
					where emp.Country == Country
					select new { emp.FirstName }).ToList();

			return q[0].FirstName;

		}


		void MyFunc(string Country , Func<string , string> ReturnFunc)
		{
			MessageBox.Show(ReturnFunc(Country));
		}


	}
}
