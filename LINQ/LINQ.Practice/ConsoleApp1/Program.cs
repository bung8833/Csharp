using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> items = Enumerable.Range(1, 100);

            //int[] result = items.Where(DivisibleBy3).ToArray();
            //int[] result = items.Where(x => x % 3 == 0).ToArray();
            int[] result2 = items.Select(x => x + 1).ToArray();
            string[] result3 = items.Select((x, index) => $"{index + 1}. {x} \r\n")
                                    .ToArray();

            foreach (var item in result3)
            {
                Console.Write(item.ToString());
            }

            

            Console.ReadLine();
        }

        static bool DivisibleBy3(int value) => value % 3 == 0;
    }
}
