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
            int targetYear = DateTime.Today.Year; // 範圍是今年
            DayOfWeek targetDayOfWeek = DayOfWeek.Wednesday; // 指定找出星期三

            DateTime startingDay = new DateTime(targetYear, 1, 1);
            DateTime endingDay = new DateTime(targetYear, 12, 31);


            List<DateTime> dates = DayOfWeekCalculation.GetDateByDayOfWeek(targetDayOfWeek, startingDay, endingDay);

            foreach (var date in dates)
            {
                Console.WriteLine(date.ToString("d"));
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
            /// <returns></returns>
            public static List<DateTime> GetDateByDayOfWeek(DayOfWeek targetDayOfWeek, DateTime startingDay, DateTime endingDay)
            {
                List<DateTime> dates= new List<DateTime>();

                for (DateTime dt = startingDay; dt <= endingDay; dt = dt.AddDays(1))
                {
                    if (dt.DayOfWeek == targetDayOfWeek)
                    {
                        dates.Add(dt);
                    }
                }

                return dates;
            }
        }
    }
}
