
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTaskUSS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly List<Command> commands = new List<Command>();
        private DeckController controller;

        public CommandExecutor(DeckController deckController)
        {
            controller = deckController;
        }
        public void Execute(string command)
        {
            if (command.Length == 0)
            {
                Console.WriteLine("please enter the command. enter the help command to find out the commands");
                return;
            }
            var cmd = FindCommandByName(command);
            if (cmd == null)
                Console.WriteLine("Sorry, command not found:(");
            else
                cmd.Execute(controller);
        }

        public Command FindCommandByName(string name)
        {
            return commands.FirstOrDefault(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));
        }

        public void Register(Command command)
        {
            commands.Add(command);
        }
    }
}
