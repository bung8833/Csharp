using Day;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.PractiveFromAllen.WednesdayConsole
{
	internal class Program
	{/// <summary>
	/// 回傳2023年中，每一個星期三。
	/// </summary>
	/// <param name="args"></param>
		static void Main(string[] args)
		{
			foreach(var item in Wednesday.FindWeekInYear(2023,DayOfWeek.Wednesday))
			{
				Console.WriteLine(item.ToString("yyyy/MM/dd"));
			}
		}
	}
}
