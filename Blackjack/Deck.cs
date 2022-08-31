using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        // List of cards
        private List<Card> cards;
        Random random = new Random();

        public List<Card> Cards
        {
            get { return cards; }
        }
        
        // Makes the deck
       public void MakeDeck()
        {
            cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }
        }

        // Fisher/Yates card shuffle
        public void Shuffle()
        {
            int n = cards.Count;

            for (int i = 0;i < (n - 1 );i++)
            {
                int r = i + random.Next(n - i);
                Card card = cards[r];
                cards[r] = cards[i];
                cards[i] = card;

            }
        }

        // Draw cards from the dec, and compare the total of dealer and player, and write out the winner
        public void DrawCards()
        {
            Card[] dealer = new Card[2];
            Card[] player = new Card[2];

            for (int i = 0; i < 2; i++)
            {
                dealer[i] = cards[0];
                cards.RemoveAt(0);

            }

            for (int i = 0; i < 2; i++)
            {
                player[i] = cards[0];
                cards.RemoveAt(0);
            }

            int r = dealer[0].Number + dealer[1].Number;
            int g = player[0].Number + player[1].Number;

            Console.WriteLine("Dealer number: {0}", r);
            Console.WriteLine("Player number: {0}", g);

            if (r > g)
            {
                Console.WriteLine("Dealer wins");
            }
            else
            {
                Console.WriteLine("Player wins");
            }






        }
    }

    // Card struct
    public struct Card
    {
        public int Number { get; set; }
        public string Type { get; set; }

        public Card(int number, int id)
        {
            
            // Switchcase to make 4 different kinds of cards
            Number = number;
            switch (id)
            {
                case 0:
                    Type = "Clubs";
                    break;
                    case 1:
                    Type = "Hearts";
                    break ;
                    case 2:
                    Type = "Spades";
                    break;
                case 3:
                    Type = "Diamonds";
                    break;

                default:
                    throw new ArgumentException();
                    
            }

        }

        



    }

    
}
