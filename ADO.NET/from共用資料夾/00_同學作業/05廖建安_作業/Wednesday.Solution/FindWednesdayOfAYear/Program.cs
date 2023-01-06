using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWednesdayOfAYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Wednesday.FindWednesdays(2023));
            Console.ReadKey();
        }
    }

    public class Wednesday
    {
        /// <summary>
        /// 找出某一年所有的星期三
        /// </summary>
        /// <param name="year">要找的年份</param>
        /// <returns></returns>
        public static string FindWednesdays(int year)
        {
            DateTime thisYear = new DateTime(year, 1, 1);
            DateTime nextYear = new DateTime(year + 1, 1, 1);

            string result = string.Empty;

            //找出該年第一個星期三
            while (thisYear.DayOfWeek != DayOfWeek.Wednesday) thisYear = thisYear.AddDays(1);

            //從第一個星期三開始，每七天算一回
            while (thisYear < nextYear)
            {
                result += $"{thisYear}\n";
                thisYear =  thisYear.AddDays(7);
            }
            return result;
        }
    }
}
