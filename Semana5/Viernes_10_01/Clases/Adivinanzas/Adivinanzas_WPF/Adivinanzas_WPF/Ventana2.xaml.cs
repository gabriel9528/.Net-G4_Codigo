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
    /// Interaction logic for Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public Control Control;
        public Ventana2(Control control)
        {
            InitializeComponent();
            Control = control;
            MostrarRegiones();
        }

        private void ButtonIngresar_Click(object sender, RoutedEventArgs e)
        {
            Control.listaRegiones.Add(new Region(textBoxPais.Text, textBoxCapital.Text));
            listBoxRegiones.Items.Add(textBoxPais.Text + " - " + textBoxCapital.Text);
            textBoxPais.Text = "";
            textBoxCapital.Text = "";
        }

        private void MostrarRegiones()
        {
            foreach(Region region in Control.listaRegiones)
            {
                listBoxRegiones.Items.Add(region.Pais + " - " + region.Capital);
            }
        }

        private void buttonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonJugar_Click(object sender, RoutedEventArgs e)
        {
            Ventana3 ventana3 = new Ventana3(Control);
            ventana3.Show();
        }
    }
}
