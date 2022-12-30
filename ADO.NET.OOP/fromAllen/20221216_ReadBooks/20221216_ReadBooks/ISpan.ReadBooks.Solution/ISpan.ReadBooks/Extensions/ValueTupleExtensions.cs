using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks.Extensions
{
    /// <summary>
    /// ValueTuple 擴充方法
    /// </summary>
    public static class ValueTupleExtensions
    {
        /// <summary>
        /// 確保ValueTuple的值有依大小順序
        /// </summary>
        /// <param name="source"></param>1
        /// <returns>return 原值,如果大小值有依序; return相反的值,如果大小順序相反</returns>
        public static (int, int) EnsureInOrder(this (int begin, int end) source)
        {
            return source.begin <= source.end
                ? source
                : (source.end, source.begin);
        }
    }
}
