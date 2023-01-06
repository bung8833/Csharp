using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetDayOfWeek
{
    internal class Program
    {
        // 題目: 找出今年 所有是星期三的日期
        
        static void Main(string[] args)
        {
            // 指定找出星期三
            DayOfWeek targetDayOfWeek = DayOfWeek.Wednesday;

            // 範圍是今年
            int targetYear = DateTime.Today.Year;
            DateTime startingDay = new DateTime(targetYear, 1, 1);
            DateTime endingDay = new DateTime(targetYear, 12, 31);

            List<DateTime> dates = DayOfWeekCalculation.GetDateByDayOfWeek
                                       (targetDayOfWeek, startingDay, endingDay);

            foreach (var date in dates)
            {
                Console.WriteLine(date.ToString("yyyy/MM/dd"));
            }


            Console.ReadLine();
        }



        class DayOfWeekCalculation
        {
            /// <summary>
            /// 找出某日期區間中 所有為指定星期(如星期日, 星期一)的日期
            /// </summary>
            /// <param name="targetDayOfWeek"></param>
            /// <param name="startingDay"></param>
            /// <param name="endingDay"></param>
            /// <returns>
            /// List of DateTime
            /// </returns>
            public static List<DateTime> GetDateByDayOfWeek
                (DayOfWeek targetDayOfWeek, DateTime startingDay, DateTime endingDay)
            {
                List<DateTime> dates= new List<DateTime>();

                // 找出第一個符合的日期
                while (startingDay.DayOfWeek != targetDayOfWeek)
                {
                    startingDay = startingDay.AddDays(1);
                }

                // 從第一個符合的日期開始 每次加7天
                for (DateTime dt = startingDay; dt <= endingDay; dt = dt.AddDays(7))
                {
                    dates.Add(dt);
                }

                return dates;
            }
        }
    }
}
