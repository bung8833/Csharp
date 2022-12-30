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
            int price = 20000;
            int total = new Order().CalcPromoPrice(price, CalcByTotal);
            Console.WriteLine(total);
        }
        static int CalcByTotal(int price)
        => price >= 10000 ? price - 1000 : price;
        static int CalcByDiscount(int price)
        => price * 8 / 10; //八折
    }
    public delegate int PromoHandler(int price);

    public class Order
    {
        /// <summary>
        /// 計算優惠價
        /// </summary>
        /// <param name="price">原始售價</param>
        /// <returns></returns>
        public int CalcPromoPrice(int price, PromoHandler handler)
        {
            return handler(price);
        }
    }
}
