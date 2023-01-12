using LINQ_Lab_Form.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities dbContext = new NorthwindEntities();

            IQueryable<Employees> linqEmp = from emp in dbContext.Employees
                          where emp.Country == "USA"
                          select emp;

            dataGridView1.DataSource = linqEmp.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NorthwindEntities dbContext = new NorthwindEntities();

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
            NorthwindEntities dbContext = new NorthwindEntities();

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
            NorthwindEntities dbContext = new NorthwindEntities();

            //var linqCat = from c in dbContext.Categories
            //              select c;

            foreach (var c in dbContext.Categories)
            {
                c.Description += "!!!";
            }

            //dbContext.SaveChanges(); // 不要亂玩

            dataGridView1.DataSource = dbContext.Categories.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            NorthwindEntities dbContext = new NorthwindEntities();


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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            NorthwindEntities dbContext = new NorthwindEntities();

            dataGridView1.DataSource = dbContext.Categories.ToList();
        }
    }
}
