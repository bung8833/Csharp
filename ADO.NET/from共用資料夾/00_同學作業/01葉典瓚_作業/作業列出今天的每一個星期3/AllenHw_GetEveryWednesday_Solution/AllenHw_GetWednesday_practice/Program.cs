using AllenHw_GetWednesday_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenHw_GetWednesday_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2023; //使用者輸入想要的年份
            var MyFunc = new MyFunction();
            //var ListOfDateTime = MyFunc.GetDatesOfYear(year);
            var a = MyFunc.GetFirstWednesdayOfYear(year);
            var ListOfDateTime = MyFunc.GetWednewdyaOfYear(year);
            foreach (var date in ListOfDateTime)
            {
                Console.WriteLine(date.ToString("yyyy/MM/dd"));
            }
            Console.ReadLine();


        }
    }
}
