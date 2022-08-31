using System;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Deck deck = new Deck();

            deck.MakeDeck();
            deck.Shuffle();
            deck.DrawCards();

            Console.ReadKey();

        }
    }
}
