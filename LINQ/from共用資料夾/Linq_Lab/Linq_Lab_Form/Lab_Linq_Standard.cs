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
	public partial class Lab_Linq_Standard : Form
	{
		public Lab_Linq_Standard()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.Fill(dsNorthwind.Employees);

			var qEmp = from emp in dsNorthwind.Employees
					   where emp.Country =="USA"
					   select emp;

			dgvShow.DataSource = qEmp.AsDataView();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			CategoriesTableAdapter taCategories = new CategoriesTableAdapter();
			taCategories.Fill(dsNorthwind.Categories);

			var qC = from c in dsNorthwind.Categories
					 select c;

			dgvShow.DataSource = qC.AsDataView();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			var emp = new
			{
				Name = "李知恩",
				City = "高雄"
			};

			//emp.City = "台北";

			MessageBox.Show(emp.Name + " " + emp.City);
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.Fill(dsNorthwind.Employees);

			var qEmp = from emp in dsNorthwind.Employees
					   where emp.Country == "USA"
					   select new
					   {
						   Name = emp.FirstName + " " + emp.LastName,
						   emp.City
					   };

			dgvShow.DataSource = qEmp.ToList();

		}
	}
}
