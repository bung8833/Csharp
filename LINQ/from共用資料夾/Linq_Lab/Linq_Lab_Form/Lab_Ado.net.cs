using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Lab_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string conn = "data source=. ; initial catalog = northwind ; integrated security = true;";
			string cmd = $"select [FirstName] + ' ' + [LastName] as 'Name'  , [City] " +
				$"from Employees " ;

			SqlConnection sqlConn = new SqlConnection(conn);
			SqlCommand sqlCmd = new SqlCommand(cmd, sqlConn);
			sqlCmd.CommandType = CommandType.Text;

			sqlConn.Open();

			DataTable data = new DataTable() ;
			data.Load(sqlCmd.ExecuteReader());

			dgvShow.DataSource = data;

			sqlCmd.Dispose();
			sqlConn.Close();
			sqlConn.Dispose();
		}
	}
}
