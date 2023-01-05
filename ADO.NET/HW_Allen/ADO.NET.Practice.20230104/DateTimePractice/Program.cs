using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 1, 5);
            dt = dt.AddDays(1);
            Console.WriteLine(dt.ToString("d"));

            Console.ReadLine();
        }
    }
}
