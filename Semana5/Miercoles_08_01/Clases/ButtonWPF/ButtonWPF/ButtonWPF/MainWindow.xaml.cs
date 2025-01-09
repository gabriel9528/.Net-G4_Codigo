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

namespace ButtonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid myGrid = new Grid();
            this.Content = myGrid;

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 100;
            myButton.Background = Brushes.LightBlue;

            WrapPanel myWrapPanel = new WrapPanel();

            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "Hola";
            textBlock1.Background = Brushes.LightGreen;
            myWrapPanel.Children.Add(textBlock1);


            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = " mundo";
            textBlock2.Background = Brushes.Red;
            myWrapPanel.Children.Add(textBlock2);


            TextBlock textBlock3 = new TextBlock();
            textBlock3.Text = " desde WPF";
            textBlock3.Background = Brushes.Blue;
            myWrapPanel.Children.Add(textBlock3);

            myButton.Content = myWrapPanel;

            myGrid.Children.Add(myButton);

        }
    }
}