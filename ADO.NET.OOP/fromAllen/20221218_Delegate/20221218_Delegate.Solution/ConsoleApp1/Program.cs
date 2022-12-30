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
            // OperationHandler handler = new OperationHandler(Add);
            OperationHandler handler = Add;

            int result = handler(10, 4); //2
        }
        static void DoIt() { 
        
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Mod(int n1, int n2)
        {
            return n1 % n2;
        }
    }

    public delegate int OperationHandler(int num1, int num2);
}
