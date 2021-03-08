using System;
using System.Collections.Generic;
using System.Linq;

namespace DaniCardGame
{
    public abstract class Deck
    {
        protected List<Card> cards = new();

        protected void Shuffle()
        {
            var rand = new Random();
            cards = cards.OrderBy(x => rand.Next()).ToList();
        }

        public Card Draw()
        {
            var card = cards.Last();
            if (card != null)
            {
                cards.Remove(card);
            }

            return card;
        }

        public int NumCardsLeft()
        {
            return cards.Count;
        }
    }
}