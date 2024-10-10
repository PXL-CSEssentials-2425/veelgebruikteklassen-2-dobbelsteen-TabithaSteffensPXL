using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dubbelsteen_h4
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            Random diceRoll = new Random();
            int roll = diceRoll.Next(1, 6);
            StringBuilder sb = new StringBuilder();
            int numberRolls = 0;
            do
            {
                roll = diceRoll.Next(1, 7);
                
                numberRolls++;
                
                sb.AppendLine($"Worp {numberRolls} geeft {roll}");
                resultTextBox.Text = $"{sb}";
               
            } while (roll != 6);
            resultTextBox.Text = $"{sb}";
        }

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            startButton.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}