using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 210;
            // int tax = Order.CalcTax(price);
            int tax = price.CalcTax();

            Console.WriteLine(tax);

            string value = "0123456789";
            string result = value.Left(4);
            Console.WriteLine(result);
        }
    }
    
    public static class Order
    {
        public static int CalcTax(this int price)
            => (int)Math.Round(price * 0.05, MidpointRounding.AwayFromZero);

        public static string Left(this string value, int length)
        {
            return value.Substring(0, length);
        }
    }
}
