using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = new DateTime(2023, 1, 7);
			// DateTime tomorrow = new DateTime(dt.Year, dt.Month, dt.Day +1); //2023/1/8
			DateTime dt2 = dt.AddDays(1);
		}
	}
}
