using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Lab_Form
{
    public partial class FormPracticeStatistics : Form
    {
        public FormPracticeStatistics()
        {
            InitializeComponent();
        }

        NorthwindEntities dbContext = new NorthwindEntities();

        private void buttonGruopByCountry_Click(object sender, EventArgs e)
        {
            var qCountry = from emp in dbContext.Employees
                           group emp by emp.Country into empGroup
                           select new
                           {
                               國家 = empGroup.Key,
                               人數 = empGroup.Count()
                           };

            dataGridViewCountry.DataSource = qCountry.ToList();
        }

        private void dataGridViewCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 判斷使用者的選擇
            string country = dataGridViewCountry
                .CurrentRow.Cells[0].Value.ToString();

            var qemp = from emp in dbContext.Employees
                       where emp.Country == country
                       select emp;

            dataGridViewEmp.DataSource = qemp.ToList();
        }
    }
}
