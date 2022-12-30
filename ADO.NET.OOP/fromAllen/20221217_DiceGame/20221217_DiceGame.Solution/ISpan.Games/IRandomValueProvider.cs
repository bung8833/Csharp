using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    public interface IRandomValueProvider
    {
        /// <summary>
        /// 傳回[min, max) 的數值
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        int Next(int min, int max);
    }
}
