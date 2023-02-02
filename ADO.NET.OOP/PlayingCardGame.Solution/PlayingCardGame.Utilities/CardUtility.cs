using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public static class CardUtility
    {
        /// <summary>
        /// 隨機選取任意張牌
        /// </summary>
        /// <param name="qty"></param>
        /// <returns></returns>
        public static List<Card> GetRandomCards(int qty)
        {
            string[] suits = new string[] { "S", "H", "D", "C" };
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            List<Card> cards = suits.Join(values,
                s => 1,
                v => 1,
                (s, v) => new Card(s, v))
                .ToList();

            List<Card> result = new List<Card>();

            for (int i = 0; i < qty; i++)
            {
                Random seed = new Random(Guid.NewGuid().GetHashCode());
                int index = seed.Next(0, cards.Count); // [0, cards.Count)

                result.Add(cards[index]);
            }

            return result;
        }

        /// <summary>
        /// 將牌按照數字、花色排序
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static void SortCards(this List<Card> cards)
        {
            cards.Sort((x, y) => x.CompareTo(y));
        }

        /// <summary>
        /// 判斷指定的物件是否等於目前的物件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="firstCard"></param>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool Equals(this Card source, Card firstCard, params Card[] cards)
        {
            if (firstCard == null) return false;

            if (source.Value != firstCard.Value 
                || source.Suit != firstCard.Suit)
            {
                return false;
            }

            if (cards == null) return true;
            foreach (var card in cards)
            {
                if (source.Value != card.Value
                || source.Suit != card.Suit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
