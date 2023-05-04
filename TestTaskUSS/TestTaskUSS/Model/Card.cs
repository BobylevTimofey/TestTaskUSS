namespace TestTaskUSS
{
    public class Card
    {
        public readonly string CardName;
        public readonly string Suit;

        public Card(string cardName, string suit)
        {
            CardName = cardName;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{CardName}:{Suit}";
        }
    }
}
