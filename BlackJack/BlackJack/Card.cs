using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public char Suit { get; }
        public string Value { get; }
        public bool FaceUp { get; set; }
        public int NumberValue { get; set; }

        public Card(int suit, int value)
        {
            if (value == 1)
            {
                Value = "A";
                NumberValue = 11;
            }
            else if (value == 11)
            {
                Value = "J";
                NumberValue = 10;
            }
            else if (value == 12)
            {
                Value = "Q";
                NumberValue = 10;
            }
            else if (value == 13)
            {
                Value = "K";
                NumberValue = 10;
            }
            else
            {
                Value = value.ToString();
                NumberValue = value;
            }
            if (suit == 1)
            {
                Suit = '\u2665';
            }
            else if (suit == 2)
            {
                Suit = '\u2663';
            }
            else if (suit == 3)
            {
                Suit = '\u2660';
            }
            else
            {
                Suit = '\u2666';
            }
            FaceUp = true;
        }
    }
}
