using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int price = 200;
			
			int num1 = 200 * 2;

			int num2 = 200 * 3;
		}
	}

	public class Member
	{
		private readonly int price;
		public Member(int price)
		{
			this.price = price;

		}
	}
}
