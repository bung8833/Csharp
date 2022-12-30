using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //Console.WriteLine(emp.GetTitle());

            //Sales emp = new Sales();
            //Console.WriteLine(emp.GetTitle());
            Employee[] employees = { 
                new Employee(),
                new Sales()
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetTitle());
            }
        }
    }
    public class Employee
    {
        public virtual string GetTitle()
            => "Employee";
    }
    public class Sales:Employee
    {
        public override string GetTitle()
            => "Sales";
    }
}
