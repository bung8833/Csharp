using PlayingCardGame.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = CardUtility.GetRandomCards(200);
            cards.SortCards();

            for (int idx = 0; idx < cards.Count -1; idx++)
            {
                if (cards[idx].Value == cards[idx+1].Value 
                    && cards[idx].Suit == cards[idx + 1].Suit)
                {
                    cards.Remove(cards[idx]);
                }
            }

            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }






            //Card card1 = new Card("s", 1);
            //Card card2 = new Card("s", 1);
            //Card card3 = new Card("s", 1);
            //Card card4 = new Card("s", 1);
            //Card card5 = new Card("s", 1);

            //if (card1.Equals(card2, card3, card4, card5))
            //{
            //    Console.WriteLine("are equal");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}



            Console.ReadLine();
        }
    }
}
