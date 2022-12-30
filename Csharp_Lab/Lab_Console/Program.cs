using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    internal class Program
    {
        static void learnArray()
        {
            int[,] array = new int[,]
            {
                { 11, 12, 13, 00 },
                { 21, 22, 23, 00 }
            };

            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                    //Console.WriteLine();
                }
            }

            Console.WriteLine(array.GetUpperBound(0)); // 1
            Console.WriteLine(array.GetUpperBound(1)); // 3

            return;
        }

        static void learnRandom()
        {
            Random seed = new Random();
            for (int i = 0; i < 4; i++)
            {
                int number = seed.Next(1, 10);
                Console.Write(number + "    ");
            }
        }






        static void Main(string[] args)
        {
            Console.WriteLine("This is Main.");





            Console.ReadKey();
            return;
        }
    }
}
