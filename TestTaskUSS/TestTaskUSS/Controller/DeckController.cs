using System;
using System.Collections.Generic;

namespace TestTaskUSS
{
    public class DeckController
    {
        private Dictionary<string, Deck> decks;

        public void CreateDeck(string name, Enum suit, Enum cardName)
        {
            if (decks == null)
                decks = new Dictionary<string, Deck>();
            if (!decks.ContainsKey(name))
                decks.Add(name, new Deck(suit, cardName));
            else
                throw new Exception($"Deck with name - {name} already exists");
        }

        public void DeleteDeck(string name)
        {
            if (decks.ContainsKey(name))
                decks.Remove(name);
            else
                throw new Exception($"Deck with name - {name} not found");
        }

        public List<string> GetAllNames()
        {
            if (decks == null)
                throw new Exception("No decks created");
            return new List<string>(decks.Keys);
        }

        public Deck GetDeck(string name)
        {
            if (decks.ContainsKey(name))
                return decks[name];
            else
                throw new Exception($"Deck with name - {name} not found");
        }

        public void ShuffleDeck(string name, ISorter sorter)
        {
            if (sorter == null)
                throw new Exception("ISorter must not be null");
            if (decks.ContainsKey(name))
                sorter.Sort(decks[name]);
            else
                throw new Exception($"Deck with name - {name} not found");
        }
    }
}
