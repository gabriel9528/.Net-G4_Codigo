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

namespace primeraInterfazWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid myGrid = new Grid();
            //this.Content = myGrid;

            //Button btn = new Button();
            //WrapPanel myWrap = new WrapPanel();
            //TextBlock txt1 = new TextBlock();

            //txt1.Text = "click";
            //txt1.Background = Brushes.Red;
            //txt1.Foreground = Brushes.Yellow;
            //myWrap.Children.Add(txt1);

            //TextBlock txt2 = new TextBlock();
            //txt2.Text = "Enviar";
            //myWrap.Children.Add(txt2);

            //TextBlock txt3 = new TextBlock();
            //txt3.Text = "Ok";
            //myWrap.Children.Add(txt3);

            //btn.Content = myWrap;
            //btn.Height = 75;
            //btn.Width = 150;
            //btn.Background = Brushes.Blue;

            //myGrid.Children.Add(btn);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Dentro de button 2");
            MessageBox.Show("Boton 2");
        }

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.Write("Dentro de button 2");
            MessageBox.Show("Pannel 2");
        }

        //private void Panel_Click(object sender, RoutedEventArgs e)
        //{
        //    //Console.WriteLine("Dentro de Pannel");
        //    MessageBox.Show("Pannel");
        //}
    }
}