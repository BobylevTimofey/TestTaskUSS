
using System;
using TestTaskUSS.Controller.Commands;

namespace TestTaskUSS
{
    class Program
    {
        private static ICommandExecutor CreateExecutor(DeckController controller)
        {
            var execitor = new CommandExecutor(controller);
            execitor.Register(new Create());
            execitor.Register(new Delete());
            execitor.Register(new Exit());
            execitor.Register(new GetDeck());
            execitor.Register(new GetNamesDecks());
            execitor.Register(new Help());
            execitor.Register(new Shuffle());
            return execitor;
        }
        static void Main(string[] args)
        {
            var deckController = new DeckController();
            var executor = CreateExecutor(deckController);
            Run(executor);
        }

        public static void Run(ICommandExecutor commandExecutor) 
        {
            commandExecutor.Execute("help");
            while (true) 
            {
                var command = Console.ReadLine();
                commandExecutor.Execute(command);
                if(string.Equals(command, "exit", StringComparison.OrdinalIgnoreCase))
                    break;   
            }
        }
    }
}
