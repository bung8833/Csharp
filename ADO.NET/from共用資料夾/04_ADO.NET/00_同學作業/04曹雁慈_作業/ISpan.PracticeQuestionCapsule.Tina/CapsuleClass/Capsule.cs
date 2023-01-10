using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleClass
{
	/// <summary>
	/// 扭蛋機
	/// </summary>
	public static class CapsuleUtility
	{
		public static int ClacCoin(int amount, int coin)//投幣時計算金額
		{
			return amount + coin;
		}

		public static int ClacShip(int amount, int capsulePrice = 50)//出貨時計算剩餘金額
		{
			return amount - capsulePrice;
		}
		public static bool CanRefund(int amount)//可不可以退幣
		{
			return (amount >0);
		}
		public static bool CanShip(int amount, int capsulePrice = 50)//可不可以出貨
		{
			return (amount >= capsulePrice);
		}

		public static int CapsuleState(int amount, int capsulePrice = 50)
		{
			if (amount == 0)
			{
				return 0;
			}
			else
			{
				if (amount < capsulePrice)
				{
					return 1;
				}
				else
				{
					return 2;
				}
			}
			

		}
		//CapsuleState standbyState = new CapsuleState();
		//CapsuleState insufficientAmountState = new CapsuleState();
		//CapsuleState readyToShip = new CapsuleState();
		//public class CapsuleState
		//{
		//	public int StandbyState;
		//	public int InsufficientAmountState;
		//	public int ReadyToShip;
		//}

	}
}

