using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.EStore.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = WA.Utility.ClassA.Add(1, 2); // 3
            Console.WriteLine(sum);
        }
    }
}
