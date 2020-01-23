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
        List<album> all_albums = new List<album>();

        public MainWindow()
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            band b1 = new band("Beatles", "John, Paul, George, Ringo", 1960);
            band b2 = new band("AC/BC", "Harry, Ronny, Fred", 1980);
            band b3 = new band("StormBorn", "Mary, Molly, Ally", 1990);
            band b4 = new band("Big Star", "Johnny, King, Ban,", 1999);
            band b5 = new band("Alice Cooper", "Alice Cooper", 1970);
            band b6 = new band("Chicago Fire", "Anne, Paul", 1960);

            all_bands.Add(b1);
            all_bands.Add(b2);
            all_bands.Add(b3);
            all_bands.Add(b4);
            all_bands.Add(b5);
            all_bands.Add(b6);

            album a1 = new album("night in sky",1234,1990);
            album a2 = new album("",1234,1990);
            album a3 = new album("",1234,1990);
            album a4 = new album("",1234,1990);
            album a5 = new album("",1234,1990);
            album a6 = new album("",1234,1990);

            all_albums.Add(a1);
            all_albums.Add(a2);
            all_albums.Add(a3);
            all_albums.Add(a4);
            all_albums.Add(a5);
            all_albums.Add(a6);

            lbxBands.ItemsSource = all_bands;
            lbxAlbums.ItemsSource = all_albums;
        }
    }
}
