using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        List<Card> deck = new List<Card>();

        public int Length
        {
            get { return deck.Count; }
        }

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Card(i, j));
                }
            }
        }

        public List<Card> Create()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Card(i, j));
                }
            }

            return deck;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int numberOfTimes = rnd.Next(15, 50);

            for (int i = 0; i < numberOfTimes; i++)
            {
                List<Card> half1 = new List<Card>();
                List<Card> half2 = new List<Card>();
                List<Card> shuffledDeck = new List<Card>();

                for (int j = 0; j < (deck.Count / 2); j++)
                {
                    half1.Add(deck[j]);
                }
                for (int j = (deck.Count / 2); j < deck.Count; j++)
                {
                    half2.Add(deck[j]);
                }
                for (int j = 0; j < half1.Count; j++)
                {
                    shuffledDeck.Add(half2[j]);
                    shuffledDeck.Add(half1[j]);
                }

                deck = shuffledDeck;
            }
        }

        public List<Card> DrawCard(int numberOfCards)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                cards.Add(deck[i]);
            }

            deck.RemoveRange(0, numberOfCards);
            return cards;
        }
    }
}
