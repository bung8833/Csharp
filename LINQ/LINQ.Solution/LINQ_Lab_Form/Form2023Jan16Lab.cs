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
    public partial class Form2023Jan16Lab : Form
    {
        public Form2023Jan16Lab()
        {
            InitializeComponent();
        }

        NorthwindEntities dbContext = new NorthwindEntities();

        void MyFunc(string country, Func<string, string> ReturnFunc)
        {
            MessageBox.Show(ReturnFunc(country));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyFunc("USA", c => dbContext.Employees.First(emp => emp.Country == c).FirstName);

            MyFunc("USA", c => dbContext.Employees.Where(emp => emp.Country == c).First().FirstName);
        }






        ////// End of class Form2023Jan16Lab //////
    }
}
