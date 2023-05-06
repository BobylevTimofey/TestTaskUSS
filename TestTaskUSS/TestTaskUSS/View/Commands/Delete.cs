
namespace TestTaskUSS
{
    public class Delete : Command
    {
        public Delete()
            : base("delete") { }

        public override void Execute(DeckController deckController)
        {
            var nameDeck = PrintAndReadText("Write name of deck:");
            deckController.DeleteDeck(nameDeck);
        }
    }
}
