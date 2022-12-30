using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add;
            Func<string, int, string> leftFunc = Left;
            Func<int, string, DateTime, int, double, string> func = xxx;

            Action greet = Greet;

            Action<int> funcDelete = DeleteMember;
        }
        static void Greet()
        {
            Console.WriteLine("Hello, world");
        }

        static void DeleteMember(int memberId)
        {

        }

        static string xxx(int n1, string v1, DateTime d1, int n2, double d2)
        {
            return "AAA";
        }

        static string Left(string value, int lenght)
        {
            return value.Substring(0, lenght);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
