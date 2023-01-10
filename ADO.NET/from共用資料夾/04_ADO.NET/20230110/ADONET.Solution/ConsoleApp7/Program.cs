using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int a = 1;
				int b = 0;
				int c = Divide(a, b);
			}catch(DivideByZeroException divideEx)
			{
				Console.WriteLine("您的分母不能為零xxxx");
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		static int Divide(int num1, int num2)
		{
			try
			{
				return num1 / num2;
			}catch(DivideByZeroException ex)
			{
				throw new Exception("兩數相除, 分母不可以為零", ex);
			}
			
		}
	}
}
