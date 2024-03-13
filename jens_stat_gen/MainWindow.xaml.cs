using System;
using System.Collections;
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

namespace jens_stat_gen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            strValue.Content = roll();
            dexValue.Content = roll();
            bldValue.Content = roll();
            intValue.Content = roll();
            prcValue.Content = roll();
            chrValue.Content = roll();
        }
        
        public int roll()
        {
            Random rand = new Random();
            ArrayList rolledNumbers = new ArrayList();
            int sum, rolledNumber;
            while(true)
            {
                sum = 0;
                while (rolledNumbers.Count != 3)
                {
                    rolledNumber = rand.Next(9);
                    if (rolledNumber == 0) rolledNumbers.Add(10);
                    else rolledNumbers.Add(rolledNumber);
                }

                rolledNumbers.Sort();
                rolledNumbers.RemoveAt(0);
                foreach (int i in rolledNumbers) sum += i;
                if (sum > 13) break;
            }

            return sum;
            //return rand.Next(7)+13;
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            strValue.Content = roll();
            dexValue.Content = roll();
            bldValue.Content = roll();
            intValue.Content = roll();
            prcValue.Content = roll();
            chrValue.Content = roll();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
