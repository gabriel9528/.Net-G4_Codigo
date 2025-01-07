using System.ComponentModel;

namespace Ejercicio9
{
    public class Producto : INotifyPropertyChanged
    {
        private string _nombre;
        private decimal _precio;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                    OnPropertyChanged("DescripcionCompleta"); // Notificar cambio en la propiedad combinada
                }
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (_precio != value)
                {
                    _precio = value;
                    OnPropertyChanged("Precio");
                    OnPropertyChanged("DescripcionCompleta"); // Notificar cambio en la propiedad combinada
                }
            }
        }

        // Propiedad combinada
        public string DescripcionCompleta => $"{Nombre} - {Precio:C}";

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
