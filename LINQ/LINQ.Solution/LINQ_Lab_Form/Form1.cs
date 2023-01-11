using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Lab_Form
{
    public partial class Form1 : Form
    {
        private string connStr = null;

        /// <summary>
        /// 根據被選取的RadioButton選項 建立Connection String
        /// </summary>
        private void SetConnString()
        {
            if (this.radioButtonDefault.Checked)
            {
                this.connStr = $@"Data Source=.;
Initial Catalog=Northwind;Integrated Security=True";
            }
            else
            {
                this.connStr = $@"Data Source=.\SQLEXPRESS;
Initial Catalog=Northwind;Integrated Security=True";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonQuery_Click(object sender, EventArgs e)
        {
            SetConnString();

            const string _tableName = "Employees";

            string sql = $@"
SELECT [FirstName] + ' ' + [LastName], [City]
FROM {_tableName}
WHERE [Country] = 'USA'";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand(sql, conn);

            command.CommandType = CommandType.Text;
            conn.Open();

            DataTable data = new DataTable();
            data.Load(command.ExecuteReader());

            dataGridViewShow.DataSource = data;

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
}
