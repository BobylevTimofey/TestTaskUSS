using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskUSS
{
    public abstract class Command
    {
        public string Name;

        protected Command(string name)
        {
            Name = name;
        }

        public abstract void Execute(DeckController deckController);

        protected string PrintAndReadText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
    }
}
