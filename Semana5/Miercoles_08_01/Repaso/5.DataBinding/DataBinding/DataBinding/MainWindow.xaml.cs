using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class StringToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convertir el valor del Slider a una cadena para mostrarlo en el TextBox
            if (value is double doubleValue)
            {
                return doubleValue.ToString();
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convertir la cadena del TextBox a un valor double para el Slider
            if (double.TryParse(value as string, out double result))
            {
                return result;
            }
            return 0.0; // O cualquier otro valor predeterminado
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    
}
