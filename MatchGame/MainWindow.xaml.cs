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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame(); // we setup our game
        }

        private void SetUpGame() // our function for setup game
        {
            // we create here list of our emoji in string type
            List<string> animalEmoji = new List<string>()
            {
                "🐙", "🐙",   // for example octobus
                "🐡", "🐡",
                "🐘", "🐘",
                "🐳", "🐳",
                "🐪", "🐪",
                "🦕", "🦕",
                "🦘", "🦘",
                "🦔", "🦔",
            };

            Random random = new Random();   // here we create new randomizer

            // that function searching each of element textBlock in our greed and
            // repeat commands for each elemnts
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                // chose random number between 0 to last count emoji elemnt in list
                // and set name for number index
                int index = random.Next(animalEmoji.Count);

                // Use random number with name index for the getting randrom emoji from list
                string nextEmoji = animalEmoji[index];
                // Update TextBlock with randrom emoji from list
                textBlock.Text = nextEmoji;
                // Remove random emoji from list
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
