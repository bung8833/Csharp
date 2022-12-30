using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = new int[] { 1,2,3,4,5,16,7,38,9,10};

            // Func<int, bool> func = number => number % 2 == 0;
            Func<int, bool>  func = number => number % 2 == 1;
            List<int> result = items.MyFilter(func);
            
        }
    }
    public static class ListExts { 
        public static List<int> MyFilter(this int[] source, Func<int, bool> func)
        {
            List<int> evenItems = new List<int>();
            foreach (var item in source)
            {
                if (func(item) == true) evenItems.Add(item);
            }

            return evenItems;
        }
    }
}
