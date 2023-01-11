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
    public partial class FormLabLinqStandard : Form
    {
        public FormLabLinqStandard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            EmployeesTableAdapter empTableAdapter = new EmployeesTableAdapter();
empTableAdapter.Fill(dsNorthwind.Employees);

            var linqEmp = from emp in dsNorthwind.Employees
                          where emp.Country == "UK"
                          select emp;

            dataGridViewShow.DataSource = linqEmp.AsDataView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            CategoriesTableAdapter catTableAdapter = new CategoriesTableAdapter();
            catTableAdapter.Fill(dsNorthwind.Categories);

            var linqCat = from cat in dsNorthwind.Categories
                          select cat;

            dataGridViewShow.DataSource = linqCat.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var emp = new
            {
                Name = "Richard",
                City = "Kaohsiung",
            };

            // emp.City = "Taiper";  // readonly
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            EmployeesTableAdapter empTableAdapter = new EmployeesTableAdapter();
            empTableAdapter.Fill(dsNorthwind.Employees);

            var linqEmp = from emp in dsNorthwind.Employees
                          where emp.Country == "USA"
                          select new
                          {
                              Name = 
                                  emp.FirstName + ' ' + emp.LastName,
                              emp.City
                          };
        }
    }
}
