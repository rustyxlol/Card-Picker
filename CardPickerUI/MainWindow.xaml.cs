using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace CardPickerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pickCardsButton_Click(object sender, RoutedEventArgs e)
        {
            // Take input from the textbox
            // Use cardPicker to generate cards
            // Output the cards on listBox

            if (int.TryParse(numOfCardsTextBox.Text, out int numOfCards))
            {
                cardsListBox.Items.Clear();
                foreach (string card in CardPicker.PickSomeCards(numOfCards))
                {
                    cardsListBox.Items.Add(card);
                }
            }
        }
    }
}
