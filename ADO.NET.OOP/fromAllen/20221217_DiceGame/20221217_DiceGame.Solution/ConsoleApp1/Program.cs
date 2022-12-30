using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice[] items = new Dice[] { 
                new Dice(5),
                new Dice(6),
                new Dice(1)
            };

            Array.Sort(items);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Dice:IComparable<Dice>
    {
        public int Value { get; private set; }
        public Dice(int value)
        {
            // pre conditions
            if (value < 1 || value > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
                //throw new ArgumentOutOfRangeException("value");
            }

            Value = value;
        }

        public int CompareTo(Dice other)
        {
            return this.Value.CompareTo(other.Value);

        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
