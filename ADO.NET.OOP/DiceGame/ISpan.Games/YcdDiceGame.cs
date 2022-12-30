using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    public class YcdDiceGame
    {
        private Dice[] diceAry;

        public YcdDiceGame() : this(new DefaultRandomValueProvider())
        {
            ;
        }

        public YcdDiceGame(IRandomValueProvider provider)
        {
            // pre conditions
            if (provider == null) throw new ArgumentNullException(nameof(provider));

            do
            {
                diceAry = DiceUtility.CreateDices(provider, 4);
            } 
            while (DiceUtility.AreUnique(diceAry) == true);
        }

        public int ComputePoints()
        {
            // 呼叫MinPair, dices[0] + dices[1] + dices[2] + dices[3] - minPair.Value * 2

            int sum = diceAry.Sum(dice => dice.Value);

            //int sum2 = 0;
            //foreach (var d in diceAry)
            //{
            //    sum2 += d.Value;
            //}

            return (sum - DiceUtility.MinPair(diceAry).Value * 2);
        }

        // 覆寫ToString()
        public override string ToString()
        {
            string diceValue = String.Empty;
            foreach (var d in diceAry)
            {
                diceValue += d.Value + ", ";
            }
            //0 oO iI lL 1 B8
            return $"骰子點數：{diceValue}\t遊戲分數：{ComputePoints(), 3}";
        }
    }
}
