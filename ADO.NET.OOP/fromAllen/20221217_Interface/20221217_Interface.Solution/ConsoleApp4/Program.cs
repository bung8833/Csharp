using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRandomValueProvider provider = new DefaultRandomValueProvider();
            var lottery = new Lottery(provider);
            int number = lottery.GetNumber();
            Console.WriteLine(number);
        }
    }
    public interface IRandomValueProvider
    {
        int Next(int min, int max); // 傳回[min, max) 的數值
    }

    public class DefaultRandomValueProvider : IRandomValueProvider
    {
        public int Next(int min, int max)
        {
            int seed = Guid.NewGuid().GetHashCode();
            var random = new Random(seed);
            return random.Next(min, max);
        }
    }

    public class Lottery // 樂透
    {
        public IRandomValueProvider Provder { get; }
        public Lottery(IRandomValueProvider provder)
        {
            Provder = provder;
        }
               

        public int GetNumber() {
            int number = this.Provder.Next(1, 100);

            return number;
        }

        /// <summary>
        /// 如果是偶數,就是winner
        /// </summary>
        /// <returns></returns>
        public bool IsWinner()
        {
            int number = GetNumber();
            // return number <= 0;
            return number % 2 == 0;
        }

    }
}
