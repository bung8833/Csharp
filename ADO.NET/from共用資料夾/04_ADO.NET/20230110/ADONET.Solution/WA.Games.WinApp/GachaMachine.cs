using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace WA.Games.WinApp
{
	/// <summary>
	/// 扭蛋機
	/// </summary>
	public class GachaMachine
	{
		public BaseState CurrentState { get; private set; }

		/// <summary>
		/// 目前已投入金額
		/// </summary>
		public int Money { get; set; }

		/// <summary>
		/// 商品單價,投入金額必需足額才允許出貨
		/// </summary>
		public int UnitPrice { get; }

		public GachaMachine(int unitPrice)
		{
			UnitPrice = unitPrice;
			CurrentState = new StandbyState(this);
		}

		public void SetState(BaseState newState)
		{
			CurrentState = newState;
		}
	}

	/// <summary>
	/// 扭蛋機狀態的父類別
	/// </summary>
	public abstract class BaseState
	{
		protected readonly GachaMachine _machine;
		public BaseState(GachaMachine machine)
		{
			_machine = machine;
		}

		/// <summary>
		/// 投幣
		/// </summary>
		/// <param name="amount"></param>
		public abstract void PutMoney(int amount);

		/// <summary>
		/// 退幣
		/// </summary>
		public abstract void RefundMoney();

		/// <summary>
		/// 取出商品
		/// </summary>
		public abstract void TakeOutProduct();
	}

	/// <summary>
	/// 待機中,等候客戶來使用
	/// </summary>
	public class StandbyState : BaseState{
		public StandbyState(GachaMachine machine):base(machine){}

		public override void PutMoney(int amount)
		{
			_machine.Money += amount;
			if(_machine.Money >= _machine.UnitPrice)
			{
				_machine.SetState(new ReadyToShip(_machine));
			}
			else
			{
				_machine.SetState(new InsufficientAmountState(_machine));
			}
		}

		public override void RefundMoney()
		{
			throw new Exception("在沒有投錢的狀態下,不允許退錢");
		}

		public override void TakeOutProduct()
		{
			throw new Exception("在沒有投錢的狀態下,不允許出貨");
		}
	}

	/// <summary>
	/// 投入足夠金額,等待客人指令就出貨
	/// </summary>
	public class ReadyToShip : BaseState
	{
		public ReadyToShip(GachaMachine machine) : base(machine) { }
		public override void PutMoney(int amount)
		{
			_machine.Money += amount;
		}

		public override void RefundMoney()
		{
			_machine.Money = 0;
			_machine.SetState(new StandbyState(_machine));
		}

		public override void TakeOutProduct()
		{
			_machine.Money -= _machine.UnitPrice;
			if (_machine.Money == 0)_machine.SetState(new StandbyState(_machine));
			
			if (_machine.Money < _machine.UnitPrice)_machine.SetState(new InsufficientAmountState(_machine));
			
		}
	}
	/// <summary>
	/// 有投幣,但金額還不足夠
	/// </summary>
	public class InsufficientAmountState : BaseState
	{
		public InsufficientAmountState(GachaMachine machine) : base(machine) { }
		public override void PutMoney(int amount)
		{
			_machine.Money += amount;
			if (_machine.Money >= _machine.UnitPrice)
			{
				_machine.SetState(new ReadyToShip(_machine));
			}
			
		}

		public override void RefundMoney()
		{
			_machine.Money = 0;
			_machine.SetState(new StandbyState(_machine));
		}

		public override void TakeOutProduct()
		{
			throw new Exception("在錢不夠的狀態下,不允許出貨");
		}
	}
}
