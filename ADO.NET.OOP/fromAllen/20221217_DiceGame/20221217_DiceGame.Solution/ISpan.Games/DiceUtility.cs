using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    public static class DiceUtility
    {
        /// <summary>
        /// 生成指定數量的骰子
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="diceCount"></param>
        /// <returns></returns>
        public static Dice[] CreateDices(IRandomValueProvider provider,
                                        int diceCount)
        {
            if(provider == null)throw new ArgumentNullException(nameof(provider));
            if(diceCount <= 0)return new Dice[0];

            List<Dice> dices = new List<Dice>();
            for(int i=0; i < diceCount; i++)
            {
                int value = provider.Next(1, 7);
                Dice dice = new Dice(value);
                dices.Add(dice);
            }
            return dices.ToArray();
        }

        /// <summary>
        /// 判斷是否每個骰子值都相異
        /// </summary>
        /// <param name="dices"></param>
        /// <returns></returns>
        public static bool AreUnique(Dice[] dices)
        {
            if (dices == null || dices.Length == 1) return true;
            if (dices.Length > 6) return false;

            var items = new HashSet<int>();
            foreach (var dice in dices)
            {
                if (items.Contains(dice.Value)) return false;

                items.Add(dice.Value);
            }
            return true;
        }

        /// <summary>
		/// 找到成對骰子的最小值, 若每顆骰子都不同, 傳回 null
		/// how-將骰子排序, 用迴圈判斷是否與下一個骰子相同
		/// </summary>
		/// <param name="dices"></param>
		/// <returns></returns>
		public static Dice MinPair(Dice[] dices)
        {
            Array.Sort(dices);

            for (int i = 0; i < dices.Length - 1; i++)
            {
                if (dices[i].Value == dices[i + 1].Value) return dices[i];
            }

            return null;
        }
    }
}
