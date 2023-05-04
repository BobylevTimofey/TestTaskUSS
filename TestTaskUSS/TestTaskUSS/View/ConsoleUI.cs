using System;

namespace TestTaskUSS
{
    public class ConsoleUI
    {
        private DeckController deckController;

        public ConsoleUI(DeckController deckController)
        {
            this.deckController = deckController;
        }

        public void Run()
        {
            var isEnd = false;

            while (!isEnd)
            {
                PrintStartText();
                var command = Console.ReadLine();

                switch (command)
                {
                    case "create":
                        var nameDeck = PrintAndReadText("Write name of deck:");
                        deckController.CreateDeck(nameDeck, new Suit(), new CardName());
                        break;

                    case "delete":
                        nameDeck = PrintAndReadText("Write name of deck:");
                        deckController.DeleteDeck(nameDeck);
                        break;

                    case "get names":
                        foreach (var name in deckController.GetAllNames())
                            Console.WriteLine(name);
                        break;

                    case "shuffle":
                        nameDeck = PrintAndReadText("Write name of deck:");
                        var shufflingMethod = PrintAndReadText("How do you want to shuffle the deck? Fisher Yates or manual");

                        if (shufflingMethod == "Fisher Yates")
                            deckController.ShuffleDeck(nameDeck, new FisherYatesSort());
                        else if (shufflingMethod == "manual")
                        {
                            var countRepeat = int.Parse(PrintAndReadText("Enter the amount of shuffling of the deck"));
                            deckController.ShuffleDeck(nameDeck, new ManualSort(countRepeat));
                        }
                        else throw new Exception("shuffle the deck not found");
                        break;

                    case "get deck":
                        nameDeck = PrintAndReadText("Write the name of the deck you want to get:");
                        deckController.GetDeck(nameDeck).Print();
                        break;

                    case "exit":
                        isEnd = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Sorry, command not found:(");
                        break;
                }
            }
        }

        private void PrintStartText()
        {
            Console.WriteLine("Choose the action:");
            Console.WriteLine("create - create new deck;");
            Console.WriteLine("delete - delete the deck;");
            Console.WriteLine("get names - to get list of decks names");
            Console.WriteLine("shuffle - shuffle the deck");
            Console.WriteLine("get deck - get the deck");
            Console.WriteLine("exit - exit the program");
        }

        private string PrintAndReadText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

    }
}
