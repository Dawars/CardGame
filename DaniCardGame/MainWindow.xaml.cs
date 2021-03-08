using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DaniCardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string SelectedDeck { get; set; }

        private Brush borderBrush = new SolidColorBrush(Colors.Red);
        private List<Button> deckButtons = new();
        private Dictionary<string, Deck> decks;

        private ObservableCollection<Card> hand = new ObservableCollection<Card>()
        {
            new Card("/Dixit/img008.jpg")
        };
        
        public MainWindow()
        {
            InitializeComponent();

            decks = new() {{DeckFrench.Name, new DeckFrench()}, {DeckDixit.Name, new DeckDixit()}};

            deckButtons.Add(DeckFrench);
            deckButtons.Add(DeckDixit);

            foreach (var button in deckButtons)
            {
                ((Border) button.Parent).BorderBrush = borderBrush;
            }

            DeckFrench.Click += SelectDeck;
            DeckDixit.Click += SelectDeck;

            resetButton.Click += ResetHand;
            drawButton.Click += DrawCards;

            for (int i = 0; i < 3; i++) {
                hand.Add(decks[DeckDixit.Name].Draw());
            }
            
            HandCardList.ItemsSource = hand;

            CheckInput();
            
            numberInput.TextChanged += (_, _) => CheckInput();
        }
        
        private void CheckInput()
        {
            if (SelectedDeck == null) {
                drawButton.IsEnabled = false;
                return;
            }
            
            int num=0;
            try
            {
                num = Convert.ToInt32(numberInput.Text);
            }
            catch
            {
                Console.WriteLine($"Invalid input {numberInput.Text}");
            }

            Deck deck = decks.GetValueOrDefault(SelectedDeck);

            drawButton.IsEnabled = deck != null && deck.NumCardsLeft() >= num && num > 0;
        }

        private void DrawCards(object sender, RoutedEventArgs e)
        {
            var deck = decks.GetValueOrDefault(SelectedDeck);
            for (int i = 0; i <  Convert.ToInt32(numberInput.Text); i++) { hand.Add(deck.Draw()); }

            CheckInput();
        }


        private void ResetHand(object sender, RoutedEventArgs e)
        {
            hand.Clear();
        }

        private bool IsDeckValid(string deckName)
        {
            var deck = decks.GetValueOrDefault(deckName);
            return deck != null;
        }

        private void SelectDeck(object sender, RoutedEventArgs e)
        {
            // save selected
            this.SelectedDeck = ((Button) sender).Name;

            Border item = (Border) ((Button) sender).Parent;

            // deselect
            foreach (var button in deckButtons)
            {
                ((Border) button.Parent).BorderThickness = new Thickness(0);
            }

            item.BorderThickness = new Thickness(2);

            CheckInput();
        }
    }
}