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
            List<Card> cards = CardUtility.GetRandomCards(20);

            cards.Sort();

            foreach(Card card in cards)
            {
                Console.WriteLine(card);
            }



            Console.ReadLine();
        }
    }
}
