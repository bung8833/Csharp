using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.LeaveSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 100;
            int tax = ISpan.LeaveSystem.Utilities.Order.CalcTax(price);
            Console.WriteLine(tax );
        }
    }

    // Ctrl + F5
}
