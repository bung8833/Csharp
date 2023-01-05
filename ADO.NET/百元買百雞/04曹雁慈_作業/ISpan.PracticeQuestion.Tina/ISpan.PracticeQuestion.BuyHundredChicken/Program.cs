using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.PracticeQuestion.BuyHundredChicken
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ClacChickenNum4();
		}
		//public static void ClacChickenNum()
		//{
		//	int Cock = 0;
		//	int Hen = 0;
		//	int Chicken = 0;
		//	const int CockPrice = 5;
		//	const int HenPrice = 3;
		//	const double ChickenPrice = 1 / 3.0;

		//	for (Cock = 1; Cock <= 100 / CockPrice; Cock++)
		//	{
		//		for (Hen = 1; Hen <= 100 / HenPrice; Hen++)
		//		{
		//			for (Chicken = 3; Chicken <= 100; Chicken += 3)
		//			{
		//				if ((Cock * CockPrice) + (Hen * HenPrice) + (Chicken * ChickenPrice) == 100 && (Cock + Hen + Chicken) == 100)
		//				{
		//					Console.WriteLine($"找到了: 公雞:{Cock}隻，母雞{Hen}隻，小雞{Chicken}隻");
		//				}
		//			}
		//		}
		//	}
		//}
		//public static void ClacChickenNum2()
		//{
		//	int Cock = 0;
		//	int Hen = 0;
		//	int Chicken = 0;
		//	const int CockPrice = 5;
		//	const int HenPrice = 3;
		//	const double ChickenPrice = 1 / 3.0;
		//	int count = 0;
		//	for (Cock = 1; Cock <= 100 / CockPrice; Cock++)
		//	{
		//		for (Hen = 1; Hen <= 100 / HenPrice; Hen++)
		//		{
		//			for (Chicken = 3; Chicken <= 100; Chicken += 3)
		//			{
		//				count++;
		//				if ((Cock * CockPrice) + (Hen * HenPrice) + (Chicken * ChickenPrice) == 100 && (Cock + Hen + Chicken) == 100)
		//				{
		//					Console.WriteLine($"找到了: 公雞:{Cock}隻，母雞{Hen}隻，小雞{Chicken}隻");
		//				}
		//			}
		//		}
		//	}
		//	Console.WriteLine($"{count}");
		//}
		//public static void ClacChickenNum3()
		//{
		//	int Cock = 0;
		//	int Hen = 0;
		//	int Chicken = 0;
		//	const int CockPrice = 5;
		//	const int HenPrice = 3;
		//	const double ChickenPrice = 1 / 3.0;
		//	int count = 0;
		//	for (Cock = 1; Cock <= 100 / CockPrice; Cock++)
		//	{
		//		for (Hen = 1; Hen <=(100 - (Cock * CockPrice))/ HenPrice; Hen++)
		//		{
		//			for (Chicken = 3; Chicken <= (100- (Cock * CockPrice)- (Hen * HenPrice))/ ChickenPrice; Chicken += 3)
		//			{
		//				count++;
		//				if ((Cock * CockPrice) + (Hen * HenPrice) + (Chicken * ChickenPrice) == 100 && (Cock + Hen + Chicken) == 100)
		//				{
		//					Console.WriteLine($"找到了: 公雞:{Cock}隻，母雞{Hen}隻，小雞{Chicken}隻");
		//				}
		//			}
		//		}
		//	}
		//	Console.WriteLine($"{count}");
		//}
		public static void ClacChickenNum4()
		{
			int Cock = 0;
			int Hen = 0;
			int Chicken = 0;
			const int CockPrice = 5;
			const int HenPrice = 3;
			const double ChickenPrice = 1 / 3.0;
			int count = 0;
			for (Cock = 1; Cock <= 100 / CockPrice; Cock++)
			{
				for (Hen = 1; Hen <= (100 - (Cock * CockPrice)) / HenPrice; Hen++)
				{
					Chicken = 100 - Cock - Hen;
					if ((Cock * CockPrice) + (Hen * HenPrice) + (Chicken * ChickenPrice) == 100)
					{
						Console.WriteLine($"找到了: 公雞:{Cock}隻，母雞{Hen}隻，小雞{Chicken}隻");
					}
					count++;
				}
			}
			Console.WriteLine($"{count}");
		}

	}
}
