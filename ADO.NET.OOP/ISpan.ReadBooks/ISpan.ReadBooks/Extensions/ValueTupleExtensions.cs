using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks.Extensions
{
    public static class ValueTupleExtensions
    {
        /// <summary>
        /// 確保ValueTuple的值依(小,大)排列
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (int, int) EnsureInOrder(this(int first, int last) source)
        {
            return 
                (source.first < source.last) ? 
                (source.first,  source.last) : (source.last, source.first);
        }
    }
}
