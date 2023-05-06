
using System;

namespace TestTaskUSS
{
    public class GetNamesDecks : Command
    {
        public GetNamesDecks()
            : base("get names") { }

        public override void Execute(DeckController deckController)
        {
            foreach (var name in deckController.GetAllNames())
                Console.WriteLine(name);
        }
    }
}
