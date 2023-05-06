
using System;

namespace TestTaskUSS
{
    public class Shuffle : Command
    {
        public Shuffle()
            : base("shuffle") { }

        public override void Execute(DeckController deckController )
        {
            var nameDeck = PrintAndReadText("Write name of deck:");
            var shufflingMethod = PrintAndReadText("How do you want to shuffle the deck? Fisher Yates or manual");

            if (shufflingMethod == "Fisher Yates")
                deckController.ShuffleDeck(nameDeck, new FisherYatesSort());
            else if (shufflingMethod == "manual")
            {
                var countRepeat = int.Parse(PrintAndReadText("Enter the amount of shuffling of the deck"));
                deckController.ShuffleDeck(nameDeck, new ManualSort(countRepeat));
            }
            else throw new Exception("shuffle the deck not found");
        }
    }
}
