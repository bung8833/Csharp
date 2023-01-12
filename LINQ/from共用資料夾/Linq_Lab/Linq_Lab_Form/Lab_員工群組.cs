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
	public partial class Lab_員工群組 : Form
	{
		public Lab_員工群組()
		{
			InitializeComponent();
		}

		NorthwindEntities dbContext = new NorthwindEntities();

		private void button1_Click(object sender, EventArgs e)
		{
			var qG = from emp in dbContext.Employees
					 group emp by emp.Country into g
					 select new { 國家 = g.Key, 人數 = g.Count() };

			dgvEmployeeGroup.DataSource = qG.ToList();
		}

		private void dgvEmployeeGroup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show("test");

		    string country = dgvEmployeeGroup.CurrentRow.Cells[0].Value.ToString();
			//MessageBox.Show(country);

			var qEmp = from emp in dbContext.Employees
					   where emp.Country == country
					   select emp;

			dgvEmployees.DataSource = qEmp.ToList();

		}
	}
}
