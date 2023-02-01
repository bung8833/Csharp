using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class Card : IComparable<Card>
    {
        public string Suit { get; }
        public int Value { get; }

        public Card(string suit, int value)
        {
            #region Suit
            if (suit.ToLower() == "spade" || suit.ToLower() == "s")
            {
                this.Suit = SuitName.Spade;
            }
            else if (suit.ToLower() == "heart" || suit.ToLower() == "h")
            {
                this.Suit = SuitName.Heart;
            }
            else if (suit.ToLower() == "diamond" || suit.ToLower() == "d")
            {
                this.Suit = SuitName.Diamond;
            }
            else if (suit.ToLower() == "club" || suit.ToLower() == "c")
            {
                this.Suit = SuitName.Club;
            }
            else
            {
                throw new Exception("No such card!");
            }
            #endregion

            #region Value
            if (value >= 1 && value <= 13) this.Value = value;
            else
            {
                throw new Exception("No such card!");
            }
            #endregion
        }

        private int GetSuitValue(string suit)
        {
            if (suit == SuitName.Spade) return 4;
            else if (suit == SuitName.Heart) return 3;
            else if (suit == SuitName.Diamond) return 2;
            else if (suit == SuitName.Club) return 1;
            else return 0;
        }

        public int CompareTo(Card other)
        {
            if (other == null) return 1;

            if (this.Value != other.Value)
            {
                return this.Value.CompareTo(other.Value);
            }
            else
            {
                return GetSuitValue(this.Suit).CompareTo(GetSuitValue(other.Suit));
            }
        }

        public bool Equals(Card other)
        {
            return other is null 
                ? false 
                : Value.Equals(other.Value) && Suit.Equals(other.Suit);
        }

        public override string ToString()
        {
            string strValue = String.Empty;

            if (this.Value == 1) strValue = "A";
            else if (this.Value == 10) strValue = "10";
            else if (this.Value == 11) strValue = "J";
            else if (this.Value == 12) strValue = "Q";
            else if (this.Value == 13) strValue = "K";
            else strValue = this.Value.ToString();

            string strSuit = String.Empty;

            if (this.Suit == SuitName.Spade) strSuit = "S";
            else if (this.Suit == SuitName.Heart) strSuit = "H";
            else if (this.Suit == SuitName.Diamond) strSuit = "D";
            else if (this.Suit == SuitName.Club) strSuit = "C";

            return strSuit + strValue;
        }
    }

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
        public static void Sort(this List<Card> cards)
        {
            cards.Sort((x,y) => x.CompareTo(y));
        }
    }

    public static class SuitName
    {
        public static string Spade { get { return "Spade"; } }
        public static string Heart { get { return "Heart"; } }
        public static string Diamond { get { return "Diamond"; } }
        public static string Club { get { return "Club"; } }
    }

    public class LINQRepo
    {
        public void CreateDeckOfCards()
        {
            string[] suits = new string[] { "S", "H", "D", "C" };
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            var cards = suits.Join(values,
                s => 1,
                v => 1,
                (s, v) => $"{s}{v,2}").ToList();
        }
    }
}
