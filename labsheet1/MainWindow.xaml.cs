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

namespace labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<band> all_bands = new List<band>();

        public MainWindow()
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            band b1 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b2 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b3 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b4 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b5 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b6 = new band("Beatles", "John, Paul, George, Ringo", 1960);

            all_bands.Add(b1);
            all_bands.Add(b2);
            all_bands.Add(b3);
            all_bands.Add(b4);
            all_bands.Add(b5);
            all_bands.Add(b6);

            lbxBands.ItemsSource = all_bands;
        }
    }
}
