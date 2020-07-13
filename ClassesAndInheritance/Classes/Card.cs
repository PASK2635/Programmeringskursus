using System;

namespace Classes.CardObject
{
    public enum CardTypes
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }

    public class Card
    {
        public CardTypes Type;

        private int _cardValue;
        public int CardValue
        {
            get => _cardValue;
            set
            {
                if(value > 13 || value < 1)
                    throw new ArgumentException("Value assigned was not a valid card-value");
                
                _cardValue = value;
            }
        }

        public override string ToString()
        {
            return "Type: " + Type + ", Value: " + _cardValue;
        }
    }
}