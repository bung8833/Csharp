using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class Card : IComparable<Card>
    {
        private string _suit;

        public string Suit
        {
            get => _suit;

            set
            {
                if (value.ToLower() == "spade" || value.ToLower() == "s")
                {
                    _suit = SuitName.Spade;
                }
                else if (value.ToLower() == "heart" || value.ToLower() == "h")
                {
                    _suit = SuitName.Heart;
                }
                else if (value.ToLower() == "diamond" || value.ToLower() == "d")
                {
                    _suit = SuitName.Diamond;
                }
                else if (value.ToLower() == "club" || value.ToLower() == "c")
                {
                    _suit = SuitName.Club;
                }
                else
                {
                    throw new Exception("No such card!");
                }
            }
        }

        private int _value;

        public int Value
        {
            get => _value;

            set
            {
                if (value >= 1 && value <= 13) _value = value;
                else
                {
                    throw new Exception("No such card!");
                }
            }
        }

        public Card(string suit, int value)
        {
            Suit = suit;
            #region Suit
            //if (suit.ToLower() == "spade" || suit.ToLower() == "s")
            //{
            //    this.Suit = SuitName.Spade;
            //}
            //else if (suit.ToLower() == "heart" || suit.ToLower() == "h")
            //{
            //    this.Suit = SuitName.Heart;
            //}
            //else if (suit.ToLower() == "diamond" || suit.ToLower() == "d")
            //{
            //    this.Suit = SuitName.Diamond;
            //}
            //else if (suit.ToLower() == "club" || suit.ToLower() == "c")
            //{
            //    this.Suit = SuitName.Club;
            //}
            //else
            //{
            //    throw new Exception("No such card!");
            //}
            #endregion

            Value = value;
            #region Value
            //if (value >= 1 && value <= 13) this.Value = value;
            //else
            //{
            //    throw new Exception("No such card!");
            //}
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

        
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Card objAsCard = obj as Card;
            if (objAsCard == null) return false;
            else return this.Value == objAsCard.Value 
                     && this.Suit == objAsCard.Suit;
        }

        public override string ToString()
        {
            string strValue = String.Empty;

            if (this.Value == 1) strValue = "A";
            else if (this.Value == 10) strValue = "T";
            else if (this.Value == 11) strValue = "J";
            else if (this.Value == 12) strValue = "Q";
            else if (this.Value == 13) strValue = "K";
            else strValue = this.Value.ToString();

            string strSuit = String.Empty;

            if (this.Suit == SuitName.Spade) strSuit = "S";
            else if (this.Suit == SuitName.Heart) strSuit = "H";
            else if (this.Suit == SuitName.Diamond) strSuit = "D";
            else if (this.Suit == SuitName.Club) strSuit = "C";
            else this.Suit = "N/A";

            return strSuit + strValue;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        // end of Card
    }
}
