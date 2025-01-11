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

namespace DependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //1. Propiedad CLR de acceso (Encapsulación):
        //GetValue y SetValue: Son métodos heredados de la clase base DependencyObject que
        //interactúan con la propiedad registrada en el sistema de WPF.
        //Esta propiedad es solo un "acceso cómodo" a la Dependency Property myDependencyProperty.
        public int myProperty
        {
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        //2. Registro de la Dependency Property:
        //Register: Registra la propiedad dentro del sistema de propiedades de WPF.
        //Parámetros:
        //        Nombre: "MiProperty" (cadena).
        //        Tipo: typeof(int), indica que la propiedad será un entero.
        //        Propietario: typeof(MainWindow), la clase que contiene la propiedad.
        //        Metadata: new PropertyMetadata(0), el valor predeterminado de la propiedad.
        public static readonly DependencyProperty myDependencyProperty = 
            DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));
        
        public MainWindow()
        {
            InitializeComponent();
            myProperty = 42;
        }
    }
}