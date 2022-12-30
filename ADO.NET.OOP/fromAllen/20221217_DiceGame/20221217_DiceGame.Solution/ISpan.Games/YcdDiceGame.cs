using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    public class YcdDiceGame
    {
        private Dice[] dices;

        public YcdDiceGame() : this(new DefaultRandomValueProvider())
        {

        }
        public YcdDiceGame(IRandomValueProvider provider)
        {
            // pre conditions
            if (provider == null) throw new ArgumentNullException(nameof(provider));

            do
            {
                dices = DiceUtility.CreateDices(provider, 4);
            } while (DiceUtility.AreUnique(dices) == true);

        }

        /// <summary>
		/// 計算點數
		/// </summary>
		/// <returns></returns>
		public int ComputPoints() {
            // int sum = dices.Sum(dice => dice.Value);
            int sum = 0;
            foreach (var dice in dices)
            {
                sum += dice.Value;
            }

            return sum - DiceUtility.MinPair(dices).Value * 2;
        }

        public override string ToString()
        {
            string diceValue = string.Empty; // 2, 5, 6, 2,
            foreach (var dice in dices)
            {
                diceValue += dice.Value + ", ";
            }

            return $"骰子點數: {diceValue}\t遊戲分數: {ComputPoints(), 3}";
        }
    }
}
