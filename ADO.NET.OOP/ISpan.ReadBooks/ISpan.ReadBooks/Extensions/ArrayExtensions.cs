using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks.Extensions
{
    public static class ArrayExtensions
    {
        public static string[] GetSubArray(this string[] source, int beginIndex, int endIndex)
        {
            // 確保source非空字串
            if ( source == null || source.Length == 0 ) return Array.Empty<string>();


            // 確保Index合理, 修改beginIndex, endIndex
            beginIndex = beginIndex.EnsureBetween(0, source.Length - 1);
            endIndex = endIndex.EnsureBetween(0, source.Length - 1);

            (int Begin, int End) range = (beginIndex, endIndex).EnsureInOrder();
            beginIndex = range.Begin;
            endIndex = range.End;


            // Copy
            int length = endIndex - beginIndex + 1;
            string[] destination = new string[length];
            Array.Copy(source, beginIndex, destination, 0, length);

            return destination;
        }



        public static string Concat(this string[] source, string seperator)
        {
            if (source == null || source.Length == 0 ) return string.Empty;

            return source.Aggregate((acc, next) => acc + seperator + next) ;
        }
    }
}
