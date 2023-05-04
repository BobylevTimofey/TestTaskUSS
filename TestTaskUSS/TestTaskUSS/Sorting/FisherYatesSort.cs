using System;

namespace TestTaskUSS
{
    public class FisherYatesSort : ISorter
    {
        public Deck Sort(Deck deck)
        {
            var random = new Random();

            for (var i = deck.Length - 1; i > 0; i--)
            {
                var randomIndex = random.Next(i + 1);
                var buffer = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = buffer;
            }
            return deck;
        }
    }
}
