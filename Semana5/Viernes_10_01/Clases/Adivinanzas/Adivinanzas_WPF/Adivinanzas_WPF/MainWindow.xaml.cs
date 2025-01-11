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

namespace Adivinanzas_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Control ControlMain;
        public MainWindow()
        {
            InitializeComponent();
            ControlMain = new Control();
        }

        private void ButtonVentana2_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana2 = new Ventana2(ControlMain);
            ventana2.Show();
        }

        private void ButtonVentana3_Click(object sender, RoutedEventArgs e)
        {
            Ventana3 ventana3 = new Ventana3(ControlMain);
            ventana3.Show();
        }
    }
}