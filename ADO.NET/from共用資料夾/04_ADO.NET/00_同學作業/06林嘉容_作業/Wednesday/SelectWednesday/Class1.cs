//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SelectWednesday
//{
//	internal class Class1
//	{
//		public static string Wednesday()
//		{
//			int yearday = 365;
//			string result = string.Empty;

//			DateTime dtbegin = new DateTime(2023, 1, 1);
//			DateTime dtend = new DateTime(2023, 12, 31);
//			DateTime dt;


//			for (int i = 0; i <= 7; i++)
//			{
//				if (dtbegin.DayOfWeek == (DayOfWeek)3)
//				{
//					result += dtbegin.ToString("yyyy/MM/dd") + "\n";
//					dt = dtbegin;
//					break;
//				}
//				//result += dtbegin.ToString("yyyy/MM/dd")+"\n";

//				dtbegin = dtbegin.AddDays(1);

//			}
//			for (int j = 0; j <= 52; j++)
//			{
//				if (dtbegin < dtend) dtbegin = dtbegin.AddDays(7);
//				result += dtbegin.ToString("yyyy/MM/dd") + "\n";
//			}

//			return result;
//		}
//	}
//}
