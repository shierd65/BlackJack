using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int dealerTotal = 0, playerTotal = 0;

            Deck d1 = new Deck();
            d1.Shuffle();
            List<Card> dealerHand = d1.DrawCard(2);
            List<Card> playerHand = d1.DrawCard(2);
            dealerHand[0].FaceUp = false;

            Console.Write("Dealer".PadRight(10));
            Console.WriteLine("Player");

            for (int i = 0; i < 2; i++)
            {
                if (dealerHand[i].FaceUp)
                {
                    Console.Write($"{dealerHand[i].Value}{dealerHand[i].Suit.ToString().PadRight(10)}");
                }
                else
                {
                    Console.Write("..".PadRight(11));
                }
                Console.WriteLine($"{playerHand[i].Value}{playerHand[i].Suit}");
                dealerTotal += dealerHand[i].NumberValue;
                playerTotal += playerHand[i].NumberValue;
            }

            Console.ReadLine();
        }
    }
}
