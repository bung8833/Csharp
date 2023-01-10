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
            int? num1 = null;
            Nullable<int> num2 = null;

            // 判斷nullable有沒有值
            bool hasValue = num1.HasValue; // false
            if (hasValue) Console.WriteLine(num1.Value);

            // 指派值
            num1 = 99;

        }
    }
}
