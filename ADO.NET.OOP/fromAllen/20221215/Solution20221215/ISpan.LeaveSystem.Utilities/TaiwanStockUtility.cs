using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.LeaveSystem.Utilities
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 判斷日期是否介於某個星期區間
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="beginDayOfWeek">開始的星期,例如星期一,就傳入1</param>
        /// <param name="endDayOfWeek">結束的星期,例如星期五,就傳入5</param>
        /// <returns>傳回true,如果介於範圍內</returns>
        public static bool BetweenDayOfWeek(this DateTime dt, int beginDayOfWeek, int endDayOfWeek)
            => dt.DayOfWeek >= (DayOfWeek)beginDayOfWeek && dt.DayOfWeek <= (DayOfWeek)endDayOfWeek;

        /// <summary>
        /// 判斷dt的時間是否介於某個時間區間
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="beginTimeOfDay"></param>
        /// <param name="endTimeOfDay"></param>
        /// <returns></returns>
        public static bool BetweenTimeOfDay(this DateTime dt, double beginTimeOfDay, double endTimeOfDay)
            => dt.TimeOfDay >= TimeSpan.FromHours(beginTimeOfDay) && 
                dt.TimeOfDay <= TimeSpan.FromHours(endTimeOfDay);
    }

    public  class TaiwanStockUtility
    {
        public static bool IsTradingHours(DateTime dt)
        => dt.BetweenDayOfWeek(1,5) && dt.BetweenTimeOfDay(9, 13.5);
            

            //if(dt.DayOfWeek>=DayOfWeek.Monday && dt.DayOfWeek<= DayOfWeek.Friday &&
            //    dt.TimeOfDay >= TimeSpan.FromHours(9) && dt.TimeOfDay<=TimeSpan.FromHours(13.5) )
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}



            //if (dt.DayOfWeek != DayOfWeek.Sunday && dt.DayOfWeek != DayOfWeek.Saturday)
            //{
            //    if (dt.Hour >= 9 && dt.Hour < 12)
            //    {
            //        if (dt.Hour == 11 && dt.Minute > 30) return false;
            //        else return true;
            //    }
            //}
            //return false;

            //int weekDay = (int)dt.DayOfWeek; 
            //int hour = Convert.ToInt32(dt.Hour);
            //int minute = Convert.ToInt32(dt.Minute);

            //if (Enumerable.Range(1, 5).Contains(weekDay) &&
            //    (9 <= hour && 12 >= hour)
            //)
            //{
            //    return true;
            //}
            //else if (Enumerable.Range(1, 5).Contains(weekDay) && 13 == hour && minute <= 30)
            //{

            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        //}
    }
}
