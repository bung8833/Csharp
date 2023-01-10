using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenHw_GetWednesday_Library
{
    public class MyFunction
    {
        // 不要笨笨的跑365圈，要算出第一天+7，直到明年
        //public static bool IsWednesDay(DateTime dateTime)
        //{
        //    return dateTime.DayOfWeek == DayOfWeek.Wednesday;
        //}

        // 寫成委派function
        //public List<DateTime> ListFilter(Func<DateTime, List<DateTime>> functionFilter)
        //{
        //    var listDate = new List<DateTime>();

        //    return listDate;
        //}

        //public List<DateTime> GetDatesOfYear(int year)
        //{
        //    var dates = new List<DateTime>();

        //    // Loop from the first day of the month until we hit the next month, moving forward a day at a time
        //    for (var date = new DateTime(year, 1, 1); date.Year == year + 1; date = date.AddDays(1))
        //    {
        //        dates.Add(date);
        //    }

        //    return dates;
        //}

        public List<DateTime> GetWednewdyaOfYear(int year)
        {
            var dates = new List<DateTime>();
            DateTime a = GetFirstWednesdayOfYear(year);
            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = a; date.Year < year + 1; date = date.AddDays(7))
            {
                dates.Add(date);
            }

            return dates;
        }

        public DateTime GetFirstWednesdayOfYear(int userYear)
        {
            DateTime wed1 = new DateTime(userYear, 1, 1); //1st Wednesday can start on the 1st of the month
            while (wed1.DayOfWeek != DayOfWeek.Wednesday)
            {
                wed1 = wed1.AddDays(1);
            }
            return wed1;
        }

        /*
        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                                .Select(day => new DateTime(year, month, day)) // Map each day to a date
                                .ToList(); // Load dates into a list
        }
        */

    }
}
