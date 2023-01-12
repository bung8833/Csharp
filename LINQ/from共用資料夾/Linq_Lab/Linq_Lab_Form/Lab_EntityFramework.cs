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
	public partial class Lab_EntityFramework : Form
	{
		public Lab_EntityFramework()
		{
			InitializeComponent();
		}

		NorthwindEntities dbContext = new NorthwindEntities();

		private void button1_Click(object sender, EventArgs e)
		{
			//NorthwindEntities dbContext = new NorthwindEntities();

			IQueryable<Employees> qEmp = from emp in dbContext.Employees
					   where emp.Country == "USA"
					   select emp;

			dgvShow.DataSource = qEmp.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//NorthwindEntities dbContext = new NorthwindEntities();

			Categories cate = new Categories();
			cate.CategoryName = "Beer";
			cate.Description = "ALL YOU NEED IS DRINK.";

			dbContext.Categories.Add(cate);

			dbContext.SaveChanges();

			dgvShow.DataSource = dbContext.Categories.ToList();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			//NorthwindEntities dbContext = new NorthwindEntities();

			var qCate = from c in dbContext.Categories
						where c.CategoryName == "Beer"
						select c;

			foreach(var cc in qCate)
			{
				cc.Description = "NO MORE DRINK";
			}

			dbContext.SaveChanges();

			IQueryable<Categories> q = from c in dbContext.Categories
					select c;

			dgvShow.DataSource = q.ToList();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//NorthwindEntities dbContext = new NorthwindEntities();
			//var qCate = from c in dbContext.Categories
			//			select c;

			foreach(var c in dbContext.Categories)
			{
				c.Description += ".";
			}

			dbContext.SaveChanges();

			dgvShow.DataSource = dbContext.Categories.ToList();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			//Categories qCate = (from c in dbContext.Categories
			//			where c.CategoryName == "Beer"
			//			select c).First();

			Categories qCate = dbContext.Categories.First(c=>c.CategoryName =="Beer");

			dbContext.Categories.Remove(qCate);
			//dbContext.Categories.RemoveRange();

			dbContext.SaveChanges();

			dgvShow.DataSource = dbContext.Categories.ToList();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var qEmp = from emp in dbContext.Employees
					   orderby emp.FirstName descending , emp.LastName
					   select new { Name = emp.FirstName + " " + emp.LastName, City = emp.City };

			var qCus = from cus in dbContext.Customers
					   select new { Name = cus.ContactName, City = cus.City };

		    dgvShow.DataSource =qEmp.Union(qCus).ToList();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var qEmp = from emp in dbContext.Employees
					   select new { Name = emp.FirstName + " " + emp.LastName, City = emp.City };

			var qCus = from cus in dbContext.Customers
					   select new { Name = cus.ContactName, City = cus.City };

			dgvShow.DataSource = qEmp.Concat(qCus).OrderBy(o=>o.Name).ToList();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var qP = from c in dbContext.Categories
					 join p in dbContext.Products on c.CategoryID equals p.CategoryID
					 select new
					 {
						 ProductName = p.ProductName,
						 ProductUnitPrice = p.UnitPrice,
						 CategoryName = c.CategoryName
					 };

			dgvShow.DataSource = qP.ToList();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			//var qP = from c in dbContext.Categories
			//		 join p in dbContext.Products on c.CategoryID equals p.CategoryID
			//		 into lsCP
			//		 from p in lsCP.DefaultIfEmpty(new Products { CategoryID = -1, ProductID = -1, ProductName = "No Product" , Discontinued = false})
			//		 select new
			//		 {
			//			 c.CategoryID,
			//			 c.CategoryName,
			//			 p.ProductName,
			//			 p.ProductID
			//		 };

			//dgvShow.DataSource = qP.ToList();

			List<Contact> lsContact = new List<Contact>
			{
				new Contact{ ComID = 1 , ContactName = "John"},
				new Contact {ComID = 3 , ContactName = "Jenna"},
				new Contact{ComID=4, ContactName="Eric"}
			};

			List<Company> lsCompany = new List<Company>
			{
				new Company{ComID = 1 , CompanyName ="Apple"},
				new Company{ComID = 2 , CompanyName ="Microsoft"},
				new Company{ComID = 3 , CompanyName ="amazon"},
				new Company {ComID = 4 , CompanyName ="SpaceX"}
			};

			var q = from com in  lsCompany
					join c in lsContact on com.ComID equals c.ComID into ls
					from c in ls.DefaultIfEmpty(new Contact { ComID = -1 , ContactName = "Nobody"})
					select new {
						com.ComID, com.CompanyName , c.ContactName
					};


			dgvShow.DataSource = q.ToList();

		}

		private void button10_Click(object sender, EventArgs e)
		{
			var q = from pro in dbContext.Products
					select new
					{
						ProductName = pro.ProductName,
						ProductUnitPrice = pro.UnitPrice,
						CategoryName = pro.Categories.CategoryName
					};

			dgvShow.DataSource = q.ToList();
		}
	}
}
