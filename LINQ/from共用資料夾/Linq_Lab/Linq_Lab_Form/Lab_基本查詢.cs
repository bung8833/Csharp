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
	public partial class Lab_基本查詢 : Form
	{
		public Lab_基本查詢()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			CategoriesTableAdapter taC = new CategoriesTableAdapter();
			taC.Fill(dsNorthwind.Categories);

			var qC = from c in dsNorthwind.Categories
					 select c.CategoryName into CC
					 from intoC in CC
					 select intoC;

			//dgvShow.DataSource = qC.ToList();

			string result = "";

			foreach(var item in qC)
			{
				result += item + "\n";
			}

			MessageBox.Show(result);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.Fill(dsNorthwind.Employees);

			var qEmp = from emp in dsNorthwind.Employees
					   group emp by emp.Country into gEmp
					   select new { Country = gEmp.Key, Count = gEmp.Count() };

			dgvShow.DataSource= qEmp.ToList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.Fill(dsNorthwind.Employees);

			//var qEmp = from emp in dsNorthwind.Employees
			//		   where emp.Country == "USA"
			//		   select new
			//		   {
			//			   Name = emp.FirstName + " " + emp.LastName,
			//			   City = emp.City+", " + emp.Country,
			//			   Age = DateTime.Now.Year - emp.BirthDate.Year
			//		   };

			var qEmp = from emp in dsNorthwind.Employees
					   where emp.Country == "USA"
					   select new NewEmployeeSelect
					   {
						   Name = emp.FirstName + " " + emp.LastName,
						   City = emp.City + ", " + emp.Country,
						   Age = DateTime.Now.Year - emp.BirthDate.Year
					   };


			dgvShow.DataSource = qEmp.ToList();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			int[] arrNumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			var q = from num in arrNumber
					where num % 2 == 0
					select new { 偶數 = num };

			//dgvShow.DataSource = q.ToList();

			dgvShow.DataSource = GetOddList(arrNumber);
		}

		List<OddNumber> GetOddList(int[] ArrayNumber)
		{
			var q = from num in ArrayNumber
					where num % 2 == 0
					select new OddNumber { 偶數 = num };
			return q.ToList();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int[] arrNumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			//var q = from num in arrNumber
			//		group num by num % 2 == 0 ? "偶數" : "奇數" into g
			//		select new { 
			//			奇偶數 = g.Key  , 
			//			Count = g.Count() 
			//		};

			var q = (from num in arrNumber
					group num by GetGroupName(num) into g
					select new
					{
						奇偶數 = g.Key,
						Count = g.Count()
					}).ToList();

			dgvShow.DataSource = q;
		}

		string GetGroupName (int Number)
		{
			return Number % 2 == 0 ? "偶數" : "奇數";
		}

		private void button6_Click(object sender, EventArgs e)
		{

		}
	}
}
