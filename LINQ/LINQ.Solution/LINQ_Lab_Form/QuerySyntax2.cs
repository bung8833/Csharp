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
    public partial class QuerySyntax2 : Form
    {
        public QuerySyntax2()
        {
            InitializeComponent();
        }


        private void buttonSieve_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            var linq = from Number in numbers
                       where Number % 2 == 0
                       select new
                       {
                           Number
                       };

            dataGridView1.DataSource = linq.ToList();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            var linq = from number in numbers
                       group number by number % 2 into NumberGroup
                       select new { Key = NumberGroup.Key == 0 ? "偶數" : "奇數",
                                    Count = NumberGroup.Count() };

            dataGridView1.DataSource = linq.ToList();
        }
    }
}
