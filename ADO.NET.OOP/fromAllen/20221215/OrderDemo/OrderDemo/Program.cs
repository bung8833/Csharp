using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 100;
            int tax = ISpan.LeaveSystem.Utilities.Order.CalcTax();
        }

        private int height;
        public int Height {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public DateTime DateOfBirth { get; set; }

        public Program()
        {

        }
    }
}
