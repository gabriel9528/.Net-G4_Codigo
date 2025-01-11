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

namespace proyectComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> listCapitales = new List<Capitales>();
            listCapitales.Add(new Capitales { NombreCapital = "Lima" });
            listCapitales.Add(new Capitales { NombreCapital = "Bogota" });
            listCapitales.Add(new Capitales { NombreCapital = "Quito" });
            listCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitales.ItemsSource = listCapitales;

        }

        private void Todas_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            Santiago.IsChecked = true;
        }

        private void Todas_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            Santiago.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogota.IsChecked == true && Lima.IsChecked == true && Santiago.IsChecked == true)
            {
                TodasCapitales.IsChecked = true;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }

        }

        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false && Santiago.IsChecked == false)
            {
                TodasCapitales.IsChecked = false;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }

        }
    }



}