using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle.Draw(5, Triangle.Left));
            Console.WriteLine();

            Console.WriteLine(Triangle.Draw(5, Triangle.Right));
            Console.WriteLine();
            
            Console.WriteLine(Triangle.Draw(5, Triangle.Center));
            Console.WriteLine();

        }

        
    }

}
