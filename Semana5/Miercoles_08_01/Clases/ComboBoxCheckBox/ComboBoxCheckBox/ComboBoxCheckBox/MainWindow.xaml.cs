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

namespace ComboBoxCheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> listaCapitales = new List<Capitales>();
            listaCapitales.Add(new Capitales() { NombreCapital = "Lima" });
            listaCapitales.Add(new Capitales() { NombreCapital = "Bogota" });
            listaCapitales.Add(new Capitales() { NombreCapital = "Quito" });
            listaCapitales.Add(new Capitales() { NombreCapital = "Santiago" });

            Capitales.ItemsSource = listaCapitales;

        }

        private void General_Checked(object sender, RoutedEventArgs e)
        {
            Lima.IsChecked = true;
            Santiago.IsChecked = true;
            Bogota.IsChecked = true;
            Quito.IsChecked = true;
        }

        private void General_Unchecked(object sender, RoutedEventArgs e)
        {
            Lima.IsChecked = false;
            Santiago.IsChecked = false;
            Bogota.IsChecked = false;
            Quito.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if(Lima.IsChecked == true && Santiago.IsChecked == true && Bogota.IsChecked == true && Quito.IsChecked == true)
            {
                General.IsChecked = true;
            }
            else
            {
                General.IsChecked = null;
            }
        }

        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Lima.IsChecked == false && Santiago.IsChecked == false && Bogota.IsChecked == false && Quito.IsChecked == false)
            {
                General.IsChecked = false;
            }
            else
            {
                General.IsChecked = null;
            }
        }
    }
}