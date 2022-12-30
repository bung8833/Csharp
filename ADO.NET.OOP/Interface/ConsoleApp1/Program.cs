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
            var Lotr = new Lottery();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(Lotr.GetNumber() + " ");
            }
            

            Console.ReadKey();
        }


        /// <summary>
        /// an Interface!!
        /// </summary>
        public interface IRandomValueProvider
        {
            int Next(int min, int max); // 傳回[min, max)的數值
        }



        public class Lottery //樂透
        {
            
            
            public int GetNumber()
            {
                // 產生亂數標準寫法
                int seed = Guid.NewGuid().GetHashCode(); //較接近真正亂數
                var random = new Random(seed);

                int number = random.Next(1, 100); // [1,100)

                return number;
            }



            public bool IsWinner()
            {
                int num = GetNumber();
                return num % 2 == 0;
            }





        }
    }

    
}
