using LINQ_Lab_Form.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Lab_Form
{
    public partial class FormLabEntityFramework : Form
    {
        public FormLabEntityFramework()
        {
            InitializeComponent();
        }

        NorthwindEntities dbContext = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();

            IQueryable<Employees> linqEmp = from emp in dbContext.Employees
                          where emp.Country == "USA"
                          select emp;

            dataGridView1.DataSource = linqEmp.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();

            Categories cat = new Categories();
            cat.CategoryName = "Energy Drinks";
            cat.Description = $@"
Energy Drinks increase a character's boost by 40 instantly. 
Performing certain actions while casting this item will cancel it.";

            dbContext.Categories.Add(cat);
            dbContext.SaveChanges();

            var qSearch = from c in dbContext.Categories
                    select c;

            dataGridView1.DataSource = qSearch.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();

            var linqCat = from c in dbContext.Categories
                          where c.CategoryName == "Energy Drinks"
                          select c;

            foreach (var cat in linqCat)
            {
                cat.Description = $@"
Nah, Energy Drinks is just something anyone can find in any stores.";
            }
            
            dbContext.SaveChanges();

            var qSearch = from c in dbContext.Categories
                    select c;

            dataGridView1.DataSource = qSearch.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();

            //var linqCat = from c in dbContext.Categories
            //              select c;

            foreach (var c in dbContext.Categories)
            {
                c.Description += "!!!";
            }

            //dbContext.SaveChanges(); // 不要亂玩

            dataGridView1.DataSource = dbContext.Categories.ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();

            dataGridView1.DataSource = dbContext.Categories.ToList();
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //NorthwindEntities dbContext = new NorthwindEntities();


            // First選取第一筆 為單一的物件
            var catInstane = (from c in dbContext.Categories
                              where c.CategoryName == "Energy Drinks"
                              select c).First();

            var catInstane1 = dbContext.Categories
                .First(c=>c.CategoryName== "Energy Drinks");

            dbContext.Categories.Remove(catInstane);

            dbContext.SaveChanges();

            dataGridView1.DataSource = dbContext.Categories.ToList();
        }

        private void buttonUnion_Click(object sender, EventArgs e)
        {
            var linqEmp = from emp in dbContext.Employees
                          orderby emp.FirstName descending, emp.LastName
                          select new
                          {
                              Name = emp.FirstName + " " + emp.LastName,
                              City = emp.City
                          };

            var linqCust = from cust in dbContext.Customers
                           select new
                           {
                               Name = cust.ContactName,
                               City = cust.City
                           };

            dataGridView1.DataSource = linqEmp.Union(linqCust).ToList();
        }

        private void buttonConcat_Click(object sender, EventArgs e)
        {
            var linqEmp = from emp in dbContext.Employees
                       select new { Name = emp.FirstName + " " + emp.LastName, City = emp.City };
            
            var linqCust = from cust in dbContext.Customers
                       select new { Name = cust.ContactName, City = cust.City };

            dataGridView1.DataSource = 
                linqEmp.Concat(linqCust).OrderBy(o => o.Name).ToList();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            var qProd = from cat in dbContext.Categories
                        join prod in dbContext.Products on cat.CategoryID equals prod.CategoryID
                        select new
                        {
                            ProductName = prod.ProductName,
                            ProductUnitPrice = prod.UnitPrice,
                            CategoryName = cat.CategoryName
                        };

            dataGridView1.DataSource = qProd.ToList();
        }

        private void buttonLeftOuterJoin_Click(object sender, EventArgs e)
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

            List<Contact> Contacts = new List<Contact>
            {
                new Contact{ ComID = 1, ContactName = "John" },
                new Contact{ ComID = 3, ContactName = "Jenna" },
                new Contact{ ComID = 4, ContactName = "Eric" }
            };

            List<Company> Companies = new List<Company>
            {
                new Company{ ComID = 1, CompanyName = "Apple" },
                new Company{ ComID = 2, CompanyName = "Microsoft" },
                new Company{ ComID = 3, CompanyName = "amazon" },
                new Company{ ComID = 4, CompanyName = "SpaceX" }
            };

            var linq = 
                from com in Companies
                join cont in Contacts on com.ComID equals cont.ComID 
                into ls
                from cont in ls.DefaultIfEmpty
                             (new Contact{ ComID = -1, ContactName = "Nobody" })
                select new
                {
                    com.ComID,
                    com.CompanyName,
                    cont.ContactName
                };

            dataGridView1.DataSource = linq.ToList();
        }

        private void buttonNavProp_Click(object sender, EventArgs e)
        {
            var linq = from prod in dbContext.Products 
                       select new
                       {
                           ProductName = prod.ProductName,
                           ProductUnitPrice = prod.UnitPrice,
                           CategoryName = prod.Categories.CategoryName
                       };

            dataGridView1.DataSource = linq.ToList();
        }



        ////// end of class FormLabEntityFramework //////
    }
}
