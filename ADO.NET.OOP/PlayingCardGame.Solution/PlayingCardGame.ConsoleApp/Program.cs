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
            var game1 = new FiveCardStud();

            game1.Hand = new List<Card>
            {
                new Card(Suits.s, 10),
                new Card(Suits.s, 11),
                new Card(Suits.s, 12),
                new Card(Suits.s, 13),
                new Card(Suits.s, 1),
            };

            Console.WriteLine(new FiveCardStud().IsRoyalFlush(game1.Hand));


            Console.ReadLine();
        }
    }
}
