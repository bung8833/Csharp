using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationHandler addFunc = delegate(int num1, int num2){ return num1 + num2; };
            addFunc = (int num1, int num2) => num1 + num2;
            addFunc = (num1, num2) => num1 + num2;

            int result = addFunc(1, 5); // 6

            Console.WriteLine(result);

            TruncateHandler handler = (string value) => value.Substring(0, 3);
            handler = (value) => value.Substring(0, 3);
            handler = value => value.Substring(0, 3);
        }
    }
    public delegate string TruncateHandler(string value);
    public delegate int OperationHandler(int num1, int num2);
}
