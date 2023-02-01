using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class Card : IComparable<Card>
    {
        public string Suit { get; private set; } //花色: Spade, Heart, Dimond, Club
        public int Value { get; private set; } //數字: A, 2, 3, ..., 10, J, Q, K

        public Card(string suit, int value)
        {
            #region Suit
            if (suit == "s" || suit == "S" || suit == "spade" || suit == "Spade")
            {
                this.Suit = "黑桃";
            }
            else if (suit == "h" || suit == "H" || suit == "heart" || suit == "Heart")
            {
                this.Suit = "紅心";
            }
            else if (suit == "d" || suit == "D" || suit == "dimond" || suit == "Dimond")
            {
                this.Suit = "方塊";
            }
            else if (suit == "c" || suit == "C" || suit == "club" || suit == "Club")
            {
                this.Suit = "梅花";
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

        /// <summary>
        /// 隨機選取任意張撲克牌
        /// </summary>
        /// <param name="selectQty"></param>
        /// <returns></returns>
        public static List<Card> RandomCards(int selectQty)
        {
            List<Card> cards = new List<Card>()
            {
                new Card("Spade", 1),
                new Card("Heart", 1),
                new Card("Dimond", 1),
                new Card("Club", 1),
                new Card("Spade", 5),
                new Card("Heart", 6),
                new Card("Dimond", 7),
                new Card("Club", 8),
                new Card("Spade", 9),
                new Card("Heart", 10),
                new Card("Dimond", 11),
                new Card("Club", 12),
                new Card("Spade", 13),
            };

            List<Card> result = new List<Card>();

            for (int i = 0; i < selectQty; i++)
            {
                Random seed = new Random(Guid.NewGuid().GetHashCode());
                int index = seed.Next(0, cards.Count); // [0, cards.Count)

                result.Add(cards[index]);
            }

            return result;
        }

        public int CompareTo(Card other)
        {
            if (this.Value != other.Value)
            {
                return this.Value.CompareTo(other.Value);
            }
            else
            {
                // todo
                return 2;
            }
        }

        public override string ToString()
        {
            string valueString = String.Empty;

            if (this.Value == 1) valueString = "A";
            else if (this.Value == 10) valueString = "10";
            else if (this.Value == 11) valueString = "J";
            else if (this.Value == 12) valueString = "Q";
            else if (this.Value == 13) valueString = "K";
            else valueString = this.Value.ToString();

            return this.Suit.ToString() + valueString;
        }
    }

    public static class CardUtility
    {
        public static List<Card> SortCards(this List<Card> cards)
        {
            return cards.OrderBy(x => x).ToList();
        }
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
