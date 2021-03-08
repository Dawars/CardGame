using System.Collections.Generic;

namespace DaniCardGame
{
    public class DeckDixit : Deck
    {

        public DeckDixit()
        {
            string[] names = {
                "img005.jpg",
                "img006.jpg",
                "img007.jpg",
                "img008.jpg",
                "img009.jpg",
                "img010.jpg",
                "img011.jpg",
                "img012.jpg",
                "img013.jpg",
                "img014.jpg",
                "img015.jpg",
                "Nevtelen-1.jpg",
                "Nevtelen-2.jpg",
                "Nevtelen-3.jpg",
                "Nevtelen-4.jpg",
                "Nevtelen-5.jpg",
                "Nevtelen-6.jpg",
                "Nevtelen-7.jpg",
                "Nevtelen-9.jpg",
                "Nevtelen-10.jpg",
                "Nevtelen-11.jpg",
                "Nevtelen-12.jpg",
                "Nevtelen-13.jpg",
                "Nevtelen-14.jpg",
                "Nevtelen-15.jpg",
                "Nevtelen-16.jpg",
                "Nevtelen-17.jpg",
                "Nevtelen-18.jpg",
                "Nevtelen-19.jpg",
                "Nevtelen-20.jpg",
                "Nevtelen-21.jpg",
                "Nevtelen-22.jpg",
                "Nevtelen-23.jpg",
                "Nevtelen-24.jpg",
                "Nevtelen-25.jpg",
                "Nevtelen-26.jpg",
                "Nevtelen-27.jpg",
                "Nevtelen-28.jpg",
                "Nevtelen-29.jpg",
                "Nevtelen-30.jpg",
                "Nevtelen-31.jpg",
                "Nevtelen-32.jpg",
                "Nevtelen-33.jpg",
                "Nevtelen-34.jpg",
                
            };
            
            foreach (var name in names) {
                cards.Add(new Card($"Dixit/{name}"));
            }
            
            Shuffle();
        }
    }
}