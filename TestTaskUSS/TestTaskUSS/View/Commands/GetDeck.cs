
namespace TestTaskUSS
{
    public class GetDeck : Command
    {
        public GetDeck()
            : base("get deck") { }

        public override void Execute(DeckController deckController)
        {
            var nameDeck = PrintAndReadText("Write the name of the deck you want to get:");
            deckController.GetDeck(nameDeck).Print();
        }
    }
}
