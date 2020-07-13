using System.Collections.Generic;
using Classes.CardObject;
using Classes.DeckObject;
using Classes.PersonObject;
using Classes.PlayerObject;

namespace Classes.DealerObject
{
    public class Dealer : Person
    {
        public List<Card> Cards{get;set;}

        private List<Player> _players;

        private Deck _deck;

        public Dealer(Deck deck, string name, uint age, List<Player> players) : base(age, name)
        {
            _players = players;
            _deck = deck;
        }

        public void Deal()
        {
             while(_deck.Cards.Count > 0)
             {
                 foreach(var player in _players)
                 {
                     if(_deck.Cards.Count > 0)
                     {
                        player.Cards.Add(_deck.Cards[0]);
                        _deck.Cards.RemoveAt(0);
                     }
                 }
             }
        }
    }
}