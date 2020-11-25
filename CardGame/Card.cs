using System.Diagnostics.CodeAnalysis;

namespace CodingChallenge.CardGame
{
    class Card : ICard
    {
        public Suit Suit { get; }

        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals([AllowNull] ICard other)
        {
            if (Equals(other))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
