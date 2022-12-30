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
        /// 確保source 值會在 [min,max]之間,若不是,就傳回min/max
        /// </summary>
        /// <param name="source"></param>
        /// <param name="min">允許的最小值</param>
        /// <param name="max">允許的最大值</param>
        /// <returns>return source,如果source介於[min,max]; return min如果source小於min; return max如果source大於max</returns>
        public static int EnsureInRange(this int source, int min, int max)
        {
            source = Math.Max(min, source);
            source = Math.Min(max, source);
            return source;
        }
    }
}
