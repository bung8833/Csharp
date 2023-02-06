using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class Deck
    {
        public List<Card> Cards { get; private set; } // 這副牌中所有的Card

        public Deck()
        {
            Cards = NewDeckOfCards();
        }

        public Deck(int[] ranks)
        {
            // todo 驗證

            Suits[] suits = new Suits[] { Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade };

            Cards = suits.Join(ranks, s => 1, v => 1, (s, v) => new Card(s, v))
                         .ToList();
        }

        private List<Card> NewDeckOfCards()
        {
            Suits[] suits = new Suits[] { Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade };
            int[] ranks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            return suits.Join(ranks, s => 1, v => 1, (s, v) => new Card(s, v))
                        .ToList();
        }

        //public Deck Shuffle() // 洗牌
        //public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
        //public Card Deal(int count) // 向Deck索取下N張牌, 如果剩下的牌不夠 N 張, 丟出例外



        // end of Deck
    }
}
