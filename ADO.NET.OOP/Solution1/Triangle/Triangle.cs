using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public static string Draw_Left(int rows = 5)
        {
            string result = String.Empty;

            for (int i = 0; i < rows; i++)
            {
                result += new string('*', i + 1) + "\r\n";
            }
            return result;
        }
    }
}
