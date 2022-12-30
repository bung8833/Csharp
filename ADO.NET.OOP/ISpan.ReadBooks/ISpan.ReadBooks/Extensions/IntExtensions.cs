using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// 確認int在[min, max]之間，否則傳回min/max
        /// </summary>
        /// <param name="source">要確認的值</param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        public static int EnsureBetween(this int source, int min, int max)
        {
            source = Math.Min(max, source);
            source = Math.Max(min, source);

            return source;
        }

        // valur tuple
        
    }
}
