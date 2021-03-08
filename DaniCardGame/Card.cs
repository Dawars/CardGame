using System.Windows.Controls;

namespace DaniCardGame
{
    public class Card
    {
        public string Name { get; set; }

        public Card(string name)
        {
            this.Name = name;
        }
        
        public override string ToString()
        {
            return this.Name;
        }
    }
}