using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Price = 10000;
            int total = new Order().CalcPromotePrice(Price, CalcByTotal);

            Console.WriteLine(total.ToString());

            Console.ReadKey();
        }

        static int CalcByTotal(int Price)
        => Price >= 10000 ? Price - 1000 : Price;

        static int CalcByDiscount(int Price)
        => Price * 8 / 10;
    }


    public delegate int PromoHandler(int Price);


    public class Order 
    {
        public int CalcPromotePrice(int Price, PromoHandler hd)
        {
            return hd(Price);
        }
    }

}
