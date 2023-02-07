using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class FiveCardStud
    {
        private List<Card> _hand = new List<Card>();

        /// <summary>
        /// 玩家的手牌 介於0~5張 且不應有重複的牌
        /// </summary>
        public List<Card> Hand
        {
            get
            {
                if (_hand.Count > 5)
                {
                    throw new Exception("一手牌最多只能有5張");
                }
                if (_hand.Distinct().Count() < _hand.Count())
                {
                    throw new Exception("一手牌內不可有重複的牌");
                }

                return _hand;
            }
            set
            {
                _hand = value;

                if (_hand.Count > 5)
                {
                    throw new Exception("一手牌最多只能有5張");
                }
                if (_hand.Distinct().Count() < _hand.Count())
                {
                    throw new Exception("一手牌內不可有重複的牌");
                }
            }
        }

        /// <summary>
        /// 判斷兩副手牌中的牌是否相同 只比較其值 不管順序
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (this == null && obj == null) return true;
            if (this == null || obj == null) return false;

            FiveCardStud objAsStud = obj as FiveCardStud;
            if (objAsStud == null) return false;
            else return (this.Hand.Count == objAsStud.Hand.Count
                         && this.Hand.All(objAsStud.Hand.Contains));
        }

        public override string ToString()
        {
            string result = String.Empty;

            foreach (Card card in Hand)
            {
                result += card.ToString() + " ";
            }

            return result;
        }

        public override int GetHashCode()
        {
            return Hand.GetHashCode();
        }

        // todo 用LINQ判斷牌型
        /// <summary>
        /// 判斷玩家的手牌 是否為同花大順
        /// </summary>
        /// <returns></returns>
        public bool IsRoyalFlush()
        {

            return true;
        }


        // end of class FiveCardStud
    }
}
