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

namespace PropertyDefinitionWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myProperty = 59;
        }

        //IMplementar un dependency Propert

        public int myProperty
        {
            get { return (int)GetValue(myDependencyProperty); }
            set { SetValue(myDependencyProperty, value); }
        }

        //Registro del dependency property

        public static readonly DependencyProperty myDependencyProperty =
            DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));
    }
}