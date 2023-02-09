using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMAUIDemo.Models
{
    public class LotteryNumberGenerator
    {
        /// <summary>
        /// 產生指定數量的不重複整數
        /// </summary>
        /// <param name="numberCount"></param>
        /// <returns></returns>
        public List<int> GetNumber(int numberCount, 
                                   int startNumber=1, int lastNumber=49)
        {
            List<int> lotteryNumbers = new List<int>() { };

            // generate random numbers
            while (lotteryNumbers.Count() < numberCount)
            {
                Random seed = new Random(Guid.NewGuid().GetHashCode());
                int number = seed.Next(startNumber, lastNumber + 1);

                if ( !lotteryNumbers.Contains(number) )
                {
                    lotteryNumbers.Add(number);
                }
            }

            BubbleSort(lotteryNumbers);

            return lotteryNumbers;
        }

        /// <summary>
        /// 將List的元素由小到大排列
        /// </summary>
        /// <param name="numbers"></param>
        public void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
