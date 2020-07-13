using System.Collections.Generic;
using Classes.CardObject;
using Classes.PersonObject;

namespace Classes.PlayerObject
{
    public class Player : Person
    {
        public Player(List<Card> cards, string name, uint age) : base(age, name)
        {
            Cards = cards;
        }

        public List<Card> Cards{get;set;}
    }
}