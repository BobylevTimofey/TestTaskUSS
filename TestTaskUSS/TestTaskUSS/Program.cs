
namespace TestTaskUSS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deckController = new DeckController();
            var consoleUI = new ConsoleUI(deckController);
            consoleUI.Run();
        }
    }
}
