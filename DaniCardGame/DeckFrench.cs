using System.Collections.Generic;

namespace DaniCardGame
{
    public class DeckFrench : Deck
    {

        public DeckFrench()
        {
            string[] colors = {"1", "2", "3", "4"};
            string[] numbers = {"a", "k", "q", "j", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            
            foreach (var color in colors) {
                foreach (var number in numbers) {
                    cards.Add(new Card($"Francia/{number}{color}.jpg"));
                }
            }

            Shuffle();
        }
    }
}