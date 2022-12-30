using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Games
{
    public class DiceUtility //可static
    {
        /// <summary>
        /// 生成指定數量的骰子
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="diceCount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Dice[] CreateDices(IRandomValueProvider provider, int diceCount)
        {
            if (provider == null) throw new ArgumentNullException(nameof(provider));
            // 驗證 Count > 0
            if (diceCount <= 0) return new Dice[0]; // return an empty array object

            List<Dice> diceLst = new List<Dice>();
            for (int i = 0; i < diceCount; i++)
            {
                // 產生隨機點數
                int value = provider.Next(1, 7); // [1, 7)
                // 呼叫建構函式 傳入點數值 建立實體
                Dice dice = new Dice(value);
                diceLst.Add(dice);
            }

            return diceLst.ToArray();

            //Dice[] diceAry = new Dice[0];
            //for (int i = 0; i < diceCount; i++)
            //{
            //    // 產生隨機點數
            //    int value = provider.Next(1, 7); // [1, 7)
            //    // 呼叫建構函式 傳入點數值 建立實體
            //    Dice dice = new Dice(value);
            //    diceAry.Append<Dice>(dice);   //diceAry.Append(dice);
            //}

            //return diceAry;
        }



        /// <summary>
        /// 判斷每顆骰子值都相異
        /// </summary>
        /// <param name="dices"></param>
        /// <returns></returns>
        public static bool AreUnique(Dice[] dices)
        {
            if (dices == null || dices.Length == 1) return true;
            if (dices.Length > 6) return false;

            var items = new HashSet<int>(); // Hash Set: Search O(1)
            foreach (var dice in dices)
            {
                if (items.Contains(dice.Value))
                {
                    return false;
                }

                items.Add(dice.Value);
            }
            return true;
        }


        public static Dice MinPair(Dice[] diceAry)
        {
            // 寫出功能依照Value排序dices
            // Dice要實作IComparable
            Array.Sort(diceAry);

            for (int i = 0; i < diceAry.Length-1; i++)
            {
                if (diceAry[i].Value == diceAry[i+1].Value)
                {
                    return diceAry[i];
                }

            }

            return null;
        }
    }
}
