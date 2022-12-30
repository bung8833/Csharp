using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpanCsharp20221215
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Price = 100;
            int tax = iSpan.Csharp.Utilities.Order.ClacTax(Price);
            Console.WriteLine(tax);


            Console.ReadKey();
        }
    }
}
