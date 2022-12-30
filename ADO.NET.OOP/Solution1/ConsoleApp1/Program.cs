using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a delegate first, then call delegate
            // Signature 要一樣
            OperationHandler handler1 = new OperationHandler(Add);
            
            int result = handler1(1, 2);
            Console.WriteLine(result.ToString());



            OperationHandler handler2 = Mod; //語法糖

            int result2 = handler2(10, 3);
            Console.WriteLine(result2.ToString());



            Console.ReadKey();
        }

        // 宣告委派 不用{}
        public delegate int OperationHandler(int num1, int num2);

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Mod(int a, int b)
        {
            return a % b;
        }
    }
}
