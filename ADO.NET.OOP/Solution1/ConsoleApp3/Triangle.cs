using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Triangle
    {
        public static string Draw_Left(int rows = 5)
        {
            string result = String.Empty;

            for (int i = 0; i < rows; i++)
            {
                result += new string('*', i+1) + "\r\n";
            }
            return result;
        }

        public static string Draw_Right(int rows = 5)
        {
            string result = String.Empty;

            for (int i = 0; i < rows; i++)
            {
                result += new string(' ', rows-1-i);
                result += new string('*', i+1).PadLeft(i+1, ' ') + "\r\n";
            }
            return result;
        }
    }
}
