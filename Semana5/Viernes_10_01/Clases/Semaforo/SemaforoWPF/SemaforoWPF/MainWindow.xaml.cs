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

namespace SemaforoWPF
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

        private void RadioButtonRojo_Click(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Visible;
            ElipseAmarilla.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButtonAmarillo_Click(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Hidden;
            ElipseAmarilla.Visibility = Visibility.Visible;
            ElipseVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButtonVerde_Click(object sender, RoutedEventArgs e)
        {
            ElipseRoja.Visibility = Visibility.Hidden;
            ElipseAmarilla.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Visible;
        }
    }
}