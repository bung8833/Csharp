using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random(Guid.NewGuid().GetHashCode());
			var player1 = BaseRockRockPaperScissors.GetInstance((GameValue)random.Next(0, 3));
			var player2 = BaseRockRockPaperScissors.GetInstance((GameValue)random.Next(0, 3));

			Result result = player1.Throw(player2);
			Console.WriteLine(result);
		}
	}

	public abstract class BaseRockRockPaperScissors
	{
		public GameValue Value { get; }
		public abstract Result Throw(BaseRockRockPaperScissors other);

		public BaseRockRockPaperScissors(GameValue value)
		{
			this.Value = value;
		}

		public static BaseRockRockPaperScissors GetInstance(GameValue value)
		{
			if (value == GameValue.Paper) return new Paper();
			if (value == GameValue.Rock) return new Rock();
			if (value == GameValue.Scissors) return new Scissors();
			throw new Exception("unknown value");
		}
	}

	public class Rock : BaseRockRockPaperScissors
	{
		public override Result Throw(BaseRockRockPaperScissors other)
		{
			if (other.Value == GameValue.Rock) return Result.Draw;
			if (other.Value == GameValue.Paper) return Result.Lose;
			return Result.Win;
		}

		public Rock() : base(GameValue.Rock)
		{
		}
	}
	public class Paper : BaseRockRockPaperScissors
	{
		public override Result Throw(BaseRockRockPaperScissors other)
		{
			if (other.Value == GameValue.Rock) return Result.Win;
			if (other.Value == GameValue.Paper) return Result.Draw;
			return Result.Lose;
		}
		public Paper() : base(GameValue.Paper)
		{
		}
	}
	public class Scissors : BaseRockRockPaperScissors
	{
		public override Result Throw(BaseRockRockPaperScissors other)
		{
			if (other.Value == GameValue.Rock) return Result.Lose;
			if (other.Value == GameValue.Paper) return Result.Win;
			return Result.Draw;
		}
		public Scissors() : base(GameValue.Scissors)
		{
		}
	}

	public enum GameValue
	{
		Rock, Paper, Scissors
	}
	public enum Result
	{
		Win, Lose, Draw
	}
}
