using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day
{
    public class Wednesday
    {//先找出第一天星期三是誰
     //再來+7天，找到所有星期三
     //結束
        public static List<DateTime> FindWeekInYear(int year, DayOfWeek week)
        {
            var dayStart = new DateTime(year, 01,01); //今年第一天
			var dayEnd = new DateTime(year, 12, 31);//今年最後一天
            List<DateTime> weekInYear = new List<DateTime>(); //存找到的日期回傳

            //找到第一個指定的星期
			do
            {
                dayStart = dayStart.AddDays(1);
            } while (dayStart.DayOfWeek != week);

            //找到每一個指定的星期
			for (DateTime dt = dayStart; dt < dayEnd; dt = dt.AddDays(7))
			{
				weekInYear.Add(dt);
			};

			return weekInYear;
        }
    }
}
