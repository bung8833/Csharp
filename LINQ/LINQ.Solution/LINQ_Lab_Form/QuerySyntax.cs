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
    public partial class QuerySyntax : Form
    {
        public QuerySyntax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            CategoriesTableAdapter catTableAdapter = new CategoriesTableAdapter();
            catTableAdapter.Fill(dsNorthwind.Categories);

            var linqCat = from c in dsNorthwind.Categories
                          select c.CategoryName into CC
                          from intoC in CC
                          select intoC;

            string result = String.Empty;
            foreach (var item in linqCat)
            {
                result += item;
            }

            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            EmployeesTableAdapter empTableAdapter = new EmployeesTableAdapter();
            empTableAdapter.Fill(dsNorthwind.Employees);

            var linqEmp = from emp in dsNorthwind.Employees
                          group emp by emp.Country into empGroup
                          select new { Country = empGroup.Key,
                                       Count = empGroup.Count() };

            dataGridView1.DataSource = linqEmp.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NorthwindDataSet dsNorthwind = new NorthwindDataSet();
            EmployeesTableAdapter empTableAdapter = new EmployeesTableAdapter();
            empTableAdapter.Fill(dsNorthwind.Employees);

            // undone
            //var linqEmp = from emp in dsNorthwind.Employees


            //dataGridView1.DataSource = linqEmp.ToList();
        }
    }
}
