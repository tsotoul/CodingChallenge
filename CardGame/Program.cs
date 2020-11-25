using System;

namespace CodingChallenge.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IPackOfCardsCreator cards = new PackOfCardsCreator();
            IPackOfCards ANewPack = cards.Create();

            Console.WriteLine("-----------------------------");
            ICard removedCard = ANewPack.TakeCardFromTopOfPack();
            Console.WriteLine($"The card that was removed is: {removedCard.Suit} - {removedCard.Value}");
            ANewPack.Shuffle();
        }
    }
}
