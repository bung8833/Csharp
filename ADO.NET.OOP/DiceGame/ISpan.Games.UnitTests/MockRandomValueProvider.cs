using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games.UnitTests
{
    internal class MockRandomValueProvider : IRandomValueProvider
    {
        private List<int> _numbers = new List<int>();

        private int currentIdx = 0;
        

        /// <summary>
        /// 傳入想要依序生成的數值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="others"></param>
        public MockRandomValueProvider(int value, params int[] others)
        {
            _numbers.Add(value);
            _numbers.AddRange(others);
        }


        
        
        /// <summary>
        /// 從 _numbers 依序傳回一個值 若已到最後 從頭繼續
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Next(int min, int max)
        {
            int count = _numbers.Count;

            return _numbers[(currentIdx++) % count];
        }
    }
}
