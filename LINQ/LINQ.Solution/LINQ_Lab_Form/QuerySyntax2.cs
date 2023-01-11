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
                1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            var linq = from n in numbers
                       where n % 2 == 0
                       select n;

            foreach (var n in linq)
            {
                
            }



            //dataGridView1.DataSource = linq.ToList();
        }
    }
}
