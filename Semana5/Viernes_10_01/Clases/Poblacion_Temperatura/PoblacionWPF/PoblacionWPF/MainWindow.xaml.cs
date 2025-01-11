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

namespace PoblacionWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listPoblaciones = new List<Poblaciones>();
            listPoblaciones.Add(new Poblaciones() { Poblacion1 = "Arequipa", Poblacion2 = "Trujillo", Temperatura1 = 32, Temperatura2 = 37});
            listPoblaciones.Add(new Poblaciones() { Poblacion1 = "Lima", Poblacion2 = "Puno", Temperatura1 = 25, Temperatura2 = 12});
            listPoblaciones.Add(new Poblaciones() { Poblacion1 = "Piura", Poblacion2 = "Moquegua", Temperatura1 = 38, Temperatura2 = 25});
            listPoblaciones.Add(new Poblaciones() { Poblacion1 = "Cusco", Poblacion2 = "Tarapoto", Temperatura1 = 10, Temperatura2 = 40});

            listaPoblaciones.ItemsSource = listPoblaciones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(listaPoblaciones.SelectedItem != null)
            {
                var seleccion = listaPoblaciones.SelectedItem as Poblaciones;
                if(seleccion != null)
                {
                    MessageBox.Show(
                        $"{seleccion.Poblacion1} {seleccion.Temperatura1}°C, " +
                        $"{seleccion.Poblacion2} {seleccion.Temperatura2}°C, " +
                        $"Diferencia de Temperaturas: {seleccion.DiferenciaTemperatura}°C"
                        );
                }
            }
        }
    }
}