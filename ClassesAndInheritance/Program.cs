using System;
using System.Collections.Generic;
using Classes.CardObject;
using Classes.DealerObject;
using Classes.DeckObject;
using Classes.PersonObject;
using Classes.PlayerObject;

namespace ClassesAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck{Cards = new System.Collections.Generic.List<Card>
            {
                new Card{CardValue = 1, Type = CardTypes.Clubs},
                new Card{CardValue = 2, Type = CardTypes.Clubs},
                new Card{CardValue = 3, Type = CardTypes.Clubs}
            }}; 

            List<Player> players = new List<Player>
            {
                new Player(new List<Card>(), "Jørgen", 13),
                new Player(new List<Card>(), "Lars", 27),
                new Player(new List<Card>(), "Jørgen", 10)
            };

            Dealer dealer = new Dealer(deck, "Karl", 12, players);

            dealer.Deal();

            List<Person> peopleInTheGame = new List<Person>
            {
                players[0],
                players[1],
                players[2],
                dealer
            };

            foreach(var person in peopleInTheGame)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
