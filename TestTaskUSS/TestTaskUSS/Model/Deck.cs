using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTaskUSS
{
    public class Deck
    {
        public List<Card> Cards;
        public int Length { get => Cards.Count; }

        public Deck(Enum suit, Enum cardName)
        {
            Cards = Enum.GetNames(suit.GetType())
                .SelectMany(suit => Enum.GetNames(cardName.GetType()),
                    (suit, name) => new Card(name, suit))
                .ToList();
        }

        public Card this[int i]
        {
            get { return Cards[i]; }
            set { Cards[i] = value; }
        }

        public void Print()
        {
            foreach (Card card in Cards)
                Console.WriteLine(card.ToString());
        }
    }
}
