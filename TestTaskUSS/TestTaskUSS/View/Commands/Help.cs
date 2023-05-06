using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskUSS.Controller.Commands
{
    public class Help : Command
    {
        public Help()
            : base("help") { }

        public override void Execute(DeckController deckController)
        {
            Console.WriteLine("help - get help about all commands");
            Console.WriteLine("create - create new deck;");
            Console.WriteLine("delete - delete the deck;");
            Console.WriteLine("get names - to get list of decks names");
            Console.WriteLine("shuffle - shuffle the deck");
            Console.WriteLine("get deck - get the deck");
            Console.WriteLine("exit - exit the program");
        }
    }
}
