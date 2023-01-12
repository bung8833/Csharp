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
	public partial class Lab_DataSet : Form
	{
		public Lab_DataSet()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.Fill(dsNorthwind.Employees);

			//dgvShow.DataSource = dsNorthwind.Employees;

			dgvShow.DataSource = taEmp.GetData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
			taEmp.FillByUSA(dsNorthwind.Employees);

			dgvShow.DataSource = dsNorthwind.Employees;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			NorthwindDataSet dsNorthwind = new NorthwindDataSet();
			Employees1TableAdapter taEmp = new Employees1TableAdapter();
			taEmp.FillByUSA(dsNorthwind.Employees1);

			dgvShow.DataSource = dsNorthwind.Employees1;
		}
	}
}
