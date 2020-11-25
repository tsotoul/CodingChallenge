using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            List<Card> cards = new List<Card>();

            //Loop through the two Enums and add Cards to the list
            foreach(Value value in Enum.GetValues(typeof(Value)))
            {
                foreach(Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    Card card = new Card(suit, value);
                    cards.Add(card);
                }
            }

            IPackOfCards NewPack = new PackOfCards(cards);  
            return NewPack;
        }
    }
}
