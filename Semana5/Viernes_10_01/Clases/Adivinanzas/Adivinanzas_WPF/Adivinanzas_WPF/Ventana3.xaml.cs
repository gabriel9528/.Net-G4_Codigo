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
using System.Windows.Shapes;

namespace Adivinanzas_WPF
{
    /// <summary>
    /// Interaction logic for Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {
        Control ControlMain;
        Region RegionTemporal;
        int contador;
        public Ventana3(Control control)
        {
            InitializeComponent();
            ControlMain = control;
            RegionTemporal = ControlMain.DarPregunta();

            if(RegionTemporal != null )
            {
                labelPregunta.Content = RegionTemporal.Pais;
            }
            else
            {
                MessageBox.Show("No hay mas preguntas disponibles");
                this.Close();
            }
        }

        private void buttonConsultar_Click(object sender, RoutedEventArgs e)
        {
            if(RegionTemporal == null)
            {
                MessageBox.Show("No hay mas preguntas disponibles");
                return;
            }

            if(textBoxRespuesta.Text == RegionTemporal.Capital)
            {
                ControlMain.Puntos += 10;
            }

            if(contador < 5)
            {
                RegionTemporal = ControlMain.DarPregunta();

                if(RegionTemporal != null )
                {
                    labelPregunta.Content = RegionTemporal.Pais;
                }
                else
                {
                    MessageBox.Show("Fin del juego. " + ControlMain.Puntos);
                    buttonConsultar.IsEnabled = false;
                }
            }
            else
            {
                MessageBox.Show("Fin del juego. " + ControlMain.Puntos);
                buttonConsultar.IsEnabled = false;
            }

            textBoxRespuesta.Text = "";
            contador++;

        }

        private void buttonVolver3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
