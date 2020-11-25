using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    class PackOfCards : Stack<Card>, IPackOfCards
    {
        public PackOfCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Push(card);
            }
        }
        public void Shuffle()
        {
            //Clear the stack and re-create a list of all the cards
            Clear();
            List<Card> cards = new List<Card>();
            foreach (Value value in Enum.GetValues(typeof(Value)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    Card card = new Card(suit, value);
                    cards.Add(card);
                }
            }

            //Move the list elements in random order inside the empty stack
            Random random = new Random();
            while (cards.Count > 0)
            {
                Card temp = cards[random.Next(0, cards.Count)];
                Push(temp);
                cards.Remove(temp);
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            ICard removedCard = Pop();
            return removedCard;
        }

        IEnumerator<ICard> IEnumerable<ICard>.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
