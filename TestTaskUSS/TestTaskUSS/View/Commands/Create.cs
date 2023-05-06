
namespace TestTaskUSS
{
    public class Create : Command
    {
        public Create()
            : base("create") { }


        public override void Execute(DeckController deckController)
        {
            var nameDeck = PrintAndReadText("Write name of deck:");
            deckController.CreateDeck(nameDeck, new Suit(), new CardName());
        }
    }
}
