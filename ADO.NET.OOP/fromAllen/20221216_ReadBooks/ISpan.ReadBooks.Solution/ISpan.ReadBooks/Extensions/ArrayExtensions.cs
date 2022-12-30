using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
     /// 擷取範圍內的子陣列
     /// </summary>
     /// <param name="source"></param>
     /// <param name="beginIndex"></param>
     /// <param name="endIndex"></param>
     /// <returns>empty array:null or empty array ; </returns>
     /// <exception cref="NotImplementedException"></exception>
        public static T[] GetSubArray<T>(this T[] source, int beginIndex, int endIndex)
        {
            if (source == null || source.Length == 0) return Array.Empty<T>();

            beginIndex = beginIndex.EnsureInRange(0, source.Length - 1);
            endIndex = endIndex.EnsureInRange(0, source.Length - 1);

            // 若大小相反，就對調
            (int Begin, int End) range = (beginIndex, endIndex).EnsureInOrder();
            beginIndex = range.Begin;
            endIndex = range.End;

            int length = endIndex - beginIndex + 1;
            T[] destination = new T[length];
            Array.Copy(source, beginIndex, destination, 0, length);

            return destination;
        }

        /// <summary>
        /// 將陣列合併成字串, 用seperator區隔
        /// </summary>
        /// <param name="source"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        public static string Concat(this string[] source, string seperator)
        {
            if (source == null || source.Length == 0) return string.Empty;

            return source.Aggregate(  (acc, next) => acc + seperator + next  );
        }

    }
}
