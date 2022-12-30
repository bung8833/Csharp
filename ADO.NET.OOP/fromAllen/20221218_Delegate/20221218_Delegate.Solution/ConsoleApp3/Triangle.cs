using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate string RowHandler(int rows, int rowIndex);
    public class Triangle
    {
        private static string Draw_Right(int rows, int rowIndex)
        =>new string('*', rowIndex + 1).PadLeft(rows, ' ');
        
        private static string Draw_Left(int rows, int rowIndex)
        => new string('*', rowIndex + 1);
        
        private static string Draw_Center(int rows, int rowIndex)
        => new string(' ', rows - rowIndex - 1) + new string('*', (rowIndex + 1) * 2 - 1);

        public static RowHandler Left
        {
            get { return Draw_Left; }
        }
        public static RowHandler Right=>Draw_Left;
        public static RowHandler Center => Draw_Center;

        public static string Draw(int rows, RowHandler handler)
        {
            string result = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                result += handler(rows, i) + "\r\n";
            }
            return result;

        }
        
    }
}
