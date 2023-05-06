
using System;

namespace TestTaskUSS
{
    public class Exit : Command
    {
        public Exit()
            : base("exit") { }

        public override void Execute(DeckController deckController)
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
